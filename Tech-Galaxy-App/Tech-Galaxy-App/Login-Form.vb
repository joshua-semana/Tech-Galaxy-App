Public Class frmLogin

    Public Sub ClearData()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub brnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DoSignIn()
        End If
    End Sub

    Public Sub DoSignIn()
        con.Open()
        Using cmd As OleDbCommand
        con.Close()
        frmMain.Show()
        Me.Close()
    End Sub
End Class
