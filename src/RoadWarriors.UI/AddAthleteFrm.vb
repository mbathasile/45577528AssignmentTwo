Imports RoadWarriors.BusinessLogic
Imports RoadWarriors.DataLayer.Repository

Public Class AddAthleteFrm

    Dim racesCompetedIn = 0
    ReadOnly raceTimes = New Dictionary(Of Integer, String)

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Close()
    End Sub

    Private Sub BDDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles BDDateTimePicker.ValueChanged
        Dim mebershipNumberGenerator = New ClubMembershipNumberGenerator()
        Dim birthDate = BDDateTimePicker.Value.ToString("ddMMyyyy")
        MembershipNumberLabel.Text = mebershipNumberGenerator.GetClubMembershipNumber(birthDate)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim athleteRepo = New AthleteRepository()
        Dim raceResultsRepo = New RaceResultsRepository()


        Dim membershipNumber = MembershipNumberLabel.Text
        Dim fullName = FullNameTextBox.Text
        Dim birthDate = BDDateTimePicker.Value.ToString("dd/MM/yyyy")
        Dim dateJoined = DJoinedDateTimePicker.Value.ToString("dd/MM/yyyy")
        Dim membershipFee = FeeTextBox.Text
        Dim raceTimesResults = ""
        Dim gender As String
        If MaleRadioBtn.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        For Each t As Object In raceTimes
            raceTimesResults &= t.ToString().Replace(",", ";")
            raceResultsRepo.Save(membershipNumber & "," & raceTimesResults)
        Next

        Dim isValid = ValidateValues(membershipNumber, fullName)

        Dim data = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}", membershipNumber, fullName, birthDate, dateJoined, gender, membershipFee, racesCompetedIn, raceTimesResults)

        If isValid = 0 Then
            athleteRepo.Save(data)
            MsgBox("Data Was Saved Successfully", MsgBoxStyle.Information, "Success")
            Me.Close()
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

    Private Sub RacesTextBox_TextChanged(sender As Object, e As EventArgs) Handles RacesTextBox.TextChanged
        If RacesTextBox.Text = "" Then
            racesCompetedIn = 0
        Else
            racesCompetedIn = CInt(RacesTextBox.Text)
        End If

        If racesCompetedIn > 0 Then
            For i = 1 To racesCompetedIn
                Dim race = InputBox("Enter race " & i, "Race Times")
                raceTimes.Add(i, race)
                RaceTimesListBox.Items.Add("Race " & i & " Time : " & race)
            Next i
        Else
            RaceTimesListBox.Items.Add("No races competed")
        End If
    End Sub

End Class