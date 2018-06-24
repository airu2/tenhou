Public Class Database
    '設定
    Private Shared Prvd As String = "Microsoft.ACE.OLEDB.12.0" 'プロバイダ(accdb)
    Public Shared db_name As String = "tenhou.accdb" 'DBファイル名
    Public Shared db2_name As String = "tenhou2.accdb" 'DBファイル名

    '接続文字列
    Public Shared Cn_txt As String = "Provider=" & Prvd & "; Data Source=" & db_name
    Public Shared Cn2_txt As String = "Provider=" & Prvd & "; Data Source=" & db2_name

    '各宣言
    Public Shared Adapter As System.Data.OleDb.OleDbDataAdapter
    Public Shared Table1 As DataTable
    Public Shared Cn As System.Data.OleDb.OleDbConnection
    Public Shared SQL As System.Data.OleDb.OleDbCommand
    Public Shared Trz As System.Data.OleDb.OleDbTransaction

    Public Shared Sub DBconnect(Cndb As String) 'DB接続
        'データベース指定
        Cn = New System.Data.OleDb.OleDbConnection
        Cn.ConnectionString = Cndb
        Cn.Open() 'オープン

        'トランザクション開始
        'Trz = Cn.BeginTransaction

        'コマンドのインスタンスを生成
        SQL = Cn.CreateCommand
        SQL.Connection = Cn
        SQL.Transaction = Trz
    End Sub

    Public Shared Sub DBdispose() 'DB切断
        Cn.Close() 'データベースを閉じる
        SQL.Dispose() 'コマンドを破棄
        Cn.Dispose() 'データベースを破棄
    End Sub
    Public Shared Sub Search_Data_Delete(From_date As String, To_date As String)
        '--------------------------------------------------------------------------
        '2015/08/18 airu 新規作成(対局テーブル削除)
        '--------------------------------------------------------------------------
        Dim iRet As Integer
        'コマンドのインスタンスを生成(以下は３セット必須^^)
        Trz = Cn.BeginTransaction
        SQL = Cn.CreateCommand
        SQL.Transaction = Trz
        SQL.CommandText = "DELETE FROM U_TAIKYOKU"
        If From_date <> "" And To_date = "" Then
            SQL.CommandText = SQL.CommandText & " WHERE TAIKYOKUBI >= #" & From_date & "#"
        End If
        iRet = SQL.ExecuteNonQuery() 'SQL実行
        Trz.Commit()
    End Sub

    Public Shared Sub HaifuTag_Data_Delete()
        '--------------------------------------------------------------------------
        '2015/08/18 airu 新規作成(タグテーブル削除)
        '--------------------------------------------------------------------------
        'コマンドのインスタンスを生成(以下は３セット必須^^)
        Trz = Cn.BeginTransaction
        SQL = Cn.CreateCommand
        SQL.Transaction = Trz
        SQL.CommandText = "DELETE FROM U_TAG"
        SQL.ExecuteNonQuery() 'SQL実行
        Trz.Commit()
    End Sub

    Public Shared Sub HaifuTag_Data_Insert(No As Integer, Ltag As String, Stag As String, kyoku As String, Haifufile As String)
        '--------------------------------------------------------------------------
        '2015/08/18 airu 新規作成(タグテーブル挿入)
        '--------------------------------------------------------------------------
        'コマンドのインスタンスを生成(以下は３セット必須^^)
        Trz = Cn.BeginTransaction
        SQL = Cn.CreateCommand
        SQL.Transaction = Trz
        SQL.CommandText = "INSERT INTO U_TAG VALUES(" & No & ",'" & Ltag & "','" & Stag & "','" & kyoku & "','" & Haifufile & "')"
        SQL.ExecuteNonQuery() 'SQL実行
        Trz.Commit()
    End Sub
    Public Shared Function Search_Kyoku(num As Integer) As String
        '--------------------------------------------------------------------------
        '2015/08/13 airu 新規作成
        '--------------------------------------------------------------------------
        Dim kyoku As String
        SQL.CommandText = "SELECT KYOKU FROM M_KYOKU WHERE ID=" & num
        kyoku = SQL.ExecuteScalar() 'SQL実行
        Return kyoku '局名を返す
    End Function
    Public Shared Sub Search_tag()
        '--------------------------------------------------------------------------
        '2015/08/13 airu 新規作成
        '--------------------------------------------------------------------------
        Dim OLEDS As DataSet = New DataSet("TEST")
        Dim SQL_txt As String
        SQL_txt = "SELECT ID,TAG,TAG_S,KYOKU,HAIHUFILE FROM U_TAG ORDER BY HAIHUFILE,ID ASC"
        'データアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter(SQL_txt, Database.Cn_txt)

        'データの読み込み
        Adapter.Fill(OLEDS, "TEST")
        'データソースを設定してDataGridViewにデータを表示
        Main.WkGridView.DataSource = OLEDS.Tables("TEST")
    End Sub
    Public Shared Sub Utaikyoku_Insert(Taikyokubi As String, Takusyurui As Integer, Mode As Integer, Juni As Integer,
                                       TaikyokuName As String, Tpoint As Integer, Fpoint As Double, Endscore As Integer,
                                       Haifufile As String, AgariCnt As Integer, FurikomiCnt As Integer, Dani As String,
                                       Sex As String, Rate As Integer, Sumkyoku As Integer, cntflg As Integer)
        '--------------------------------------------------------------------------
        '2015/08/18 airu 新規作成(対局テーブル挿入)
        '--------------------------------------------------------------------------
        'コマンドのインスタンスを生成(以下は３セット必須^^)
        Trz = Cn.BeginTransaction
        SQL = Cn.CreateCommand
        SQL.Transaction = Trz
        SQL.CommandText = "INSERT INTO U_TAIKYOKU VALUES(#" & Taikyokubi & "#," & Takusyurui & "," & Mode & "," & Juni & ",'" & TaikyokuName & "'," _
        & Tpoint & "," & Fpoint & "," & Endscore & ",'" & Haifufile & "'," & AgariCnt & "," & FurikomiCnt & "," & Dani & ",'" & Sex & "'," & Rate & "," & Sumkyoku & "," & cntflg & ",#" & Now.ToString("yyyy/MM/dd HH:mm:ss") & "#)"
        SQL.ExecuteNonQuery() 'SQL実行
        Trz.Commit()
    End Sub

    Public Shared Sub SelectAll_Taikyoku()
        '--------------------------------------------------------------------------
        '2015/08/13 airu 新規作成
        '--------------------------------------------------------------------------
        Dim OLEDS As DataSet = New DataSet("TEST")
        Dim SQL_txt As String
        SQL_txt = "SELECT * FROM U_TAIKYOKU"
        'データアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter(SQL_txt, Database.Cn_txt)

        'データの読み込み
        Adapter.Fill(OLEDS, "TEST")
        'データソースを設定してDataGridViewにデータを表示
        Main.WkGridView.DataSource = OLEDS.Tables("TEST")
    End Sub
End Class
