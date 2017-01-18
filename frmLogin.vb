Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub lblRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegister.Click
        frmAddUser.ShowDialog()
    End Sub
End Class
