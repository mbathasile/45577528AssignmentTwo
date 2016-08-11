Public Class Athlete

    Public Sub New()
        Me.RaceResults() = New List(Of RaceResults)
    End Sub
    Public Property MembershipNumber() As Integer
    Public Property FullName() As Integer
    Public Property BirthDate() As DateTime
    Public Property Gender() As String
    Public Property DateJoinedClub() As DateTime
    Public Property OutstandingMembershipFee() As Decimal
    Public Overridable Property RaceResults() As ICollection(Of RaceResults)

End Class
