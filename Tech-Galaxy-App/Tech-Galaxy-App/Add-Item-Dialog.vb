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
            Using cmd As New OleDbCommand("SELECT * FROM tbl_items WHERE [ID] = @id", con)
                cmd.Parameters.AddWithValue("@id", lblPrefix.Text.Substring(0, 3).ToString + txtID.Text.ToString)
                cmd.ExecuteNonQuery()
                Using da As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        AddItem()
                    End If
                End Using
            End Using
        End If
    End Sub

    Public Sub AddItem()
        Using cmd As New OleDbCommand("INSERT INTO tbl_items ([ID], [item_name], [category], [price], [stock]) VALUES(@ID, @item_name, @category, @price, @stock)", con)
            With cmd.Parameters
                .AddWithValue("@ID", lblPrefix.Text.Substring(0, 3) + txtID.Text)
                .AddWithValue("@item_name", txtItemName.Text)
                .AddWithValue("@category", cmbCategory.Text)
                .AddWithValue("@price", txtPrice.Text)
                .AddWithValue("@stock", numStock.Value)
            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("You have successfully created a new item.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
        frmInventory.btnFilterAll.PerformClick()
        frmInventory.grdItems_CellClick(frmInventory.grdItems, New DataGridViewCellEventArgs(0, 0))
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearData()
        Me.Close()
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress, txtID.KeyPress
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
