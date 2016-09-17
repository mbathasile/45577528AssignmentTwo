Imports System.Data.OleDb
Imports System.Globalization

Namespace Repository
    Public Class AthleteRepository
        ReadOnly _connectionString As String
        Public Sub New()
            _connectionString = Configuration.ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        End Sub

        Public Function Save(athlete As String())
            Const insertQuery As String = "INSERT INTO ATHLETE (MembershipNumber, FullName, BirthDate, Gender, DateJoinedClub, OutstandingMembershipFee)" &
                                          "VALUES(@MembershipNumber, @FullName, @BirthDate, @Gender, @DateJoinedClub, @OutstandingMembershipFee)"

            Dim birthDate As Date = Date.ParseExact(athlete(2), "dd-MM-yyyy", CultureInfo.CurrentCulture)
            Dim dateJoinedClub As Date = Date.ParseExact(athlete(3), "dd-MM-yyyy", CultureInfo.CurrentCulture)
            Dim insertCount As Integer
            Try
                Using dbConnection = New OleDbConnection(_connectionString)
                    Using sqlCmd = New OleDbCommand(insertQuery, dbConnection)
                        dbConnection.Open()
                        sqlCmd.Parameters.Add("@MembershipNumber", OleDbType.VarChar).Value = athlete(0)
                        sqlCmd.Parameters.Add("@FullName", OleDbType.VarChar).Value = athlete(1)
                        sqlCmd.Parameters.Add("@BirthDate", OleDbType.Date).Value = birthDate
                        sqlCmd.Parameters.Add("@Gender", OleDbType.VarChar).Value = athlete(4)
                        sqlCmd.Parameters.Add("@DateJoinedClub", OleDbType.Date).Value = dateJoinedClub
                        sqlCmd.Parameters.Add("@OutstandingMembershipFee", OleDbType.Currency).Value = Convert.ToDouble(athlete(5))
                        insertCount = sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                Throw New ArgumentNullException("Unexpected error! Couldn't access database", ex.Message.ToString())
            End Try

            Return insertCount
        End Function

        Public Function Upadate(athlete As String())
            Const updateQuery As String = "UPDATE ATHLETE " &
                                          "SET MembershipNumber=@member, FullName=@name, BirthDate=@bDate, Gender=@gender, DateJoinedClub=@jDate, OutstandingMembershipFee=@fee, EventId=@event " &
                                          "WHERE MembershipNumber =@member"

            Dim birthDate As Date = Date.ParseExact(athlete(2), "dd-MM-yyyy", CultureInfo.CurrentCulture)
            Dim dateJoinedClub As Date = Date.ParseExact(athlete(3), "dd-MM-yyyy", CultureInfo.CurrentCulture)
            Dim insertCount As Integer

            Using dbConnection = New OleDbConnection(_connectionString)
                Using sqlCmd = New OleDbCommand(updateQuery, dbConnection)
                    dbConnection.Open()
                    sqlCmd.Parameters.AddWithValue("@member", athlete(0))
                    sqlCmd.Parameters.AddWithValue("@name", athlete(1))
                    sqlCmd.Parameters.AddWithValue("@bDate", birthDate)
                    sqlCmd.Parameters.AddWithValue("@gender", athlete(4))
                    sqlCmd.Parameters.AddWithValue("@jDate", dateJoinedClub)
                    sqlCmd.Parameters.AddWithValue("@fee", Convert.ToDouble(athlete(5)))
                    sqlCmd.Parameters.AddWithValue("@event", 0)
                    insertCount = sqlCmd.ExecuteNonQuery()
                End Using
            End Using
            Return insertCount
        End Function

        Function GetAllAthletes() As DataTable
            Const selectQuery As String = "SELECT * FROM ATHLETE"
            Dim dt = New DataTable

            Using dbConnection = New OleDbConnection(_connectionString)
                Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                    dbConnection.Open()
                    Dim athleteDr As OleDbDataReader = sqlCmd.ExecuteReader
                    If (athleteDr.HasRows) Then
                        dt.Load(athleteDr)
                    End If
                End Using
            End Using

            Return dt
        End Function

        Function GetAthleteBy(membershipNumber As String) As DataTable
            Const selectQuery As String = "SELECT * FROM ATHLETE " &
                                          "WHERE MembershipNumber =@member"
            Dim athleteDT = New DataTable

            Using dbConnection = New OleDbConnection(_connectionString)
                Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                    dbConnection.Open()
                    sqlCmd.Parameters.Add("@member", OleDbType.VarChar).Value = membershipNumber
                    Dim athleteDR As OleDbDataReader = sqlCmd.ExecuteReader()
                    If (athleteDR.HasRows) Then
                        athleteDT.Load(athleteDR)
                    End If
                End Using
            End Using
            Return athleteDT
        End Function

        Function DeleteAthlete(ByVal memberNumber As String) As Boolean
            Dim deleted = False
            Const selectQuery As String = "DELETE * FROM ATHLETE " &
                                          "WHERE MembershipNumber =@member"
            Dim insertCount As Integer
            Using dbConnection = New OleDbConnection(_connectionString)
                Using sqlCmd = New OleDbCommand(selectQuery, dbConnection)
                    dbConnection.Open()
                    sqlCmd.Parameters.AddWithValue("@member", memberNumber)
                    insertCount = sqlCmd.ExecuteNonQuery()
                End Using
            End Using
            If insertCount > 0 Then
                deleted = True
            End If
            Return deleted
        End Function

    End Class
End Namespace




