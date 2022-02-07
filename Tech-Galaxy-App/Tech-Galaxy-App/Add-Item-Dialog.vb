Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class dlgAddItem

    Public Sub ClearData()
        lblPrefix.Text = "Prc -"
        txtID.Text = ""
        txtItemName.Text = ""
        cmbCategory.Text = ""
        txtPrice.Text = ""
        numStock.Value = 1
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtID.Text = "" Or txtItemName.Text = "" Or cmbCategory.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Please enter the necessary information to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddItem()
        End If
    End Sub

    Public Sub AddItem()
        ClearData()
        Using cmd As New OleDbCommand("INSERT INTO tbl_exampleitems ([item_name],[category],[price],[stock]) VALUES('" & txtItemName.Text & "','" & cmbCategory.Text & "','" & txtPrice.Text & "','" & numStock.Value & "')", con)
            If txtItemName.Text = Nothing And cmbCategory.Text = Nothing And txtPrice.Text = Nothing And numStock.Value = 0 Then
                MsgBox("Please fill the required Information", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            MsgBox("Data has been inserted successfully", MsgBoxStyle.Information)
            cmd.ExecuteNonQuery()
        End Using
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearData()
        Me.Close()
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please Enter Number Only", vbCritical)
        End If
    End Sub

    Private Sub dlgAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearData()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        Select Case cmbCategory.SelectedItem.ToString
            Case "Processor"
                lblPrefix.Text = "Prc -"
            Case "Motherboard"
                lblPrefix.Text = "Mob - "
            Case "Video Card"
                lblPrefix.Text = "Vid -"
            Case "Memory"
                lblPrefix.Text = "Mem - "
            Case "Power Supply"
                lblPrefix.Text = "Pow -"
            Case "Others"
                lblPrefix.Text = "Oth - "
        End Select
    End Sub
End Class
