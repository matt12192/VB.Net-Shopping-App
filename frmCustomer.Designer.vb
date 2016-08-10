<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblSurnameD = New System.Windows.Forms.Label()
        Me.lblTownD = New System.Windows.Forms.Label()
        Me.lblAddressD = New System.Windows.Forms.Label()
        Me.lblForenameD = New System.Windows.Forms.Label()
        Me.lblTitleD = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Epr1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.Epr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Bodoni MT Condensed", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(12, 152)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(248, 28)
        Me.lblDisplay.TabIndex = 5
        Me.lblDisplay.Text = "Please Enter Customer Details"
        '
        'lblSurnameD
        '
        Me.lblSurnameD.AutoSize = True
        Me.lblSurnameD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurnameD.Location = New System.Drawing.Point(62, 262)
        Me.lblSurnameD.Name = "lblSurnameD"
        Me.lblSurnameD.Size = New System.Drawing.Size(93, 24)
        Me.lblSurnameD.TabIndex = 6
        Me.lblSurnameD.Text = "Surname:"
        '
        'lblTownD
        '
        Me.lblTownD.AutoSize = True
        Me.lblTownD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownD.Location = New System.Drawing.Point(89, 329)
        Me.lblTownD.Name = "lblTownD"
        Me.lblTownD.Size = New System.Drawing.Size(66, 24)
        Me.lblTownD.TabIndex = 7
        Me.lblTownD.Text = "Town:"
        '
        'lblAddressD
        '
        Me.lblAddressD.AutoSize = True
        Me.lblAddressD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressD.Location = New System.Drawing.Point(69, 295)
        Me.lblAddressD.Name = "lblAddressD"
        Me.lblAddressD.Size = New System.Drawing.Size(86, 24)
        Me.lblAddressD.TabIndex = 8
        Me.lblAddressD.Text = "Address:"
        '
        'lblForenameD
        '
        Me.lblForenameD.AutoSize = True
        Me.lblForenameD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForenameD.Location = New System.Drawing.Point(51, 229)
        Me.lblForenameD.Name = "lblForenameD"
        Me.lblForenameD.Size = New System.Drawing.Size(104, 24)
        Me.lblForenameD.TabIndex = 9
        Me.lblForenameD.Text = "Forename:"
        '
        'lblTitleD
        '
        Me.lblTitleD.AutoSize = True
        Me.lblTitleD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleD.Location = New System.Drawing.Point(96, 195)
        Me.lblTitleD.Name = "lblTitleD"
        Me.lblTitleD.Size = New System.Drawing.Size(59, 24)
        Me.lblTitleD.TabIndex = 10
        Me.lblTitleD.Text = "Title:"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty.Location = New System.Drawing.Point(76, 362)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(79, 24)
        Me.lblCounty.TabIndex = 11
        Me.lblCounty.Text = "County:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(17, 428)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(138, 24)
        Me.lblTelephone.TabIndex = 12
        Me.lblTelephone.Text = "Telephone No:"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostcode.Location = New System.Drawing.Point(60, 395)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(95, 24)
        Me.lblPostcode.TabIndex = 13
        Me.lblPostcode.Text = "Postcode:"
        '
        'cboTitle
        '
        Me.cboTitle.BackColor = System.Drawing.Color.Black
        Me.cboTitle.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTitle.ForeColor = System.Drawing.Color.White
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Miss", "Dr"})
        Me.cboTitle.Location = New System.Drawing.Point(161, 196)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(51, 27)
        Me.cboTitle.TabIndex = 14
        Me.cboTitle.Text = "MR"
        '
        'txtTelephone
        '
        Me.txtTelephone.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtTelephone.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.ForeColor = System.Drawing.Color.White
        Me.txtTelephone.Location = New System.Drawing.Point(160, 431)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 27)
        Me.txtTelephone.TabIndex = 17
        Me.txtTelephone.Text = "07856707416"
        '
        'txtPostcode
        '
        Me.txtPostcode.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtPostcode.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostcode.ForeColor = System.Drawing.Color.White
        Me.txtPostcode.Location = New System.Drawing.Point(160, 398)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(100, 27)
        Me.txtPostcode.TabIndex = 18
        Me.txtPostcode.Text = "BT28£NZ"
        '
        'txtCounty
        '
        Me.txtCounty.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtCounty.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounty.ForeColor = System.Drawing.Color.White
        Me.txtCounty.Location = New System.Drawing.Point(161, 365)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(100, 27)
        Me.txtCounty.TabIndex = 19
        Me.txtCounty.Text = "ANtrim"
        '
        'txtTown
        '
        Me.txtTown.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtTown.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTown.ForeColor = System.Drawing.Color.White
        Me.txtTown.Location = New System.Drawing.Point(160, 332)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(100, 27)
        Me.txtTown.TabIndex = 20
        Me.txtTown.Text = "LISburn"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtAddress.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(160, 299)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 27)
        Me.txtAddress.TabIndex = 21
        Me.txtAddress.Text = "CAStle STReet"
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtSurname.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.ForeColor = System.Drawing.Color.White
        Me.txtSurname.Location = New System.Drawing.Point(160, 264)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 27)
        Me.txtSurname.TabIndex = 22
        Me.txtSurname.Text = "Boden"
        '
        'txtForename
        '
        Me.txtForename.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtForename.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForename.ForeColor = System.Drawing.Color.White
        Me.txtForename.Location = New System.Drawing.Point(160, 230)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(100, 27)
        Me.txtForename.TabIndex = 23
        Me.txtForename.Text = "Matthew"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(576, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 44)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Epr1
        '
        Me.Epr1.ContainerControl = Me
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtEmail.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(161, 464)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 27)
        Me.txtEmail.TabIndex = 16
        Me.txtEmail.Text = "Hotmail.co.uk"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(13, 461)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(145, 24)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "Email Address:"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(576, 418)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 44)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(828, 538)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.cboTitle)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTitleD)
        Me.Controls.Add(Me.lblForenameD)
        Me.Controls.Add(Me.lblAddressD)
        Me.Controls.Add(Me.lblTownD)
        Me.Controls.Add(Me.lblSurnameD)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "frmCustomer"
        Me.Controls.SetChildIndex(Me.lblDisplay, 0)
        Me.Controls.SetChildIndex(Me.lblSurnameD, 0)
        Me.Controls.SetChildIndex(Me.lblTownD, 0)
        Me.Controls.SetChildIndex(Me.lblAddressD, 0)
        Me.Controls.SetChildIndex(Me.lblForenameD, 0)
        Me.Controls.SetChildIndex(Me.lblTitleD, 0)
        Me.Controls.SetChildIndex(Me.lblCounty, 0)
        Me.Controls.SetChildIndex(Me.lblTelephone, 0)
        Me.Controls.SetChildIndex(Me.lblPostcode, 0)
        Me.Controls.SetChildIndex(Me.cboTitle, 0)
        Me.Controls.SetChildIndex(Me.lblEmail, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.txtTelephone, 0)
        Me.Controls.SetChildIndex(Me.txtPostcode, 0)
        Me.Controls.SetChildIndex(Me.txtCounty, 0)
        Me.Controls.SetChildIndex(Me.txtTown, 0)
        Me.Controls.SetChildIndex(Me.txtAddress, 0)
        Me.Controls.SetChildIndex(Me.txtSurname, 0)
        Me.Controls.SetChildIndex(Me.txtForename, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnReset, 0)
        CType(Me.Epr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents lblSurnameD As System.Windows.Forms.Label
    Friend WithEvents lblTownD As System.Windows.Forms.Label
    Friend WithEvents lblAddressD As System.Windows.Forms.Label
    Friend WithEvents lblForenameD As System.Windows.Forms.Label
    Friend WithEvents lblTitleD As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Epr1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
