Imports System.IO

Public Class AthleteRepository
    'This file will be found in the bin\Debug folder of UI project 
    'RoadWarriors\RoadWarriors.UI\bin\Debug
    Dim filePath As String = "Athlete.txt"

    Public Sub New()
        If Not File.Exists(filePath) Then
            Dim path As FileStream
            path = File.Create(filePath)
            path.Close()
        End If
    End Sub

    ' Write to a Text File
    Public Sub Save(athlete As String)
        If File.Exists(filePath) Then
            If (String.IsNullOrEmpty(athlete)) Then
                Throw New ArgumentNullException("Cannot save empty athlete")
            Else
                File.AppendAllText(filePath, athlete & vbCrLf)
            End If
        End If
    End Sub

    ' Read From a Text File
    Function GetAthleteBy(id As String)
        Dim line As String = ""
        Try
            Dim reader As StreamReader
            reader = File.OpenText(filePath)
            While reader.Peek <> -1
                line = reader.ReadLine()
                'compare line to search for member number
                If line.Contains(id) Then
                    Return line
                End If
            End While
            reader.Close()
        Catch ex As Exception
            Throw New Exception("Cannot open file!!!")
        End Try
        Return line
    End Function

    ' Delete a text file
    Public Sub DeleteAthlete(athlete As String)
        If File.Exists(filePath) Then

        End If
    End Sub
End Class
