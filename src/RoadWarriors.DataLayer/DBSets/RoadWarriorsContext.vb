Imports System.Data.Entity

Public Class RoadWarriorsContext
    Inherits DbContext

    Public Property Athletes() As DbSet(Of Athlete)
    Public Property AthleticEvents() As DbSet(Of AthleticEvent)
    Public Property RaceResults() As DbSet(Of RaceResults)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
