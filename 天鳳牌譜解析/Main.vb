Public Class Main
    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        'アプリケーション終了
        Application.Exit()
    End Sub

    Private Sub 設定ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 設定ToolStripMenuItem.Click
        '設定フォーム開く
        Setteing.ShowDialog()
    End Sub

    Private Sub 空牌譜ファイル作成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 空牌譜ファイル作成ToolStripMenuItem.Click
        '空牌譜ファイル作成フォームを開く
        KaraHaihuCreate.ShowDialog()
    End Sub

    Private Sub バージョン情報VToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles バージョン情報VToolStripMenuItem.Click
        'バージョン情報フォームを開く
        Version.ShowDialog()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        '--------------------------------------------------------------------------
        '2015/08/06 airu 新規作成
        '--------------------------------------------------------------------------
        Dim playnum As Integer 'モード 3:3麻、4:4麻
        Dim taikyokunum As Integer '対局者 0:自分、1:ALL
        Dim taikyokubi As Integer '対局日 0:今月、1:指定
        Dim taikyokubi_From As String '対局日(From)
        Dim taikyokubi_To As String '対局日(To)
        Dim dt As DateTime
        Dim DateFrom365 As DateTime
        Dim DateTo As DateTime
        Dim iDateRet As Integer

        'エリア初期化
        taikyokubi_From = ""
        taikyokubi_To = ""

        'モード
        If mode3Rbt.Checked = True Then
            playnum = 3
        Else
            playnum = 4
        End If
        '対局者
        If JibnRbt.Checked = True Then
            taikyokunum = 0
        Else
            taikyokunum = 1
        End If

        '対局日
        If NowMonthRbn.Checked = True Then
            taikyokubi = 0
        Else
            taikyokubi = 1
            taikyokubi_From = OtherMonthFromTxt.Text
            taikyokubi_To = OtherMonthToTxt.Text
            If OtherMonthFromTxt.Text = "" Then
                MessageBox.Show("対局日(FROM)が未入力です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf OtherMonthToTxt.Text = "" Then
                MessageBox.Show("対局日(TO)が未入力です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DateTime.TryParse(taikyokubi_From, dt) Then
            Else
                MessageBox.Show(taikyokubi_From & "は、有効な日付ではありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DateTime.TryParse(taikyokubi_To, dt) Then
            Else
                MessageBox.Show(taikyokubi_To & "は、有効な日付ではありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DateFrom365 = DateTime.Parse(taikyokubi_From).AddDays(365)
            DateTo = DateTime.Parse(taikyokubi_To)
            iDateRet = Date.Compare(DateFrom365, DateTo)
            If iDateRet = -1 Then
                MessageBox.Show("対局日の指定は365日以内に設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If mode3Rbt.Checked = False And mode4Rbt.Checked = False Then
            MessageBox.Show("モードは必ず選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '待機状態
        Cursor.Current = Cursors.WaitCursor
        '検索してデータグリッドに表示
        DatagridShow(playnum, taikyokunum, taikyokubi, taikyokubi_From, taikyokubi_To)
        TaikyokuSensekiDisp(playnum)
        '元に戻す
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------------------------------------------------------------------
        '2015/08/06 airu 新規作成
        '--------------------------------------------------------------------------
        Dim playnum As Integer 'モード 3:3麻、4:4麻
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        'フォームサイズ変更不可
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        '設定ファイルより情報反映
        JibnRbt.Checked = True
        NowMonthRbn.Checked = True
        Label3.Font = New Font("Arial Unicode MS", 11)
        NowTime.Start()
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
        'モードが3麻 or 4麻のときは検索
        If playnum = 3 Or playnum = 4 Then
            '検索してデータグリッドに表示
            DatagridShow(playnum, 0, 0, "", "")
            TaikyokuSensekiDisp(playnum)
        Else
            'モードが選択されていない場合は、デフォルト値を設定
            NowMonthLbl2.Text = "0-0-0-0"
            TsusanLbl2.Text = "0-0-0-0"
            NowMonthAvgLbl2.Text = "0.00"
            TsusanAvgLbl2.Text = "0.00"
            TenhouPointLbl2.Text = "0pt"
            FreePointLbl2.Text = "0"
            Last1Lbl.Text = "-"
            Last2Lbl.Text = "-"
            Last3Lbl.Text = "-"
            Last4Lbl.Text = "-"
            Last5Lbl.Text = "-"
            NowMonthAgariLbl2.Text = ".000"
            NowMonthFurikomiLbl2.Text = ".000"
            TsusanAgariLbl2.Text = ".000"
            TsusanFurikomiLbl2.Text = ".000"
        End If
    End Sub

    Private Sub DatagridShow(playnum As Integer, taikyokunum As Integer, taikyokubi As Integer, taikyokubi_From As String, taikyokubi_To As String)
        '--------------------------------------------------------------------------
        '2015/08/06 airu 新規作成(検索時、フォームロード時共通)
        '--------------------------------------------------------------------------
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Dim OLEDS As DataSet = New DataSet("TEST")
        Dim wk_from As String
        Dim wk_to As String
        Dim dt As DateTime

        'SQL文
        Dim SQL_txt As String = "SELECT FORMAT(TAI.TAIKYOKUBI,'YYYY/MM/DD HH:NN:SS') AS 対局日,TAKU.TAKULEVEL AS 卓レベル,TAKU.TAKUSYURUI AS 卓種類,TAKU.PLAYERSU & '麻' AS モード" &
                                ",TAI.JUNI AS 順位,MDAN.DAN AS 段位,TAI.TAIKYOKUNAME AS 対局者,TAI.T_POINT AS 天鳳ポイント,TAI.F_POINT AS フリーポイント,TAI.END_SCORE AS 最終持ち点,TAI.SUM_KYOKU AS 対局数,TAI.CNTFLG AS 接続フラグ" &
                                ",TAI.SEX AS 性別,TAI.RATE AS レート FROM U_TAIKYOKU TAI,M_TAKU TAKU,M_DAN MDAN" &
                                "  WHERE TAI.TAKUSYURUI = TAKU.CODE AND TAI.MODE = TAKU.PLAYERSU AND TAKU.PLAYERSU = " & playnum & "AND TAI.DANI = MDAN.CODE"
        '対局者が自分の場合、設定ファイルのプレーヤ名を指定->複数検索対応のためIN検索
        If taikyokunum = 0 Then
            inifileaccess.GetPrivateProfileString("プレーヤー情報", "name", "default", strSb, 255, ".\setting.ini")
            SQL_txt = SQL_txt & " AND TAI.TAIKYOKUNAME In ('" & strSb.ToString & "')"
        End If
        If taikyokubi = 0 Then
            wk_from = Format(Now, "yyyy/MM") & "/01"
            wk_to = Format(Now.AddMonths(1).AddDays(-1), "yyyy/MM/dd")
        Else
            If DateTime.TryParse(taikyokubi_From, dt) Then
                wk_from = taikyokubi_From
            Else
                MessageBox.Show("指定期間(FROM)は、日付に変換できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DateTime.TryParse(taikyokubi_To, dt) Then
                wk_to = taikyokubi_To & " 23:59:59"
            Else
                MessageBox.Show("指定期間(TO)は、日付に変換できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        SQL_txt = SQL_txt & " AND TAIKYOKUBI BETWEEN #" & wk_from & "# AND #" & wk_to & "#"
        SQL_txt = SQL_txt & " ORDER BY TAI.TAIKYOKUBI DESC,TAI.HAIHUFILE,TAI.JUNI ASC"

        'データアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter(SQL_txt, Database.Cn_txt)

        'データの読み込み
        Adapter.Fill(OLEDS, "TEST")
        'データソースを設定してDataGridViewにデータを表示
        DataGridView1.DataSource = OLEDS.Tables("TEST")

        If DataGridView1.Rows.Count > 0 Then
            DataGridEdit()
        End If
        DataGridView1.Columns(10).Visible = False '対局数非表示
        DataGridView1.Columns(11).Visible = False '接続フラグ非表示
        DataGridView1.Columns(12).Visible = False '性別非表示
        DataGridView1.Columns(13).Visible = False 'レート非表示
    End Sub

    Private Sub NowMonthRbn_CheckedChanged(sender As Object, e As EventArgs) Handles NowMonthRbn.CheckedChanged
        OtherMonthFromTxt.Enabled = False
        OtherMonthToTxt.Enabled = False
    End Sub

    Private Sub OtherMonthRbn_CheckedChanged(sender As Object, e As EventArgs) Handles OtherMonthRbn.CheckedChanged
        OtherMonthFromTxt.Enabled = True
        OtherMonthToTxt.Enabled = True
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


    Private Sub AllImportBtn_Click(sender As Object, e As EventArgs) Handles AllImportBtn.Click
        Dim NowMonth As String
        Dim NowMonth_Sc As String
        Dim strSb As System.Text.StringBuilder
        Dim filelist As ArrayList
        Dim haihufile As String
        Dim rtn As Integer
        strSb = New System.Text.StringBuilder

        If MessageBox.Show("今月分の牌譜ファイルをインポートします。" & vbLf & "よろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '待機状態
            Cursor.Current = Cursors.WaitCursor
            'ファイルリスト初期化
            filelist = New ArrayList()
            '現在の年月取得
            NowMonth = Now.ToString("yyyyMM")
            NowMonth_Sc = Now.ToString("yyyy/MM") & "/01 00:00:00"
            inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解析ディレクトリ", "default", strSb, 255, ".\setting.ini")
            '下記フォルダ内のディレクトリのmjlogファイルを検索し、ファイルリストに格納
            Common.GetAllFiles(strSb.ToString & "\" & NowMonth, "*.mjlog", filelist)

            '牌譜解凍ディレクトリ内のファイルをすべて削除します。
            strSb = New System.Text.StringBuilder
            inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解凍ディレクトリ", "default", strSb, 255, ".\setting.ini")

            For Each tempFile As String In System.IO.Directory.GetFiles(strSb.ToString)
                System.IO.File.Delete(tempFile)
            Next
            'ファイルリスト分ループ(mjlog形式のファイルgzip解凍)
            For Each haihufile In filelist
                rtn = Common.Gzipkaitou(haihufile)
                If rtn = -1 Then
                    MessageBox.Show("牌譜ファイルが読み込めませんでした。(Error01)", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Database.DBconnect(Database.Cn_txt)
            '今月の戦績データ削除
            Database.Search_Data_Delete(NowMonth_Sc, "")
            '牌譜取込データタグ削除
            Database.HaifuTag_Data_Delete()
            'データ取込(Tag)
            filelist = New ArrayList()
            '下記フォルダ内のディレクトリのmjlogファイルを検索し、ファイルリストに格納
            Common.GetAllFiles(strSb.ToString & "\", "*.mjlog", filelist)
            For Each haihufile In filelist
                Common.TagInsert(haihufile)
                If rtn = -1 Then
                    MessageBox.Show("牌譜ファイルが読み込めませんでした。(Error02)", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            'Tag情報を読み込み
            Database.Search_tag()
            '対局成績データを作成
            Common.TaikyokuInsert()
            Database.DBdispose()
            '牌譜解凍ディレクトリ内のファイルをすべて削除します。（再）
            For Each tempFile As String In System.IO.Directory.GetFiles(strSb.ToString)
                System.IO.File.Delete(tempFile)
            Next

            '元に戻す
            Cursor.Current = Cursors.Default
            If MessageBox.Show("対局データの取込が完了しました。" & vbLf & "対局データを再ロードしますか？", "対局データ取込完了", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
                SearchBtn_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub All2ImportBtn_Click(sender As Object, e As EventArgs) Handles All2ImportBtn.Click
        Dim strSb As System.Text.StringBuilder
        Dim filelist As ArrayList
        Dim haihufile As String
        Dim rtn As Integer
        strSb = New System.Text.StringBuilder

        If MessageBox.Show("全ての牌譜ファイルをインポートします。" & vbLf & "牌譜ファイルの数が多いと処理に時間がかかる場合があります。" & vbLf & "よろしいですか？" & vbLf & "※取込後は、ツール→最適化を行うことをおすすめします。", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '待機状態
            Cursor.Current = Cursors.WaitCursor
            'ファイルリスト初期化
            filelist = New ArrayList()
            inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解析ディレクトリ", "Default", strSb, 255, ".\setting.ini")
            '下記フォルダ内のディレクトリのmjlogファイルを検索し、ファイルリストに格納
            Common.GetAllFiles(strSb.ToString, "*.mjlog", filelist)

            '牌譜解凍ディレクトリ内のファイルをすべて削除します。
            strSb = New System.Text.StringBuilder
            inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解凍ディレクトリ", "Default", strSb, 255, ".\setting.ini")

            For Each tempFile As String In System.IO.Directory.GetFiles(strSb.ToString)
                System.IO.File.Delete(tempFile)
            Next
            'ファイルリスト分ループ(mjlog形式のファイルgzip解凍)
            For Each haihufile In filelist
                rtn = Common.Gzipkaitou(haihufile)
                If rtn = -1 Then
                    MessageBox.Show("牌譜ファイルが読み込めませんでした。(Error01) Then" & vbLf & "[ファイル:" & haihufile & "]", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Database.DBconnect(Database.Cn_txt)
            '今月の戦績データ削除
            Database.Search_Data_Delete("", "")
            '牌譜取込データタグ削除
            Database.HaifuTag_Data_Delete()
            'データ取込(Tag)
            filelist = New ArrayList()
            '下記フォルダ内のディレクトリのmjlogファイルを検索し、ファイルリストに格納
            Common.GetAllFiles(strSb.ToString & "\", "*.mjlog", filelist)
            For Each haihufile In filelist
                Common.TagInsert(haihufile)
                If rtn = -1 Then
                    MessageBox.Show("牌譜ファイルが読み込めませんでした。(Error02)" & vbLf & "[ファイル:" & haihufile & "]", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            'Tag情報を読み込み
            Database.Search_tag()
            '対局成績データを作成
            Common.TaikyokuInsert()
            Database.DBdispose()
            '牌譜解凍ディレクトリ内のファイルをすべて削除します。（再）
            For Each tempFile As String In System.IO.Directory.GetFiles(strSb.ToString)
                System.IO.File.Delete(tempFile)
            Next
            '元に戻す
            Cursor.Current = Cursors.Default
            If MessageBox.Show("対局データの取込が完了しました。" & vbLf & "対局データを再ロードしますか？", "対局データ取込完了", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
                SearchBtn_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub NowTime_Tick(sender As Object, e As EventArgs) Handles NowTime.Tick
        Label3.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub
    Private Sub TaikyokuSensekiDisp(mode As Integer)
        Dim strSb As System.Text.StringBuilder
        Dim player As String
        Dim past5Senseki(5) As String
        Dim NowmonthSenseki(4) As Long
        Dim TsusanSenseki(4) As Long
        Dim TenhouPoint As Long
        Dim FreePoint As Double
        Dim wkdate As String
        Dim Nowwkdate As String
        Dim juni As Integer
        Dim iNowMonthAgari As Long     '今月あがり回数(数値型)
        Dim iNowMonthFurikomi As Long  '今月振込回数(数値型)
        Dim iTsusanAgari As Long       '通算あがり回数(数値型)
        Dim iTsusanFurikomi As Long    '通算振込回数(数値型)
        Dim NowMonthTaikyokusu As Long
        Dim TsusanTaikyokusu As Long
        Dim NowMonthHeikinJuni As Double
        Dim TsusanHeikinJuni As Double
        Dim TsusanCnt As Integer
        strSb = New System.Text.StringBuilder
        past5Senseki(0) = "-"
        past5Senseki(1) = "-"
        past5Senseki(2) = "-"
        past5Senseki(3) = "-"
        past5Senseki(4) = "-"
        NowmonthSenseki(1) = 0
        NowmonthSenseki(2) = 0
        NowmonthSenseki(3) = 0
        NowmonthSenseki(4) = 0
        TsusanSenseki(1) = 0
        TsusanSenseki(2) = 0
        TsusanSenseki(3) = 0
        TsusanSenseki(4) = 0
        TenhouPoint = 0
        Dim OLEDS As DataSet = New DataSet("TEST")

        'プレーヤー情報を設定ファイルから取得
        inifileaccess.GetPrivateProfileString("プレーヤー情報", "name", "default", strSb, 255, ".\setting.ini")
        player = strSb.ToString

        '通算戦績表示件数を設定ファイルから取得
        inifileaccess.GetPrivateProfileString("通算戦績表示件数", "cnt", "default", strSb, 255, ".\setting.ini")
        TsusanCnt = strSb.ToString

        'SQL文
        Dim SQL_txt As String = "SELECT FORMAT(TAI.TAIKYOKUBI,'YYYY/MM/DD HH:NN:SS') AS 対局日,TAKU.TAKUSYURUI AS 卓種類,TAKU.PLAYERSU & '麻' AS モード" &
                                ",TAI.JUNI AS 順位,TAI.TAIKYOKUNAME AS 対局者,TAI.T_POINT AS 天鳳ポイント,TAI.F_POINT AS フリーポイント,TAI.END_SCORE AS 最終持ち点,TAI.SUM_KYOKU AS 対局数,TAI.CNTFLG AS 接続フラグ" &
                                ",TAI.SEX AS 性別,AGARI_CNT AS 和がり回数,FURIKOMI_CNT AS 振込回数 FROM U_TAIKYOKU TAI,M_TAKU TAKU" &
                                "  WHERE TAI.TAKUSYURUI = TAKU.CODE AND TAI.MODE = TAKU.PLAYERSU AND TAKU.PLAYERSU = " & mode &
                                " AND TAI.TAIKYOKUNAME In ('" & player & "')" &
                                " ORDER BY TAI.TAIKYOKUBI DESC,TAI.HAIHUFILE ASC"

        'データアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter(SQL_txt, Database.Cn_txt)

        'データの読み込み
        Adapter.Fill(OLEDS, "TEST")
        'データソースを設定してDataGridViewにデータを表示
        WkGridView.DataSource = OLEDS.Tables("TEST")

        Nowwkdate = Now.ToString("yyyy/MM/01").Replace("/", "")

        '3麻
        If mode = 3 Then
            SensekiLbl1.Text = "最近五戦戦績（三麻）"
            TenhouPointLbl1.Text = "今月天鳳ポイント（三麻）"
            FreePointLbl1.Text = "今月のフリーポイント（三麻）"
            NowMonthLbl1.Text = "今月の戦績（三麻）"
            TsusanLbl1.Text = "通算戦績（三麻）"
            NowMonthAvgLbl1.Text = "平均順位（三麻）"
            TsusanAvgLbl1.Text = "平均順位（三麻）"
            NowMonthAgariLbl1.Text = "今月和了率（三麻）"
            NowMonthFurikomiLbl1.Text = "今月放銃率（三麻）"
            TsusanAgariLbl1.Text = "通算和了率（三麻）"
            TsusanFurikomiLbl1.Text = "通算放銃率（三麻）"
            Dim DatagridCnt As Integer = WkGridView.Rows.Count
            'データ数分、実施（１位 or ３位 or ４位の場合、順位と最終持ち点に色付）
            For i = 0 To DatagridCnt - 1
                juni = WkGridView.Item(3, i).Value
                If i <= 4 Then
                    past5Senseki(i) = WkGridView.Item(3, i).Value
                End If
                wkdate = WkGridView.Item(0, i).Value.ToString.Substring(0, 10).Replace("/", "")
                If wkdate >= Nowwkdate Then
                    TenhouPoint = TenhouPoint + WkGridView.Item(5, i).Value
                    FreePoint = FreePoint + WkGridView.Item(6, i).Value
                    NowmonthSenseki(juni) = NowmonthSenseki(juni) + 1
                    NowMonthTaikyokusu = NowMonthTaikyokusu + WkGridView.Item(8, i).Value
                    iNowMonthAgari = iNowMonthAgari + WkGridView.Item(11, i).Value
                    iNowMonthFurikomi = iNowMonthFurikomi + WkGridView.Item(12, i).Value
                End If
                If TsusanCnt - 1 >= i Or TsusanCnt = 0 Then
                    iTsusanAgari = iTsusanAgari + WkGridView.Item(11, i).Value
                    iTsusanFurikomi = iTsusanFurikomi + WkGridView.Item(12, i).Value
                    TsusanSenseki(juni) = TsusanSenseki(juni) + 1
                    TsusanTaikyokusu = TsusanTaikyokusu + WkGridView.Item(8, i).Value
                End If
            Next
            Last1Lbl.Text = past5Senseki(0)
            Last2Lbl.Text = past5Senseki(1)
            Last3Lbl.Text = past5Senseki(2)
            Last4Lbl.Text = past5Senseki(3)
            Last5Lbl.Text = past5Senseki(4)
            If Last1Lbl.Text = "1" Then
                Last1Lbl.ForeColor = Color.Blue
            ElseIf Last1Lbl.Text = "3" Then
                Last1Lbl.ForeColor = Color.Red
            Else
                Last1Lbl.ForeColor = Color.Black
            End If

            If Last2Lbl.Text = "1" Then
                Last2Lbl.ForeColor = Color.Blue
            ElseIf Last2Lbl.Text = "3" Then
                Last2Lbl.ForeColor = Color.Red
            Else
                Last2Lbl.ForeColor = Color.Black
            End If

            If Last3Lbl.Text = "1" Then
                Last3Lbl.ForeColor = Color.Blue
            ElseIf Last3Lbl.Text = "3" Then
                Last3Lbl.ForeColor = Color.Red
            Else
                Last3Lbl.ForeColor = Color.Black
            End If

            If Last4Lbl.Text = "1" Then
                Last4Lbl.ForeColor = Color.Blue
            ElseIf Last4Lbl.Text = "3" Then
                Last4Lbl.ForeColor = Color.Red
            Else
                Last4Lbl.ForeColor = Color.Black
            End If

            If Last5Lbl.Text = "1" Then
                Last5Lbl.ForeColor = Color.Blue
            ElseIf Last5Lbl.Text = "3" Then
                Last5Lbl.ForeColor = Color.Red
            Else
                Last5Lbl.ForeColor = Color.Black
            End If
            NowMonthHeikinJuni = Math.Round((NowmonthSenseki(1) + (NowmonthSenseki(2) * 2) + (NowmonthSenseki(3) * 3)) / (NowmonthSenseki(1) + NowmonthSenseki(2) + NowmonthSenseki(3)), 2).ToString("F2")
            TsusanHeikinJuni = Math.Round((TsusanSenseki(1) + (TsusanSenseki(2) * 2) + (TsusanSenseki(3) * 3)) / (TsusanSenseki(1) + TsusanSenseki(2) + TsusanSenseki(3)), 2)
            NowMonthLbl2.Text = NowmonthSenseki(1) & "-" & NowmonthSenseki(2) & "-" & NowmonthSenseki(3)
            TsusanLbl2.Text = TsusanSenseki(1) & "-" & TsusanSenseki(2) & "-" & TsusanSenseki(3)
        Else '4麻
            SensekiLbl1.Text = "最近五戦戦績（四麻）"
            TenhouPointLbl1.Text = "今月天鳳ポイント（四麻）"
            FreePointLbl1.Text = "今月のフリーポイント（四麻）"
            NowMonthLbl1.Text = "今月の戦績（四麻）"
            TsusanLbl1.Text = "通算戦績（四麻）"
            NowMonthAvgLbl1.Text = "平均順位（四麻）"
            TsusanAvgLbl1.Text = "平均順位（四麻）"
            NowMonthAgariLbl1.Text = "今月和了率（四麻）"
            NowMonthFurikomiLbl1.Text = "今月放銃率（四麻）"
            TsusanAgariLbl1.Text = "通算和了率（四麻）"
            TsusanFurikomiLbl1.Text = "通算放銃率（四麻）"
            Dim DatagridCnt As Integer = WkGridView.Rows.Count
            'データ数分、実施（１位 or ３位 or ４位の場合、順位と最終持ち点に色付）
            For i = 0 To DatagridCnt - 1
                juni = WkGridView.Item(3, i).Value
                If i <= 4 Then
                    past5Senseki(i) = WkGridView.Item(3, i).Value
                End If
                wkdate = WkGridView.Item(0, i).Value.ToString.Substring(0, 10).Replace("/", "")
                If wkdate >= Nowwkdate Then
                    TenhouPoint = TenhouPoint + WkGridView.Item(5, i).Value '天鳳ポイント
                    FreePoint = FreePoint + WkGridView.Item(6, i).Value     'フリーポイント
                    NowmonthSenseki(juni) = NowmonthSenseki(juni) + 1       '1～4位の成績
                    NowMonthTaikyokusu = NowMonthTaikyokusu + WkGridView.Item(8, i).Value '今月の対局数
                    iNowMonthAgari = iNowMonthAgari + WkGridView.Item(11, i).Value
                    iNowMonthFurikomi = iNowMonthFurikomi + WkGridView.Item(12, i).Value
                End If
                If TsusanCnt - 1 >= i Or TsusanCnt = 0 Then
                    iTsusanAgari = iTsusanAgari + WkGridView.Item(11, i).Value
                    iTsusanFurikomi = iTsusanFurikomi + WkGridView.Item(12, i).Value
                    TsusanSenseki(juni) = TsusanSenseki(juni) + 1
                    TsusanTaikyokusu = TsusanTaikyokusu + WkGridView.Item(8, i).Value
                End If
            Next
            Last1Lbl.Text = past5Senseki(0)
            Last2Lbl.Text = past5Senseki(1)
            Last3Lbl.Text = past5Senseki(2)
            Last4Lbl.Text = past5Senseki(3)
            Last5Lbl.Text = past5Senseki(4)
            If Last1Lbl.Text = "1" Then
                Last1Lbl.ForeColor = Color.Blue
            ElseIf Last1Lbl.Text = "4" Then
                Last1Lbl.ForeColor = Color.Red
            Else
                Last1Lbl.ForeColor = Color.Black
            End If

            If Last2Lbl.Text = "1" Then
                Last2Lbl.ForeColor = Color.Blue
            ElseIf Last2Lbl.Text = "4" Then
                Last2Lbl.ForeColor = Color.Red
            Else
                Last2Lbl.ForeColor = Color.Black
            End If

            If Last3Lbl.Text = "1" Then
                Last3Lbl.ForeColor = Color.Blue
            ElseIf Last3Lbl.Text = "4" Then
                Last3Lbl.ForeColor = Color.Red
            Else
                Last3Lbl.ForeColor = Color.Black
            End If

            If Last4Lbl.Text = "1" Then
                Last4Lbl.ForeColor = Color.Blue
            ElseIf Last4Lbl.Text = "4" Then
                Last4Lbl.ForeColor = Color.Red
            Else
                Last4Lbl.ForeColor = Color.Black
            End If

            If Last5Lbl.Text = "1" Then
                Last5Lbl.ForeColor = Color.Blue
            ElseIf Last5Lbl.Text = "4" Then
                Last5Lbl.ForeColor = Color.Red
            Else
                Last5Lbl.ForeColor = Color.Black
            End If
            NowMonthHeikinJuni = Math.Round((NowmonthSenseki(1) + (NowmonthSenseki(2) * 2) + (NowmonthSenseki(3) * 3) + (NowmonthSenseki(4) * 4)) / (NowmonthSenseki(1) + NowmonthSenseki(2) + NowmonthSenseki(3) + NowmonthSenseki(4)), 2).ToString("F2")
            TsusanHeikinJuni = Math.Round((TsusanSenseki(1) + (TsusanSenseki(2) * 2) + (TsusanSenseki(3) * 3) + (TsusanSenseki(4) * 4)) / (TsusanSenseki(1) + TsusanSenseki(2) + TsusanSenseki(3) + TsusanSenseki(4)), 2)
            NowMonthLbl2.Text = NowmonthSenseki(1) & "-" & NowmonthSenseki(2) & "-" & NowmonthSenseki(3) & "-" & NowmonthSenseki(4)
            TsusanLbl2.Text = TsusanSenseki(1) & "-" & TsusanSenseki(2) & "-" & TsusanSenseki(3) & "-" & TsusanSenseki(4)
        End If
        TenhouPointLbl2.Text = TenhouPoint & "pt"
        FreePointLbl2.Text = Math.Round(FreePoint, 1)

        If NowMonthTaikyokusu > 0 Then
            NowMonthAvgLbl2.Text = NowMonthHeikinJuni
            NowMonthAgariLbl2.Text = Math.Round(iNowMonthAgari / NowMonthTaikyokusu * 100, 1) & "%"
            NowMonthFurikomiLbl2.Text = Math.Round(iNowMonthFurikomi / NowMonthTaikyokusu * 100, 1) & "%"
        Else
            NowMonthAvgLbl2.Text = "0.00"
            NowMonthAgariLbl2.Text = ".000"
            NowMonthFurikomiLbl2.Text = ".000"
        End If
        If TsusanTaikyokusu > 0 Then
            TsusanAvgLbl2.Text = TsusanHeikinJuni
            TsusanAgariLbl2.Text = Math.Round(iTsusanAgari / TsusanTaikyokusu * 100, 1) & "%"
            TsusanFurikomiLbl2.Text = Math.Round(iTsusanFurikomi / TsusanTaikyokusu * 100, 1) & "%"
        Else
            TsusanAvgLbl2.Text = "0.00"
            TsusanAgariLbl2.Text = ".000"
            TsusanFurikomiLbl2.Text = ".000"
        End If
    End Sub

    Private Sub DataExportBtn_Click(sender As Object, e As EventArgs) Handles DataExportBtn.Click
        SearchOutput.ShowDialog()
    End Sub

    Private Sub DataGridEdit()
        '色付
        Dim DatagridCnt As Integer = DataGridView1.Rows.Count
        'データ数分、実施（１位 or ３位 or ４位の場合、順位と最終持ち点に色付）
        For i = 0 To DatagridCnt - 1
            If DataGridView1.Item(3, i).Value = "3麻" And (DataGridView1.Item(4, i).Value = "3" Or DataGridView1.Item(9, i).Value < 0) Then
                DataGridView1.Item(4, i).Style.ForeColor = Color.Red
                DataGridView1.Item(9, i).Style.ForeColor = Color.Red
            ElseIf DataGridView1.Item(3, i).Value = "4麻" And (DataGridView1.Item(4, i).Value = "4" Or DataGridView1.Item(9, i).Value < 0) Then
                DataGridView1.Item(4, i).Style.ForeColor = Color.Red
                DataGridView1.Item(9, i).Style.ForeColor = Color.Red
            ElseIf DataGridView1.Item(4, i).Value = "1" Then
                DataGridView1.Item(4, i).Style.ForeColor = Color.Blue
                DataGridView1.Item(9, i).Style.ForeColor = Color.Blue
            End If
            If DataGridView1.Item(3, i).Value = "3麻" And DataGridView1.Item(2, i).Value = "東風" Then
                DataGridView1.Item(2, i).Style.ForeColor = Color.White
                DataGridView1.Item(2, i).Style.BackColor = Color.MediumVioletRed
            ElseIf DataGridView1.Item(3, i).Value = "3麻" And DataGridView1.Item(2, i).Value = "半荘" Then
                DataGridView1.Item(2, i).Style.ForeColor = Color.White
                DataGridView1.Item(2, i).Style.BackColor = Color.Orange
            ElseIf DataGridView1.Item(3, i).Value = "4麻" And DataGridView1.Item(2, i).Value = "東風" Then
                DataGridView1.Item(2, i).Style.ForeColor = Color.White
                DataGridView1.Item(2, i).Style.BackColor = Color.Green
            ElseIf DataGridView1.Item(3, i).Value = "4麻" And DataGridView1.Item(2, i).Value = "半荘" Then
                DataGridView1.Item(2, i).Style.ForeColor = Color.White
                DataGridView1.Item(2, i).Style.BackColor = Color.Orchid
            End If
            '接続フラグによりプレーヤ名の色をつける
            If DataGridView1.Item(11, i).Value = "1" Then
                DataGridView1.Item(6, i).Style.ForeColor = Color.Red
            ElseIf DataGridView1.Item(11, i).Value = "2" Then
                DataGridView1.Item(6, i).Style.ForeColor = Color.SeaGreen
            End If
            '性別により背景の色をつける
            If DataGridView1.Item(12, i).Value = "M" Then
                DataGridView1.Item(0, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(1, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(3, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(4, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(5, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(6, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(7, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(8, i).Style.BackColor = Color.FromArgb(200, 200, 250)
                DataGridView1.Item(9, i).Style.BackColor = Color.FromArgb(200, 200, 250)
            Else
                DataGridView1.Item(0, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(1, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(3, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(4, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(5, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(6, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(7, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(8, i).Style.BackColor = Color.FromArgb(250, 200, 200)
                DataGridView1.Item(9, i).Style.BackColor = Color.FromArgb(250, 200, 200)
            End If
        Next
        'フォントを変更する
        DataGridView1.DefaultCellStyle.Font = New Font("Arial Unicode MS", 12, FontStyle.Regular)
        '行選択にする
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.RowHeadersWidth = 65 '行ヘッダの幅を変更する
    End Sub

    Private Sub 最適化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 最適化ToolStripMenuItem.Click
        Saitekika.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) _
  Handles DataGridView1.CellPainting
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

    Private Sub 今日の成績ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 今日の成績ToolStripMenuItem.Click
        TodayScoreBoard.ShowDialog()
    End Sub

    Private Sub 対局者戦績ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 対局者戦績ToolStripMenuItem.Click
        TaikyokusyaBunseki.ShowDialog()
    End Sub
End Class
