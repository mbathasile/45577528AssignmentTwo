Public Class AthleticEvent

    Public Sub New()
        Me.Athletes = New List(Of Athlete)()
    End Sub

    Public Property AthleticEventID() As Integer
    Public Property Title() As String
    Public Property EventDate() As DateTime
    Public Property RegistrationFee() As Decimal
    Public Property EventLocation() As String
    Public Property Distance() As Double

    Public Overridable Property Athletes() As ICollection(Of Athlete)
End Class
