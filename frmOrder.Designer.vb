<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.gbSystems = New System.Windows.Forms.GroupBox()
        Me.picPc60 = New System.Windows.Forms.PictureBox()
        Me.picPc50 = New System.Windows.Forms.PictureBox()
        Me.picLaptop = New System.Windows.Forms.PictureBox()
        Me.gbUpgrades = New System.Windows.Forms.GroupBox()
        Me.radGraphicscard1 = New System.Windows.Forms.RadioButton()
        Me.radGraphicscard = New System.Windows.Forms.RadioButton()
        Me.radHarddrive1 = New System.Windows.Forms.RadioButton()
        Me.radHarddrive = New System.Windows.Forms.RadioButton()
        Me.radWarranty3 = New System.Windows.Forms.RadioButton()
        Me.radWarranty2 = New System.Windows.Forms.RadioButton()
        Me.radWarranty1 = New System.Windows.Forms.RadioButton()
        Me.radWarranty = New System.Windows.Forms.RadioButton()
        Me.lblGraphicscard = New System.Windows.Forms.Label()
        Me.lblHarddrive = New System.Windows.Forms.Label()
        Me.lblWarranty = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rtfSystemDetails = New System.Windows.Forms.RichTextBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSubTotalD = New System.Windows.Forms.Label()
        Me.lblVatD = New System.Windows.Forms.Label()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.gbSystems.SuspendLayout()
        CType(Me.picPc60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPc50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUpgrades.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSystems
        '
        Me.gbSystems.Controls.Add(Me.picPc60)
        Me.gbSystems.Controls.Add(Me.picPc50)
        Me.gbSystems.Controls.Add(Me.picLaptop)
        Me.gbSystems.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSystems.Location = New System.Drawing.Point(12, 155)
        Me.gbSystems.Name = "gbSystems"
        Me.gbSystems.Size = New System.Drawing.Size(468, 147)
        Me.gbSystems.TabIndex = 5
        Me.gbSystems.TabStop = False
        Me.gbSystems.Text = "Select a System"
        '
        'picPc60
        '
        Me.picPc60.Image = Global.Elite_Computer_Systems.My.Resources.Resources.PC60
        Me.picPc60.Location = New System.Drawing.Point(334, 29)
        Me.picPc60.Name = "picPc60"
        Me.picPc60.Size = New System.Drawing.Size(128, 111)
        Me.picPc60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPc60.TabIndex = 9
        Me.picPc60.TabStop = False
        '
        'picPc50
        '
        Me.picPc50.Image = Global.Elite_Computer_Systems.My.Resources.Resources.PC50
        Me.picPc50.Location = New System.Drawing.Point(174, 29)
        Me.picPc50.Name = "picPc50"
        Me.picPc50.Size = New System.Drawing.Size(128, 111)
        Me.picPc50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPc50.TabIndex = 8
        Me.picPc50.TabStop = False
        '
        'picLaptop
        '
        Me.picLaptop.Image = Global.Elite_Computer_Systems.My.Resources.Resources.Laptop
        Me.picLaptop.Location = New System.Drawing.Point(15, 29)
        Me.picLaptop.Name = "picLaptop"
        Me.picLaptop.Size = New System.Drawing.Size(128, 111)
        Me.picLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaptop.TabIndex = 7
        Me.picLaptop.TabStop = False
        '
        'gbUpgrades
        '
        Me.gbUpgrades.Controls.Add(Me.radGraphicscard1)
        Me.gbUpgrades.Controls.Add(Me.radGraphicscard)
        Me.gbUpgrades.Controls.Add(Me.radHarddrive1)
        Me.gbUpgrades.Controls.Add(Me.radHarddrive)
        Me.gbUpgrades.Controls.Add(Me.radWarranty3)
        Me.gbUpgrades.Controls.Add(Me.radWarranty2)
        Me.gbUpgrades.Controls.Add(Me.radWarranty1)
        Me.gbUpgrades.Controls.Add(Me.radWarranty)
        Me.gbUpgrades.Controls.Add(Me.lblGraphicscard)
        Me.gbUpgrades.Controls.Add(Me.lblHarddrive)
        Me.gbUpgrades.Controls.Add(Me.lblWarranty)
        Me.gbUpgrades.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUpgrades.Location = New System.Drawing.Point(12, 301)
        Me.gbUpgrades.Name = "gbUpgrades"
        Me.gbUpgrades.Size = New System.Drawing.Size(525, 252)
        Me.gbUpgrades.TabIndex = 6
        Me.gbUpgrades.TabStop = False
        Me.gbUpgrades.Text = "Upgrades"
        '
        'radGraphicscard1
        '
        Me.radGraphicscard1.AutoSize = True
        Me.radGraphicscard1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGraphicscard1.Location = New System.Drawing.Point(229, 220)
        Me.radGraphicscard1.Name = "radGraphicscard1"
        Me.radGraphicscard1.Size = New System.Drawing.Size(202, 23)
        Me.radGraphicscard1.TabIndex = 10
        Me.radGraphicscard1.TabStop = True
        Me.radGraphicscard1.Text = "4GB Version of same card"
        Me.ToolTip1.SetToolTip(Me.radGraphicscard1, "£105.00")
        Me.radGraphicscard1.UseVisualStyleBackColor = True
        '
        'radGraphicscard
        '
        Me.radGraphicscard.AutoSize = True
        Me.radGraphicscard.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGraphicscard.Location = New System.Drawing.Point(21, 220)
        Me.radGraphicscard.Name = "radGraphicscard"
        Me.radGraphicscard.Size = New System.Drawing.Size(202, 23)
        Me.radGraphicscard.TabIndex = 9
        Me.radGraphicscard.TabStop = True
        Me.radGraphicscard.Text = "2GB Version of same card"
        Me.ToolTip1.SetToolTip(Me.radGraphicscard, "£75.00")
        Me.radGraphicscard.UseVisualStyleBackColor = True
        '
        'radHarddrive1
        '
        Me.radHarddrive1.AutoSize = True
        Me.radHarddrive1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHarddrive1.Location = New System.Drawing.Point(270, 170)
        Me.radHarddrive1.Name = "radHarddrive1"
        Me.radHarddrive1.Size = New System.Drawing.Size(249, 23)
        Me.radHarddrive1.TabIndex = 8
        Me.radHarddrive1.TabStop = True
        Me.radHarddrive1.Text = "1TB Version of same Hard Drive"
        Me.ToolTip1.SetToolTip(Me.radHarddrive1, "£50.00")
        Me.radHarddrive1.UseVisualStyleBackColor = True
        '
        'radHarddrive
        '
        Me.radHarddrive.AutoSize = True
        Me.radHarddrive.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHarddrive.Location = New System.Drawing.Point(4, 170)
        Me.radHarddrive.Name = "radHarddrive"
        Me.radHarddrive.Size = New System.Drawing.Size(266, 23)
        Me.radHarddrive.TabIndex = 7
        Me.radHarddrive.TabStop = True
        Me.radHarddrive.Text = "750GB Version of same Hard Drive"
        Me.ToolTip1.SetToolTip(Me.radHarddrive, "£30.00")
        Me.radHarddrive.UseVisualStyleBackColor = True
        '
        'radWarranty3
        '
        Me.radWarranty3.AutoSize = True
        Me.radWarranty3.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWarranty3.Location = New System.Drawing.Point(21, 116)
        Me.radWarranty3.Name = "radWarranty3"
        Me.radWarranty3.Size = New System.Drawing.Size(474, 23)
        Me.radWarranty3.TabIndex = 6
        Me.radWarranty3.TabStop = True
        Me.radWarranty3.Text = "3 Years Next Day In-Home Service with Premium Home Support"
        Me.ToolTip1.SetToolTip(Me.radWarranty3, "£140.00")
        Me.radWarranty3.UseVisualStyleBackColor = True
        '
        'radWarranty2
        '
        Me.radWarranty2.AutoSize = True
        Me.radWarranty2.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWarranty2.Location = New System.Drawing.Point(21, 87)
        Me.radWarranty2.Name = "radWarranty2"
        Me.radWarranty2.Size = New System.Drawing.Size(471, 23)
        Me.radWarranty2.TabIndex = 5
        Me.radWarranty2.TabStop = True
        Me.radWarranty2.Text = "1 Year Next Day In-Home Service with Premium Phone Support"
        Me.ToolTip1.SetToolTip(Me.radWarranty2, "£70.00")
        Me.radWarranty2.UseVisualStyleBackColor = True
        '
        'radWarranty1
        '
        Me.radWarranty1.AutoSize = True
        Me.radWarranty1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWarranty1.Location = New System.Drawing.Point(21, 58)
        Me.radWarranty1.Name = "radWarranty1"
        Me.radWarranty1.Size = New System.Drawing.Size(273, 23)
        Me.radWarranty1.TabIndex = 4
        Me.radWarranty1.TabStop = True
        Me.radWarranty1.Text = "1 Year Next Day Hardware Support"
        Me.ToolTip1.SetToolTip(Me.radWarranty1, "£45.00")
        Me.radWarranty1.UseVisualStyleBackColor = True
        '
        'radWarranty
        '
        Me.radWarranty.AutoSize = True
        Me.radWarranty.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWarranty.Location = New System.Drawing.Point(109, 29)
        Me.radWarranty.Name = "radWarranty"
        Me.radWarranty.Size = New System.Drawing.Size(344, 23)
        Me.radWarranty.TabIndex = 3
        Me.radWarranty.TabStop = True
        Me.radWarranty.Text = "1 Year Collect and Return Warranty Included"
        Me.ToolTip1.SetToolTip(Me.radWarranty, "Included")
        Me.radWarranty.UseVisualStyleBackColor = True
        '
        'lblGraphicscard
        '
        Me.lblGraphicscard.AutoSize = True
        Me.lblGraphicscard.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphicscard.Location = New System.Drawing.Point(6, 199)
        Me.lblGraphicscard.Name = "lblGraphicscard"
        Me.lblGraphicscard.Size = New System.Drawing.Size(123, 23)
        Me.lblGraphicscard.TabIndex = 2
        Me.lblGraphicscard.Text = "Graphics card:"
        '
        'lblHarddrive
        '
        Me.lblHarddrive.AutoSize = True
        Me.lblHarddrive.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarddrive.Location = New System.Drawing.Point(11, 147)
        Me.lblHarddrive.Name = "lblHarddrive"
        Me.lblHarddrive.Size = New System.Drawing.Size(101, 23)
        Me.lblHarddrive.TabIndex = 1
        Me.lblHarddrive.Text = "Hard drive:"
        '
        'lblWarranty
        '
        Me.lblWarranty.AutoSize = True
        Me.lblWarranty.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarranty.Location = New System.Drawing.Point(11, 26)
        Me.lblWarranty.Name = "lblWarranty"
        Me.lblWarranty.Size = New System.Drawing.Size(92, 23)
        Me.lblWarranty.TabIndex = 0
        Me.lblWarranty.Text = "Warranty:"
        '
        'rtfSystemDetails
        '
        Me.rtfSystemDetails.BackColor = System.Drawing.Color.White
        Me.rtfSystemDetails.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfSystemDetails.ForeColor = System.Drawing.Color.Black
        Me.rtfSystemDetails.Location = New System.Drawing.Point(543, 155)
        Me.rtfSystemDetails.Name = "rtfSystemDetails"
        Me.rtfSystemDetails.Size = New System.Drawing.Size(442, 339)
        Me.rtfSystemDetails.TabIndex = 7
        Me.rtfSystemDetails.Text = ""
        Me.rtfSystemDetails.Visible = False
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(15, 559)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(100, 81)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 8
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(121, 559)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(100, 81)
        Me.pic2.TabIndex = 9
        Me.pic2.TabStop = False
        '
        'lstOrder
        '
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.Location = New System.Drawing.Point(227, 555)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(277, 134)
        Me.lstOrder.TabIndex = 11
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Black
        Me.btnTotal.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.Color.White
        Me.btnTotal.Location = New System.Drawing.Point(510, 559)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(87, 35)
        Me.btnTotal.TabIndex = 12
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(510, 592)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 35)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblSubTotalD
        '
        Me.lblSubTotalD.AutoSize = True
        Me.lblSubTotalD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalD.Location = New System.Drawing.Point(612, 558)
        Me.lblSubTotalD.Name = "lblSubTotalD"
        Me.lblSubTotalD.Size = New System.Drawing.Size(97, 24)
        Me.lblSubTotalD.TabIndex = 15
        Me.lblSubTotalD.Text = "SubTotal:"
        '
        'lblVatD
        '
        Me.lblVatD.AutoSize = True
        Me.lblVatD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatD.Location = New System.Drawing.Point(660, 597)
        Me.lblVatD.Name = "lblVatD"
        Me.lblVatD.Size = New System.Drawing.Size(49, 24)
        Me.lblVatD.TabIndex = 16
        Me.lblVatD.Text = "Vat:"
        '
        'lblTotalD
        '
        Me.lblTotalD.AutoSize = True
        Me.lblTotalD.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalD.Location = New System.Drawing.Point(645, 635)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(64, 24)
        Me.lblTotalD.TabIndex = 17
        Me.lblTotalD.Text = "Total:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Black
        Me.lblSubTotal.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.White
        Me.lblSubTotal.Location = New System.Drawing.Point(726, 559)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(120, 23)
        Me.lblSubTotal.TabIndex = 18
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(726, 636)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 23)
        Me.lblTotal.TabIndex = 19
        '
        'lblVat
        '
        Me.lblVat.BackColor = System.Drawing.Color.Black
        Me.lblVat.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.White
        Me.lblVat.Location = New System.Drawing.Point(726, 598)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(120, 23)
        Me.lblVat.TabIndex = 20
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.Black
        Me.btnInvoice.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoice.ForeColor = System.Drawing.Color.White
        Me.btnInvoice.Location = New System.Drawing.Point(887, 627)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(87, 35)
        Me.btnInvoice.TabIndex = 23
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(997, 714)
        Me.Controls.Add(Me.btnInvoice)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblTotalD)
        Me.Controls.Add(Me.lblVatD)
        Me.Controls.Add(Me.lblSubTotalD)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lstOrder)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.gbSystems)
        Me.Controls.Add(Me.gbUpgrades)
        Me.Controls.Add(Me.rtfSystemDetails)
        Me.Name = "frmOrder"
        Me.Controls.SetChildIndex(Me.rtfSystemDetails, 0)
        Me.Controls.SetChildIndex(Me.gbUpgrades, 0)
        Me.Controls.SetChildIndex(Me.gbSystems, 0)
        Me.Controls.SetChildIndex(Me.pic1, 0)
        Me.Controls.SetChildIndex(Me.pic2, 0)
        Me.Controls.SetChildIndex(Me.lstOrder, 0)
        Me.Controls.SetChildIndex(Me.btnTotal, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.lblSubTotalD, 0)
        Me.Controls.SetChildIndex(Me.lblVatD, 0)
        Me.Controls.SetChildIndex(Me.lblTotalD, 0)
        Me.Controls.SetChildIndex(Me.lblSubTotal, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.lblVat, 0)
        Me.Controls.SetChildIndex(Me.btnInvoice, 0)
        Me.gbSystems.ResumeLayout(False)
        CType(Me.picPc60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPc50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLaptop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUpgrades.ResumeLayout(False)
        Me.gbUpgrades.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSystems As System.Windows.Forms.GroupBox
    Friend WithEvents picPc60 As System.Windows.Forms.PictureBox
    Friend WithEvents picPc50 As System.Windows.Forms.PictureBox
    Friend WithEvents picLaptop As System.Windows.Forms.PictureBox
    Friend WithEvents gbUpgrades As System.Windows.Forms.GroupBox
    Friend WithEvents lblGraphicscard As System.Windows.Forms.Label
    Friend WithEvents lblHarddrive As System.Windows.Forms.Label
    Friend WithEvents lblWarranty As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rtfSystemDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents lstOrder As System.Windows.Forms.ListBox
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblSubTotalD As System.Windows.Forms.Label
    Friend WithEvents lblVatD As System.Windows.Forms.Label
    Friend WithEvents lblTotalD As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents radHarddrive1 As System.Windows.Forms.RadioButton
    Friend WithEvents radHarddrive As System.Windows.Forms.RadioButton
    Friend WithEvents radWarranty3 As System.Windows.Forms.RadioButton
    Friend WithEvents radWarranty2 As System.Windows.Forms.RadioButton
    Friend WithEvents radWarranty1 As System.Windows.Forms.RadioButton
    Friend WithEvents radWarranty As System.Windows.Forms.RadioButton
    Friend WithEvents radGraphicscard1 As System.Windows.Forms.RadioButton
    Friend WithEvents radGraphicscard As System.Windows.Forms.RadioButton
    Friend WithEvents btnInvoice As System.Windows.Forms.Button

End Class
