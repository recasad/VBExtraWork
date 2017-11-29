<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picRenee = New System.Windows.Forms.PictureBox()
        Me.picJames = New System.Windows.Forms.PictureBox()
        Me.picBecca = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBetting = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radJames = New System.Windows.Forms.RadioButton()
        Me.radRenee = New System.Windows.Forms.RadioButton()
        Me.radBecca = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRenee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBecca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.Font = New System.Drawing.Font("Magneto", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRace.Location = New System.Drawing.Point(26, 251)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(361, 63)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Moving_Things.My.Resources.Resources.SpeedMaxPC_Racing_Flags
        Me.PictureBox1.Location = New System.Drawing.Point(309, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picRenee
        '
        Me.picRenee.Image = Global.Moving_Things.My.Resources.Resources.IMG_3459
        Me.picRenee.Location = New System.Drawing.Point(26, 195)
        Me.picRenee.Name = "picRenee"
        Me.picRenee.Size = New System.Drawing.Size(50, 50)
        Me.picRenee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRenee.TabIndex = 3
        Me.picRenee.TabStop = False
        '
        'picJames
        '
        Me.picJames.Image = Global.Moving_Things.My.Resources.Resources.IMG_2825
        Me.picJames.Location = New System.Drawing.Point(26, 139)
        Me.picJames.Name = "picJames"
        Me.picJames.Size = New System.Drawing.Size(50, 50)
        Me.picJames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJames.TabIndex = 2
        Me.picJames.TabStop = False
        '
        'picBecca
        '
        Me.picBecca.Image = Global.Moving_Things.My.Resources.Resources.IMG_0247
        Me.picBecca.Location = New System.Drawing.Point(26, 83)
        Me.picBecca.Name = "picBecca"
        Me.picBecca.Size = New System.Drawing.Size(50, 50)
        Me.picBecca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBecca.TabIndex = 1
        Me.picBecca.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magneto", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Casad Family Races"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBetting)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radJames)
        Me.GroupBox1.Controls.Add(Me.radRenee)
        Me.GroupBox1.Controls.Add(Me.radBecca)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Magneto", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(405, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 284)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bet on your favorite Casad"
        '
        'txtBetting
        '
        Me.txtBetting.Location = New System.Drawing.Point(24, 141)
        Me.txtBetting.Name = "txtBetting"
        Me.txtBetting.Size = New System.Drawing.Size(206, 26)
        Me.txtBetting.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Amount:"
        '
        'radJames
        '
        Me.radJames.AutoSize = True
        Me.radJames.Location = New System.Drawing.Point(15, 53)
        Me.radJames.Name = "radJames"
        Me.radJames.Size = New System.Drawing.Size(79, 23)
        Me.radJames.TabIndex = 5
        Me.radJames.TabStop = True
        Me.radJames.Text = "James"
        Me.radJames.UseVisualStyleBackColor = True
        '
        'radRenee
        '
        Me.radRenee.AutoSize = True
        Me.radRenee.Location = New System.Drawing.Point(15, 82)
        Me.radRenee.Name = "radRenee"
        Me.radRenee.Size = New System.Drawing.Size(77, 23)
        Me.radRenee.TabIndex = 4
        Me.radRenee.TabStop = True
        Me.radRenee.Text = "Renee"
        Me.radRenee.UseVisualStyleBackColor = True
        '
        'radBecca
        '
        Me.radBecca.AutoSize = True
        Me.radBecca.Location = New System.Drawing.Point(15, 25)
        Me.radBecca.Name = "radBecca"
        Me.radBecca.Size = New System.Drawing.Size(75, 23)
        Me.radBecca.TabIndex = 3
        Me.radBecca.TabStop = True
        Me.radBecca.Text = "Becca"
        Me.radBecca.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBank)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 99)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bank"
        '
        'lblBank
        '
        Me.lblBank.Font = New System.Drawing.Font("Magneto", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(25, 32)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(205, 41)
        Me.lblBank.TabIndex = 0
        Me.lblBank.Text = "$1,000.00"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 1
        '
        'lblWarning
        '
        Me.lblWarning.Location = New System.Drawing.Point(23, 326)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(634, 23)
        Me.lblWarning.TabIndex = 7
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 363)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picRenee)
        Me.Controls.Add(Me.picJames)
        Me.Controls.Add(Me.picBecca)
        Me.Controls.Add(Me.btnRace)
        Me.Name = "Form1"
        Me.Text = "Casad Family Races"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRenee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBecca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents picBecca As System.Windows.Forms.PictureBox
    Friend WithEvents picJames As System.Windows.Forms.PictureBox
    Friend WithEvents picRenee As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBetting As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radJames As System.Windows.Forms.RadioButton
    Friend WithEvents radRenee As System.Windows.Forms.RadioButton
    Friend WithEvents radBecca As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label

End Class
