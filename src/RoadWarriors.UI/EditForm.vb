Imports System.IO
Imports RoadWarriors.DataLayer
Imports RoadWarriors.DataLayer.Repository

Public Class EditForm

    Dim membershipNumber, fullName, birthDate, dateJoined, membershipFee, racesCompetedIn, raceTimes, athleteId

    Private Sub AddNewRaceTimesBtn_Click(sender As Object, e As EventArgs) Handles AddNewRaceTimesBtn.Click

    End Sub
    'under construction
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim athleteRepo = New AthleteRepository()
        Dim raceResultsRepo = New RaceResultsRepository()

        membershipNumber = MembershipNumberLabel.Text
        fullName = FullNameTextBox.Text
        birthDate = BDDateTimePicker.Value.ToString("dd/MM/yyyy")
        dateJoined = DJoinedDateTimePicker.Value.ToString("dd/MM/yyyy")
        membershipFee = FeeTextBox.Text

        Dim gender As String
        If MaleRadioBtn.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        Dim isValid = ValidateValues(membershipNumber, fullName)

        If isValid = 0 Then

            Dim athleteData() As String = {membershipNumber, fullName, birthDate, dateJoined, gender, membershipFee}
            If (athleteRepo.Save(athleteData) > 0) Then
                MsgBox("Data Was Saved Successfully", MsgBoxStyle.Information, "Success")
            Else
                MsgBox("Athlete not saved!", MsgBoxStyle.Exclamation, "Error")
            End If
            Close()
            MsgBox("Data Was Saved Successfully", MsgBoxStyle.Information, "Success")
        End If

    End Sub

    Function ValidateValues(membershipNumber As String, fullName As String) As Integer
        Dim count = 0
        If membershipNumber = String.Empty Then
            ErrorProvider1.SetError(MembershipNumberLabel, "Please select date of birth")
            count = count + 1
        End If

        If fullName = String.Empty Then
            ErrorProvider1.SetError(FullNameTextBox, "Please enter full name")
            count = count + 1
        End If

        Return count

    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
    End Sub

    Public Sub GetValues(athleteDt As DataTable)
        Dim athleteData = From athlete In athleteDt.AsEnumerable().ToList()

        athleteId = athleteData.ElementAt(0).ItemArray(0)
        membershipNumber = athleteData.ElementAt(0).ItemArray(1)
        fullName = athleteData.ElementAt(0).ItemArray(2)
        birthDate = athleteData.ElementAt(0).ItemArray(3).ToShortDateString()
        dateJoined = athleteData.ElementAt(0).ItemArray(5).ToShortDateString()

        If athleteData.ElementAt(0).ItemArray(4) = "Male" Then
            MaleRadioBtn.Checked = True
        Else
            FemaleRadioBtn.Checked = True
        End If

        membershipFee = athleteData.ElementAt(0).ItemArray(6)
    End Sub

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MembershipNumberLabel.Text = membershipNumber
        FullNameTextBox.Text = fullName
        BDDateTimePicker.Value = DateTime.Parse(birthDate)
        FeeTextBox.Text = membershipFee
        RacesTextBox.Text = racesCompetedIn
        DJoinedDateTimePicker.Value = DateTime.Parse(dateJoined)
        Dim raceT = raceTimes.Split("][")

        For Each s In raceT
            RaceTimesListBox.Items.Add(s & "]")
        Next
    End Sub
End Class