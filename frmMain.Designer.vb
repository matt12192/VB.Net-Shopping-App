<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits Elite_Computer_Systems.frmTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.rtbInfobox = New System.Windows.Forms.RichTextBox()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Bodoni MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 182)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(270, 32)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.Text = "Only the Finest Computer Systems"
        '
        'picComputer
        '
        Me.picComputer.Image = Global.Elite_Computer_Systems.My.Resources.Resources.Forecourt
        Me.picComputer.Location = New System.Drawing.Point(18, 228)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(264, 219)
        Me.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComputer.TabIndex = 6
        Me.picComputer.TabStop = False
        '
        'rtbInfobox
        '
        Me.rtbInfobox.BackColor = System.Drawing.Color.Black
        Me.rtbInfobox.ForeColor = System.Drawing.Color.White
        Me.rtbInfobox.Location = New System.Drawing.Point(408, 167)
        Me.rtbInfobox.Name = "rtbInfobox"
        Me.rtbInfobox.Size = New System.Drawing.Size(292, 280)
        Me.rtbInfobox.TabIndex = 7
        Me.rtbInfobox.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(810, 523)
        Me.Controls.Add(Me.rtbInfobox)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmMain"
        Me.Controls.SetChildIndex(Me.lblMessage, 0)
        Me.Controls.SetChildIndex(Me.picComputer, 0)
        Me.Controls.SetChildIndex(Me.rtbInfobox, 0)
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picComputer As System.Windows.Forms.PictureBox
    Friend WithEvents rtbInfobox As System.Windows.Forms.RichTextBox

End Class
