Imports RoadWarriors.DataLayer

Public Class SearchEvent
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim eventRepo = New EventRepository()
        Dim isValidMember = ""
        Dim eventDt = eventRepo.GetEventBy(EventTitleTextBox.Text)
        Dim athletes = eventDt.AsEnumerable().Select(Function(d) DirectCast(d(1).ToString(), Object)).ToArray()
        If EventTitleTextBox.Text <> "" Then
            isValidMember = athletes(0)
        End If
        If isValidMember <> "" Then
            Me.Hide()
            Dim editEventFrm = New EditEventForm_()
            editEventFrm.GetValues(eventRepo.GetEventBy(EventTitleTextBox.Text))
            editEventFrm.Show()
        Else
            MsgBox("Event title does not exist/valid please enter a valid title", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub
End Class