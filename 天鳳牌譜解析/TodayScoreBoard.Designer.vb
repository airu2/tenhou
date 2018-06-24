<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodayScoreBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodayScoreBoard))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Avg3Lbl = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Ruikei3Lbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Three3CntLbl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Two3CntLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.One3CntLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AvgJuni3Lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TaikyokuNum3Lbl = New System.Windows.Forms.Label()
        Me.TenhouPointLbl1 = New System.Windows.Forms.Label()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Four4CntLbl = New System.Windows.Forms.Label()
        Me.Avg4Lbl = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Ruikei4Lbl = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Three4CntLbl = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Two4CntLbl = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.One4CntLbl = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.AvgJuni4Lbl = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TaikyokuNum4Lbl = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resetLbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Avg3Lbl)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Ruikei3Lbl)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Three3CntLbl)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Two3CntLbl)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.One3CntLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.AvgJuni3Lbl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TaikyokuNum3Lbl)
        Me.GroupBox1.Controls.Add(Me.TenhouPointLbl1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "三麻"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(361, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 12)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "点"
        '
        'Avg3Lbl
        '
        Me.Avg3Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Avg3Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Avg3Lbl.Location = New System.Drawing.Point(303, 71)
        Me.Avg3Lbl.Name = "Avg3Lbl"
        Me.Avg3Lbl.Size = New System.Drawing.Size(62, 16)
        Me.Avg3Lbl.TabIndex = 38
        Me.Avg3Lbl.Text = "999900"
        Me.Avg3Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(215, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 12)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "平均点棒収支："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(178, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 12)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "点"
        '
        'Ruikei3Lbl
        '
        Me.Ruikei3Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ruikei3Lbl.Location = New System.Drawing.Point(120, 71)
        Me.Ruikei3Lbl.Name = "Ruikei3Lbl"
        Me.Ruikei3Lbl.Size = New System.Drawing.Size(62, 16)
        Me.Ruikei3Lbl.TabIndex = 35
        Me.Ruikei3Lbl.Text = "999900"
        Me.Ruikei3Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 12)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "累計点棒収支："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "回"
        '
        'Three3CntLbl
        '
        Me.Three3CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Three3CntLbl.Location = New System.Drawing.Point(241, 48)
        Me.Three3CntLbl.Name = "Three3CntLbl"
        Me.Three3CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.Three3CntLbl.TabIndex = 32
        Me.Three3CntLbl.Text = "999"
        Me.Three3CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 12)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "３位："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "回"
        '
        'Two3CntLbl
        '
        Me.Two3CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Two3CntLbl.Location = New System.Drawing.Point(147, 48)
        Me.Two3CntLbl.Name = "Two3CntLbl"
        Me.Two3CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.Two3CntLbl.TabIndex = 29
        Me.Two3CntLbl.Text = "999"
        Me.Two3CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(121, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 12)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "２位："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "回"
        '
        'One3CntLbl
        '
        Me.One3CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.One3CntLbl.Location = New System.Drawing.Point(58, 48)
        Me.One3CntLbl.Name = "One3CntLbl"
        Me.One3CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.One3CntLbl.TabIndex = 26
        Me.One3CntLbl.Text = "999"
        Me.One3CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "１位："
        '
        'AvgJuni3Lbl
        '
        Me.AvgJuni3Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AvgJuni3Lbl.Location = New System.Drawing.Point(180, 21)
        Me.AvgJuni3Lbl.Name = "AvgJuni3Lbl"
        Me.AvgJuni3Lbl.Size = New System.Drawing.Size(39, 16)
        Me.AvgJuni3Lbl.TabIndex = 24
        Me.AvgJuni3Lbl.Text = "1.00"
        Me.AvgJuni3Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "平均順位"
        '
        'TaikyokuNum3Lbl
        '
        Me.TaikyokuNum3Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TaikyokuNum3Lbl.Location = New System.Drawing.Point(70, 21)
        Me.TaikyokuNum3Lbl.Name = "TaikyokuNum3Lbl"
        Me.TaikyokuNum3Lbl.Size = New System.Drawing.Size(35, 16)
        Me.TaikyokuNum3Lbl.TabIndex = 22
        Me.TaikyokuNum3Lbl.Text = "999"
        Me.TaikyokuNum3Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TenhouPointLbl1
        '
        Me.TenhouPointLbl1.AutoSize = True
        Me.TenhouPointLbl1.Location = New System.Drawing.Point(32, 25)
        Me.TenhouPointLbl1.Name = "TenhouPointLbl1"
        Me.TenhouPointLbl1.Size = New System.Drawing.Size(41, 12)
        Me.TenhouPointLbl1.TabIndex = 21
        Me.TenhouPointLbl1.Text = "対局数"
        '
        'QuitBtn
        '
        Me.QuitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuitBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitBtn.Location = New System.Drawing.Point(19, 303)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(533, 33)
        Me.QuitBtn.TabIndex = 6
        Me.QuitBtn.Text = "閉じる"
        Me.QuitBtn.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(196, 264)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(200, 16)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "今日も１日お疲れ様でした。"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Four4CntLbl)
        Me.GroupBox2.Controls.Add(Me.Avg4Lbl)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Ruikei4Lbl)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Three4CntLbl)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Two4CntLbl)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.One4CntLbl)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.AvgJuni4Lbl)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.TaikyokuNum4Lbl)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 101)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "四麻"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(361, 52)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(17, 12)
        Me.Label38.TabIndex = 44
        Me.Label38.Text = "回"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(361, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 12)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "点"
        '
        'Four4CntLbl
        '
        Me.Four4CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Four4CntLbl.Location = New System.Drawing.Point(330, 48)
        Me.Four4CntLbl.Name = "Four4CntLbl"
        Me.Four4CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.Four4CntLbl.TabIndex = 43
        Me.Four4CntLbl.Text = "999"
        Me.Four4CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Avg4Lbl
        '
        Me.Avg4Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Avg4Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Avg4Lbl.Location = New System.Drawing.Point(303, 71)
        Me.Avg4Lbl.Name = "Avg4Lbl"
        Me.Avg4Lbl.Size = New System.Drawing.Size(62, 16)
        Me.Avg4Lbl.TabIndex = 38
        Me.Avg4Lbl.Text = "999900"
        Me.Avg4Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(304, 52)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(31, 12)
        Me.Label40.TabIndex = 42
        Me.Label40.Text = "４位："
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(215, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 12)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "平均点棒収支："
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(178, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 12)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "点"
        '
        'Ruikei4Lbl
        '
        Me.Ruikei4Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ruikei4Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ruikei4Lbl.Location = New System.Drawing.Point(120, 71)
        Me.Ruikei4Lbl.Name = "Ruikei4Lbl"
        Me.Ruikei4Lbl.Size = New System.Drawing.Size(62, 16)
        Me.Ruikei4Lbl.TabIndex = 35
        Me.Ruikei4Lbl.Text = "999900"
        Me.Ruikei4Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(32, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 12)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "累計点棒収支："
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(272, 52)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(17, 12)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "回"
        '
        'Three4CntLbl
        '
        Me.Three4CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Three4CntLbl.Location = New System.Drawing.Point(241, 48)
        Me.Three4CntLbl.Name = "Three4CntLbl"
        Me.Three4CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.Three4CntLbl.TabIndex = 32
        Me.Three4CntLbl.Text = "999"
        Me.Three4CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(215, 52)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 12)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "３位："
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(178, 52)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(17, 12)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "回"
        '
        'Two4CntLbl
        '
        Me.Two4CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Two4CntLbl.Location = New System.Drawing.Point(147, 48)
        Me.Two4CntLbl.Name = "Two4CntLbl"
        Me.Two4CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.Two4CntLbl.TabIndex = 29
        Me.Two4CntLbl.Text = "999"
        Me.Two4CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(121, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 12)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "２位："
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(89, 52)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(17, 12)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "回"
        '
        'One4CntLbl
        '
        Me.One4CntLbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.One4CntLbl.Location = New System.Drawing.Point(58, 48)
        Me.One4CntLbl.Name = "One4CntLbl"
        Me.One4CntLbl.Size = New System.Drawing.Size(35, 16)
        Me.One4CntLbl.TabIndex = 26
        Me.One4CntLbl.Text = "999"
        Me.One4CntLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(32, 52)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 12)
        Me.Label33.TabIndex = 25
        Me.Label33.Text = "１位："
        '
        'AvgJuni4Lbl
        '
        Me.AvgJuni4Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AvgJuni4Lbl.Location = New System.Drawing.Point(180, 21)
        Me.AvgJuni4Lbl.Name = "AvgJuni4Lbl"
        Me.AvgJuni4Lbl.Size = New System.Drawing.Size(39, 16)
        Me.AvgJuni4Lbl.TabIndex = 24
        Me.AvgJuni4Lbl.Text = "1.00"
        Me.AvgJuni4Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(121, 25)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 12)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "平均順位"
        '
        'TaikyokuNum4Lbl
        '
        Me.TaikyokuNum4Lbl.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TaikyokuNum4Lbl.Location = New System.Drawing.Point(70, 21)
        Me.TaikyokuNum4Lbl.Name = "TaikyokuNum4Lbl"
        Me.TaikyokuNum4Lbl.Size = New System.Drawing.Size(35, 16)
        Me.TaikyokuNum4Lbl.TabIndex = 22
        Me.TaikyokuNum4Lbl.Text = "999"
        Me.TaikyokuNum4Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(32, 25)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 12)
        Me.Label37.TabIndex = 21
        Me.Label37.Text = "対局数"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 12)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "※累計点棒収支は配給原点を基準に算出しております。"
        '
        'resetLbl
        '
        Me.resetLbl.AutoSize = True
        Me.resetLbl.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.resetLbl.Location = New System.Drawing.Point(19, 242)
        Me.resetLbl.Name = "resetLbl"
        Me.resetLbl.Size = New System.Drawing.Size(196, 12)
        Me.resetLbl.TabIndex = 43
        Me.resetLbl.Text = "※本日の戦績は○時にリセットされます。"
        '
        'TodayScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 345)
        Me.Controls.Add(Me.resetLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TodayScoreBoard"
        Me.Text = "本日の戦績"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QuitBtn As Button
    Friend WithEvents TenhouPointLbl1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Avg3Lbl As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Ruikei3Lbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Three3CntLbl As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Two3CntLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents One3CntLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AvgJuni3Lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TaikyokuNum3Lbl As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Four4CntLbl As Label
    Friend WithEvents Avg4Lbl As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Ruikei4Lbl As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Three4CntLbl As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Two4CntLbl As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents One4CntLbl As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents AvgJuni4Lbl As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents TaikyokuNum4Lbl As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents resetLbl As Label
End Class
