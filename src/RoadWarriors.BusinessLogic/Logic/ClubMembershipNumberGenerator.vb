Imports RoadWarriors.DataLayer

Public Class ClubMembershipNumberGenerator
        'Generate a random number between 0 and 999
        Function GenerateRandomNumber()
            Static generator As Random = New Random()
            Return generator.Next(0, 999)
        End Function
        Function GetClubMembershipNumber(ByVal birthDate As String) As String
            'Member birth date
            Dim b = birthDate
            'Random number between 0 and 999
            Dim randomNumber As Integer = GenerateRandomNumber()

            'Two rightmost digits of current year
            Dim c = Date.Today.ToString("yy")
            Dim m = c & b & randomNumber

            Dim s = 0

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

        Function MembershipNumberValidator(ByVal membershipNumber As String) As Boolean
            Dim results As Boolean = False

            Dim s As Integer = 0
            For Each m In membershipNumber
                s = s + CInt(m.ToString().Replace("/", ""))
            Next

            Dim d = s Mod 10

            If d = 0 Then
                results = True
            End If

            Return results
        End Function
    End Class
