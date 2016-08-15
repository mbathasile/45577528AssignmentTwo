Public Class ManageEvents
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim searchForm = New SearchEvent()
        Me.Hide()
        searchForm.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mainForm = New MainForm()
        Me.Close()
        mainForm.Show()
    End Sub

    Private Sub AddEvent_Btn_Click(sender As Object, e As EventArgs) Handles AddEvent_Btn.Click
        Dim addEventForm = New AddEventForm()
        Me.Hide()
        addEventForm.Show()
    End Sub
End Class