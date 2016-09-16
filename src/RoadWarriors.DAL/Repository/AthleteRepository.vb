Imports System.IO

Namespace Repository

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

        Function GetAllAthletes() As List(Of String)
            Dim line As List(Of String) = New List(Of String)
            Try
                Dim reader As StreamReader
                reader = File.OpenText(filePath)
                While reader.Peek <> -1
                    Dim data = reader.ReadLine()
                    'compare line to search for member number
                    line.Add(data)
                End While
                reader.Close()
            Catch ex As Exception
                Throw New Exception("Cannot open file!!!")
            End Try
            Return line
        End Function

        ' Read From a Text File
        Function GetAthleteBy(id As String) As String
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
        'Delete Athlete
        Public Sub DeleteAthlete(ByVal athlete As String)
            Dim searchString As String = athlete
            Dim line As String = ""
            Dim lines As List(Of String) = New List(Of String)
            Dim reader As StreamReader
            reader = File.OpenText(filePath)
            While reader.Peek <> -1
                line = reader.ReadLine()
                'compare line to search for member number
                If line.Contains(searchString) = False Then
                    lines.Add(line)
                End If
            End While
            reader.Close()
            File.WriteAllText(filePath, line & vbCrLf)
        End Sub
    End Class
End Namespace