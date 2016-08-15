Public Class EditEventForm_
    Dim eventName, eventDate, ragistrationFee, location, distance

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim form = New ManageEvents()
        Me.Close()
        form.Show()
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