Imports System.IO

Public Class EventRegistrationRepository
    'This file will be found in the bin\Debug folder of UI project 
    'RoadWarriors\RoadWarriors.UI\bin\Debug
    Dim filePath As String = "EventRegistrationData.txt"

    Public Sub New()
        If Not File.Exists(filePath) Then
            Dim path As FileStream
            path = File.Create(filePath)
            path.Close()
        End If
    End Sub

    Function SaveEventRegistration(eventData As String) As Integer
        Dim count = 0
        Dim lines As List(Of String) = New List(Of String)
        If File.Exists(filePath) Then
            If (String.IsNullOrEmpty(eventData)) Then
                Throw New ArgumentNullException("Cannot save empty event")
            Else
                count = count + 1
                File.AppendAllText(filePath, eventData & vbCrLf)
            End If
        End If
        Return count
    End Function
End Class