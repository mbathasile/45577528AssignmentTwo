Public Class Athlete

    Public Sub New()
        Me.RaceResults() = New List(Of RaceResults)
    End Sub
    Public Property AthleteID As Integer
    Public Property MembershipNumber() As String
    Public Property FullName() As String
    Public Property BirthDate() As DateTime
    Public Property Gender() As String
    Public Property DateJoinedClub() As Date
    Public Property OutstandingMembershipFee() As Decimal
    Public Overridable Property RaceResults() As ICollection(Of RaceResults)

End Class
