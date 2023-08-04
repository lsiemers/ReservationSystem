Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim LastName, FirstName, PhoneNumber, TrailerSize As String

        FirstName = txtFirstName.Text
        LastName = txtLastName.Text
        PhoneNumber = txtPhoneNumber.Text
        TrailerSize = txtSize.Text

        lstMatchingspot.Items.Add(dtpArrival.Text)

    End Sub
End Class
