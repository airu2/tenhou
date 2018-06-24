<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KaraHaihuCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KaraHaihuCreate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Seki = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Crypt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Room = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Takusyubetsu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nichiji = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.対局日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddBtn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Seki)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Crypt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Room)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Takusyubetsu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Nichiji)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "空ファイル作成情報"
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(544, 9)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(124, 33)
        Me.AddBtn.TabIndex = 6
        Me.AddBtn.Text = "追加"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(504, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = ".mjlog"
        '
        'Seki
        '
        Me.Seki.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Seki.Location = New System.Drawing.Point(474, 18)
        Me.Seki.MaxLength = 1
        Me.Seki.Name = "Seki"
        Me.Seki.Size = New System.Drawing.Size(24, 19)
        Me.Seki.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(433, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "＆tw="
        '
        'Crypt
        '
        Me.Crypt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Crypt.Location = New System.Drawing.Point(323, 18)
        Me.Crypt.MaxLength = 8
        Me.Crypt.Name = "Crypt"
        Me.Crypt.Size = New System.Drawing.Size(104, 19)
        Me.Crypt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "-"
        '
        'Room
        '
        Me.Room.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Room.Location = New System.Drawing.Point(242, 18)
        Me.Room.MaxLength = 4
        Me.Room.Name = "Room"
        Me.Room.Size = New System.Drawing.Size(58, 19)
        Me.Room.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "-"
        '
        'Takusyubetsu
        '
        Me.Takusyubetsu.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Takusyubetsu.Location = New System.Drawing.Point(163, 18)
        Me.Takusyubetsu.MaxLength = 4
        Me.Takusyubetsu.Name = "Takusyubetsu"
        Me.Takusyubetsu.Size = New System.Drawing.Size(58, 19)
        Me.Takusyubetsu.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "gm-"
        '
        'Nichiji
        '
        Me.Nichiji.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Nichiji.Location = New System.Drawing.Point(6, 18)
        Me.Nichiji.MaxLength = 10
        Me.Nichiji.Name = "Nichiji"
        Me.Nichiji.Size = New System.Drawing.Size(124, 19)
        Me.Nichiji.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.対局日})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(427, 210)
        Me.DataGridView1.TabIndex = 2
        '
        'No
        '
        Me.No.HeaderText = "NO"
        Me.No.MaxInputLength = 10000
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        '対局日
        '
        Me.対局日.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.対局日.HeaderText = "牌譜ファイル"
        Me.対局日.MaxInputLength = 100
        Me.対局日.MinimumWidth = 50
        Me.対局日.Name = "対局日"
        Me.対局日.ReadOnly = True
        Me.対局日.Width = 88
        '
        'QuitBtn
        '
        Me.QuitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuitBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitBtn.Location = New System.Drawing.Point(524, 292)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(163, 33)
        Me.QuitBtn.TabIndex = 7
        Me.QuitBtn.Text = "閉じる"
        Me.QuitBtn.UseVisualStyleBackColor = False
        '
        'CreateBtn
        '
        Me.CreateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CreateBtn.Location = New System.Drawing.Point(12, 292)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(163, 33)
        Me.CreateBtn.TabIndex = 6
        Me.CreateBtn.Text = "作成"
        Me.CreateBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(188, 292)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(124, 33)
        Me.ClearBtn.TabIndex = 8
        Me.ClearBtn.Text = "クリア"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'KaraHaihuCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 333)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KaraHaihuCreate"
        Me.Text = "空牌譜ファイル作成"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Nichiji As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Seki As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Crypt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Room As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Takusyubetsu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QuitBtn As Button
    Friend WithEvents CreateBtn As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents 対局日 As DataGridViewTextBoxColumn
    Friend WithEvents ClearBtn As Button
End Class
