Imports RoadWarriors.DataLayer
Imports RoadWarriors.DataLayer.Repository

Public Class EventRegistration
    Dim racesCompetedIn = 0
    ReadOnly raceTimes = New Dictionary(Of Integer, String)
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Me.Close()
    End Sub

    Private Sub EventRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim athleteRepo = New AthleteRepository()
        Dim eventRepo = New EventRepository()

        Dim events = eventRepo.GetAllEvents()
        Dim athletes = athleteRepo.GetAllAthletes()

        For Each eventDetail In events
            EventTileComboBox.Items.Add(eventDetail.Substring(0, eventDetail.IndexOf(",")))
        Next

        For Each athlete In athletes
            AthletesComboBox.Items.Add(athlete.Substring(0, athlete.IndexOf(",")))
        Next

    End Sub

    Private Sub RaceTextBoxTextBox_TextChanged(sender As Object, e As EventArgs) Handles RaceTextBox.TextChanged
        If RaceTextBox.Text = "" Then
            racesCompetedIn = 0
        Else
            racesCompetedIn = CInt(RaceTextBox.Text)
        End If

        If racesCompetedIn > 0 Then
            For i = 1 To racesCompetedIn
                Dim race = InputBox("Enter race " & i, "Race Times")
                raceTimes.Add(i, race)
            Next i
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim eventRepo = New EventRegistrationRepository()
        Dim raceTimesResults = ""
        For Each t As Object In raceTimes
            raceTimesResults &= t.ToString().Replace(",", ";")
        Next
        Dim saved = 0
        If AthletesComboBox.Text <> "" And EventTileComboBox.Text <> "" And RaceTextBox.Text <> "" Then
            saved = eventRepo.SaveEventRegistration(AthletesComboBox.Text & "," & raceTimesResults)
        Else
            MsgBox("Please fill in the missing Information", MsgBoxStyle.Exclamation, "Error")
        End If


        If saved > 0 Then
            MsgBox("Data Was Saved Successfully", MsgBoxStyle.Information, "Success")
            Me.Close()
        Else
            MsgBox("Something went wrong...", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub
End Class