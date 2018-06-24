<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saitekika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Saitekika))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrDisp = New System.Windows.Forms.Label()
        Me.AfterFilesize = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NowFilesize = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaitekikaBtn = New System.Windows.Forms.Button()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ErrDisp)
        Me.GroupBox1.Controls.Add(Me.AfterFilesize)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NowFilesize)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "データベース最適化"
        '
        'ErrDisp
        '
        Me.ErrDisp.AutoSize = True
        Me.ErrDisp.ForeColor = System.Drawing.Color.Red
        Me.ErrDisp.Location = New System.Drawing.Point(6, 94)
        Me.ErrDisp.Name = "ErrDisp"
        Me.ErrDisp.Size = New System.Drawing.Size(313, 12)
        Me.ErrDisp.TabIndex = 5
        Me.ErrDisp.Text = "エラー：tenhou.accdbが存在しないので最適化は実行できません。"
        '
        'AfterFilesize
        '
        Me.AfterFilesize.AutoSize = True
        Me.AfterFilesize.Location = New System.Drawing.Point(135, 70)
        Me.AfterFilesize.Name = "AfterFilesize"
        Me.AfterFilesize.Size = New System.Drawing.Size(174, 12)
        Me.AfterFilesize.TabIndex = 4
        Me.AfterFilesize.Text = "？？？？？？？？？？？KBytes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "最適化後のファイルサイズ："
        '
        'NowFilesize
        '
        Me.NowFilesize.AutoSize = True
        Me.NowFilesize.Location = New System.Drawing.Point(135, 47)
        Me.NowFilesize.Name = "NowFilesize"
        Me.NowFilesize.Size = New System.Drawing.Size(122, 12)
        Me.NowFilesize.TabIndex = 2
        Me.NowFilesize.Text = "９９９９９９９９９９KBytes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "現在のファイルサイズ："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "対象データベース：tenhou.accdb"
        '
        'SaitekikaBtn
        '
        Me.SaitekikaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaitekikaBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SaitekikaBtn.Location = New System.Drawing.Point(14, 137)
        Me.SaitekikaBtn.Name = "SaitekikaBtn"
        Me.SaitekikaBtn.Size = New System.Drawing.Size(164, 33)
        Me.SaitekikaBtn.TabIndex = 7
        Me.SaitekikaBtn.Text = "最適化実行"
        Me.SaitekikaBtn.UseVisualStyleBackColor = False
        '
        'QuitBtn
        '
        Me.QuitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuitBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitBtn.Location = New System.Drawing.Point(195, 137)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(163, 33)
        Me.QuitBtn.TabIndex = 8
        Me.QuitBtn.Text = "閉じる"
        Me.QuitBtn.UseVisualStyleBackColor = False
        '
        'Saitekika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 187)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.SaitekikaBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Saitekika"
        Me.Text = "データベース最適化"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AfterFilesize As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NowFilesize As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrDisp As Label
    Friend WithEvents SaitekikaBtn As Button
    Friend WithEvents QuitBtn As Button
End Class
