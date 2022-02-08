﻿Public Class frmAccount
    'method for enable edit
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
        btnSignOut.Enabled = False
    End Sub
    'method for disable edit
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
        btnSignOut.Enabled = True

        lblConfirm.Visible = False
        txtConfirmPassword.Visible = False
        Populate()
    End Sub
    'method for table item to data grid view
    Public Sub Populate()
        Using adp As New OleDb.OleDbDataAdapter("SELECT ID AS User_ID, username AS Username, firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_login", con)
            Dim dt As New DataTable
            adp.Fill(dt)
            grdAccounts.DataSource = dt.DefaultView
            btnEdit.Enabled = True
            grdAccounts_CellClick(Me.grdAccounts, New DataGridViewCellEventArgs(0, 0))
            grdAccounts.Sort(grdAccounts.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End Using
        txtSearch.Text = ""
    End Sub
    'Form Load
    Private Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Populate()
        grdAccounts_CellClick(Me.grdAccounts, New DataGridViewCellEventArgs(0, 0))
    End Sub
    'side panel
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
    'function for cell click to text box
    Private Sub grdAccounts_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAccounts.CellClick
        Using cmd As New OleDb.OleDbCommand("SELECT * FROM tbl_login WHERE ID = @id", con)
            cmd.Parameters.AddWithValue("@id", grdAccounts.SelectedCells(0).Value.ToString)
            Dim result = cmd.ExecuteScalar()
            If result > 0 Then
                Dim rdr As OleDb.OleDbDataReader
                rdr = cmd.ExecuteReader
                rdr.Read()
                If rdr.HasRows Then
                    txtUsername.Text = rdr.Item(1).ToString
                    txtFirstname.Text = rdr.Item(3).ToString
                    txtLastname.Text = rdr.Item(4).ToString
                    txtPassword.Text = rdr.Item(2).ToString
                    txtConfirmPassword.Text = txtPassword.Text
                End If
            End If
        End Using
    End Sub
    'function for btn edit
    Private Sub btnEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.CheckedChanged
        If btnEdit.Checked.Equals(True) Then
            EnableEdit()
        Else
            DisableEdit()
        End If
    End Sub
    'add new account btn  
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim result = dlgAddAccount.ShowDialog()
        If result = Windows.Forms.DialogResult.Yes Then
            Populate()
        End If
    End Sub
    'update btn
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Pssword do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                UpdateAccount()
                btnEdit.Checked = False
                Populate()
            End If
        End If
    End Sub
    'delete btn
    Private Sub btnRemoveAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAccount.Click
        Dim result = dlgConfirmation2.ShowDialog()
        If result = DialogResult.Yes Then
            RemoveAccount()
            btnEdit.Checked = False
            Populate()
        End If
    End Sub
    'method for Update account
    Public Sub UpdateAccount()
        Using cmd As New OleDb.OleDbCommand("UPDATE tbl_login SET [username] = @user, [password] = @pass, [firstname] = @first, [lastname] = @last WHERE ID = @id", con)
            With cmd.Parameters
                .AddWithValue("@user", txtUsername.Text)
                .AddWithValue("@pass", txtPassword.Text)
                .AddWithValue("@first", txtFirstname.Text)
                .AddWithValue("@last", txtLastname.Text)
                .AddWithValue("@id", grdAccounts.SelectedCells(0).Value)
            End With
            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Information has been updated.", "Notice", MessageBoxButtons.OK)
            End If
        End Using
    End Sub
    'method for Remove account
    Public Sub RemoveAccount()
        Using cmd As New OleDb.OleDbCommand("DELETE FROM tbl_login WHERE ID = @id", con)
            cmd.Parameters.AddWithValue("@id", grdAccounts.SelectedCells(0).Value)
            Dim result = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("User account has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
    'search btn
    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Using adp As New OleDb.OleDbDataAdapter("SELECT ID AS User_ID, username AS Username, firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_login WHERE username LIKE '%" + txtSearch.Text + "%'", con)
                Dim dt As New DataTable
                dt.Clear()
                adp.Fill(dt)
                grdAccounts.DataSource = dt.DefaultView
                grdAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If dt.Rows.Count <> 0 Then
                    btnEdit.Enabled = True
                    grdAccounts_CellClick(Me.grdAccounts, New DataGridViewCellEventArgs(0, 0))
                Else
                    DisablePreview()
                End If
            End Using
        End If
    End Sub

    Public Sub DisablePreview()
        btnEdit.Enabled = False
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtUsername.Text = ""
        txtLastname.Text = ""
    End Sub

    'function for password text box
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Enabled = True Then
            lblConfirm.Visible = True
            txtConfirmPassword.Visible = True
        End If
    End Sub
    'btn for cancel
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnEdit.Checked = False
    End Sub
    'btn for sign out
    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Dim result = dlgConfirmation3.ShowDialog()
        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class