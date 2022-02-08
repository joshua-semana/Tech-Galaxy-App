Imports System.Data.OleDb

Public Class dlgAddAccount
    'method for clear data
    Public Sub ClearData()
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        tglAsAnAdmin.Checked = False
    End Sub
    'method for add new account
    Public Sub AddAccount()
        Using cmd As New OleDb.OleDbCommand("INSERT INTO tbl_login ([username], [password], [firstname], [lastname], [status]) VALUES (?, ?, ?, ?, ?)", con)
            With cmd.Parameters
                .AddWithValue("@username", txtUsername.Text)
                .AddWithValue("@password", txtPassword.Text)
                .AddWithValue("@firstname", txtFirstname.Text)
                .AddWithValue("@lastname", txtLastname.Text)
                If tglAsAnAdmin.Checked = True Then
                    .AddWithValue("@status", "admin")
                Else
                    .AddWithValue("@status", "user")
                End If
            End With
            cmd.ExecuteReader()
        End Using
        MessageBox.Show("You have successfully created a new account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearData()
        frmAccount.Populate()
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
    'add btn
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Using cmd As New OleDbCommand("SELECT * FROM tbl_login WHERE [username] = @username", con)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.ExecuteNonQuery()
                    Using da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            AddAccount()
                        End If
                    End Using
                End Using
            End If
        End If
    End Sub
    'cancel btn
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearData()
        Me.Close()
    End Sub
End Class