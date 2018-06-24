Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class Common
    '--------------------------------------------------------------------------
    ' フォルダ選択オブジェクトを表示する
    '2015/07/29 airu 新規作成
    '--------------------------------------------------------------------------
    Public Shared Function FolderDialog(path As String) As String
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        If path = "" Then
            fbd.SelectedPath = "C:\Windows"
        Else
            fbd.SelectedPath = path
        End If
        '新しいフォルダ作成不可にする
        fbd.ShowNewFolderButton = False

        'ダイアログを表示する
        If fbd.ShowDialog() = DialogResult.OK Then
            '選択されたフォルダを表示する
            Return fbd.SelectedPath
        ElseIf path <> "" Then
            Return fbd.SelectedPath
        End If
        Return ""
    End Function
    '--------------------------------------------------------------------------
    ' Gzip解凍
    '2015/08/13 airu 新規作成
    '--------------------------------------------------------------------------
    Public Shared Function Gzipkaitou(filename As String) As Integer

        Dim inFile As String = filename
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder

        Try
            ' 入力ファイルは.mjlogファイルのみ有効
            If Not inFile.ToLower().EndsWith(".mjlog") Then
                Return 1
            End If

            ' ファイル名末尾の「.mjlog」を削除
            inifileaccess.GetPrivateProfileString("各種ディレクトリ", "牌譜解凍ディレクトリ", "default", strSb, 255, ".\setting.ini")
            Dim outFile As String = strSb.ToString & "\" & System.IO.Path.GetFileName(filename)

            Dim num As Integer
            Dim buf(1024) As Byte ' 1Kbytesずつ処理する

            ' 入力ストリーム
            Dim inStream As New FileStream _
   (inFile, FileMode.Open, FileAccess.Read)

            ' 解凍ストリーム
            Dim decompStream As New GZipStream _
  (inStream, CompressionMode.Decompress)

            ' 出力ストリーム
            Dim outStream As New FileStream _
  (outFile, FileMode.Create)

            Using inStream
                Using outStream
                    Using decompStream
                        Do
                            num = decompStream.Read(buf, 0, buf.Length)
                            If num <= 0 Then Exit Do
                            outStream.Write(buf, 0, num)
                        Loop
                    End Using
                End Using
            End Using
        Catch
            'エラーとなった場合、-1を返す
            Return -1
        End Try
        Return 0
    End Function
    '--------------------------------------------------------------------------
    ' ファイル検索（サブフォルダ以下まで検索する）
    '2015/08/13 airu 新規作成
    '--------------------------------------------------------------------------
    Public Shared Sub GetAllFiles(ByVal folder As String,
        ByVal searchPattern As String, ByRef files As ArrayList)
        'folderにあるファイルを取得する
        Dim fs As String() =
            System.IO.Directory.GetFiles(folder, searchPattern, System.IO.SearchOption.AllDirectories)
        'ArrayListに追加する
        files.AddRange(fs)

        'folderのサブフォルダを取得する
        Dim ds As String() = System.IO.Directory.GetDirectories(folder)
        'サブフォルダにあるファイルも調べる
        Dim d As String
        For Each d In ds
            GetAllFiles(d, searchPattern, files)
        Next d
    End Sub
    '--------------------------------------------------------------------------
    ' TagINSERT（解凍したファイルを区切り文字で配列に格納し格納したデータをDBへINSERT）
    '2015/08/18 airu 新規作成
    '--------------------------------------------------------------------------
    Public Shared Sub TagInsert(ByVal filename As String)
        Dim stCsvData As String
        ' >区切りで分割して配列に格納する
        Dim stArrayData As String()
        Dim Ltag As String
        Dim Stag As String
        Dim Kyoku As String()
        Dim No As Integer
        Dim Sfilename As String
        Dim Skyoku As String
        Dim Sba As String
        Dim Wk_kyoku As String

        stCsvData = ""
        No = 0
        Sfilename = System.IO.Path.GetFileName(filename)
        Dim sr As New StreamReader(
        filename, Encoding.GetEncoding("Shift_JIS"))
        stCsvData = sr.ReadToEnd()
        sr.Close()
        stArrayData = stCsvData.Split(">"c)
        For i = 0 To stArrayData.Length - 1
            Ltag = stArrayData(i).Replace("<", "")
            Ltag = Ltag.Replace("/", "")
            Stag = stArrayData(i).Replace("<", "")
            Stag = Stag.Replace(">", "")
            Stag = Stag.Replace("/", "")
            Stag = Stag.Replace(Chr(34), "")
            If Stag.IndexOf(" ") > 0 Then
                Stag = Stag.Substring(0, Stag.IndexOf(" "))
            End If
            If Not Ltag.Contains("SHUFFLE") Then
                If Ltag.Contains("GO") Or Ltag.Contains("UN") Or Ltag.Contains("INIT") Or Ltag.Contains("BYE") Or Ltag.Contains("AGARI") Or Ltag.Contains("owari") Then
                    'タグ情報をインサート
                    No = No + 1
                    '場、局を検索
                    If Ltag.Contains("INIT seed") Then
                        Skyoku = ""
                        Sba = ""
                        Wk_kyoku = ""
                        Kyoku = Ltag.Substring(Ltag.IndexOf("seed") + 6, ((Ltag.IndexOf("ten") - 3) - (Ltag.IndexOf("seed") + 6) + 1)).Split(","c)
                        Skyoku = Kyoku(0).Replace(Chr(34), "")
                        Sba = Kyoku(1).Replace(Chr(34), "")
                        '局
                        Wk_kyoku = Database.Search_Kyoku(CInt(Skyoku))

                        '積棒
                        If Integer.Parse(Sba) > 0 Then
                            Wk_kyoku = Wk_kyoku & " R" & Sba
                        End If
                    End If
                    Database.HaifuTag_Data_Insert(No, Ltag, Stag, Wk_kyoku, Sfilename)
                End If
            End If
        Next
    End Sub
    Public Shared Sub TaikyokuInsert()
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
        '##################################################
        ' 対局DB情報
        '##################################################
        Dim Player(4) As String 'プレーヤー名n0～n3まで格納
        Dim Taikyokubi As String
        Dim Takusyurui As Integer
        Dim Juni(4) As Integer
        Dim Tpoint(4) As Integer
        Dim Fpoint(4) As Double
        Dim Haifufile As String
        Dim Agaricnt(4) As Integer
        Dim Furikomicnt(4) As Integer
        Dim LastScore(4) As Integer
        Dim Rate(4) As String
        Dim wk As String
        Dim taikyokumode As Integer
        Dim wkscore() As String
        Dim Sum_kyoku As Integer
        Dim CntFlg(4) As Integer
        Dim Sex(4) As String
        Dim Dani(4) As String
        Dim who As Integer
        Dim Fromwho As Integer

        Try
            Taikyokubi = ""
            Haifufile = ""
            Sum_kyoku = 0
            CntFlg(1) = 0 'P1接続フラグ(0:接続済)
            CntFlg(2) = 0 'P2接続フラグ(0:接続済)
            CntFlg(3) = 0 'P3接続フラグ(0:接続済)
            CntFlg(4) = 0 'P4接続フラグ(0:接続済)
            Agaricnt(0) = 0
            Agaricnt(1) = 0
            Agaricnt(2) = 0
            Agaricnt(3) = 0
            Furikomicnt(0) = 0
            Furikomicnt(1) = 0
            Furikomicnt(2) = 0
            Furikomicnt(3) = 0
            If Main.WkGridView.Rows.Count > 0 Then
                '色付
                Dim DatagridCnt As Integer = Main.WkGridView.Rows.Count
                'データ数分、実施
                For i = 0 To DatagridCnt - 1
                    wk = Main.WkGridView.Item(1, i).Value
                    If Main.WkGridView.Item(2, i).Value = "GO" And Main.WkGridView.Item(0, i).Value = "1" Then
                        Haifufile = Main.WkGridView.Item(4, i).Value
                        Taikyokubi = Haifufile.Substring(0, 4) & "/" & Haifufile.Substring(4, 2) & "/" & Haifufile.Substring(6, 2) & " " & Haifufile.Substring(8, 2) & ":00:00"
                        Takusyurui = CInt(wk.Substring(wk.IndexOf("type") + 6, (wk.IndexOf("lobby") - wk.IndexOf("type") - 8)))
                        Sum_kyoku = 0
                    ElseIf Main.WkGridView.Item(2, i).Value = "UN" And Main.WkGridView.Item(0, i).Value = "2" Then
                        'ランキング戦の場合
                        If wk.Contains("dan") Then
                            '4人目のプレーヤー情報があれば4人打ち、それ以外は3人打ち
                            If Uri.UnescapeDataString(wk.Substring(wk.IndexOf("n3") + 4, (wk.IndexOf("dan") - wk.IndexOf("n3") - 6))) <> "" Then
                                taikyokumode = 4
                            Else
                                taikyokumode = 3
                            End If
                            Dani = wk.Substring(wk.IndexOf("dan") + 5, ((wk.IndexOf("rate") - 3) - (wk.IndexOf("dan") + 5) + 1)).Split(","c)
                            '雀荘戦の場合
                        ElseIf wk.Contains("rc") Then
                            '4人目のプレーヤー情報があれば4人打ち、それ以外は3人打ち
                            If Uri.UnescapeDataString(wk.Substring(wk.IndexOf("n3") + 4, (wk.IndexOf("rc") - wk.IndexOf("n3") - 6))) <> "" Then
                                taikyokumode = 4
                            Else
                                taikyokumode = 3
                            End If
                            Dani = wk.Substring(wk.IndexOf("rc") + 4, ((wk.IndexOf("rate") - 3) - (wk.IndexOf("rc") + 4) + 1)).Split(","c)
                        End If
                        'プレーヤー名を格納
                        Player(1) = Uri.UnescapeDataString(wk.Substring(wk.IndexOf("n0") + 4, (wk.IndexOf("n1") - wk.IndexOf("n0") - 6)))
                        Player(2) = Uri.UnescapeDataString(wk.Substring(wk.IndexOf("n1") + 4, (wk.IndexOf("n2") - wk.IndexOf("n1") - 6)))
                        Player(3) = Uri.UnescapeDataString(wk.Substring(wk.IndexOf("n2") + 4, (wk.IndexOf("n3") - wk.IndexOf("n2") - 6)))
                        Sex = wk.Substring(wk.IndexOf("sx") + 4, ((wk.Length - 1) - (wk.IndexOf("sx") + 4))).Split(","c)
                        '四人打ちの場合、四人目のプレーヤ名を格納
                        If taikyokumode = 4 Then
                                Player(4) = Uri.UnescapeDataString(wk.Substring(wk.IndexOf("n3") + 4, (wk.IndexOf("dan") - wk.IndexOf("n3") - 6)))
                            Else
                                Player(4) = ""
                            End If
                            'レート情報
                            Rate = wk.Substring(wk.IndexOf("rate") + 6, ((wk.IndexOf("sx") - 3) - (wk.IndexOf("rate") + 6) + 1)).Split(","c)
                            CntFlg(1) = 0 'P1接続フラグ(0:接続済)
                            CntFlg(2) = 0 'P2接続フラグ(0:接続済)
                            CntFlg(3) = 0 'P3接続フラグ(0:接続済)
                            CntFlg(4) = 0 'P4接続フラグ(0:接続済)
                            Agaricnt(0) = 0
                            Agaricnt(1) = 0
                            Agaricnt(2) = 0
                            Agaricnt(3) = 0
                            Furikomicnt(0) = 0
                            Furikomicnt(1) = 0
                            Furikomicnt(2) = 0
                            Furikomicnt(3) = 0
                        ElseIf Main.WkGridView.Item(2, i).Value = "INIT" Then
                            Sum_kyoku = Sum_kyoku + 1
                        ElseIf Main.WkGridView.Item(2, i).Value = "AGARI" Then
                            who = Uri.UnescapeDataString(wk.Substring(wk.IndexOf("who") + 5, (wk.IndexOf("fromWho") - wk.IndexOf("who") - 7)))
                            Fromwho = Uri.UnescapeDataString(wk.Substring(wk.IndexOf("fromWho") + 9, (wk.IndexOf("sc") - wk.IndexOf("fromWho") - 11)))
                            Agaricnt(who) = Agaricnt(who) + 1
                            'whoとFromwhoが同じ違う場合、振込回数をカウントする
                            If who <> Fromwho Then
                                Furikomicnt(Fromwho) = Furikomicnt(Fromwho) + 1
                            End If
                        ElseIf Main.WkGridView.Item(2, i).Value = "BYE" Then
                            '回線切断があった場合、フラグを1にセット
                            If wk.Contains("0") = True Then
                                CntFlg(1) = 1
                            ElseIf wk.Contains("1") = True Then
                                CntFlg(2) = 1
                            ElseIf wk.Contains("2") = True Then
                                CntFlg(3) = 1
                            ElseIf wk.Contains("3") = True Then
                                CntFlg(4) = 1
                            End If
                        ElseIf Main.WkGridView.Item(2, i).Value = "UN" And Main.WkGridView.Item(0, i).Value <> "2" Then
                            '回線復帰があった場合、フラグを2にセット
                            If wk.Contains("n0") = True Then
                            CntFlg(1) = 2
                        ElseIf wk.Contains("n1") = True Then
                            CntFlg(2) = 2
                        ElseIf wk.Contains("n2") = True Then
                            CntFlg(3) = 2
                        ElseIf wk.Contains("n3") = True Then
                            CntFlg(4) = 2
                        End If
                    End If
                    If Main.WkGridView.Item(1, i).Value.ToString.Contains("owari") Then
                        wkscore = wk.Substring(wk.IndexOf("owari") + 7, ((wk.Length - 1) - (wk.IndexOf("owari") + 9) + 1)).Split(","c)
                        LastScore(1) = CInt(wkscore(0)) * 100
                        Tpoint(1) = CInt(wkscore(1))
                        LastScore(2) = CInt(wkscore(2)) * 100
                        Tpoint(2) = CInt(wkscore(3))
                        LastScore(3) = CInt(wkscore(4)) * 100
                        Tpoint(3) = CInt(wkscore(5))
                        If taikyokumode = 4 Then
                            LastScore(4) = CInt(wkscore(6)) * 100
                            Tpoint(4) = CInt(wkscore(7))
                        End If
                        '着順情報,Fpoint情報を格納
                        Chakujun(Tpoint(1), Tpoint(2), Tpoint(3), Tpoint(4), taikyokumode, Juni, Fpoint, LastScore)
                        '対局情報INSERT
                        Database.Utaikyoku_Insert(Taikyokubi, Takusyurui, taikyokumode, Juni(1), Player(1), Tpoint(1), Fpoint(1), LastScore(1), Haifufile, Agaricnt(0), Furikomicnt(0), Dani(0), Sex(0), Rate(0), Sum_kyoku, CntFlg(1))
                        Database.Utaikyoku_Insert(Taikyokubi, Takusyurui, taikyokumode, Juni(2), Player(2), Tpoint(2), Fpoint(2), LastScore(2), Haifufile, Agaricnt(1), Furikomicnt(1), Dani(1), Sex(1), Rate(1), Sum_kyoku, CntFlg(2))
                        Database.Utaikyoku_Insert(Taikyokubi, Takusyurui, taikyokumode, Juni(3), Player(3), Tpoint(3), Fpoint(3), LastScore(3), Haifufile, Agaricnt(2), Furikomicnt(2), Dani(2), Sex(2), Rate(2), Sum_kyoku, CntFlg(3))
                        If taikyokumode = 4 Then
                            Database.Utaikyoku_Insert(Taikyokubi, Takusyurui, taikyokumode, Juni(4), Player(4), Tpoint(4), Fpoint(4), LastScore(4), Haifufile, Agaricnt(3), Furikomicnt(3), Dani(3), Sex(3), Rate(3), Sum_kyoku, CntFlg(4))
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            errMsgDialog("エラーが発生しました。ファイル名：" & Haifufile & "[詳細:" & ex.Message & "]")
        End Try
    End Sub
    Public Shared Sub Chakujun(p1Point As Integer, p2Point As Integer, p3Point As Integer, p4Point As Integer, playnum As Integer, Juni() As Integer, Fpoint() As Double, LastScore() As Integer)
        Dim Point As New System.Collections.ArrayList()
        Dim p1juni As Integer
        Dim p2juni As Integer
        Dim p3juni As Integer
        Dim p4juni As Integer
        Dim strSb As System.Text.StringBuilder
        strSb = New System.Text.StringBuilder
        Dim p3Score As Integer
        Dim p4Score As Integer
        Dim p3Calc As Integer
        Dim p4Calc As Integer

        '設定ファイル読込
        inifileaccess.GetPrivateProfileString("得点の算出方法", "3p_score", "default", strSb, 255, ".\setting.ini")
        p3Score = CInt(strSb.ToString())
        inifileaccess.GetPrivateProfileString("得点の算出方法", "4p_score", "default", strSb, 255, ".\setting.ini")
        p4Score = CInt(strSb.ToString())
        inifileaccess.GetPrivateProfileString("得点の算出方法", "3p_calc", "default", strSb, 255, ".\setting.ini")
        p3Calc = CInt(strSb.ToString())
        inifileaccess.GetPrivateProfileString("得点の算出方法", "4p_calc", "default", strSb, 255, ".\setting.ini")
        p4Calc = CInt(strSb.ToString())
        '順位情報ソート
        Point.Add(p1Point)
        Point.Add(p2Point)
        Point.Add(p3Point)
        If playnum = 4 Then
            Point.Add(p4Point)
        End If
        Point.Sort()
        '４位
        If playnum = 4 Then
            If Point.Item(0) = p1Point Then
                p1juni = 4
            ElseIf Point.Item(0) = p2Point Then
                p2juni = 4
            ElseIf Point.Item(0) = p3Point Then
                p3juni = 4
            ElseIf Point.Item(0) = p4Point Then
                p4juni = 4
            End If
        End If
        '３位
        If playnum = 4 Then
            If Point.Item(1) = p1Point Then
                p1juni = 3
            ElseIf Point.Item(1) = p2Point Then
                p2juni = 3
            ElseIf Point.Item(1) = p3Point Then
                p3juni = 3
            ElseIf Point.Item(1) = p4Point Then
                p4juni = 3
            End If
        ElseIf playnum = 3 Then
            If Point.Item(0) = p1Point Then
                p1juni = 3
            ElseIf Point.Item(0) = p2Point Then
                p2juni = 3
            ElseIf Point.Item(0) = p3Point Then
                p3juni = 3
            End If
        End If
        '２位
        If playnum = 4 Then
            If Point.Item(2) = p1Point Then
                p1juni = 2
            ElseIf Point.Item(2) = p2Point Then
                p2juni = 2
            ElseIf Point.Item(2) = p3Point Then
                p3juni = 2
            ElseIf Point.Item(2) = p4Point Then
                p4juni = 2
            End If
        ElseIf playnum = 3 Then
            If Point.Item(1) = p1Point Then
                p1juni = 2
            ElseIf Point.Item(1) = p2Point Then
                p2juni = 2
            ElseIf Point.Item(1) = p3Point Then
                p3juni = 2
            End If
        End If

        '１位
        If playnum = 4 Then
            If Point.Item(3) = p1Point Then
                p1juni = 1
            ElseIf Point.Item(3) = p2Point Then
                p2juni = 1
            ElseIf Point.Item(3) = p3Point Then
                p3juni = 1
            ElseIf Point.Item(3) = p4Point Then
                p4juni = 1
            End If
        ElseIf playnum = 3 Then
            If Point.Item(2) = p1Point Then
                p1juni = 1
            ElseIf Point.Item(2) = p2Point Then
                p2juni = 1
            ElseIf Point.Item(2) = p3Point Then
                p3juni = 1
            End If
        End If
        '順位情報格納
        Juni(1) = p1juni
        Juni(2) = p2juni
        Juni(3) = p3juni
        If playnum = 4 Then
            Juni(4) = p4juni
        End If
        'Fscore情報格納
        If playnum = 3 Then
            '２，３位のスコア算出
            If p1juni = 2 Or p1juni = 3 Then
                Fpoint(1) = fpoint_calc(LastScore(1), p3Score, p3Calc)
            End If
            If p2juni = 2 Or p2juni = 3 Then
                Fpoint(2) = fpoint_calc(LastScore(2), p3Score, p3Calc)
            End If
            If p3juni = 2 Or p3juni = 3 Then
                Fpoint(3) = fpoint_calc(LastScore(3), p3Score, p3Calc)
            End If

            '１位のスコア算出
            If p1juni = 1 Then
                Fpoint(1) = (CDbl(Fpoint(2)) + CDbl(Fpoint(3))) * (-1)
            ElseIf p2juni = 1 Then
                Fpoint(2) = (CDbl(Fpoint(1)) + CDbl(Fpoint(3))) * (-1)
            ElseIf p3juni = 1 Then
                Fpoint(3) = (CDbl(Fpoint(1)) + CDbl(Fpoint(2))) * (-1)
            End If
        ElseIf playnum = 4 Then

            '２，３，４位のスコア算出
            If p1juni = 2 Or p1juni = 3 Or p1juni = 4 Then
                Fpoint(1) = fpoint_calc(LastScore(1), p4Score, p4Calc)
            End If
            If p2juni = 2 Or p2juni = 3 Or p2juni = 4 Then
                Fpoint(2) = fpoint_calc(LastScore(2), p4Score, p4Calc)
            End If
            If p3juni = 2 Or p3juni = 3 Or p3juni = 4 Then
                Fpoint(3) = fpoint_calc(LastScore(3), p4Score, p4Calc)
            End If
            If p4juni = 2 Or p4juni = 3 Or p4juni = 4 Then
                Fpoint(4) = fpoint_calc(LastScore(4), p4Score, p4Calc)
            End If

            '１位のスコア算出
            If p1juni = 1 Then
                Fpoint(1) = (CDbl(Fpoint(2)) + CDbl(Fpoint(3)) + CDbl(Fpoint(4))) * (-1)
            ElseIf p2juni = 1 Then
                Fpoint(2) = (CDbl(Fpoint(1)) + CDbl(Fpoint(3)) + CDbl(Fpoint(4))) * (-1)
            ElseIf p3juni = 1 Then
                Fpoint(3) = (CDbl(Fpoint(1)) + CDbl(Fpoint(2)) + CDbl(Fpoint(4))) * (-1)
            ElseIf p4juni = 1 Then
                Fpoint(4) = (CDbl(Fpoint(1)) + CDbl(Fpoint(2)) + CDbl(Fpoint(3))) * (-1)
            End If
        End If
    End Sub
    Public Shared Function fpoint_calc(LastScore As Integer, pScore As Integer, pCalc As Integer) As Double
        Dim RtnScore As Double

        If pCalc = 0 Then '生点
            RtnScore = (LastScore - pScore) / 1000
        ElseIf pCalc = 1 Then '切り捨て
            RtnScore = Math.Floor((LastScore - pScore) / 1000)
        ElseIf pCalc = 2 Then '切り上げ
            RtnScore = Math.Ceiling((LastScore - pScore) / 1000)
        ElseIf pCalc = 3 Then '四捨五入
            If System.Math.Abs(LastScore Mod 1000) >= 500 Then
                RtnScore = Math.Ceiling((LastScore - pScore) / 1000)
            Else
                RtnScore = Math.Floor((LastScore - pScore) / 1000)
            End If
        ElseIf pCalc = 4 Then '五捨六入
            If System.Math.Abs(LastScore Mod 1000) >= 600 Then
                RtnScore = Math.Ceiling((LastScore - pScore) / 1000)
            Else
                RtnScore = Math.Floor((LastScore - pScore) / 1000)
            End If
        End If
        Return RtnScore
    End Function

    Public Shared Sub errMsgDialog(Message As String)
        MessageBox.Show(Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class

