Imports MySql.Data.MySqlClient
Module modSQL
    'Database Connection
    Public Sub connect()
        Try
            strServer = "localhost"
            strDatabaseName = "dblibrary"
            strUser = "admin"
            strPass = "admin"
            If Not conn Is Nothing Then conn.Close()
            conn = New MySqlConnection
            conn.ConnectionString = String.Format("server={0}; user id={1}; " & _
                                                  "password={2}; database={3};", _
                                                  strServer, strUser, strPass, _
                                                  strDatabaseName)
            conn.Open()
            With frmLogin
                .lblConnection.Text = "Connected"
                .lblConnection.ForeColor = Color.Green
            End With
        Catch ex As Exception
            MsgBox("Error connection: " & ex.Message, MsgBoxStyle.Critical, "Error")
            With frmLogin
                .lblConnection.Text = "Disconnected"
                .lblConnection.ForeColor = Color.Red
            End With
        End Try
    End Sub
End Module
