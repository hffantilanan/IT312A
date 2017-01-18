Public Class frmAddUser
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SetExpirationDate()
        AddUser(txtUserID, txtFirstName, txtLastName, txtMiddleName, txtAddress, txtContactNo, txtEmail, txtUsername, txtPass, cboRole)
        AddMembership(txtUserID, Format(Date.Now, "yyyy-MM-dd"), strDate)
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class
