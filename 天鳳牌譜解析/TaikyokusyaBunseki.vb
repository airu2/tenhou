Public Class TaikyokusyaBunseki
    Private Sub TaikyokusyaBunseki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playnum As Integer 'モード 3:3麻、4:4麻
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        'オート検索は行わない(対局者の選択があるため)
        inifileaccess.GetPrivateProfileString("メイン画面表示", "disp", "default", strSb, 255, ".\setting.ini")
        If strSb.ToString() = "0" Then
            playnum = 0
        ElseIf strSb.ToString() = "1" Then
            playnum = 3
            mode3Rbt.Checked = True
        ElseIf strSb.ToString() = "2" Then
            playnum = 4
            mode4Rbt.Checked = True
        Else
            playnum = 4
            mode4Rbt.Checked = True
        End If
        DataGridView1.DataSource = ""
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim playnum As Integer 'モード 3:3麻、4:4麻

        'モード
        If mode3Rbt.Checked = True Then
            playnum = 3
        Else
            playnum = 4
        End If

        If mode3Rbt.Checked = False And mode4Rbt.Checked = False Then
            MessageBox.Show("モードは必ず選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '待機状態
        Cursor.Current = Cursors.WaitCursor
        DatagridShow(playnum)
        '元に戻す
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub DatagridShow(playnum As Integer)
        '--------------------------------------------------------------------------
        '2015/08/06 airu 新規作成(検索時、フォームロード時共通)
        '--------------------------------------------------------------------------
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Dim OLEDS As DataSet = New DataSet("TEST")

        'SQL文
        Dim SQL_txt As String = "SELECT TAIKYOKUNAME AS 対局者,MODE AS モード,SUM(SUM_KYOKU) AS 対局数,ROUND(SUM(AGARI_CNT) / SUM(SUM_KYOKU) *100,2) AS 和がり率（％）," &
                                "ROUND(SUM(FURIKOMI_CNT) / SUM(SUM_KYOKU) *100,2) AS 振込率（％）" &
                                " FROM U_TAIKYOKU WHERE MODE=" & playnum

        '対局者が自分以外の場合、自分を含めない
        If NjibnChk.Checked = True Then
            inifileaccess.GetPrivateProfileString("プレーヤー情報", "name", "default", strSb, 255, ".\setting.ini")
            SQL_txt = SQL_txt & " AND TAIKYOKUNAME NOT In ('" & strSb.ToString & "')"
        End If
        '対局者がNoName以外の場合、NoNameを含めない
        If NnonameChk.Checked = True Then
            SQL_txt = SQL_txt & " AND TAIKYOKUNAME NOT In ('NoName')"
        End If
        SQL_txt = SQL_txt & " GROUP BY MODE,TAIKYOKUNAME ORDER BY TAIKYOKUNAME"

        'データアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter(SQL_txt, Database.Cn_txt)

        'データの読み込み
        Adapter.Fill(OLEDS, "TEST")
        'データソースを設定してDataGridViewにデータを表示
        DataGridView1.DataSource = OLEDS.Tables("TEST")

        If DataGridView1.Rows.Count > 0 Then
            DataGridEdit()
        End If
    End Sub
    Private Sub DataGridEdit()
        '色付
        Dim DatagridCnt As Integer = DataGridView1.Rows.Count
        'フォントを変更する
        DataGridView1.DefaultCellStyle.Font = New Font("Arial Unicode MS", 12, FontStyle.Regular)
        '行選択にする
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.RowHeadersWidth = 65 '行ヘッダの幅を変更する
    End Sub
    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting _

        '--------------------------------------------------------------------------
        '2015/08/30 airu 新規作成(DataGridview行番号表示)
        '--------------------------------------------------------------------------
        '列ヘッダを対象外しておかないと列ヘッダにも番号を表示してしまう
        If e.ColumnIndex < 0 And e.RowIndex >= 0 Then
            'セルを描画する
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
            '行番号を描画する範囲を決定する
            Dim idxRect As Rectangle = e.CellBounds
            'e.Padding(値を表示する境界線からの間隔)を考慮して描画位置を決める
            Dim rectHeight As Long = e.CellStyle.Padding.Top
            Dim rectLeft As Long = e.CellStyle.Padding.Left
            idxRect.Inflate(rectLeft, rectHeight)
            '行番号を描画する
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), New Font("Arial Unicode MS", 12, FontStyle.Regular), idxRect, e.CellStyle.ForeColor, TextFormatFlags.Right Or TextFormatFlags.VerticalCenter)
            '描画完了の通知
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.ClearSelection()
    End Sub
    Private Sub dataGridView1_Sorted(ByVal sender As Object,
ByVal e As System.EventArgs) Handles DataGridView1.Sorted
        If DataGridView1.Rows.Count > 0 Then
            DataGridEdit()
        End If
    End Sub
End Class