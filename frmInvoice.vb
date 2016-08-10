Public Class frmInvoice

    Private Sub frmInvoice_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim count As Integer
        For count = 0 To frmOrder.lstOrder.Items.Count - 2
            lstOrder.Items.Add(frmOrder.lstOrder.Items(count))
        Next
        'Code to Populate the customer Details
        lblTitle1.Text = strTitle
        lblForename.Text = strForename
        lblSurname.Text = strSurname
        lblAddress.Text = strAddress
        lblTown.Text = strTown
        lblPostcode.Text = strPostCode
        lblTelephone.Text = strTelephone
        lblEmail.Text = strEmail

        lblVat.Text = Format(sVat, "Currency")
        lblTotal.Text = Format(sTotal, "Currency")

        'Code to display the items from the array in the list box on the invoice form.

        For Each selecteditem In selecteditems
            Me.lstOrder.Items.Add(selecteditem)
        Next
    End Sub



    
    Private Sub frmInvoice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Code verifying customer details being entered
        If IsNothing(strTitle) = True Then
            MsgBox("No Customer Details")
            frmCustomer.Show()
            Me.Hide()

        End If
    End Sub

    

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        frmOrder.Show()
        Me.Hide()
    End Sub

    

    Private Sub radLondon_Click(sender As Object, e As System.EventArgs) Handles radLondon.Click

        strLocation = "London"
        lblDelivery.Text = (Format(DeliveryValue(strLocation, strSystem), "Currency"))


    End Sub

    
    
    Private Sub radEngland_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radEngland.CheckedChanged
        strLocation = "England(Exclude London)"
        lblDelivery.Text = (Format(DeliveryValue(strLocation, strSystem), "Currency"))
    End Sub

    Private Sub radWales_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radWales.CheckedChanged
        strLocation = "Wales"
        lblDelivery.Text = (Format(DeliveryValue(strLocation, strSystem), "Currency"))
    End Sub

    Private Sub radScotland_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radScotland.CheckedChanged
        strLocation = "Scotland"
        lblDelivery.Text = (Format(DeliveryValue(strLocation, strSystem), "Currency"))
    End Sub

    Private Sub radNorthernireland_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radNorthernireland.CheckedChanged
        strLocation = "Northern Ireland"
        lblDelivery.Text = (Format(DeliveryValue(strLocation, strSystem), "Currency"))
    End Sub
End Class
