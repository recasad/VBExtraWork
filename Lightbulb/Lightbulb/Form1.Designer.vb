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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.picRight = New System.Windows.Forms.PictureBox()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(98, 186)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(99, 47)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Button1"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.Location = New System.Drawing.Point(93, 134)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(0, 25)
        Me.lblEmpty.TabIndex = 1
        '
        'picRight
        '
        Me.picRight.Image = Global.Lightbulb.My.Resources.Resources.IMG_02471
        Me.picRight.Location = New System.Drawing.Point(27, 56)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(100, 50)
        Me.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRight.TabIndex = 2
        Me.picRight.TabStop = False
        Me.picRight.Visible = False
        '
        'picLeft
        '
        Me.picLeft.Image = Global.Lightbulb.My.Resources.Resources.IMG_02471
        Me.picLeft.Location = New System.Drawing.Point(175, 56)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(100, 50)
        Me.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLeft.TabIndex = 3
        Me.picLeft.TabStop = False
        Me.picLeft.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 300)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblEmpty As System.Windows.Forms.Label
    Friend WithEvents picRight As System.Windows.Forms.PictureBox
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox

End Class
