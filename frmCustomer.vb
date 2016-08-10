Public Class frmCustomer

    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Code to validate the customer details
        If cboTitle.Text = "" Then
            Epr1.SetError(cboTitle, "You must select a Title")
            cboTitle.Select()
            Exit Sub
        ElseIf txtForename.Text = "" Or Len(txtForename.Text) > 10 Or IsNumeric(txtForename.Text) = True Then
            Epr1.SetError(txtForename, "You must enter a name no longer than 10 characters")
            txtForename.Select()
            Exit Sub
        ElseIf txtSurname.Text = "" Or Len(txtSurname.Text) > 20 Or IsNumeric(txtSurname.Text) = True Then
            Epr1.SetError(txtSurname, "You must enter a name no longer then 20 characters")
            txtSurname.Select()
            Exit Sub
        ElseIf txtAddress.Text = "" Or Len(txtAddress.Text) > 20 Then
            Epr1.SetError(txtAddress, "You must enter an address no longer then 20 characters")
            txtAddress.Select()
            Exit Sub
        ElseIf txtTown.Text = "" Or Len(txtTown.Text) > 15 Or IsNumeric(txtTown.Text) = True Then
            Epr1.SetError(txtTown, "You must enter a Town name no longer then 15 characters")
            txtTown.Select()
            Exit Sub
        ElseIf txtCounty.Text = "" Or Len(txtCounty.Text) > 15 Or IsNumeric(txtCounty.Text) = True Then
            Epr1.SetError(txtCounty, "You must enter a name no longer then 15 characters")
            txtCounty.Select()
            Exit Sub
        ElseIf txtPostcode.Text = "" Or Len(txtPostcode.Text) > 8 Or IsNumeric(txtPostcode.Text) = True Then
            Epr1.SetError(txtPostcode, "You must enter a valid Postcode")
            txtPostcode.Select()
            Exit Sub
        ElseIf txtTelephone.Text = "" Or Len(txtTelephone.Text) > 12 Or Len(txtTelephone.Text) < 10 Or IsNumeric(txtTelephone.Text) = False Then
            Epr1.SetError(txtTelephone, "You must enter a valid telephone number")
            txtTelephone.Select()
            Exit Sub
        ElseIf txtEmail.Text = "" Or Len(txtEmail.Text) > 30 Or IsNumeric(txtEmail.Text) = True Then
            Epr1.SetError(txtEmail, "You must enter a valid Email")
            txtEmail.Select()
            Exit Sub
        End If
        Dim bSave As Byte
        'code to confirm save
        bSave = MsgBox("Customer Details have been saved!")



        'code to save the customer details
        strTitle = cboTitle.Text
        strForename = txtForename.Text
        strSurname = txtSurname.Text
        strAddress = txtAddress.Text
        strTown = txtTown.Text
        strCounty = txtCounty.Text
        strPostCode = txtPostcode.Text
        strTelephone = txtTelephone.Text
        strEmail = txtEmail.Text

    End Sub

   
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        cboTitle.Text = ""
        txtForename.Text = ""
        txtSurname.Text = ""
        txtAddress.Text = ""
        txtTown.Text = ""
        txtCounty.Text = ""
        txtPostcode.Text = ""
        txtTelephone.Text = ""
        txtEmail.Text = ""
    End Sub


    Private Sub frmCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
