Imports RoadWarriors.DataLayer

Public Class AddEventForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim eventRepo = New EventRepository()

        Dim title = TitleTextBox.Text
        Dim eventDate = EventDateTimePicker.Value.ToString("dd-MM-yyyy")
        Dim regFee = FeeTextBox.Text
        Dim location = LocationTextBox.Text
        Dim distance = DistanceTextBox.Text

        Dim isValid = ValidateValues(title, regFee, location, distance)

        If isValid = 0 Then
            Dim data = String.Format("{0},{1},{2},{3},{4}", title, eventDate, regFee, location, distance)
            Dim saved = eventRepo.Save(data, title)
            If saved > 0 Then
                MsgBox("Data Was Saved Successfully", MsgBoxStyle.Information, "Success")
                Me.Close()
                MsgBox("Event name already exist", MsgBoxStyle.Exclamation, "Error")
            End If
        End If

    End Sub



    Function ValidateValues(title As String, ByVal regFee As String, ByVal location As String, ByVal distance As String) As Integer
        Dim count = 0
        If title = String.Empty Then
            ErrorProvider1.SetError(TitleTextBox, "Please enter event title")
            count = count + 1
        End If

        If regFee = String.Empty Then
            ErrorProvider1.SetError(FeeTextBox, "Please enter registration fee")
            count = count + 1
        End If

        If location = String.Empty Then
            ErrorProvider1.SetError(LocationTextBox, "Please enter location")
            count = count + 1
        End If

        If distance = String.Empty Then
            ErrorProvider1.SetError(DistanceTextBox, "Please enter distance")
            count = count + 1
        End If

        Return count

    End Function
End Class