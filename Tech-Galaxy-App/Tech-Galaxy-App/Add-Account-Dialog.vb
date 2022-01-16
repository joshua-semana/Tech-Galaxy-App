Public Class dlgAddAccount

    Public Sub ClearData()
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        tglAsAnAdmin.Checked = False
    End Sub

    Public Sub AddAccount()
        'Add Account to Database
        ClearData()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                AddAccount()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearData()
        Me.Close()
    End Sub

End Class