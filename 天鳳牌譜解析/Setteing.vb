Imports System.Text
Public Class Setteing

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        '閉じる
        Me.Close()
    End Sub

    Private Sub Setteing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------------------------------------------------------------------
        '2015/07/29 airu 新規作成
        '--------------------------------------------------------------------------
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        'setting.iniを開いて表示する
        inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解析ディレクトリ", "default", strSb, 255, ".\setting.ini")
        HaihuDir.Text = strSb.ToString
        inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解凍ディレクトリ", "default", strSb, 255, ".\setting.ini")
        HaihuKaitouDir.Text = strSb.ToString
        inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜ファイル作成ディレクトリ", "default", strSb, 255, ".\setting.ini")
        HaihuCreateDir.Text = strSb.ToString
        inifileaccess.GetPrivateProfileString("得点の算出方法", "3p_score", "default", strSb, 255, ".\setting.ini")
        Kaeshi3.Text = strSb.ToString
        inifileaccess.GetPrivateProfileString("得点の算出方法", "4p_score", "default", strSb, 255, ".\setting.ini")
        Kaeshi4.Text = strSb.ToString
        inifileaccess.GetPrivateProfileString("得点の算出方法", "3p_calc", "default", strSb, 255, ".\setting.ini")
        If strSb.ToString = "0" Then
            score3_0Rbt.Checked = True
        ElseIf strSb.ToString = "1" Then
            score3_1Rbt.Checked = True
        ElseIf strSb.ToString = "2" Then
            score3_2Rbt.Checked = True
        ElseIf strSb.ToString = "3" Then
            score3_3Rbt.Checked = True
        ElseIf strSb.ToString = "4" Then
            score3_4Rbt.Checked = True
        Else
            score3_0Rbt.Checked = True
        End If
        inifileaccess.GetPrivateProfileString("得点の算出方法", "4p_calc", "default", strSb, 255, ".\setting.ini")
        If strSb.ToString = "0" Then
            score4_0Rbt.Checked = True
        ElseIf strSb.ToString = "1" Then
            score4_1Rbt.Checked = True
        ElseIf strSb.ToString = "2" Then
            score4_2Rbt.Checked = True
        ElseIf strSb.ToString = "3" Then
            score4_3Rbt.Checked = True
        ElseIf strSb.ToString = "4" Then
            score4_4Rbt.Checked = True
        Else
            score4_0Rbt.Checked = True
        End If
        inifileaccess.GetPrivateProfileString("プレーヤー情報", "name", "default", strSb, 255, ".\setting.ini")
        PlayerName.Text = strSb.ToString
        inifileaccess.GetPrivateProfileString("メイン画面表示", "disp", "default", strSb, 255, ".\setting.ini")
        If strSb.ToString = "0" Then
            Main1Rbt.Checked = True
        ElseIf strSb.ToString = "1" Then
            Main2Rbt.Checked = True
        ElseIf strSb.ToString = "2" Then
            Main3Rbt.Checked = True
        Else
            Main3Rbt.Checked = True
        End If
        inifileaccess.GetPrivateProfileString("通算戦績表示件数", "cnt", "default", strSb, 255, ".\setting.ini")
        If strSb.ToString = "30" Then
            Tsusan30Rbt.Checked = True
            TsusanCnt.Enabled = False
        ElseIf strSb.ToString = "50" Then
            Tsusan50Rbt.Checked = True
            TsusanCnt.Enabled = False
        ElseIf strSb.ToString = "100" Then
            Tsusan100Rbt.Checked = True
            TsusanCnt.Enabled = False
        ElseIf strSb.ToString = "0" Then
            TsusanAllRbt.Checked = True
            TsusanCnt.Enabled = False
        Else
            TsusanOtherRbt.Checked = True
            TsusanCnt.Text = strSb.ToString
            TsusanCnt.Enabled = True
        End If
        inifileaccess.GetPrivateProfileString("本日成績リセットタイミング", "time", "default", strSb, 255, ".\setting.ini")
        If strSb.ToString = "0" Then
            time0Rbt.Checked = True
        ElseIf strSb.ToString = "1" Then
            time1Rbt.Checked = True
        ElseIf strSb.ToString = "2" Then
            time2Rbt.Checked = True
        ElseIf strSb.ToString = "3" Then
            time3Rbt.Checked = True
        ElseIf strSb.ToString = "4" Then
            time4Rbt.Checked = True
        ElseIf strSb.ToString = "5" Then
            time5Rbt.Checked = True
        ElseIf strSb.ToString = "6" Then
            time6Rbt.Checked = True
        ElseIf strSb.ToString = "7" Then
            time7Rbt.Checked = True
        ElseIf strSb.ToString = "8" Then
            time8Rbt.Checked = True
        ElseIf strSb.ToString = "9" Then
            time9Rbt.Checked = True
        ElseIf strSb.ToString = "10" Then
            time10Rbt.Checked = True
        Else
            time0Rbt.Checked = True
        End If
    End Sub
    Private Sub SetteiBtn_Click(sender As Object, e As EventArgs) Handles SetteiBtn.Click
        'Doubleに変換できるか確かめる
        Dim d As Double
        '--------------------------------------------------------------------------
        '2015/08/01 airu 新規作成
        '--------------------------------------------------------------------------
        '必須入力チェック
        If HaihuDir.Text = "" Then
            MessageBox.Show("牌譜解析ディレクトリは必ず入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If HaihuKaitouDir.Text = "" Then
            MessageBox.Show("牌譜ファイル解凍ディレクトリは必ず入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If HaihuCreateDir.Text = "" Then
            MessageBox.Show("牌譜ファイル作成ディレクトリは必ず入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Kaeshi3.Text = "" Then
            MessageBox.Show("得点の算出方法（三麻）は必ず入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Kaeshi4.Text = "" Then
            MessageBox.Show("得点の算出方法（四麻）は必ず入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If PlayerName.Text = "" Then
            MessageBox.Show("プレーヤー名は必ず入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TsusanOtherRbt.Checked = True And TsusanCnt.Text = "" Then
            MessageBox.Show("通算戦績表示でその他を選択した場合は、件数を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TsusanOtherRbt.Checked = True Then
            If Double.TryParse(TsusanCnt.Text, d) = False Then
                MessageBox.Show("件数は数値で入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
            If TsusanOtherRbt.Checked = True Then
            If TsusanCnt.Text <= 0 Then
                MessageBox.Show("件数は1以上で入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If MessageBox.Show("設定内容を反映します。" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '設定データ書込
            inifileaccess.WritePrivateProfileString("各種ディレクトリ", "牌譜解析ディレクトリ", HaihuDir.Text, ".\setting.ini")
            inifileaccess.WritePrivateProfileString("各種ディレクトリ", "牌譜解凍ディレクトリ", HaihuKaitouDir.Text, ".\setting.ini")
            inifileaccess.WritePrivateProfileString("各種ディレクトリ", "牌譜ファイル作成ディレクトリ", HaihuCreateDir.Text, ".\setting.ini")
            inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_score", Kaeshi3.Text, ".\setting.ini")
            inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_score", Kaeshi4.Text, ".\setting.ini")
            inifileaccess.WritePrivateProfileString("プレーヤー情報", "name", PlayerName.Text, ".\setting.ini")
            '得点の算出方法（三麻）
            If score3_0Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_calc", 0, ".\setting.ini")
            ElseIf score3_1Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_calc", 1, ".\setting.ini")
            ElseIf score3_2Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_calc", 2, ".\setting.ini")
            ElseIf score3_3Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_calc", 3, ".\setting.ini")
            ElseIf score3_4Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_calc", 4, ".\setting.ini")
            Else
                inifileaccess.WritePrivateProfileString("得点の算出方法", "3p_calc", 0, ".\setting.ini")
            End If
            '得点の算出方法（四麻）
            If score4_0Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_calc", 0, ".\setting.ini")
            ElseIf score4_1Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_calc", 1, ".\setting.ini")
            ElseIf score4_2Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_calc", 2, ".\setting.ini")
            ElseIf score4_3Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_calc", 3, ".\setting.ini")
            ElseIf score4_4Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_calc", 4, ".\setting.ini")
            Else
                inifileaccess.WritePrivateProfileString("得点の算出方法", "4p_calc", 0, ".\setting.ini")
            End If
            'メイン画面表示
            If Main1Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("メイン画面表示", "disp", 0, ".\setting.ini")
            ElseIf Main2Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("メイン画面表示", "disp", 1, ".\setting.ini")
            ElseIf Main3Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("メイン画面表示", "disp", 2, ".\setting.ini")
            Else
                inifileaccess.WritePrivateProfileString("メイン画面表示", "disp", 2, ".\setting.ini")
            End If
            '通算戦績表示
            If Tsusan30Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("通算戦績表示件数", "cnt", 30, ".\setting.ini")
            ElseIf Tsusan50Rbt.Checked = True
                inifileaccess.WritePrivateProfileString("通算戦績表示件数", "cnt", 50, ".\setting.ini")
            ElseIf Tsusan100Rbt.Checked = True
                inifileaccess.WritePrivateProfileString("通算戦績表示件数", "cnt", 100, ".\setting.ini")
            ElseIf TsusanAllRbt.Checked = True
                inifileaccess.WritePrivateProfileString("通算戦績表示件数", "cnt", 0, ".\setting.ini")
            Else TsusanOtherRbt.Checked = True
                inifileaccess.WritePrivateProfileString("通算戦績表示件数", "cnt", TsusanCnt.Text, ".\setting.ini")
            End If
            '本日の戦績表示
            If time0Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 0, ".\setting.ini")
            ElseIf time1Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 1, ".\setting.ini")
            ElseIf time2Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 2, ".\setting.ini")
            ElseIf time3Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 3, ".\setting.ini")
            ElseIf time4Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 4, ".\setting.ini")
            ElseIf time5Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 5, ".\setting.ini")
            ElseIf time6Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 6, ".\setting.ini")
            ElseIf time7Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 7, ".\setting.ini")
            ElseIf time8Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 8, ".\setting.ini")
            ElseIf time9Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 9, ".\setting.ini")
            ElseIf time10Rbt.Checked = True Then
                inifileaccess.WritePrivateProfileString("本日成績リセットタイミング", "time", 10, ".\setting.ini")
            End If
            MessageBox.Show("設定内容を更新しました。", "設定内容変更完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
    End Sub
    '--------------------------------------------------------------------------
    '2015/07/29 airu 新規作成
    '--------------------------------------------------------------------------
    Private Sub SanshoBtn1_Click(sender As Object, e As EventArgs) Handles SanshoBtn1.Click
        HaihuDir.Text = Common.FolderDialog(HaihuDir.Text)
    End Sub
    '--------------------------------------------------------------------------
    '2015/07/29 airu 新規作成
    '--------------------------------------------------------------------------
    Private Sub SanshoBtn2_Click(sender As Object, e As EventArgs) Handles SanshoBtn2.Click
        HaihuKaitouDir.Text = Common.FolderDialog(HaihuKaitouDir.Text)
    End Sub
    '--------------------------------------------------------------------------
    '2015/07/29 airu 新規作成
    '--------------------------------------------------------------------------
    Private Sub SanshoBtn3_Click(sender As Object, e As EventArgs) Handles SanshoBtn3.Click
        HaihuCreateDir.Text = Common.FolderDialog(HaihuCreateDir.Text)
    End Sub

    Private Sub Tsusan30Rbt_CheckedChanged(sender As Object, e As EventArgs) Handles Tsusan30Rbt.CheckedChanged
        TsusanCnt.Enabled = False
    End Sub

    Private Sub Tsusan50Rbt_CheckedChanged(sender As Object, e As EventArgs) Handles Tsusan50Rbt.CheckedChanged
        TsusanCnt.Enabled = False
    End Sub

    Private Sub Tsusan100Rbt_CheckedChanged(sender As Object, e As EventArgs) Handles Tsusan100Rbt.CheckedChanged
        TsusanCnt.Enabled = False
    End Sub

    Private Sub TsusanAllRbt_CheckedChanged(sender As Object, e As EventArgs) Handles TsusanAllRbt.CheckedChanged
        TsusanCnt.Enabled = False
    End Sub

    Private Sub TsusanOtherRbt_CheckedChanged(sender As Object, e As EventArgs) Handles TsusanOtherRbt.CheckedChanged
        TsusanCnt.Enabled = True
    End Sub
End Class