<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSearch = New Button()
        btnConfirm = New Button()
        lblFirstName = New Label()
        lblLastName = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtPhoneNumber = New TextBox()
        lblPhoneNumber = New Label()
        radTravelTrailer = New RadioButton()
        radMotorhome = New RadioButton()
        rad5thWheel = New RadioButton()
        radTent = New RadioButton()
        lblSize = New Label()
        txtSize = New TextBox()
        lblFeet = New Label()
        lstMatchingspot = New ListBox()
        lblSpots = New Label()
        lstOpenSpots = New ListBox()
        lblOpenspots = New Label()
        dtpArrival = New DateTimePicker()
        dtpDeparture = New DateTimePicker()
        lblArriveDate = New Label()
        lblDepartureDate = New Label()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(12, 406)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(232, 32)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(310, 148)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(179, 32)
        btnConfirm.TabIndex = 1
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(23, 16)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(67, 15)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name:"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(144, 16)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(66, 15)
        lblLastName.TabIndex = 3
        lblLastName.Text = "Last Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(23, 34)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(100, 23)
        txtFirstName.TabIndex = 4
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(144, 34)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(100, 23)
        txtLastName.TabIndex = 5
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(23, 90)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(100, 23)
        txtPhoneNumber.TabIndex = 6
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(23, 72)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(91, 15)
        lblPhoneNumber.TabIndex = 7
        lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' radTravelTrailer
        ' 
        radTravelTrailer.AutoSize = True
        radTravelTrailer.Location = New Point(23, 148)
        radTravelTrailer.Name = "radTravelTrailer"
        radTravelTrailer.Size = New Size(89, 19)
        radTravelTrailer.TabIndex = 8
        radTravelTrailer.TabStop = True
        radTravelTrailer.Text = "Travel Trailer"
        radTravelTrailer.UseVisualStyleBackColor = True
        ' 
        ' radMotorhome
        ' 
        radMotorhome.AutoSize = True
        radMotorhome.Location = New Point(144, 148)
        radMotorhome.Name = "radMotorhome"
        radMotorhome.Size = New Size(89, 19)
        radMotorhome.TabIndex = 9
        radMotorhome.TabStop = True
        radMotorhome.Text = "Motorhome"
        radMotorhome.UseVisualStyleBackColor = True
        ' 
        ' rad5thWheel
        ' 
        rad5thWheel.AutoSize = True
        rad5thWheel.Location = New Point(23, 173)
        rad5thWheel.Name = "rad5thWheel"
        rad5thWheel.Size = New Size(78, 19)
        rad5thWheel.TabIndex = 10
        rad5thWheel.TabStop = True
        rad5thWheel.Text = "5th Wheel"
        rad5thWheel.UseVisualStyleBackColor = True
        ' 
        ' radTent
        ' 
        radTent.AutoSize = True
        radTent.Location = New Point(144, 173)
        radTent.Name = "radTent"
        radTent.Size = New Size(47, 19)
        radTent.TabIndex = 11
        radTent.TabStop = True
        radTent.Text = "Tent"
        radTent.UseVisualStyleBackColor = True
        ' 
        ' lblSize
        ' 
        lblSize.AutoSize = True
        lblSize.Location = New Point(23, 208)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(30, 15)
        lblSize.TabIndex = 12
        lblSize.Text = "Size:"
        ' 
        ' txtSize
        ' 
        txtSize.Location = New Point(23, 226)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(67, 23)
        txtSize.TabIndex = 13
        ' 
        ' lblFeet
        ' 
        lblFeet.AutoSize = True
        lblFeet.Location = New Point(96, 229)
        lblFeet.Name = "lblFeet"
        lblFeet.Size = New Size(15, 15)
        lblFeet.TabIndex = 14
        lblFeet.Text = "ft"
        ' 
        ' lstMatchingspot
        ' 
        lstMatchingspot.FormattingEnabled = True
        lstMatchingspot.ItemHeight = 15
        lstMatchingspot.Location = New Point(310, 34)
        lstMatchingspot.Name = "lstMatchingspot"
        lstMatchingspot.Size = New Size(179, 94)
        lstMatchingspot.TabIndex = 15
        ' 
        ' lblSpots
        ' 
        lblSpots.AutoSize = True
        lblSpots.Location = New Point(310, 16)
        lblSpots.Name = "lblSpots"
        lblSpots.Size = New Size(90, 15)
        lblSpots.TabIndex = 16
        lblSpots.Text = "Available Spots:"
        ' 
        ' lstOpenSpots
        ' 
        lstOpenSpots.FormattingEnabled = True
        lstOpenSpots.ItemHeight = 15
        lstOpenSpots.Location = New Point(573, 34)
        lstOpenSpots.Name = "lstOpenSpots"
        lstOpenSpots.Size = New Size(179, 94)
        lstOpenSpots.TabIndex = 17
        ' 
        ' lblOpenspots
        ' 
        lblOpenspots.AutoSize = True
        lblOpenspots.Location = New Point(573, 16)
        lblOpenspots.Name = "lblOpenspots"
        lblOpenspots.Size = New Size(71, 15)
        lblOpenspots.TabIndex = 18
        lblOpenspots.Text = "Open Spots:"
        ' 
        ' dtpArrival
        ' 
        dtpArrival.Location = New Point(12, 279)
        dtpArrival.Name = "dtpArrival"
        dtpArrival.Size = New Size(200, 23)
        dtpArrival.TabIndex = 19
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(10, 328)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(200, 23)
        dtpDeparture.TabIndex = 20
        ' 
        ' lblArriveDate
        ' 
        lblArriveDate.AutoSize = True
        lblArriveDate.Location = New Point(23, 261)
        lblArriveDate.Name = "lblArriveDate"
        lblArriveDate.Size = New Size(71, 15)
        lblArriveDate.TabIndex = 21
        lblArriveDate.Text = "Arrival Date:"
        ' 
        ' lblDepartureDate
        ' 
        lblDepartureDate.AutoSize = True
        lblDepartureDate.Location = New Point(22, 310)
        lblDepartureDate.Name = "lblDepartureDate"
        lblDepartureDate.Size = New Size(89, 15)
        lblDepartureDate.TabIndex = 22
        lblDepartureDate.Text = "Departure Date:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblDepartureDate)
        Controls.Add(lblArriveDate)
        Controls.Add(dtpDeparture)
        Controls.Add(dtpArrival)
        Controls.Add(lblOpenspots)
        Controls.Add(lstOpenSpots)
        Controls.Add(lblSpots)
        Controls.Add(lstMatchingspot)
        Controls.Add(lblFeet)
        Controls.Add(txtSize)
        Controls.Add(lblSize)
        Controls.Add(radTent)
        Controls.Add(rad5thWheel)
        Controls.Add(radMotorhome)
        Controls.Add(radTravelTrailer)
        Controls.Add(lblPhoneNumber)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(btnConfirm)
        Controls.Add(btnSearch)
        Name = "Form1"
        Text = "AOK Reservation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents radTravelTrailer As RadioButton
    Friend WithEvents radMotorhome As RadioButton
    Friend WithEvents rad5thWheel As RadioButton
    Friend WithEvents radTent As RadioButton
    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblFeet As Label
    Friend WithEvents lstMatchingspot As ListBox
    Friend WithEvents lblSpots As Label
    Friend WithEvents lstOpenSpots As ListBox
    Friend WithEvents lblOpenspots As Label
    Friend WithEvents dtpArrival As DateTimePicker
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents lblArriveDate As Label
    Friend WithEvents lblDepartureDate As Label
End Class
