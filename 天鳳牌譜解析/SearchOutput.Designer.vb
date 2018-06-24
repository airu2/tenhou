<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchOutput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchOutput))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rateChk = New System.Windows.Forms.CheckBox()
        Me.sexChk = New System.Windows.Forms.CheckBox()
        Me.connectFlgChk = New System.Windows.Forms.CheckBox()
        Me.taikyokuNumChk = New System.Windows.Forms.CheckBox()
        Me.lastScoreChk = New System.Windows.Forms.CheckBox()
        Me.freePointChk = New System.Windows.Forms.CheckBox()
        Me.tenhouPointChk = New System.Windows.Forms.CheckBox()
        Me.taikyokusyaChk = New System.Windows.Forms.CheckBox()
        Me.daniChk = New System.Windows.Forms.CheckBox()
        Me.juniChk = New System.Windows.Forms.CheckBox()
        Me.modeChk = New System.Windows.Forms.CheckBox()
        Me.takuKindChk = New System.Windows.Forms.CheckBox()
        Me.takuLevelChk = New System.Windows.Forms.CheckBox()
        Me.taikyokubiChk = New System.Windows.Forms.CheckBox()
        Me.noChk = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.excelRbt = New System.Windows.Forms.RadioButton()
        Me.htmlRbt = New System.Windows.Forms.RadioButton()
        Me.csvRbt = New System.Windows.Forms.RadioButton()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.DataExportBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rateChk)
        Me.GroupBox1.Controls.Add(Me.sexChk)
        Me.GroupBox1.Controls.Add(Me.connectFlgChk)
        Me.GroupBox1.Controls.Add(Me.taikyokuNumChk)
        Me.GroupBox1.Controls.Add(Me.lastScoreChk)
        Me.GroupBox1.Controls.Add(Me.freePointChk)
        Me.GroupBox1.Controls.Add(Me.tenhouPointChk)
        Me.GroupBox1.Controls.Add(Me.taikyokusyaChk)
        Me.GroupBox1.Controls.Add(Me.daniChk)
        Me.GroupBox1.Controls.Add(Me.juniChk)
        Me.GroupBox1.Controls.Add(Me.modeChk)
        Me.GroupBox1.Controls.Add(Me.takuKindChk)
        Me.GroupBox1.Controls.Add(Me.takuLevelChk)
        Me.GroupBox1.Controls.Add(Me.taikyokubiChk)
        Me.GroupBox1.Controls.Add(Me.noChk)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 370)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "出力項目"
        '
        'rateChk
        '
        Me.rateChk.AutoSize = True
        Me.rateChk.Location = New System.Drawing.Point(6, 335)
        Me.rateChk.Name = "rateChk"
        Me.rateChk.Size = New System.Drawing.Size(63, 16)
        Me.rateChk.TabIndex = 15
        Me.rateChk.Text = "レート※"
        Me.rateChk.UseVisualStyleBackColor = True
        '
        'sexChk
        '
        Me.sexChk.AutoSize = True
        Me.sexChk.Location = New System.Drawing.Point(6, 313)
        Me.sexChk.Name = "sexChk"
        Me.sexChk.Size = New System.Drawing.Size(60, 16)
        Me.sexChk.TabIndex = 14
        Me.sexChk.Text = "性別※"
        Me.sexChk.UseVisualStyleBackColor = True
        '
        'connectFlgChk
        '
        Me.connectFlgChk.AutoSize = True
        Me.connectFlgChk.Location = New System.Drawing.Point(6, 291)
        Me.connectFlgChk.Name = "connectFlgChk"
        Me.connectFlgChk.Size = New System.Drawing.Size(85, 16)
        Me.connectFlgChk.TabIndex = 13
        Me.connectFlgChk.Text = "接続フラグ※"
        Me.connectFlgChk.UseVisualStyleBackColor = True
        '
        'taikyokuNumChk
        '
        Me.taikyokuNumChk.AutoSize = True
        Me.taikyokuNumChk.Location = New System.Drawing.Point(6, 269)
        Me.taikyokuNumChk.Name = "taikyokuNumChk"
        Me.taikyokuNumChk.Size = New System.Drawing.Size(72, 16)
        Me.taikyokuNumChk.TabIndex = 12
        Me.taikyokuNumChk.Text = "対局数※"
        Me.taikyokuNumChk.UseVisualStyleBackColor = True
        '
        'lastScoreChk
        '
        Me.lastScoreChk.AutoSize = True
        Me.lastScoreChk.Location = New System.Drawing.Point(6, 247)
        Me.lastScoreChk.Name = "lastScoreChk"
        Me.lastScoreChk.Size = New System.Drawing.Size(81, 16)
        Me.lastScoreChk.TabIndex = 11
        Me.lastScoreChk.Text = "最終持ち点"
        Me.lastScoreChk.UseVisualStyleBackColor = True
        '
        'freePointChk
        '
        Me.freePointChk.AutoSize = True
        Me.freePointChk.Location = New System.Drawing.Point(6, 225)
        Me.freePointChk.Name = "freePointChk"
        Me.freePointChk.Size = New System.Drawing.Size(85, 16)
        Me.freePointChk.TabIndex = 10
        Me.freePointChk.Text = "フリーポイント"
        Me.freePointChk.UseVisualStyleBackColor = True
        '
        'tenhouPointChk
        '
        Me.tenhouPointChk.AutoSize = True
        Me.tenhouPointChk.Location = New System.Drawing.Point(6, 203)
        Me.tenhouPointChk.Name = "tenhouPointChk"
        Me.tenhouPointChk.Size = New System.Drawing.Size(84, 16)
        Me.tenhouPointChk.TabIndex = 9
        Me.tenhouPointChk.Text = "天鳳ポイント"
        Me.tenhouPointChk.UseVisualStyleBackColor = True
        '
        'taikyokusyaChk
        '
        Me.taikyokusyaChk.AutoSize = True
        Me.taikyokusyaChk.Location = New System.Drawing.Point(6, 181)
        Me.taikyokusyaChk.Name = "taikyokusyaChk"
        Me.taikyokusyaChk.Size = New System.Drawing.Size(60, 16)
        Me.taikyokusyaChk.TabIndex = 8
        Me.taikyokusyaChk.Text = "対局者"
        Me.taikyokusyaChk.UseVisualStyleBackColor = True
        '
        'daniChk
        '
        Me.daniChk.AutoSize = True
        Me.daniChk.Location = New System.Drawing.Point(6, 159)
        Me.daniChk.Name = "daniChk"
        Me.daniChk.Size = New System.Drawing.Size(48, 16)
        Me.daniChk.TabIndex = 7
        Me.daniChk.Text = "段位"
        Me.daniChk.UseVisualStyleBackColor = True
        '
        'juniChk
        '
        Me.juniChk.AutoSize = True
        Me.juniChk.Location = New System.Drawing.Point(6, 137)
        Me.juniChk.Name = "juniChk"
        Me.juniChk.Size = New System.Drawing.Size(48, 16)
        Me.juniChk.TabIndex = 6
        Me.juniChk.Text = "順位"
        Me.juniChk.UseVisualStyleBackColor = True
        '
        'modeChk
        '
        Me.modeChk.AutoSize = True
        Me.modeChk.Location = New System.Drawing.Point(6, 115)
        Me.modeChk.Name = "modeChk"
        Me.modeChk.Size = New System.Drawing.Size(52, 16)
        Me.modeChk.TabIndex = 5
        Me.modeChk.Text = "モード"
        Me.modeChk.UseVisualStyleBackColor = True
        '
        'takuKindChk
        '
        Me.takuKindChk.AutoSize = True
        Me.takuKindChk.Location = New System.Drawing.Point(6, 93)
        Me.takuKindChk.Name = "takuKindChk"
        Me.takuKindChk.Size = New System.Drawing.Size(60, 16)
        Me.takuKindChk.TabIndex = 4
        Me.takuKindChk.Text = "卓種類"
        Me.takuKindChk.UseVisualStyleBackColor = True
        '
        'takuLevelChk
        '
        Me.takuLevelChk.AutoSize = True
        Me.takuLevelChk.Location = New System.Drawing.Point(6, 71)
        Me.takuLevelChk.Name = "takuLevelChk"
        Me.takuLevelChk.Size = New System.Drawing.Size(65, 16)
        Me.takuLevelChk.TabIndex = 3
        Me.takuLevelChk.Text = "卓レベル"
        Me.takuLevelChk.UseVisualStyleBackColor = True
        '
        'taikyokubiChk
        '
        Me.taikyokubiChk.AutoSize = True
        Me.taikyokubiChk.Location = New System.Drawing.Point(6, 49)
        Me.taikyokubiChk.Name = "taikyokubiChk"
        Me.taikyokubiChk.Size = New System.Drawing.Size(60, 16)
        Me.taikyokubiChk.TabIndex = 2
        Me.taikyokubiChk.Text = "対局日"
        Me.taikyokubiChk.UseVisualStyleBackColor = True
        '
        'noChk
        '
        Me.noChk.AutoSize = True
        Me.noChk.Location = New System.Drawing.Point(6, 27)
        Me.noChk.Name = "noChk"
        Me.noChk.Size = New System.Drawing.Size(38, 16)
        Me.noChk.TabIndex = 1
        Me.noChk.Text = "No"
        Me.noChk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "※は、検索画面での非表示項目"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.excelRbt)
        Me.GroupBox2.Controls.Add(Me.htmlRbt)
        Me.GroupBox2.Controls.Add(Me.csvRbt)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 141)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "出力形式"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "　 必要があります。"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "　 Excelがインストールされている"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "※Excel＆PDFを選択した場合"
        '
        'excelRbt
        '
        Me.excelRbt.AutoSize = True
        Me.excelRbt.Location = New System.Drawing.Point(16, 68)
        Me.excelRbt.Name = "excelRbt"
        Me.excelRbt.Size = New System.Drawing.Size(92, 16)
        Me.excelRbt.TabIndex = 4
        Me.excelRbt.TabStop = True
        Me.excelRbt.Text = "EXCEL＆PDF"
        Me.excelRbt.UseVisualStyleBackColor = True
        '
        'htmlRbt
        '
        Me.htmlRbt.AutoSize = True
        Me.htmlRbt.Location = New System.Drawing.Point(16, 46)
        Me.htmlRbt.Name = "htmlRbt"
        Me.htmlRbt.Size = New System.Drawing.Size(53, 16)
        Me.htmlRbt.TabIndex = 3
        Me.htmlRbt.TabStop = True
        Me.htmlRbt.Text = "HTML"
        Me.htmlRbt.UseVisualStyleBackColor = True
        '
        'csvRbt
        '
        Me.csvRbt.AutoSize = True
        Me.csvRbt.Location = New System.Drawing.Point(16, 24)
        Me.csvRbt.Name = "csvRbt"
        Me.csvRbt.Size = New System.Drawing.Size(46, 16)
        Me.csvRbt.TabIndex = 0
        Me.csvRbt.TabStop = True
        Me.csvRbt.Text = "CSV"
        Me.csvRbt.UseVisualStyleBackColor = True
        '
        'QuitBtn
        '
        Me.QuitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuitBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitBtn.Location = New System.Drawing.Point(193, 349)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(178, 33)
        Me.QuitBtn.TabIndex = 7
        Me.QuitBtn.Text = "閉じる"
        Me.QuitBtn.UseVisualStyleBackColor = False
        '
        'DataExportBtn
        '
        Me.DataExportBtn.BackColor = System.Drawing.Color.GreenYellow
        Me.DataExportBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataExportBtn.Location = New System.Drawing.Point(193, 303)
        Me.DataExportBtn.Name = "DataExportBtn"
        Me.DataExportBtn.Size = New System.Drawing.Size(178, 33)
        Me.DataExportBtn.TabIndex = 8
        Me.DataExportBtn.Text = "検索結果出力"
        Me.DataExportBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "※出力結果は当アプリの"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "　output配下に出力されます。"
        '
        'SearchOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 408)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataExportBtn)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchOutput"
        Me.Text = "検索結果出力"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents noChk As CheckBox
    Friend WithEvents takuLevelChk As CheckBox
    Friend WithEvents taikyokubiChk As CheckBox
    Friend WithEvents lastScoreChk As CheckBox
    Friend WithEvents freePointChk As CheckBox
    Friend WithEvents tenhouPointChk As CheckBox
    Friend WithEvents taikyokusyaChk As CheckBox
    Friend WithEvents daniChk As CheckBox
    Friend WithEvents juniChk As CheckBox
    Friend WithEvents modeChk As CheckBox
    Friend WithEvents takuKindChk As CheckBox
    Friend WithEvents connectFlgChk As CheckBox
    Friend WithEvents taikyokuNumChk As CheckBox
    Friend WithEvents rateChk As CheckBox
    Friend WithEvents sexChk As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents excelRbt As RadioButton
    Friend WithEvents htmlRbt As RadioButton
    Friend WithEvents csvRbt As RadioButton
    Friend WithEvents QuitBtn As Button
    Friend WithEvents DataExportBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
