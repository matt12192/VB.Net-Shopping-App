Public Class frmOrder


    Private Sub picLaptop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLaptop.Click
        'code to add laptop to order
        lstOrder.Items.Add("Laptop Inspiron N5110 i3 processor 4096MB DDR3 £430")
        sSystemTotal = 430
        strSystem = "Laptop Inspiron N5110 i3 processor 4096MB DDR3"

    End Sub

    Private Sub picLaptop_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLaptop.MouseHover
        rtfSystemDetails.Visible = True
        rtfSystemDetails.LoadFile(path_name & "Laptop.rtf")
        pic1.Image = Image.FromFile(path_name & "Laptop.jpg")

    End Sub

    Private Sub picLaptop_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLaptop.MouseLeave
        rtfSystemDetails.Clear()
        rtfSystemDetails.Visible = False
        pic1.Image = Nothing

    End Sub

    Private Sub picPc50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPc50.Click
        'code to add PC to order
        lstOrder.Items.Add("Pc Model PC50 i5 Processor 4096MB DDR3 £475")
        sSystemTotal = 475
        strSystem = "Pc Model PC50 i5 Processor 4096MB DDR3"

    End Sub

    Private Sub picPc50_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPc50.MouseHover
        rtfSystemDetails.Visible = True
        rtfSystemDetails.LoadFile(path_name & "PC50.rtf")
        pic1.Image = Image.FromFile(path_name & "PC50.jpg")


    End Sub

    Private Sub picPc50_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPc50.MouseLeave
        rtfSystemDetails.Clear()
        rtfSystemDetails.Visible = False
        pic1.Image = Nothing

    End Sub

    Private Sub picPc60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPc60.Click
        lstOrder.Items.Add("Pc Model PC60 i7 Processor 6144MB DDR3 £700")
        sSystemTotal = 700
        strSystem = "Model PC60 i7 Processor 6144MB DDR3"

    End Sub

    Private Sub picPc60_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPc60.MouseHover
        rtfSystemDetails.Visible = True
        rtfSystemDetails.LoadFile(path_name & "PC60.rtf")
        pic1.Image = Image.FromFile(path_name & "PC60.jpg")

    End Sub

    Private Sub picPc60_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPc60.MouseLeave
        rtfSystemDetails.Clear()
        rtfSystemDetails.Visible = False
        pic1.Image = Nothing

    End Sub


    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        sSubtotal = sSystemTotal + sUpgrades
        lblSubTotal.Text = Format(sSubtotal, "Currency")
        sVat = VAT(sSubtotal)
        sTotal = sSubtotal + sVat
        lblVat.Text = Format(sVat, "Currency")
        lblTotal.Text = Format(sTotal, "Currency")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstOrder.Items.Clear()
        lblSubTotal.Text = ""
        lblVat.Text = ""
        lblTotal.Text = ""

        Exit Sub

    End Sub

    Private Sub btnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoice.Click
        'Code to select the items in the list box
        For i = 0 To lstOrder.Items.Count - 1
            lstOrder.SetSelected(i, True)
        Next
        'Code to copy the selected items to the array
        selecteditems = (From i In lstOrder.SelectedItems).ToArray()

        frmInvoice.Show()
    End Sub

    
    Private Sub radWarranty_Click(sender As Object, e As System.EventArgs) Handles radWarranty.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("1 Year Collect and Return Warranty Included")
        sUpgrades = sUpgrades + 0
    End Sub

    Private Sub radWarranty1_Click(sender As Object, e As System.EventArgs) Handles radWarranty1.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("1 Year Next Day Hardware Support")
        sUpgrades = sUpgrades + 45

    End Sub

    Private Sub radWarranty2_Click(sender As Object, e As System.EventArgs) Handles radWarranty2.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("1 Year Next Day In-Home Service with Premium Phone Support")
        sUpgrades = sUpgrades + 70
    End Sub

    Private Sub radWarranty3_Click(sender As Object, e As System.EventArgs) Handles radWarranty3.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("3 Years Next Day In-Home Service with Premium Home Support")
        sUpgrades = sUpgrades + 140
    End Sub

    Private Sub radHarddrive_Click(sender As Object, e As System.EventArgs) Handles radHarddrive.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("750GB Version of same Hard Drive")
        sUpgrades = sUpgrades + 30
    End Sub

    Private Sub radHarddrive1_Click(sender As Object, e As System.EventArgs) Handles radHarddrive1.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("1TB Version of same Hard Drive")
        sUpgrades = sUpgrades + 50
    End Sub

    Private Sub radGraphicscard_Click(sender As Object, e As System.EventArgs) Handles radGraphicscard.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("2GB Version of same card")
        sUpgrades = sUpgrades + 75
    End Sub

    Private Sub radGraphicscard1_Click(sender As Object, e As System.EventArgs) Handles radGraphicscard1.Click
        'Code to add upgrade to order
        lstOrder.Items.Add("4GB Version of same card")
        sUpgrades = sUpgrades + 105
    End Sub


    
    
End Class
