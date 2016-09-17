Imports System.Data.OleDb
Imports System.Globalization

Public Class EventRepository

    ReadOnly _connectionString As String
    Public Sub New()
        _connectionString = Configuration.ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
    End Sub

    Public Function Upadate(athlete As String())
        Const updateQuery As String = "UPDATE EVENT " &
                                      "SET Title=@title, EventDate=@date, RegistrationFee=@fee, EventLocation=@location, Distance=@distance " &
                                      "WHERE Title =@title"

        Dim eventDate As Date = Date.ParseExact(athlete(1), "dd-MM-yyyy", CultureInfo.CurrentCulture)
        Dim insertCount As Integer

        Using dbConnection = New OleDbConnection(_connectionString)
            Using sqlCmd = New OleDbCommand(updateQuery, dbConnection)
                dbConnection.Open()
                sqlCmd.Parameters.AddWithValue("@title", athlete(0))
                sqlCmd.Parameters.AddWithValue("@date", eventDate)
                sqlCmd.Parameters.AddWithValue("@fee", athlete(2))
                sqlCmd.Parameters.AddWithValue("@location", athlete(3))
                sqlCmd.Parameters.AddWithValue("@distance", athlete(4))
                insertCount = sqlCmd.ExecuteNonQuery()
            End Using
        End Using
        Return insertCount
    End Function

    ReadOnly Property AllEvents As DataTable
        Get
            Const selectQuery As String = "SELECT * FROM EVENT"
            Dim dt = New DataTable

            Using dbConnection = New OleDbConnection(_connectionString)
                Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                    dbConnection.Open()
                    Dim eventDR As OleDbDataReader = sqlCmd.ExecuteReader
                    If (eventDR.HasRows) Then
                        dt.Load(eventDR)
                    End If
                End Using
            End Using
            Return dt
        End Get
    End Property

    ' Read From a Text File
    Function GetEventBy(title As String) As DataTable
        Const selectQuery As String = "SELECT * FROM EVENT " &
                                  "WHERE Title =@title"
        Dim athleteDt = New DataTable

        Using dbConnection = New OleDbConnection(_connectionString)
            Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                dbConnection.Open()
                sqlCmd.Parameters.Add("@title", OleDbType.VarChar).Value = title
                Dim athleteDr As OleDbDataReader = sqlCmd.ExecuteReader()
                If (athleteDr.HasRows) Then
                    athleteDt.Load(athleteDr)
                End If
            End Using
        End Using
        Return athleteDt
    End Function

    Function GetAllEvents() As DataTable
        Const selectQuery As String = "SELECT * FROM EVENT"
        Dim dt = New DataTable

        Using dbConnection = New OleDbConnection(_connectionString)
            Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                dbConnection.Open()
                Dim eventDr As OleDbDataReader = sqlCmd.ExecuteReader
                If (eventDr.HasRows) Then
                    dt.Load(eventDr)
                End If
            End Using
        End Using

        Return dt
    End Function

    Function DeleteEvent(ByVal title As String) As Boolean
        Dim deleted = False
        Const selectQuery As String = "DELETE * FROM EVENT " &
                                      "WHERE Title =@title"
        Dim insertCount As Integer
        Using dbConnection = New OleDbConnection(_connectionString)
            Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                dbConnection.Open()
                sqlCmd.Parameters.AddWithValue("@title", title)
                insertCount = sqlCmd.ExecuteNonQuery()
            End Using
        End Using
        If insertCount > 0 Then
            deleted = True
        End If
        Return deleted
    End Function

    Public Function Save(eventData() As String, title As String) As Object
        Const insertQuery As String = "INSERT INTO EVENT (Title, EventDate, RegistrationFee, EventLocation, Distance)" &
                                       "VALUES(@Title, @EventDate, @RegistrationFee, @EventLocation, @Distance)"

        Dim eventDate As Date = Date.ParseExact(eventData(1), "dd-MM-yyyy", CultureInfo.CurrentCulture)
        Dim insertCount As Integer

        Using dbConnection = New OleDbConnection(_connectionString)
            Using sqlCmd = New OleDbCommand(insertQuery, dbConnection)
                dbConnection.Open()
                sqlCmd.Parameters.Add("@Title", OleDbType.VarChar).Value = eventData(0)
                sqlCmd.Parameters.Add("@EventDate", OleDbType.VarChar).Value = eventDate
                sqlCmd.Parameters.Add("@RegistrationFee", OleDbType.Currency).Value = eventData(2)
                sqlCmd.Parameters.Add("@EventLocation", OleDbType.VarChar).Value = eventData(3)
                sqlCmd.Parameters.Add("@Distance", OleDbType.Integer).Value = eventData(4)
                insertCount = sqlCmd.ExecuteNonQuery()
            End Using
        End Using
        Return insertCount
    End Function
End Class
