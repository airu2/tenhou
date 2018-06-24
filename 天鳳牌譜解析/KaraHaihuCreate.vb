Public Class KaraHaihuCreate
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        '閉じる
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        Dim idx As Integer
        If Nichiji.Text = "" Or Takusyubetsu.Text = "" Or Room.Text = "" Or Crypt.Text = "" Or Seki.Text = "" Then
            MessageBox.Show("項目は全て入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        idx = DataGridView1.Rows.Count
        DataGridView1.Rows.Add()
        DataGridView1.Rows(idx).Cells(0).Value = idx + 1 'No
        DataGridView1.Rows(idx).Cells(1).Value = Nichiji.Text & "gm-" & Takusyubetsu.Text & "-" &
        Room.Text & "-" & Crypt.Text & "&tw=" & Seki.Text & ".mjlog"
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        If MessageBox.Show("データをクリアします" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Dim hStream As System.IO.FileStream
        Dim HaihuDir As String
        Dim i As Integer
        If MessageBox.Show("データを作成します" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '牌譜ファイル作成ディレクトリを取得
            inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜ファイル作成ディレクトリ", "default", strSb, 255, ".\setting.ini")
            HaihuDir = strSb.ToString
            '牌譜ファイル作成ディレクトリ存在チェック
            If System.IO.Directory.Exists(HaihuDir) Then
            Else
                MessageBox.Show("ディレクトリは存在しません。", "エラーメッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End
            End If
            ' hStream が破棄されることを保証するために Try ～ Finally を使用する
            Try
                'DataGridView1に表示されている分の空ファイルを作成する
                For i = 0 To DataGridView1.RowCount - 1
                    ' hStream が閉じられることを保証するために Try ～ Finally を使用する
                    Try
                        ' 指定したパスのファイルを作成する
                        hStream = System.IO.File.Create(HaihuDir & "\" & DataGridView1.Rows(i).Cells(1).Value)
                    Finally
                        ' 作成時に返される FileStream を利用して閉じる
                        If Not hStream Is Nothing Then
                            hStream.Close()
                        End If
                    End Try

                Next

            Finally
                ' hStream を破棄する
                If Not hStream Is Nothing Then
                    Dim cDisposable As System.IDisposable = hStream
                    cDisposable.Dispose()
                End If
            End Try
            MsgBox("空の牌譜ファイルを作成しました。")
        End If
    End Sub

    Private Sub KaraHaihuCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
    End Sub
End Class