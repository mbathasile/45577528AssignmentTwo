Imports RoadWarriors.DataLayer

Public Class EditEventForm_
    Dim _eventTitle, _eventDate, _ragistrationFee, _location, _distance

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim eventRepo = New EventRepository()
        Dim deleted = eventRepo.DeleteEvent(TitleTextBox.Text)

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
        TitleTextBox.Text = _eventTitle
        EventDateTimePicker.Value = DateTime.Parse(_eventDate)
        FeeTextBox.Text = _ragistrationFee
        LocationTextBox.Text = _location
        DistanceTextBox.Text = _distance
    End Sub

    Friend Sub GetValues(eventDt As DataTable)
        Dim eventData = From eventV In eventDt.AsEnumerable().ToArray()
        _eventTitle = eventData.ElementAt(0).ItemArray(1)
        _eventDate = eventData.ElementAt(0).ItemArray(2)
        _ragistrationFee = eventData.ElementAt(0).ItemArray(3)
        _location = eventData.ElementAt(0).ItemArray(4)
        _distance = eventData.ElementAt(0).ItemArray(5)
    End Sub
End Class