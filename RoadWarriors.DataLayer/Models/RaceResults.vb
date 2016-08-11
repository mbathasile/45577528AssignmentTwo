Public Class RaceResults

    Public Sub New()
        Me.FinishTimes = New Dictionary(Of Integer, String)
    End Sub

    Public Property RaceResultsID() As Integer
    Public Property RaceTitle() As String
    Public Property RacesCompleted() As Integer
    Public Property FinishTimes() As New Dictionary(Of Integer, String)

    Public Property MembershipNumber() As Integer
End Class
