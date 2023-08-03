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
        optTravelTrailer = New RadioButton()
        optMotorhome = New RadioButton()
        opt5thWheel = New RadioButton()
        optTent = New RadioButton()
        lblSize = New Label()
        txtSize = New TextBox()
        lblFeet = New Label()
        lstMatchingspot = New ListBox()
        lblSpots = New Label()
        lstOpenSpots = New ListBox()
        lblOpenspots = New Label()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(12, 277)
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
        ' optTravelTrailer
        ' 
        optTravelTrailer.AutoSize = True
        optTravelTrailer.Location = New Point(23, 148)
        optTravelTrailer.Name = "optTravelTrailer"
        optTravelTrailer.Size = New Size(89, 19)
        optTravelTrailer.TabIndex = 8
        optTravelTrailer.TabStop = True
        optTravelTrailer.Text = "Travel Trailer"
        optTravelTrailer.UseVisualStyleBackColor = True
        ' 
        ' optMotorhome
        ' 
        optMotorhome.AutoSize = True
        optMotorhome.Location = New Point(144, 148)
        optMotorhome.Name = "optMotorhome"
        optMotorhome.Size = New Size(89, 19)
        optMotorhome.TabIndex = 9
        optMotorhome.TabStop = True
        optMotorhome.Text = "Motorhome"
        optMotorhome.UseVisualStyleBackColor = True
        ' 
        ' opt5thWheel
        ' 
        opt5thWheel.AutoSize = True
        opt5thWheel.Location = New Point(23, 173)
        opt5thWheel.Name = "opt5thWheel"
        opt5thWheel.Size = New Size(78, 19)
        opt5thWheel.TabIndex = 10
        opt5thWheel.TabStop = True
        opt5thWheel.Text = "5th Wheel"
        opt5thWheel.UseVisualStyleBackColor = True
        ' 
        ' optTent
        ' 
        optTent.AutoSize = True
        optTent.Location = New Point(144, 173)
        optTent.Name = "optTent"
        optTent.Size = New Size(47, 19)
        optTent.TabIndex = 11
        optTent.TabStop = True
        optTent.Text = "Tent"
        optTent.UseVisualStyleBackColor = True
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblOpenspots)
        Controls.Add(lstOpenSpots)
        Controls.Add(lblSpots)
        Controls.Add(lstMatchingspot)
        Controls.Add(lblFeet)
        Controls.Add(txtSize)
        Controls.Add(lblSize)
        Controls.Add(optTent)
        Controls.Add(opt5thWheel)
        Controls.Add(optMotorhome)
        Controls.Add(optTravelTrailer)
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
    Friend WithEvents optTravelTrailer As RadioButton
    Friend WithEvents optMotorhome As RadioButton
    Friend WithEvents opt5thWheel As RadioButton
    Friend WithEvents optTent As RadioButton
    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblFeet As Label
    Friend WithEvents lstMatchingspot As ListBox
    Friend WithEvents lblSpots As Label
    Friend WithEvents lstOpenSpots As ListBox
    Friend WithEvents lblOpenspots As Label
End Class
