Imports System.IO

Namespace Repository
    Public Class RaceResultsRepository
           'This file will be found in the bin\Debug folder of UI project 
        'RoadWarriors\RoadWarriors.UI\bin\Debug
        Dim filePath As String = "RaceResults.txt"

        Public Sub New()
            If Not File.Exists(filePath) Then
                Dim path As FileStream
                path = File.Create(filePath)
                path.Close()
            End If
        End Sub

         ' Write to a Text File
        Public Sub Save(raceResults As String)
            If File.Exists(filePath) Then
                If (String.IsNullOrEmpty(raceResults)) Then
                    Throw New ArgumentNullException("Cannot save empty race results")
                Else
                    File.AppendAllText(filePath, raceResults & vbCrLf)
                End If
            End If
        End Sub
    End Class
End NameSpace