<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.メニューToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.空牌譜ファイル作成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.今日の成績ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.最適化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.その他OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mode4Rbt = New System.Windows.Forms.RadioButton()
        Me.mode3Rbt = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OtherMonthToTxt = New System.Windows.Forms.TextBox()
        Me.OtherMonthFromTxt = New System.Windows.Forms.TextBox()
        Me.OtherMonthRbn = New System.Windows.Forms.RadioButton()
        Me.NowMonthRbn = New System.Windows.Forms.RadioButton()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AllRbt = New System.Windows.Forms.RadioButton()
        Me.JibnRbt = New System.Windows.Forms.RadioButton()
        Me.DataExportBtn = New System.Windows.Forms.Button()
        Me.AllImportBtn = New System.Windows.Forms.Button()
        Me.All2ImportBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NowTime = New System.Windows.Forms.Timer(Me.components)
        Me.WkGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TsusanAvgLbl2 = New System.Windows.Forms.Label()
        Me.NowMonthAvgLbl2 = New System.Windows.Forms.Label()
        Me.TsusanAvgLbl1 = New System.Windows.Forms.Label()
        Me.NowMonthAvgLbl1 = New System.Windows.Forms.Label()
        Me.Last5Lbl = New System.Windows.Forms.Label()
        Me.Ten4Lbl = New System.Windows.Forms.Label()
        Me.Last4Lbl = New System.Windows.Forms.Label()
        Me.Ten3Lbl = New System.Windows.Forms.Label()
        Me.Last3Lbl = New System.Windows.Forms.Label()
        Me.Ten2Lbl = New System.Windows.Forms.Label()
        Me.Last2Lbl = New System.Windows.Forms.Label()
        Me.Ten1Lbl = New System.Windows.Forms.Label()
        Me.Last1Lbl = New System.Windows.Forms.Label()
        Me.FreePointLbl2 = New System.Windows.Forms.Label()
        Me.FreePointLbl1 = New System.Windows.Forms.Label()
        Me.TsusanFurikomiLbl2 = New System.Windows.Forms.Label()
        Me.TsusanAgariLbl2 = New System.Windows.Forms.Label()
        Me.NowMonthFurikomiLbl2 = New System.Windows.Forms.Label()
        Me.TenhouPointLbl2 = New System.Windows.Forms.Label()
        Me.NowMonthAgariLbl2 = New System.Windows.Forms.Label()
        Me.TenhouPointLbl1 = New System.Windows.Forms.Label()
        Me.NowMonthFurikomiLbl1 = New System.Windows.Forms.Label()
        Me.NowMonthAgariLbl1 = New System.Windows.Forms.Label()
        Me.TsusanFurikomiLbl1 = New System.Windows.Forms.Label()
        Me.TsusanAgariLbl1 = New System.Windows.Forms.Label()
        Me.TsusanLbl2 = New System.Windows.Forms.Label()
        Me.TsusanLbl1 = New System.Windows.Forms.Label()
        Me.NowMonthLbl2 = New System.Windows.Forms.Label()
        Me.NowMonthLbl1 = New System.Windows.Forms.Label()
        Me.SensekiLbl1 = New System.Windows.Forms.Label()
        Me.対局者戦績ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.WkGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.メニューToolStripMenuItem, Me.ツールToolStripMenuItem, Me.その他OToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(983, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'メニューToolStripMenuItem
        '
        Me.メニューToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.空牌譜ファイル作成ToolStripMenuItem, Me.今日の成績ToolStripMenuItem, Me.対局者戦績ToolStripMenuItem, Me.終了ToolStripMenuItem})
        Me.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem"
        Me.メニューToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.メニューToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.メニューToolStripMenuItem.Text = "メニュー(&M)"
        '
        '空牌譜ファイル作成ToolStripMenuItem
        '
        Me.空牌譜ファイル作成ToolStripMenuItem.Name = "空牌譜ファイル作成ToolStripMenuItem"
        Me.空牌譜ファイル作成ToolStripMenuItem.ShortcutKeyDisplayString = "(&K)"
        Me.空牌譜ファイル作成ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.空牌譜ファイル作成ToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.空牌譜ファイル作成ToolStripMenuItem.Text = "空牌譜ファイル作成"
        '
        '今日の成績ToolStripMenuItem
        '
        Me.今日の成績ToolStripMenuItem.Name = "今日の成績ToolStripMenuItem"
        Me.今日の成績ToolStripMenuItem.ShortcutKeyDisplayString = "(&T)"
        Me.今日の成績ToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.今日の成績ToolStripMenuItem.Text = "本日の成績"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.ShortcutKeyDisplayString = "(&E)"
        Me.終了ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'ツールToolStripMenuItem
        '
        Me.ツールToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.設定ToolStripMenuItem, Me.最適化ToolStripMenuItem})
        Me.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem"
        Me.ツールToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ツールToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ツールToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.ツールToolStripMenuItem.Text = "ツール(&T)"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.ShortcutKeyDisplayString = "(&S)"
        Me.設定ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        '最適化ToolStripMenuItem
        '
        Me.最適化ToolStripMenuItem.Name = "最適化ToolStripMenuItem"
        Me.最適化ToolStripMenuItem.ShortcutKeyDisplayString = "(&M)"
        Me.最適化ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.最適化ToolStripMenuItem.Text = "最適化"
        '
        'その他OToolStripMenuItem
        '
        Me.その他OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ヘルプHToolStripMenuItem, Me.バージョン情報VToolStripMenuItem})
        Me.その他OToolStripMenuItem.Name = "その他OToolStripMenuItem"
        Me.その他OToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.その他OToolStripMenuItem.Text = "ヘルプ＆バージョン情報(&O)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報VToolStripMenuItem
        '
        Me.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem"
        Me.バージョン情報VToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 301)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(952, 323)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "対局情報検索"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.mode4Rbt)
        Me.GroupBox1.Controls.Add(Me.mode3Rbt)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 37)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "モード"
        '
        'mode4Rbt
        '
        Me.mode4Rbt.AutoSize = True
        Me.mode4Rbt.Location = New System.Drawing.Point(99, 15)
        Me.mode4Rbt.Name = "mode4Rbt"
        Me.mode4Rbt.Size = New System.Drawing.Size(47, 16)
        Me.mode4Rbt.TabIndex = 4
        Me.mode4Rbt.TabStop = True
        Me.mode4Rbt.Text = "四麻"
        Me.mode4Rbt.UseVisualStyleBackColor = True
        '
        'mode3Rbt
        '
        Me.mode3Rbt.AutoSize = True
        Me.mode3Rbt.Location = New System.Drawing.Point(37, 15)
        Me.mode3Rbt.Name = "mode3Rbt"
        Me.mode3Rbt.Size = New System.Drawing.Size(47, 16)
        Me.mode3Rbt.TabIndex = 0
        Me.mode3Rbt.TabStop = True
        Me.mode3Rbt.Text = "三麻"
        Me.mode3Rbt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.SearchBtn)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(794, 116)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "検索"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.OtherMonthToTxt)
        Me.GroupBox4.Controls.Add(Me.OtherMonthFromTxt)
        Me.GroupBox4.Controls.Add(Me.OtherMonthRbn)
        Me.GroupBox4.Controls.Add(Me.NowMonthRbn)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(510, 48)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "対局日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "～"
        '
        'OtherMonthToTxt
        '
        Me.OtherMonthToTxt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.OtherMonthToTxt.Location = New System.Drawing.Point(335, 18)
        Me.OtherMonthToTxt.MaxLength = 10
        Me.OtherMonthToTxt.Name = "OtherMonthToTxt"
        Me.OtherMonthToTxt.Size = New System.Drawing.Size(124, 19)
        Me.OtherMonthToTxt.TabIndex = 9
        '
        'OtherMonthFromTxt
        '
        Me.OtherMonthFromTxt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.OtherMonthFromTxt.Location = New System.Drawing.Point(176, 18)
        Me.OtherMonthFromTxt.MaxLength = 10
        Me.OtherMonthFromTxt.Name = "OtherMonthFromTxt"
        Me.OtherMonthFromTxt.Size = New System.Drawing.Size(124, 19)
        Me.OtherMonthFromTxt.TabIndex = 5
        '
        'OtherMonthRbn
        '
        Me.OtherMonthRbn.AutoSize = True
        Me.OtherMonthRbn.Location = New System.Drawing.Point(99, 19)
        Me.OtherMonthRbn.Name = "OtherMonthRbn"
        Me.OtherMonthRbn.Size = New System.Drawing.Size(71, 16)
        Me.OtherMonthRbn.TabIndex = 4
        Me.OtherMonthRbn.TabStop = True
        Me.OtherMonthRbn.Text = "指定期間"
        Me.OtherMonthRbn.UseVisualStyleBackColor = True
        '
        'NowMonthRbn
        '
        Me.NowMonthRbn.AutoSize = True
        Me.NowMonthRbn.Location = New System.Drawing.Point(37, 19)
        Me.NowMonthRbn.Name = "NowMonthRbn"
        Me.NowMonthRbn.Size = New System.Drawing.Size(47, 16)
        Me.NowMonthRbn.TabIndex = 0
        Me.NowMonthRbn.TabStop = True
        Me.NowMonthRbn.Text = "今月"
        Me.NowMonthRbn.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(522, 70)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(124, 33)
        Me.SearchBtn.TabIndex = 5
        Me.SearchBtn.Text = "検索"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AllRbt)
        Me.GroupBox3.Controls.Add(Me.JibnRbt)
        Me.GroupBox3.Location = New System.Drawing.Point(201, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 37)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "対局者"
        '
        'AllRbt
        '
        Me.AllRbt.AutoSize = True
        Me.AllRbt.Location = New System.Drawing.Point(119, 15)
        Me.AllRbt.Name = "AllRbt"
        Me.AllRbt.Size = New System.Drawing.Size(83, 16)
        Me.AllRbt.TabIndex = 4
        Me.AllRbt.TabStop = True
        Me.AllRbt.Text = "対局者全員"
        Me.AllRbt.UseVisualStyleBackColor = True
        '
        'JibnRbt
        '
        Me.JibnRbt.AutoSize = True
        Me.JibnRbt.Location = New System.Drawing.Point(25, 15)
        Me.JibnRbt.Name = "JibnRbt"
        Me.JibnRbt.Size = New System.Drawing.Size(68, 16)
        Me.JibnRbt.TabIndex = 0
        Me.JibnRbt.TabStop = True
        Me.JibnRbt.Text = "自分のみ"
        Me.JibnRbt.UseVisualStyleBackColor = True
        '
        'DataExportBtn
        '
        Me.DataExportBtn.BackColor = System.Drawing.Color.GreenYellow
        Me.DataExportBtn.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataExportBtn.Location = New System.Drawing.Point(835, 182)
        Me.DataExportBtn.Name = "DataExportBtn"
        Me.DataExportBtn.Size = New System.Drawing.Size(130, 33)
        Me.DataExportBtn.TabIndex = 6
        Me.DataExportBtn.Text = "検索結果出力画面"
        Me.DataExportBtn.UseVisualStyleBackColor = False
        '
        'AllImportBtn
        '
        Me.AllImportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AllImportBtn.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AllImportBtn.Location = New System.Drawing.Point(835, 221)
        Me.AllImportBtn.Name = "AllImportBtn"
        Me.AllImportBtn.Size = New System.Drawing.Size(130, 33)
        Me.AllImportBtn.TabIndex = 7
        Me.AllImportBtn.Text = "全取込（今月分）"
        Me.AllImportBtn.UseVisualStyleBackColor = False
        '
        'All2ImportBtn
        '
        Me.All2ImportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.All2ImportBtn.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.All2ImportBtn.Location = New System.Drawing.Point(835, 258)
        Me.All2ImportBtn.Name = "All2ImportBtn"
        Me.All2ImportBtn.Size = New System.Drawing.Size(130, 33)
        Me.All2ImportBtn.TabIndex = 8
        Me.All2ImportBtn.Text = "全取込（ALL）"
        Me.All2ImportBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(837, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NowTime
        '
        '
        'WkGridView
        '
        Me.WkGridView.AllowUserToAddRows = False
        Me.WkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WkGridView.Location = New System.Drawing.Point(835, 48)
        Me.WkGridView.Name = "WkGridView"
        Me.WkGridView.RowTemplate.Height = 21
        Me.WkGridView.Size = New System.Drawing.Size(127, 125)
        Me.WkGridView.TabIndex = 10
        Me.WkGridView.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.TsusanAvgLbl2)
        Me.GroupBox5.Controls.Add(Me.NowMonthAvgLbl2)
        Me.GroupBox5.Controls.Add(Me.TsusanAvgLbl1)
        Me.GroupBox5.Controls.Add(Me.NowMonthAvgLbl1)
        Me.GroupBox5.Controls.Add(Me.Last5Lbl)
        Me.GroupBox5.Controls.Add(Me.Ten4Lbl)
        Me.GroupBox5.Controls.Add(Me.Last4Lbl)
        Me.GroupBox5.Controls.Add(Me.Ten3Lbl)
        Me.GroupBox5.Controls.Add(Me.Last3Lbl)
        Me.GroupBox5.Controls.Add(Me.Ten2Lbl)
        Me.GroupBox5.Controls.Add(Me.Last2Lbl)
        Me.GroupBox5.Controls.Add(Me.Ten1Lbl)
        Me.GroupBox5.Controls.Add(Me.Last1Lbl)
        Me.GroupBox5.Controls.Add(Me.FreePointLbl2)
        Me.GroupBox5.Controls.Add(Me.FreePointLbl1)
        Me.GroupBox5.Controls.Add(Me.TsusanFurikomiLbl2)
        Me.GroupBox5.Controls.Add(Me.TsusanAgariLbl2)
        Me.GroupBox5.Controls.Add(Me.NowMonthFurikomiLbl2)
        Me.GroupBox5.Controls.Add(Me.TenhouPointLbl2)
        Me.GroupBox5.Controls.Add(Me.NowMonthAgariLbl2)
        Me.GroupBox5.Controls.Add(Me.TenhouPointLbl1)
        Me.GroupBox5.Controls.Add(Me.NowMonthFurikomiLbl1)
        Me.GroupBox5.Controls.Add(Me.NowMonthAgariLbl1)
        Me.GroupBox5.Controls.Add(Me.TsusanFurikomiLbl1)
        Me.GroupBox5.Controls.Add(Me.TsusanAgariLbl1)
        Me.GroupBox5.Controls.Add(Me.TsusanLbl2)
        Me.GroupBox5.Controls.Add(Me.TsusanLbl1)
        Me.GroupBox5.Controls.Add(Me.NowMonthLbl2)
        Me.GroupBox5.Controls.Add(Me.NowMonthLbl1)
        Me.GroupBox5.Controls.Add(Me.SensekiLbl1)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(17, 48)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(794, 124)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "対局成績"
        '
        'TsusanAvgLbl2
        '
        Me.TsusanAvgLbl2.AutoSize = True
        Me.TsusanAvgLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TsusanAvgLbl2.Location = New System.Drawing.Point(444, 87)
        Me.TsusanAvgLbl2.Name = "TsusanAvgLbl2"
        Me.TsusanAvgLbl2.Size = New System.Drawing.Size(39, 16)
        Me.TsusanAvgLbl2.TabIndex = 25
        Me.TsusanAvgLbl2.Text = "1.00"
        '
        'NowMonthAvgLbl2
        '
        Me.NowMonthAvgLbl2.AutoSize = True
        Me.NowMonthAvgLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NowMonthAvgLbl2.Location = New System.Drawing.Point(444, 53)
        Me.NowMonthAvgLbl2.Name = "NowMonthAvgLbl2"
        Me.NowMonthAvgLbl2.Size = New System.Drawing.Size(39, 16)
        Me.NowMonthAvgLbl2.TabIndex = 23
        Me.NowMonthAvgLbl2.Text = "1.00"
        '
        'TsusanAvgLbl1
        '
        Me.TsusanAvgLbl1.AutoSize = True
        Me.TsusanAvgLbl1.Location = New System.Drawing.Point(349, 91)
        Me.TsusanAvgLbl1.Name = "TsusanAvgLbl1"
        Me.TsusanAvgLbl1.Size = New System.Drawing.Size(89, 12)
        Me.TsusanAvgLbl1.TabIndex = 24
        Me.TsusanAvgLbl1.Text = "平均順位（四麻）"
        '
        'NowMonthAvgLbl1
        '
        Me.NowMonthAvgLbl1.AutoSize = True
        Me.NowMonthAvgLbl1.Location = New System.Drawing.Point(349, 57)
        Me.NowMonthAvgLbl1.Name = "NowMonthAvgLbl1"
        Me.NowMonthAvgLbl1.Size = New System.Drawing.Size(89, 12)
        Me.NowMonthAvgLbl1.TabIndex = 14
        Me.NowMonthAvgLbl1.Text = "平均順位（四麻）"
        '
        'Last5Lbl
        '
        Me.Last5Lbl.AutoSize = True
        Me.Last5Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Last5Lbl.Location = New System.Drawing.Point(219, 24)
        Me.Last5Lbl.Name = "Last5Lbl"
        Me.Last5Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Last5Lbl.TabIndex = 16
        Me.Last5Lbl.Text = "4"
        '
        'Ten4Lbl
        '
        Me.Ten4Lbl.AutoSize = True
        Me.Ten4Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ten4Lbl.Location = New System.Drawing.Point(208, 27)
        Me.Ten4Lbl.Name = "Ten4Lbl"
        Me.Ten4Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Ten4Lbl.TabIndex = 27
        Me.Ten4Lbl.Text = "・"
        '
        'Last4Lbl
        '
        Me.Last4Lbl.AutoSize = True
        Me.Last4Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Last4Lbl.Location = New System.Drawing.Point(196, 24)
        Me.Last4Lbl.Name = "Last4Lbl"
        Me.Last4Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Last4Lbl.TabIndex = 15
        Me.Last4Lbl.Text = "4"
        '
        'Ten3Lbl
        '
        Me.Ten3Lbl.AutoSize = True
        Me.Ten3Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ten3Lbl.Location = New System.Drawing.Point(184, 27)
        Me.Ten3Lbl.Name = "Ten3Lbl"
        Me.Ten3Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Ten3Lbl.TabIndex = 26
        Me.Ten3Lbl.Text = "・"
        '
        'Last3Lbl
        '
        Me.Last3Lbl.AutoSize = True
        Me.Last3Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Last3Lbl.Location = New System.Drawing.Point(172, 24)
        Me.Last3Lbl.Name = "Last3Lbl"
        Me.Last3Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Last3Lbl.TabIndex = 14
        Me.Last3Lbl.Text = "4"
        '
        'Ten2Lbl
        '
        Me.Ten2Lbl.AutoSize = True
        Me.Ten2Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ten2Lbl.Location = New System.Drawing.Point(161, 27)
        Me.Ten2Lbl.Name = "Ten2Lbl"
        Me.Ten2Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Ten2Lbl.TabIndex = 25
        Me.Ten2Lbl.Text = "・"
        '
        'Last2Lbl
        '
        Me.Last2Lbl.AutoSize = True
        Me.Last2Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Last2Lbl.Location = New System.Drawing.Point(149, 24)
        Me.Last2Lbl.Name = "Last2Lbl"
        Me.Last2Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Last2Lbl.TabIndex = 13
        Me.Last2Lbl.Text = "4"
        '
        'Ten1Lbl
        '
        Me.Ten1Lbl.AutoSize = True
        Me.Ten1Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ten1Lbl.Location = New System.Drawing.Point(138, 27)
        Me.Ten1Lbl.Name = "Ten1Lbl"
        Me.Ten1Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Ten1Lbl.TabIndex = 13
        Me.Ten1Lbl.Text = "・"
        '
        'Last1Lbl
        '
        Me.Last1Lbl.AutoSize = True
        Me.Last1Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Last1Lbl.Location = New System.Drawing.Point(126, 24)
        Me.Last1Lbl.Name = "Last1Lbl"
        Me.Last1Lbl.Size = New System.Drawing.Size(17, 16)
        Me.Last1Lbl.TabIndex = 12
        Me.Last1Lbl.Text = "4"
        '
        'FreePointLbl2
        '
        Me.FreePointLbl2.AutoSize = True
        Me.FreePointLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FreePointLbl2.Location = New System.Drawing.Point(722, 20)
        Me.FreePointLbl2.Name = "FreePointLbl2"
        Me.FreePointLbl2.Size = New System.Drawing.Size(66, 16)
        Me.FreePointLbl2.TabIndex = 23
        Me.FreePointLbl2.Text = "99999.9"
        '
        'FreePointLbl1
        '
        Me.FreePointLbl1.AutoSize = True
        Me.FreePointLbl1.Location = New System.Drawing.Point(590, 24)
        Me.FreePointLbl1.Name = "FreePointLbl1"
        Me.FreePointLbl1.Size = New System.Drawing.Size(126, 12)
        Me.FreePointLbl1.TabIndex = 21
        Me.FreePointLbl1.Text = "今月フリーポイント（四麻）"
        '
        'TsusanFurikomiLbl2
        '
        Me.TsusanFurikomiLbl2.AutoSize = True
        Me.TsusanFurikomiLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TsusanFurikomiLbl2.Location = New System.Drawing.Point(739, 87)
        Me.TsusanFurikomiLbl2.Name = "TsusanFurikomiLbl2"
        Me.TsusanFurikomiLbl2.Size = New System.Drawing.Size(48, 16)
        Me.TsusanFurikomiLbl2.TabIndex = 24
        Me.TsusanFurikomiLbl2.Text = "1.000"
        '
        'TsusanAgariLbl2
        '
        Me.TsusanAgariLbl2.AutoSize = True
        Me.TsusanAgariLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TsusanAgariLbl2.Location = New System.Drawing.Point(588, 87)
        Me.TsusanAgariLbl2.Name = "TsusanAgariLbl2"
        Me.TsusanAgariLbl2.Size = New System.Drawing.Size(48, 16)
        Me.TsusanAgariLbl2.TabIndex = 22
        Me.TsusanAgariLbl2.Text = "1.000"
        '
        'NowMonthFurikomiLbl2
        '
        Me.NowMonthFurikomiLbl2.AutoSize = True
        Me.NowMonthFurikomiLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NowMonthFurikomiLbl2.Location = New System.Drawing.Point(739, 53)
        Me.NowMonthFurikomiLbl2.Name = "NowMonthFurikomiLbl2"
        Me.NowMonthFurikomiLbl2.Size = New System.Drawing.Size(48, 16)
        Me.NowMonthFurikomiLbl2.TabIndex = 23
        Me.NowMonthFurikomiLbl2.Text = "1.000"
        '
        'TenhouPointLbl2
        '
        Me.TenhouPointLbl2.AutoSize = True
        Me.TenhouPointLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TenhouPointLbl2.Location = New System.Drawing.Point(480, 20)
        Me.TenhouPointLbl2.Name = "TenhouPointLbl2"
        Me.TenhouPointLbl2.Size = New System.Drawing.Size(69, 16)
        Me.TenhouPointLbl2.TabIndex = 22
        Me.TenhouPointLbl2.Text = "99999pt"
        '
        'NowMonthAgariLbl2
        '
        Me.NowMonthAgariLbl2.AutoSize = True
        Me.NowMonthAgariLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NowMonthAgariLbl2.Location = New System.Drawing.Point(588, 53)
        Me.NowMonthAgariLbl2.Name = "NowMonthAgariLbl2"
        Me.NowMonthAgariLbl2.Size = New System.Drawing.Size(48, 16)
        Me.NowMonthAgariLbl2.TabIndex = 21
        Me.NowMonthAgariLbl2.Text = "1.000"
        '
        'TenhouPointLbl1
        '
        Me.TenhouPointLbl1.AutoSize = True
        Me.TenhouPointLbl1.Location = New System.Drawing.Point(349, 24)
        Me.TenhouPointLbl1.Name = "TenhouPointLbl1"
        Me.TenhouPointLbl1.Size = New System.Drawing.Size(125, 12)
        Me.TenhouPointLbl1.TabIndex = 20
        Me.TenhouPointLbl1.Text = "今月天鳳ポイント（四麻）"
        '
        'NowMonthFurikomiLbl1
        '
        Me.NowMonthFurikomiLbl1.AutoSize = True
        Me.NowMonthFurikomiLbl1.Location = New System.Drawing.Point(641, 57)
        Me.NowMonthFurikomiLbl1.Name = "NowMonthFurikomiLbl1"
        Me.NowMonthFurikomiLbl1.Size = New System.Drawing.Size(101, 12)
        Me.NowMonthFurikomiLbl1.TabIndex = 20
        Me.NowMonthFurikomiLbl1.Text = "今月放銃率（四麻）"
        '
        'NowMonthAgariLbl1
        '
        Me.NowMonthAgariLbl1.AutoSize = True
        Me.NowMonthAgariLbl1.Location = New System.Drawing.Point(488, 57)
        Me.NowMonthAgariLbl1.Name = "NowMonthAgariLbl1"
        Me.NowMonthAgariLbl1.Size = New System.Drawing.Size(101, 12)
        Me.NowMonthAgariLbl1.TabIndex = 19
        Me.NowMonthAgariLbl1.Text = "今月和了率（四麻）"
        '
        'TsusanFurikomiLbl1
        '
        Me.TsusanFurikomiLbl1.AutoSize = True
        Me.TsusanFurikomiLbl1.Location = New System.Drawing.Point(641, 91)
        Me.TsusanFurikomiLbl1.Name = "TsusanFurikomiLbl1"
        Me.TsusanFurikomiLbl1.Size = New System.Drawing.Size(101, 12)
        Me.TsusanFurikomiLbl1.TabIndex = 18
        Me.TsusanFurikomiLbl1.Text = "通算放銃率（四麻）"
        '
        'TsusanAgariLbl1
        '
        Me.TsusanAgariLbl1.AutoSize = True
        Me.TsusanAgariLbl1.Location = New System.Drawing.Point(488, 91)
        Me.TsusanAgariLbl1.Name = "TsusanAgariLbl1"
        Me.TsusanAgariLbl1.Size = New System.Drawing.Size(101, 12)
        Me.TsusanAgariLbl1.TabIndex = 17
        Me.TsusanAgariLbl1.Text = "通算和了率（四麻）"
        '
        'TsusanLbl2
        '
        Me.TsusanLbl2.AutoSize = True
        Me.TsusanLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TsusanLbl2.Location = New System.Drawing.Point(125, 87)
        Me.TsusanLbl2.Name = "TsusanLbl2"
        Me.TsusanLbl2.Size = New System.Drawing.Size(215, 16)
        Me.TsusanLbl2.TabIndex = 16
        Me.TsusanLbl2.Text = "99999-99999-99999-99999"
        '
        'TsusanLbl1
        '
        Me.TsusanLbl1.AutoSize = True
        Me.TsusanLbl1.Location = New System.Drawing.Point(6, 91)
        Me.TsusanLbl1.Name = "TsusanLbl1"
        Me.TsusanLbl1.Size = New System.Drawing.Size(89, 12)
        Me.TsusanLbl1.TabIndex = 15
        Me.TsusanLbl1.Text = "通算戦績（四麻）"
        '
        'NowMonthLbl2
        '
        Me.NowMonthLbl2.AutoSize = True
        Me.NowMonthLbl2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NowMonthLbl2.Location = New System.Drawing.Point(125, 53)
        Me.NowMonthLbl2.Name = "NowMonthLbl2"
        Me.NowMonthLbl2.Size = New System.Drawing.Size(215, 16)
        Me.NowMonthLbl2.TabIndex = 14
        Me.NowMonthLbl2.Text = "99999-99999-99999-99999"
        '
        'NowMonthLbl1
        '
        Me.NowMonthLbl1.AutoSize = True
        Me.NowMonthLbl1.Location = New System.Drawing.Point(6, 57)
        Me.NowMonthLbl1.Name = "NowMonthLbl1"
        Me.NowMonthLbl1.Size = New System.Drawing.Size(99, 12)
        Me.NowMonthLbl1.TabIndex = 13
        Me.NowMonthLbl1.Text = "今月の戦績（四麻）"
        '
        'SensekiLbl1
        '
        Me.SensekiLbl1.AutoSize = True
        Me.SensekiLbl1.Location = New System.Drawing.Point(6, 24)
        Me.SensekiLbl1.Name = "SensekiLbl1"
        Me.SensekiLbl1.Size = New System.Drawing.Size(113, 12)
        Me.SensekiLbl1.TabIndex = 0
        Me.SensekiLbl1.Text = "最近五戦戦績（四麻）"
        '
        '対局者戦績ToolStripMenuItem
        '
        Me.対局者戦績ToolStripMenuItem.Name = "対局者戦績ToolStripMenuItem"
        Me.対局者戦績ToolStripMenuItem.ShortcutKeyDisplayString = "(&B)"
        Me.対局者戦績ToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.対局者戦績ToolStripMenuItem.Text = "対局者分析"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 637)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.WkGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.All2ImportBtn)
        Me.Controls.Add(Me.AllImportBtn)
        Me.Controls.Add(Me.DataExportBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "天鳳牌譜解析"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.WkGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents メニューToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 空牌譜ファイル作成ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ツールToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 設定ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mode4Rbt As RadioButton
    Friend WithEvents mode3Rbt As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AllRbt As RadioButton
    Friend WithEvents JibnRbt As RadioButton
    Friend WithEvents SearchBtn As Button
    Friend WithEvents DataExportBtn As Button
    Friend WithEvents AllImportBtn As Button
    Friend WithEvents その他OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OtherMonthFromTxt As TextBox
    Friend WithEvents OtherMonthRbn As RadioButton
    Friend WithEvents NowMonthRbn As RadioButton
    Friend WithEvents All2ImportBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OtherMonthToTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NowTime As Timer
    Friend WithEvents WkGridView As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TsusanFurikomiLbl2 As Label
    Friend WithEvents TsusanAgariLbl2 As Label
    Friend WithEvents NowMonthFurikomiLbl2 As Label
    Friend WithEvents TenhouPointLbl2 As Label
    Friend WithEvents NowMonthAgariLbl2 As Label
    Friend WithEvents TenhouPointLbl1 As Label
    Friend WithEvents NowMonthFurikomiLbl1 As Label
    Friend WithEvents NowMonthAgariLbl1 As Label
    Friend WithEvents TsusanFurikomiLbl1 As Label
    Friend WithEvents TsusanAgariLbl1 As Label
    Friend WithEvents TsusanLbl2 As Label
    Friend WithEvents TsusanLbl1 As Label
    Friend WithEvents NowMonthLbl2 As Label
    Friend WithEvents NowMonthLbl1 As Label
    Friend WithEvents SensekiLbl1 As Label
    Friend WithEvents FreePointLbl1 As Label
    Friend WithEvents FreePointLbl2 As Label
    Friend WithEvents Ten3Lbl As Label
    Friend WithEvents Last3Lbl As Label
    Friend WithEvents Ten2Lbl As Label
    Friend WithEvents Last2Lbl As Label
    Friend WithEvents Ten1Lbl As Label
    Friend WithEvents Last1Lbl As Label
    Friend WithEvents Last5Lbl As Label
    Friend WithEvents Ten4Lbl As Label
    Friend WithEvents Last4Lbl As Label
    Friend WithEvents NowMonthAvgLbl2 As Label
    Friend WithEvents NowMonthAvgLbl1 As Label
    Friend WithEvents TsusanAvgLbl2 As Label
    Friend WithEvents TsusanAvgLbl1 As Label
    Friend WithEvents 最適化ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 今日の成績ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 対局者戦績ToolStripMenuItem As ToolStripMenuItem
End Class
