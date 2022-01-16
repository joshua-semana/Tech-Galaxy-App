Public Class frmAccount

    Public Sub EnableEdit()
        txtFirstname.Enabled = True
        txtLastname.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtConfirmPassword.Enabled = True
        btnRemoveAccount.Visible = True
        btnSave.Visible = True
        btnCancel.Visible = True

        btnAdd.Enabled = False
        txtSearch.Enabled = False

        grdAccounts.Enabled = False

        btnMain.Enabled = False
        btnInventory.Enabled = False
        btnHistory.Enabled = False
    End Sub

    Public Sub DisableEdit()
        txtFirstname.Enabled = False
        txtLastname.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtConfirmPassword.Enabled = False
        btnRemoveAccount.Visible = False
        btnSave.Visible = False
        btnCancel.Visible = False

        btnAdd.Enabled = True
        txtSearch.Enabled = True

        grdAccounts.Enabled = True

        btnMain.Enabled = True
        btnInventory.Enabled = True
        btnHistory.Enabled = True
    End Sub

    Private Sub btnEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.CheckedChanged
        If btnEdit.Checked.Equals(True) Then
            EnableEdit()
        Else
            DisableEdit()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnEdit.Checked = False
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Do Search
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        frmHistory.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dlgAddAccount.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Pssword do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                UpdateAccount()
            End If
        End If
    End Sub

    Public Sub UpdateAccount()

    End Sub

    Private Sub btnRemoveAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAccount.Click
        Dim result = dlgConfirmation2.ShowDialog()
        If result = DialogResult.Yes Then
            'Remove Account Confirm
            btnEdit.Checked = False
        End If
    End Sub

    Public Sub RemoveAccount()

    End Sub

    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Dim result = dlgConfirmation3.ShowDialog()
        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class