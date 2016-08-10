Public Class frmMain

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Code to load text file on main page
        path_name = file_name.Substring(0, file_name.LastIndexOf("Elite Computer Systems\Elite Computer Systems\bin"))
        ImagePath = path_name & "Elite Computer Systems.rtf"
        rtbInfobox.LoadFile(ImagePath)
    End Sub

    
   
   
End Class
