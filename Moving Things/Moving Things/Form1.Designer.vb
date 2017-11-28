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
        Me.picRenee = New System.Windows.Forms.PictureBox()
        Me.picJames = New System.Windows.Forms.PictureBox()
        Me.picBecca = New System.Windows.Forms.PictureBox()
        CType(Me.picRenee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBecca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(27, 222)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'picRenee
        '
        Me.picRenee.Image = Global.Moving_Things.My.Resources.Resources.IMG_3459
        Me.picRenee.Location = New System.Drawing.Point(27, 154)
        Me.picRenee.Name = "picRenee"
        Me.picRenee.Size = New System.Drawing.Size(50, 50)
        Me.picRenee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRenee.TabIndex = 3
        Me.picRenee.TabStop = False
        '
        'picJames
        '
        Me.picJames.Image = Global.Moving_Things.My.Resources.Resources.IMG_2825
        Me.picJames.Location = New System.Drawing.Point(27, 98)
        Me.picJames.Name = "picJames"
        Me.picJames.Size = New System.Drawing.Size(50, 50)
        Me.picJames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJames.TabIndex = 2
        Me.picJames.TabStop = False
        '
        'picBecca
        '
        Me.picBecca.Image = Global.Moving_Things.My.Resources.Resources.IMG_0247
        Me.picBecca.Location = New System.Drawing.Point(27, 42)
        Me.picBecca.Name = "picBecca"
        Me.picBecca.Size = New System.Drawing.Size(50, 50)
        Me.picBecca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBecca.TabIndex = 1
        Me.picBecca.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 306)
        Me.Controls.Add(Me.picRenee)
        Me.Controls.Add(Me.picJames)
        Me.Controls.Add(Me.picBecca)
        Me.Controls.Add(Me.btnRace)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picRenee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBecca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents picBecca As System.Windows.Forms.PictureBox
    Friend WithEvents picJames As System.Windows.Forms.PictureBox
    Friend WithEvents picRenee As System.Windows.Forms.PictureBox

End Class
