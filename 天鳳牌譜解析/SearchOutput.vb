Public Class SearchOutput
    Public filename As String
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        '--------------------------------------------------------------------------
        '2015/08/29 airu 新規作成
        '--------------------------------------------------------------------------
        '閉じる
        Me.Close()
    End Sub

    Private Sub SearchOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Excelがインストールされていない端末では選択不可
        If Type.GetTypeFromProgID("Excel.Application") Is Nothing Then
            excelRbt.Enabled = False
        End If
    End Sub

    Private Sub DataExportBtn_Click(sender As Object, e As EventArgs) Handles DataExportBtn.Click
        'CSVが選択された場合
        If csvRbt.Checked = True Then
            If MessageBox.Show("CSV出力を開始します。" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '待機状態
                Cursor.Current = Cursors.WaitCursor
                CsvExport()
                '元に戻す
                Cursor.Current = Cursors.Default
                MessageBox.Show("CSV出力が完了しました。[" & filename & "]", "CSV出力完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
        'HTMLが選択された場合
        If htmlRbt.Checked = True Then
            If MessageBox.Show("HTML出力を開始します。" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '待機状態
                Cursor.Current = Cursors.WaitCursor
                HtmlExport()
                '元に戻す
                Cursor.Current = Cursors.Default
                MessageBox.Show("HTML出力が完了しました。[" & filename & "]", "HTML出力完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
        'Excelが選択された場合
        If excelRbt.Checked = True Then
            ExcelExport()
        End If
    End Sub

    Private Sub CsvExport()
        Dim DatagridCnt As Integer = Main.DataGridView1.Rows.Count
        Dim wk As String
        Dim header As String
        'Shift JISで書き込む
        filename = Now.ToString("yyyyMMddHHmmss") & ".csv"
        '書き込むファイルが既に存在している場合は、上書きする
        Dim sw As New System.IO.StreamWriter(".\output\" & filename,
            False,
            System.Text.Encoding.GetEncoding("shift_jis"))
        'ヘッダ部
        header = ""
        If noChk.Checked = True Then
            header = header & "No,"
        End If
        If taikyokubiChk.Checked = True Then
            header = header & "対局日,"
        End If
        If takuLevelChk.Checked = True Then
            header = header & "卓レベル,"
        End If
        If takuKindChk.Checked = True Then
            header = header & "卓種類,"
        End If
        If modeChk.Checked = True Then
            header = header & "モード,"
        End If
        If juniChk.Checked = True Then
            header = header & "順位,"
        End If
        If daniChk.Checked = True Then
            header = header & "段位,"
        End If
        If taikyokusyaChk.Checked = True Then
            header = header & "対局者,"
        End If
        If tenhouPointChk.Checked = True Then
            header = header & "天鳳ポイント,"
        End If
        If freePointChk.Checked = True Then
            header = header & "フリーポイント,"
        End If
        If lastScoreChk.Checked = True Then
            header = header & "最終持ち点,"
        End If
        If taikyokuNumChk.Checked = True Then
            header = header & "対局数,"
        End If
        If connectFlgChk.Checked = True Then
            header = header & "接続フラグ,"
        End If
        If sexChk.Checked = True Then
            header = header & "性別,"
        End If
        If rateChk.Checked = True Then
            header = header & "レート,"
        End If
        header = header.TrimEnd({","c})
        sw.Write(header & Chr(13) + Chr(10))
        'データ部
        For i = 0 To DatagridCnt - 1
            wk = ""
            If noChk.Checked = True Then
                wk = i + 1 & ","
            End If
            If taikyokubiChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(0, i).Value & ","
            End If
            If takuLevelChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(1, i).Value & ","
            End If
            If takuKindChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(2, i).Value & ","
            End If
            If modeChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(3, i).Value & ","
            End If
            If juniChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(4, i).Value & ","
            End If
            If daniChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(5, i).Value & ","
            End If
            If taikyokusyaChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(6, i).Value & ","
            End If
            If tenhouPointChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(7, i).Value & ","
            End If
            If freePointChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(8, i).Value & ","
            End If
            If lastScoreChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(9, i).Value & ","
            End If
            If taikyokuNumChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(10, i).Value & ","
            End If
            If connectFlgChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(11, i).Value & ","
            End If
            If sexChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(12, i).Value & ","
            End If
            If rateChk.Checked = True Then
                wk = wk & Main.DataGridView1.Item(13, i).Value & ","
            End If
            '末尾の「,」を削除
            wk = wk.TrimEnd({","c})
            'Data + 改行コード
            sw.Write(wk & Chr(13) + Chr(10))
        Next

        '閉じる
        sw.Close()
    End Sub

    Private Sub HtmlExport()
        Dim DatagridCnt As Integer = Main.DataGridView1.Rows.Count
        Dim wk As String
        Dim header As String
        Dim checkCnt As Integer

        checkCnt = 0
        'Shift JISで書き込む
        filename = Now.ToString("yyyyMMddHHmmss") & ".html"
        '書き込むファイルが既に存在している場合は、上書きする
        Dim sw As New System.IO.StreamWriter(".\output\" & filename,
            False,
            System.Text.Encoding.GetEncoding("shift_jis"))
        'ヘッダ部
        header = "<style type='text/css'>"
        header = header & ".table4 {"
        header = header & "border - collapse : collapse;"
        header = header & "width: 100px;"
        header = header & "}"
        header = header & ".table4 th {"
        header = header & "background-color: #cccccc;"
        header = header & "}"
        header = header & "</style>"
        header = header & "<table class='table4' border=1>"
        If noChk.Checked = True Then
            header = header & "<tr><th>" & "No" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If taikyokubiChk.Checked = True Then
            header = header & "<th>" & "対局日" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If takuLevelChk.Checked = True Then
            header = header & "<th>" & "卓レベル" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If takuKindChk.Checked = True Then
            header = header & "<th>" & "卓種類" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If modeChk.Checked = True Then
            header = header & "<th>" & "モード" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If juniChk.Checked = True Then
            header = header & "<th>" & "順位" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If daniChk.Checked = True Then
            header = header & "<th>" & "段位" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If taikyokusyaChk.Checked = True Then
            header = header & "<th>" & "対局者" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If tenhouPointChk.Checked = True Then
            header = header & "<th>" & "天鳳ポイント" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If freePointChk.Checked = True Then
            header = header & "<th>" & "フリーポイント" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If lastScoreChk.Checked = True Then
            header = header & "<th>" & "最終持ち点" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If taikyokuNumChk.Checked = True Then
            header = header & "<th>" & "対局数" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If connectFlgChk.Checked = True Then
            header = header & "<th>" & "接続フラグ" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If sexChk.Checked = True Then
            header = header & "<th>" & "性別" & "</th>"
            checkCnt = checkCnt + 1
        End If
        If rateChk.Checked = True Then
            header = header & "<th>" & "レート" & "</th>"
            checkCnt = checkCnt + 1
        End If
        header = header.Replace("width: 100px;", "width: " & checkCnt * 80 & "px;")
        sw.Write(header & Chr(13) + Chr(10))
        'データ部
        For i = 0 To DatagridCnt - 1
            wk = ""
            If noChk.Checked = True Then
                wk = "<tr><td>" & i + 1 & "</td>"
            End If
            If taikyokubiChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(0, i).Value & "</td>"
            End If
            If takuLevelChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(1, i).Value & "</td>"
            End If
            If takuKindChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(2, i).Value & "</td>"
            End If
            If modeChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(3, i).Value & "</td>"
            End If
            If juniChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(4, i).Value & "</td>"
            End If
            If daniChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(5, i).Value & "</td>"
            End If
            If taikyokusyaChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(6, i).Value & "</td>"
            End If
            If tenhouPointChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(7, i).Value & "</td>"
            End If
            If freePointChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(8, i).Value & "</td>"
            End If
            If lastScoreChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(9, i).Value & "</td>"
            End If
            If taikyokuNumChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(10, i).Value & "</td>"
            End If
            If connectFlgChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(11, i).Value & "</td>"
            End If
            If sexChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(12, i).Value & "</td>"
            End If
            If rateChk.Checked = True Then
                wk = wk & "<td>" & Main.DataGridView1.Item(13, i).Value & "</td>"
            End If
            'Data + 改行コード
            sw.Write(wk & "</tr>")
        Next
        sw.Write(wk & "</table>")
        '閉じる
        sw.Close()
    End Sub

    Private Sub ExcelExport()
    End Sub
End Class