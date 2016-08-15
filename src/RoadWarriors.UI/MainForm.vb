Imports RoadWarriors.BusinessLogic
Imports RoadWarriors.DataLayer

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f = New AthleteRepository()

        Dim athlete = New Athlete()
        athlete.BirthDate = DateTime.Today.ToString("d")

        Dim s = f.GetAthleteBy("Musa")
        Dim m = New ClubMembershipNumberGenerator()

        'MessageBox.Show("Returned value is : " & m.GetCheckDigit(athlete.BirthDate.ToString().Replace("/", "")))

       ' MessageBox.Show("Returned value is : " & m.GetCheckDigit("19890105"))
        Dim check = m.MembershipNumberValidator("15198901050010")
        If check Then
            MessageBox.Show("Yeppy !!! Found" & check)
        Else
            MessageBox.Show("Error this number dont exist" & check)
        End If
    End Sub
End Class