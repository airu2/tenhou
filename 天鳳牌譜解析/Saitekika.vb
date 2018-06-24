Public Class Saitekika
    Private Sub Saitekika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'フォームサイズ変更不可
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        NowFilesize.Text = "０KBytes"
        AfterFilesize.Text = "？？？？？？？？？？？KBytes"
        ErrDisp.Text = ""
        SaitekikaBtn.Enabled = True
        SaitekikaBtn.BackColor = Color.FromArgb(255, 192, 192)
        Try
            Dim fi As New System.IO.FileInfo(".\tenhou.accdb")
            'ファイルのサイズを取得
            Dim l As Long = fi.Length
            NowFilesize.Text = StrConv(l / 1024, VbStrConv.Wide) & "KBytes"
        Catch
            SaitekikaBtn.Enabled = False
            SaitekikaBtn.BackColor = Color.FromArgb(224, 224, 224)
            ErrDisp.Text = "エラー：tenhou.accdbが存在しないので最適化は実行できません。"
        End Try
    End Sub

    Private Sub SaitekikaBtn_Click(sender As Object, e As EventArgs) Handles SaitekikaBtn.Click
        Try
            Dim DatagridCnt As Integer
            Dim fi As New System.IO.FileInfo(".\tenhou.accdb")
            If MessageBox.Show("データベースの最適化を実行します。" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '最適化を行う新ファイルをコピーしtenhou2.accdbにリネームする
                If System.IO.File.Exists(".\tmp\tenhou.accdb") Then
                    '待機状態
                    Cursor.Current = Cursors.WaitCursor
                    System.IO.File.Copy(".\tmp\tenhou.accdb", ".\tenhou2.accdb", True)
                    '移行する対局データを全読み込み->wkgridviewに格納
                    Database.SelectAll_Taikyoku()
                    DatagridCnt = Main.WkGridView.Rows.Count
                    '移行する新データベースに接続
                    Database.DBconnect(Database.Cn2_txt)
                    'データ数分、INSERT処理を実施->u_taikyokuはデータがない前提でデータの削除は行わない
                    For i = 0 To DatagridCnt - 1
                        Database.Utaikyoku_Insert(Main.WkGridView.Item(0, i).Value, Main.WkGridView.Item(1, i).Value, Main.WkGridView.Item(2, i).Value, Main.WkGridView.Item(3, i).Value, Main.WkGridView.Item(4, i).Value, Main.WkGridView.Item(5, i).Value, Main.WkGridView.Item(6, i).Value,
                                                  Main.WkGridView.Item(7, i).Value, Main.WkGridView.Item(8, i).Value, Main.WkGridView.Item(9, i).Value, Main.WkGridView.Item(10, i).Value, Main.WkGridView.Item(11, i).Value, Main.WkGridView.Item(12, i).Value,
                                                  Main.WkGridView.Item(13, i).Value, Main.WkGridView.Item(14, i).Value, Main.WkGridView.Item(15, i).Value)
                    Next
                    'データベース切断
                    Database.DBdispose()
                    '最適化前のファイルを削除
                    System.IO.File.Delete(".\tenhou.accdb")
                    '最適化後のファイルをリネーム
                    System.IO.File.Move(".\tenhou2.accdb", ".\tenhou.accdb")
                    'ファイルのサイズを取得
                    Dim l As Long = fi.Length
                    AfterFilesize.Text = StrConv(l / 1024, VbStrConv.Wide) & "KBytes"
                    '元に戻す
                    Cursor.Current = Cursors.Default
                    MessageBox.Show("データベースの最適化が完了しました。", "最適化完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("最適化を行うファイルが存在しません。(.\tmp\tenhou.accdb)", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Common.errMsgDialog("エラーが発生しました。[詳細:" & ex.Message & "]")
            '元に戻す
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        '--------------------------------------------------------------------------
        '2015/08/29 airu 新規作成
        '--------------------------------------------------------------------------
        '閉じる
        Me.Close()
    End Sub
End Class