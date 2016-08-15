Imports RoadWarriors.DataLayer

Public Class SearchEvent
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim form = New ManageEvents()
        Me.Close()
        form.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim eventRepo = New EventRepository()
        Dim isValidMember = ""

        If EventTitleTextBox.Text <> "" Then
            isValidMember = eventRepo.GetEventeBy(EventTitleTextBox.Text)
        End If

        If isValidMember <> "" Then
            Me.Hide()
            Dim editEventFrm = New EditEventForm_()
            editEventFrm.GetValues(eventRepo.GetEventeBy(EventTitleTextBox.Text))
            editEventFrm.Show()
        Else
            MsgBox("Event title does not exist valid please enter a valid title", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class