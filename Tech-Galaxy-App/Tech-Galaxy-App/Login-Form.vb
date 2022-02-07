Imports System.Data.OleDb
Public Class frmLogin

    Public Sub ClearData()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub brnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Select()
        Else
            DoSignIn()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            DoSignIn()
        End If
    End Sub

    Public Sub DoSignIn()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand("SELECT * FROM tbl_login WHERE username=@Username AND password=@Password", con)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            Dim result = cmd.ExecuteScalar()
            If result > 0 Then
                Dim reader As OleDbDataReader
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    If reader.Item(5).ToString = "admin" Then
                        frmMain.Show()
                        Me.Close()
                    Else
                        frmUserMain.Show()
                        Me.Close()
                    End If
                End If
            Else
                MsgBox("Username or Password is incorrect, please try again.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Login Error")
                txtUsername.Select()
            End If
        End Using
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtUsername.Select()
    End Sub
End Class
