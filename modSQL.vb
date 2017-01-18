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

    'Add User
    Public Sub AddUser(ByVal iUserID As TextBox, ByVal iFirstName As TextBox, ByVal iLastName As TextBox, ByVal iMiddleName As TextBox, ByVal iAddress As TextBox, ByVal iContactNo As TextBox, ByVal iEmail As TextBox, ByVal iUsername As TextBox, ByVal iPassword As TextBox, ByVal iRole As ComboBox)
        strAddUserQuery = "INSERT INTO dblibrary.tblusers(UserID, FirstName, LastName, " & _
            "MiddleName, Address, ContactNo, EmailAdd, username, password, role) " & _
            "VALUES(@iUserID, @iFirstName, @iLastName, @iMiddleName, @iAddress, " & _
            "@iContactNo, @iEmail, @iUsername, @iPassword, @iRole)"
        Try
            If Not conn Is Nothing Then conn.Close()
            strCmd = New MySqlCommand(strAddUserQuery, conn)

            strCmd.Parameters.AddWithValue("@iUserID", iUserID.Text)
            strCmd.Parameters.AddWithValue("@iFirstName", iFirstName.Text)
            strCmd.Parameters.AddWithValue("@iLastName", iLastName.Text)
            strCmd.Parameters.AddWithValue("@iMiddleName", iMiddleName.Text)
            strCmd.Parameters.AddWithValue("@iAddress", iAddress.Text)
            strCmd.Parameters.AddWithValue("@iContactNo", iContactNo.Text)
            strCmd.Parameters.AddWithValue("@iEmail", iEmail.Text)
            strCmd.Parameters.AddWithValue("@iUsername", iUsername.Text)
            strCmd.Parameters.AddWithValue("@iPassword", iPassword.Text)
            strCmd.Parameters.AddWithValue("@iRole", iRole.Text)

            da.SelectCommand = strCmd
            dbDataSet.Clear()
            da.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            da.Update(dbDataSet)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Adding New User: " & ex.Message, MsgBoxStyle.Critical, "Error")
            conn.Close()
        End Try
    End Sub


    'Add Membership
    Public Sub AddMembership(ByVal iUserID As TextBox, ByVal iDateJoined As String, ByVal iValidity As String)
        strAddMembershipQuery = "INSERT INTO dblibrary.tblmembership(UserID, DateJoined, Validity) " & _
            "VALUES(@iUserID, @iDateJoined, @iValidity)"
        Try
            If Not conn Is Nothing Then conn.Close()
            strCmd = New MySqlCommand(strAddMembershipQuery, conn)

            strCmd.Parameters.AddWithValue("@iUserID", iUserID.Text)
            strCmd.Parameters.AddWithValue("@iDateJoined", iDateJoined)
            strCmd.Parameters.AddWithValue("@iValidity", iValidity)


            da.SelectCommand = strCmd
            dbDataSet.Clear()
            da.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            da.Update(dbDataSet)
            conn.Close()
            MsgBox("Record Saved!", MsgBoxStyle.Information, "Successful")
        Catch ex As Exception
            MsgBox("Error Adding Membership Info: " & ex.Message, MsgBoxStyle.Critical, "Error")
            conn.Close()
        End Try
    End Sub
End Module
