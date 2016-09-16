Imports RoadWarriors.DataLayer

Public Class EditEventForm_
    Dim eventName, eventDate, ragistrationFee, location, distance

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim eventRepo = New EventRepository()
        Dim eventData = String.Format("{0},{1},{2},{3},{4}", TitleTextBox.Text, EventDateTimePicker.Value, FeeTextBox.Text, LocationTextBox.Text, DistanceTextBox.Text)

        Dim list As List(Of String) = eventRepo.FindEvents(eventData)

        Dim deleted = eventRepo.DeleteEvent(list, TitleTextBox.Text)

        If deleted Then
            MsgBox("Data Was Deleted Successfully", MsgBoxStyle.Information, "Success")
            Me.Close()
        Else
            MsgBox("Data Was Not Deleted", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub EditEventForm__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleTextBox.Text = eventName
        EventDateTimePicker.Value = DateTime.Parse(eventDate)
        FeeTextBox.Text = ragistrationFee
        LocationTextBox.Text = location
        DistanceTextBox.Text = distance
    End Sub

    Friend Sub GetValues(eventValues As String)
        Dim eventData = eventValues.Split(",")
        eventName = eventData(0)
        eventDate = eventData(1)
        ragistrationFee = eventData(2)
        location = eventData(3)
        distance = eventData(4)
    End Sub
End Class