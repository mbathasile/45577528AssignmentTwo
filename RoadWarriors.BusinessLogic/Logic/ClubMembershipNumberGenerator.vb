Imports RoadWarriors.DataLayer

Public Class ClubMembershipNumberGenerator
    'Generate a random number between 0 and 999
    Function GenerateRandomNumber()
        Static Generator As Random = New Random()
        Return Generator.Next(0, 999)
    End Function
    Function GetCheckDigit(ByVal birthDate As String) As String
        'Member birth date
        Dim b = birthDate.Substring(0, birthDate.IndexOf(" "))
        'Random number between 0 and 999
        Dim randomNumber As Integer = GenerateRandomNumber()
        'Two rightmost digits of current year
        Dim c = Date.Today.ToString("yy")

        Dim m = c & b & randomNumber

        Dim s As Integer = 0

        For Each mm In m
            s = s + CInt(mm.ToString())
        Next

        Dim d = s Mod 10
        Dim q As Integer

        If d = 0 Then
            q = 0
        Else
            q = (10 - d)
        End If
        m = m & q
        Return m
    End Function

    Function GenerateMembershipNumber()
        Dim membershipNumber As String

        membershipNumber = String.Format("{0}{1}{2}")

        Return membershipNumber
    End Function

End Class
