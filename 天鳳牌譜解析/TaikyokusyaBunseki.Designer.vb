<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaikyokusyaBunseki
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaikyokusyaBunseki))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NnonameChk = New System.Windows.Forms.CheckBox()
        Me.NjibnChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mode4Rbt = New System.Windows.Forms.RadioButton()
        Me.mode3Rbt = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchBtn)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 71)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "検索"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(448, 23)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(124, 33)
        Me.SearchBtn.TabIndex = 5
        Me.SearchBtn.Text = "検索"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NnonameChk)
        Me.GroupBox3.Controls.Add(Me.NjibnChk)
        Me.GroupBox3.Location = New System.Drawing.Point(201, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 37)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "対局者"
        '
        'NnonameChk
        '
        Me.NnonameChk.AutoSize = True
        Me.NnonameChk.Location = New System.Drawing.Point(111, 15)
        Me.NnonameChk.Name = "NnonameChk"
        Me.NnonameChk.Size = New System.Drawing.Size(118, 16)
        Me.NnonameChk.TabIndex = 9
        Me.NnonameChk.Text = "NoNameを含めない"
        Me.NnonameChk.UseVisualStyleBackColor = True
        '
        'NjibnChk
        '
        Me.NjibnChk.AutoSize = True
        Me.NjibnChk.Location = New System.Drawing.Point(6, 15)
        Me.NjibnChk.Name = "NjibnChk"
        Me.NjibnChk.Size = New System.Drawing.Size(99, 16)
        Me.NjibnChk.TabIndex = 0
        Me.NjibnChk.Text = "自分を含めない"
        Me.NjibnChk.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(580, 233)
        Me.DataGridView1.TabIndex = 0
        '
        'TaikyokusyaBunseki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 327)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TaikyokusyaBunseki"
        Me.Text = "対局者分析"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NnonameChk As CheckBox
    Friend WithEvents NjibnChk As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mode4Rbt As RadioButton
    Friend WithEvents mode3Rbt As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
