<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Me.gbCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.lblVatD = New System.Windows.Forms.Label()
        Me.lblDeliveryD = New System.Windows.Forms.Label()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.gbDelivery = New System.Windows.Forms.GroupBox()
        Me.radNorthernireland = New System.Windows.Forms.RadioButton()
        Me.radScotland = New System.Windows.Forms.RadioButton()
        Me.radWales = New System.Windows.Forms.RadioButton()
        Me.radEngland = New System.Windows.Forms.RadioButton()
        Me.radLondon = New System.Windows.Forms.RadioButton()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.gbCustomerDetails.SuspendLayout()
        Me.gbDelivery.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomerDetails
        '
        Me.gbCustomerDetails.Controls.Add(Me.lblEmail)
        Me.gbCustomerDetails.Controls.Add(Me.lblForename)
        Me.gbCustomerDetails.Controls.Add(Me.lblSurname)
        Me.gbCustomerDetails.Controls.Add(Me.lblAddress)
        Me.gbCustomerDetails.Controls.Add(Me.lblTown)
        Me.gbCustomerDetails.Controls.Add(Me.lblPostcode)
        Me.gbCustomerDetails.Controls.Add(Me.lblTelephone)
        Me.gbCustomerDetails.Controls.Add(Me.lblTitle1)
        Me.gbCustomerDetails.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCustomerDetails.Location = New System.Drawing.Point(12, 155)
        Me.gbCustomerDetails.Name = "gbCustomerDetails"
        Me.gbCustomerDetails.Size = New System.Drawing.Size(392, 251)
        Me.gbCustomerDetails.TabIndex = 5
        Me.gbCustomerDetails.TabStop = False
        Me.gbCustomerDetails.Text = "Customer Details"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(20, 197)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "Email"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(134, 48)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(77, 20)
        Me.lblForename.TabIndex = 15
        Me.lblForename.Text = "Forename"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(269, 48)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(69, 20)
        Me.lblSurname.TabIndex = 14
        Me.lblSurname.Text = "Surname"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(20, 78)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 20)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTown.Location = New System.Drawing.Point(20, 108)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(47, 20)
        Me.lblTown.TabIndex = 12
        Me.lblTown.Text = "Town"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostcode.Location = New System.Drawing.Point(20, 138)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(68, 20)
        Me.lblPostcode.TabIndex = 11
        Me.lblPostcode.Text = "Postcode"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(20, 167)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(78, 20)
        Me.lblTelephone.TabIndex = 10
        Me.lblTelephone.Text = "Telephone"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(20, 48)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(39, 20)
        Me.lblTitle1.TabIndex = 0
        Me.lblTitle1.Text = "Title"
        '
        'lblVatD
        '
        Me.lblVatD.AutoSize = True
        Me.lblVatD.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatD.Location = New System.Drawing.Point(46, 428)
        Me.lblVatD.Name = "lblVatD"
        Me.lblVatD.Size = New System.Drawing.Size(44, 23)
        Me.lblVatD.TabIndex = 6
        Me.lblVatD.Text = "Vat:"
        '
        'lblDeliveryD
        '
        Me.lblDeliveryD.AutoSize = True
        Me.lblDeliveryD.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryD.Location = New System.Drawing.Point(227, 152)
        Me.lblDeliveryD.Name = "lblDeliveryD"
        Me.lblDeliveryD.Size = New System.Drawing.Size(82, 23)
        Me.lblDeliveryD.TabIndex = 7
        Me.lblDeliveryD.Text = "Delivery:"
        '
        'lblTotalD
        '
        Me.lblTotalD.AutoSize = True
        Me.lblTotalD.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalD.Location = New System.Drawing.Point(35, 460)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(58, 23)
        Me.lblTotalD.TabIndex = 8
        Me.lblTotalD.Text = "Total:"
        '
        'lstOrder
        '
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.Location = New System.Drawing.Point(480, 157)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(451, 264)
        Me.lstOrder.TabIndex = 9
        '
        'lblVat
        '
        Me.lblVat.BackColor = System.Drawing.Color.Black
        Me.lblVat.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.White
        Me.lblVat.Location = New System.Drawing.Point(96, 431)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(64, 20)
        Me.lblVat.TabIndex = 17
        '
        'lblDelivery
        '
        Me.lblDelivery.BackColor = System.Drawing.Color.Black
        Me.lblDelivery.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.ForeColor = System.Drawing.Color.White
        Me.lblDelivery.Location = New System.Drawing.Point(315, 156)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(64, 20)
        Me.lblDelivery.TabIndex = 18
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(96, 462)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 20)
        Me.lblTotal.TabIndex = 19
        '
        'gbDelivery
        '
        Me.gbDelivery.Controls.Add(Me.lblDeliveryD)
        Me.gbDelivery.Controls.Add(Me.lblDelivery)
        Me.gbDelivery.Controls.Add(Me.radNorthernireland)
        Me.gbDelivery.Controls.Add(Me.radScotland)
        Me.gbDelivery.Controls.Add(Me.radWales)
        Me.gbDelivery.Controls.Add(Me.radEngland)
        Me.gbDelivery.Controls.Add(Me.radLondon)
        Me.gbDelivery.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDelivery.Location = New System.Drawing.Point(541, 431)
        Me.gbDelivery.Name = "gbDelivery"
        Me.gbDelivery.Size = New System.Drawing.Size(390, 202)
        Me.gbDelivery.TabIndex = 20
        Me.gbDelivery.TabStop = False
        Me.gbDelivery.Text = "Delivery Charge"
        '
        'radNorthernireland
        '
        Me.radNorthernireland.AutoSize = True
        Me.radNorthernireland.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNorthernireland.Location = New System.Drawing.Point(32, 152)
        Me.radNorthernireland.Name = "radNorthernireland"
        Me.radNorthernireland.Size = New System.Drawing.Size(139, 24)
        Me.radNorthernireland.TabIndex = 7
        Me.radNorthernireland.TabStop = True
        Me.radNorthernireland.Text = "Northern Ireland"
        Me.radNorthernireland.UseVisualStyleBackColor = True
        '
        'radScotland
        '
        Me.radScotland.AutoSize = True
        Me.radScotland.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radScotland.Location = New System.Drawing.Point(32, 122)
        Me.radScotland.Name = "radScotland"
        Me.radScotland.Size = New System.Drawing.Size(84, 24)
        Me.radScotland.TabIndex = 6
        Me.radScotland.TabStop = True
        Me.radScotland.Text = "Scotland"
        Me.radScotland.UseVisualStyleBackColor = True
        '
        'radWales
        '
        Me.radWales.AutoSize = True
        Me.radWales.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWales.Location = New System.Drawing.Point(32, 92)
        Me.radWales.Name = "radWales"
        Me.radWales.Size = New System.Drawing.Size(68, 24)
        Me.radWales.TabIndex = 5
        Me.radWales.TabStop = True
        Me.radWales.Text = "Wales"
        Me.radWales.UseVisualStyleBackColor = True
        '
        'radEngland
        '
        Me.radEngland.AutoSize = True
        Me.radEngland.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEngland.Location = New System.Drawing.Point(32, 62)
        Me.radEngland.Name = "radEngland"
        Me.radEngland.Size = New System.Drawing.Size(206, 24)
        Me.radEngland.TabIndex = 4
        Me.radEngland.TabStop = True
        Me.radEngland.Text = "England(Exclude London)"
        Me.radEngland.UseVisualStyleBackColor = True
        '
        'radLondon
        '
        Me.radLondon.AutoSize = True
        Me.radLondon.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLondon.Location = New System.Drawing.Point(32, 32)
        Me.radLondon.Name = "radLondon"
        Me.radLondon.Size = New System.Drawing.Size(79, 24)
        Me.radLondon.TabIndex = 3
        Me.radLondon.TabStop = True
        Me.radLondon.Text = "London"
        Me.radLondon.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Black
        Me.btnReturn.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(84, 527)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(87, 44)
        Me.btnReturn.TabIndex = 25
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1053, 673)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstOrder)
        Me.Controls.Add(Me.gbCustomerDetails)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.gbDelivery)
        Me.Controls.Add(Me.lblVatD)
        Me.Controls.Add(Me.lblTotalD)
        Me.Controls.Add(Me.lblVat)
        Me.Name = "frmInvoice"
        Me.Controls.SetChildIndex(Me.lblVat, 0)
        Me.Controls.SetChildIndex(Me.lblTotalD, 0)
        Me.Controls.SetChildIndex(Me.lblVatD, 0)
        Me.Controls.SetChildIndex(Me.gbDelivery, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.gbCustomerDetails, 0)
        Me.Controls.SetChildIndex(Me.lstOrder, 0)
        Me.Controls.SetChildIndex(Me.btnReturn, 0)
        Me.gbCustomerDetails.ResumeLayout(False)
        Me.gbCustomerDetails.PerformLayout()
        Me.gbDelivery.ResumeLayout(False)
        Me.gbDelivery.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents lblVatD As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryD As System.Windows.Forms.Label
    Friend WithEvents lblTotalD As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lstOrder As System.Windows.Forms.ListBox
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents gbDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents radNorthernireland As System.Windows.Forms.RadioButton
    Friend WithEvents radScotland As System.Windows.Forms.RadioButton
    Friend WithEvents radWales As System.Windows.Forms.RadioButton
    Friend WithEvents radEngland As System.Windows.Forms.RadioButton
    Friend WithEvents radLondon As System.Windows.Forms.RadioButton
    Friend WithEvents btnReturn As System.Windows.Forms.Button

End Class
