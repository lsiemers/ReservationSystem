Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'make it so the entry fields are unchecked after being used! 
        'This allows us to store customers in formation in the system for future reservations

        Dim LastName, FirstName, PhoneNumber, TrailerSize, GuestInformation, TrailerType As String

        FirstName = txtFirstName.Text
        LastName = txtLastName.Text
        PhoneNumber = txtPhoneNumber.Text
        TrailerSize = txtSize.Text
        If radTravelTrailer.Checked Then
            TrailerType = "Travel-Trailer"
        ElseIf rad5thWheel.Checked Then
            TrailerType = "5thWheel"
        ElseIf radMotorhome.Checked Then
            TrailerType = "Motorhome"
        ElseIf radTent.Checked Then
            TrailerType = "Tent"
        End If

        GuestInformation = FirstName + " " + LastName + " " + PhoneNumber + " " + TrailerType
        lstMatchingspot.Items.Add(GuestInformation)
    End Sub
End Class
