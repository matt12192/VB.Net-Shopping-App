Public Module modVariables
    Public strTitle, strForename, strSurname, strAddress As String
    Public strTown, strCounty, strPostCode, strTelephone, strEmail As String
    Public file_name As String = Application.ExecutablePath
    Public path_name As String
    Public ImagePath As String
    Public sSystemTotal, sUpgrades, sSubtotal, sVat, sDelivery, sTotal As Single
    Public strSystem, strLocation, strDelivery As String
    Public List As Object, arrayIndex As String
    Public selecteditems As Array
    Function VAT(ByVal sSubTotal As Single)

        VAT = sSubTotal / 100 * 20
        sTotal = sSubTotal + sVat

        Return VAT

    End Function

    Public Function DeliveryValue(ByVal strLocation As String, ByVal strSystem As String)
        Select Case strLocation
            Case "London"
                If strSystem = "Laptop Inspiron N5110 i3 processor 4096MB DDR3" Then
                    sDelivery = 20
                ElseIf strSystem = "Pc Model PC50 i5 Processor 4096MB DDR3" Then
                    sDelivery = 30
                ElseIf strSystem = "Model PC60 i7 Processor 6144MB DDR3" Then
                    sDelivery = 35
                End If
            Case "England(Exclude London)"
                If strSystem = "Laptop Inspiron N5110 i3 processor 4096MB DDR3" Then
                    sDelivery = 15
                ElseIf strSystem = "Pc Model PC50 i5 Processor 4096MB DDR3" Then
                    sDelivery = 25
                ElseIf strSystem = "Model PC60 i7 Processor 6144MB DDR3" Then
                    sDelivery = 30
                End If
            Case "Wales"
                If strSystem = "Laptop Inspiron N5110 i3 processor 4096MB DDR3" Then
                    sDelivery = 25
                ElseIf strSystem = "Pc Model PC50 i5 Processor 4096MB DDR3" Then
                    sDelivery = 35
                ElseIf strSystem = "Model PC60 i7 Processor 6144MB DDR3" Then
                    sDelivery = 40
                End If
            Case "Scotland"
                If strSystem = "Laptop Inspiron N5110 i3 processor 4096MB DDR3" Then
                    sDelivery = 30
                ElseIf strSystem = "Pc Model PC50 i5 Processor 4096MB DDR3" Then
                    sDelivery = 40
                ElseIf strSystem = "Model PC60 i7 Processor 6144MB DDR3" Then
                    sDelivery = 45
                End If
            Case "Northern Ireland"
                If strSystem = "Laptop Inspiron N5110 i3 processor 4096MB DDR3" Then
                    sDelivery = 40
                ElseIf strSystem = "Pc Model PC50 i5 Processor 4096MB DDR3" Then
                    sDelivery = 50
                ElseIf strSystem = "Model PC60 i7 Processor 6144MB DDR3" Then
                    sDelivery = 55
                End If
        End Select
        Return sDelivery
    End Function
End Module
