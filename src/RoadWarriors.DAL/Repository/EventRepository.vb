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
    Function Save(eventData As String, ByVal title As String) As Integer
        Dim count = 0
        Dim lines As List(Of String) = New List(Of String)
        If File.Exists(filePath) Then
            If (String.IsNullOrEmpty(eventData)) Then
                Throw New ArgumentNullException("Cannot save empty event")
            Else
                Dim reader As StreamReader
                reader = File.OpenText(filePath)
                While reader.Peek <> -1
                    Dim data = reader.ReadLine()
                    lines.Add(data)
                End While
                reader.Close()

                For Each line In lines
                    If line.Substring(0, line.IndexOf(",")) <> title Then
                        count = count + 1
                        File.AppendAllText(filePath, eventData & vbCrLf)
                    End If
                Next

                If lines.Count = 0 Then
                    count = count + 1
                    File.AppendAllText(filePath, eventData & vbCrLf)
                End If
            End If
        End If
        Return count
    End Function

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
    Function DeleteEvent(ByVal eventData As List(Of String), ByVal title As String) As Boolean
        Dim deleted = False
        Dim count = 0
        Dim lines As List(Of String) = New List(Of String)

        If File.Exists(filePath) Then
            If (eventData.Count = 0) Then
                Throw New ArgumentNullException("Cannot delete empty event")
            Else
                lines = eventData
                count = lines.Count
                For Each line In lines
                    If line.Substring(0, line.IndexOf(",")) <> title Then
                        count = count - 1
                        File.AppendAllText(filePath, line & vbCrLf)
                    ElseIf lines.Count = 1 Then
                        count = count - 1
                        File.Delete(filePath)
                    End If
                Next
            End If
        End If

        If count = lines.Count - 1 Then
            deleted = True
        End If

        Return deleted
    End Function


    Function FindEvents(ByVal eventData As String)
        Dim lines As List(Of String) = New List(Of String)

        If File.Exists(filePath) Then
            If (String.IsNullOrEmpty(eventData)) Then
                Throw New ArgumentNullException("Cannot delete empty event")
            Else
                Dim reader As StreamReader
                reader = File.OpenText(filePath)
                While reader.Peek <> -1
                    Dim data = reader.ReadLine()
                    lines.Add(data)
                End While
                reader.Dispose()
                reader.Close()

            End If
        End If
        Return lines

    End Function

End Class
