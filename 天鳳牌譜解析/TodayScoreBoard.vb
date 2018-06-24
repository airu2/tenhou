Public Class TodayScoreBoard
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        '閉じる
        Me.Close()
    End Sub

    Private Sub TodayScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Taikyokunum3 As Integer
        Dim juni3(3) As Integer
        Dim syusi3 As Long
        Dim Taikyokunum4 As Integer
        Dim juni4(4) As Integer
        Dim syusi4 As Long
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Dim OLEDS As DataSet = New DataSet("TEST")
        Dim i As Integer
        Dim player As String
        Dim selectDate As String

        'フォームサイズ変更不可
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        '表示初期化
        TaikyokuNum3Lbl.Text = "0"
        AvgJuni3Lbl.Text = "0.00"
        One3CntLbl.Text = "0"
        Two3CntLbl.Text = "0"
        Three3CntLbl.Text = "0"
        Ruikei3Lbl.Text = "0"
        Avg3Lbl.Text = "0"
        TaikyokuNum4Lbl.Text = "0"
        AvgJuni4Lbl.Text = "0.00"
        One4CntLbl.Text = "0"
        Two4CntLbl.Text = "0"
        Three4CntLbl.Text = "0"
        Four4CntLbl.Text = "0"
        Ruikei4Lbl.Text = "0"
        Avg4Lbl.Text = "0"

        inifileaccess.GetPrivateProfileString("プレーヤー情報", "name", "default", strSb, 255, ".\setting.ini")
        player = strSb.ToString
        inifileaccess.GetPrivateProfileString("本日成績リセットタイミング", "time", "default", strSb, 255, ".\setting.ini")
        resetLbl.Text = "※本日の戦績は" & strSb.ToString & "時に表示がリセットされます。"
        If CInt(DateTime.Now.ToString("HHmmss")) < CInt(strSb.ToString & "0000") Then
            selectDate = Format(Now.AddDays(-1), "yyyy/MM/dd")
        Else
            selectDate = Format(Now, "yyyy/MM/dd")
        End If
        'SQL文
        Dim SQL_txt As String = "SELECT FORMAT(TAI.TAIKYOKUBI,'YYYY/MM/DD HH:NN:SS') AS 対局日,TAKU.PLAYERSU  AS モード" &
                                ",TAI.JUNI AS 順位,TAI.END_SCORE AS 最終持ち点 FROM U_TAIKYOKU TAI,M_TAKU TAKU,M_DAN MDAN" &
                                "  WHERE TAI.TAKUSYURUI = TAKU.CODE AND TAI.MODE = TAKU.PLAYERSU AND TAI.DANI = MDAN.CODE" &
                                " AND TAI.TAIKYOKUNAME In ('" & player & "') AND TAIKYOKUBI>=#" & selectDate & "#"

        'データアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter(SQL_txt, Database.Cn_txt)

        'データの読み込み
        Adapter.Fill(OLEDS, "TEST")
        'データソースを設定してDataGridViewにデータを表示
        Main.WkGridView.DataSource = OLEDS.Tables("TEST")
        Dim DatagridCnt As Integer = Main.WkGridView.Rows.Count
        For i = 0 To DatagridCnt - 1
            '■三麻
            If Main.WkGridView.Item(1, i).Value = "3" Then
                Taikyokunum3 = Taikyokunum3 + 1
                If Main.WkGridView.Item(2, i).Value = "1" Then
                    juni3(1) = juni3(1) + 1
                ElseIf Main.WkGridView.Item(2, i).Value = "2" Then
                    juni3(2) = juni3(2) + 1
                Else
                    juni3(3) = juni3(3) + 1
                End If
                syusi3 = syusi3 + Main.WkGridView.Item(3, i).Value
                '■四麻
            ElseIf Main.WkGridView.Item(1, i).Value = "4" Then
                Taikyokunum4 = Taikyokunum4 + 1
                If Main.WkGridView.Item(2, i).Value = "1" Then
                    juni4(1) = juni4(1) + 1
                ElseIf Main.WkGridView.Item(2, i).Value = "2" Then
                    juni4(2) = juni4(2) + 1
                ElseIf Main.WkGridView.Item(2, i).Value = "3" Then
                    juni4(3) = juni4(3) + 1
                Else
                    juni4(4) = juni4(4) + 1
                End If
                syusi4 = syusi4 + Main.WkGridView.Item(3, i).Value
            End If
        Next
        If Taikyokunum3 > 0 Then
            '■表示（三麻）
            TaikyokuNum3Lbl.Text = Taikyokunum3
            One3CntLbl.Text = juni3(1)
            Two3CntLbl.Text = juni3(2)
            Three3CntLbl.Text = juni3(3)
            Ruikei3Lbl.Text = syusi3 - (35000 * Taikyokunum3)
            Avg3Lbl.Text = Math.Floor((syusi3 - (35000 * Taikyokunum3)) / Taikyokunum3)
            AvgJuni3Lbl.Text = Math.Round((juni3(1) + (juni3(2) * 2) + (juni3(3) * 3)) / (juni3(1) + juni3(2) + juni3(3)), 2).ToString("F2")
        End If
        If Taikyokunum4 > 0 Then
            '■表示（四麻）
            TaikyokuNum4Lbl.Text = Taikyokunum4
            One4CntLbl.Text = juni4(1)
            Two4CntLbl.Text = juni4(2)
            Three4CntLbl.Text = juni4(3)
            Four4CntLbl.Text = juni4(4)
            Ruikei4Lbl.Text = syusi4 - (25000 * Taikyokunum4)
            Avg4Lbl.Text = Math.Floor((syusi4 - (25000 * Taikyokunum4)) / Taikyokunum4.ToString("F0"))
            AvgJuni4Lbl.Text = Math.Round((juni4(1) + (juni4(2) * 2) + (juni4(3) * 3) + (juni4(4) * 4)) / (juni4(1) + juni4(2) + juni4(3) + juni4(4)), 2).ToString("F2")
        End If
    End Sub
End Class