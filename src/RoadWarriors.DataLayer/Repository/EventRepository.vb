Imports System.IO

Public Class EventRepository
    'This file will be found in the bin\Debug folder of UI project 
    'RoadWarriors\RoadWarriors.UI\bin\Debug
    Dim filePath As String = "Event.txt"
    Public Sub New()
        If Not File.Exists(filePath) Then
            Dim path As FileStream
            path = File.Create(filePath)
            path.Close()
        End If
    End Sub

    ' Write to a Text File
    Public Sub Save(eventData As String)

        If File.Exists(filePath) Then
            If (String.IsNullOrEmpty(eventData)) Then
                Throw New ArgumentNullException("Cannot save empty event")
            Else
                File.AppendAllText(filePath, eventData & vbCrLf)
            End If
        End If

    End Sub


    Function GetAllEvents() As List(Of String)
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
    Function GetEventeBy(title As String) As String
        Dim line As String = ""
        Try
            Dim reader As StreamReader
            reader = File.OpenText(filePath)
            While reader.Peek <> -1
                line = reader.ReadLine()
                If line.Contains(title) Then
                    Return line
                End If
            End While
            reader.Close()
        Catch ex As Exception
            Throw New Exception("Cannot open file!!!")
        End Try
        Return line
    End Function

End Class