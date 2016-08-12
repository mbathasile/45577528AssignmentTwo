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

        MessageBox.Show("Returned value is : " & m.GetCheckDigit("19890105"))

    End Sub
End Class