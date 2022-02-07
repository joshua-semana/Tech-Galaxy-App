Imports System.Data.OleDb
Public Class frmInventory

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Public Sub EnableEdit()
        txtID.Enabled = True
        txtItemName.Enabled = True
        cmbCategory.Enabled = True
        txtPrice.Enabled = True
        numStock.Enabled = True
        btnSave.Visible = True
        btnCancel.Visible = True
        btnRemoveItem.Visible = True

        btnAdd.Enabled = False
        btnAddStock.Enabled = False

        txtSearch.Enabled = False
        btnFilterAll.Enabled = False
        btnFilterOthers.Enabled = False
        btnFilterMemory.Enabled = False
        btnFilterMotherboard.Enabled = False
        btnFilterPowerSupply.Enabled = False
        btnFilterProcessor.Enabled = False
        btnFilterVideoCard.Enabled = False

        grdItems.Enabled = False

        btnMain.Enabled = False
        btnHistory.Enabled = False
        btnSetting.Enabled = False
    End Sub
    Public Sub DisableEdit()
        txtID.Enabled = False
        txtItemName.Enabled = False
        cmbCategory.Enabled = False
        txtPrice.Enabled = False
        numStock.Enabled = False
        btnSave.Visible = False
        btnCancel.Visible = False
        btnRemoveItem.Visible = False

        btnAdd.Enabled = True
        btnAddStock.Enabled = True

        txtSearch.Enabled = True
        btnFilterAll.Enabled = True
        btnFilterOthers.Enabled = True
        btnFilterMemory.Enabled = True
        btnFilterMotherboard.Enabled = True
        btnFilterPowerSupply.Enabled = True
        btnFilterProcessor.Enabled = True
        btnFilterVideoCard.Enabled = True

        grdItems.Enabled = True

        btnMain.Enabled = True
        btnHistory.Enabled = True
        btnSetting.Enabled = True
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
        btnInventory.PerformClick()
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        frmHistory.Show()
        Me.Close()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        frmAccount.Show()
        Me.Close()
    End Sub

    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Dim result = dlgConfirmation3.ShowDialog()
        If result = DialogResult.Yes Then
            con.Close()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dlgAddItem.ShowDialog()
    End Sub

    Private Sub btnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStock.Click
        dlgAddStock.ShowDialog()
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please Enter Number Only", vbCritical)
        End If
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        Dim result = dlgConfirmation2.ShowDialog()
        If result = DialogResult.Yes Then
            RemoveItem()
            btnEdit.Checked = False
        End If
    End Sub

    Public Sub RemoveItem()
        Using cmd As New OleDbCommand("DELETE FROM tbl_exampleitems WHERE [ID] = @ID", con)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = txtID.Text.Trim
            If cmd.ExecuteNonQuery() Then
                Dim result = MessageBox.Show("Item Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = DialogResult.OK Then
                    btnCancel.PerformClick()
                End If
                Exit Sub
            End If
        End Using
    End Sub

    Public Sub Populate()
        Using da As New OleDbDataAdapter("SELECT ID AS Product_ID, item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items", con)
            Dim dt As New DataTable
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
        End Using
    End Sub
    'filters
    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Using da As New OleDbDataAdapter("SELECT ID AS Product_ID, item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE item_name LIKE '%" + txtSearch.Text + "%'", con)
                Dim dt As New DataTable
                dt.Clear()
                da.Fill(dt)
                grdItems.DataSource = dt.DefaultView
                grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        End If
    End Sub

    Public Sub Filter(ByVal name As String)
        Using da As New OleDbDataAdapter("SELECT ID AS Product_ID, item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + name + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub

    Private Sub btnFilterAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterAll.Click
        Populate()
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterProcessor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterProcessor.Click
        Filter("Processor")
    End Sub
    Private Sub btnFilterMotherboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterMotherboard.Click
        Filter("Motherboard")
    End Sub
    Private Sub btnFilterVideoCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterVideoCard.Click
        Filter("Video Card")
    End Sub
    Private Sub btnFilterMemory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterMemory.Click
        Filter("Memory")
    End Sub
    Private Sub btnFilterPowerSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterPowerSupply.Click
        Filter("Power Supply")
    End Sub
    Private Sub btnFilterOthers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterOthers.Click
        Filter("Processor")
    End Sub

    Private Sub grdItems_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdItems.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = grdItems.Rows(index)
            txtID.Text = row.Cells(0).Value.ToString.Substring(3)
            txtItemName.Text = row.Cells(1).Value.ToString
            cmbCategory.Text = row.Cells(2).Value.ToString
            txtPrice.Text = row.Cells(3).Value.ToString
            numStock.Value = row.Cells(4).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using cmd As New OleDbCommand("UPDATE tbl_exampleitems SET [item_name] = '" & txtItemName.Text & "', [category] = '" & cmbCategory.Text & "', [price] = '" & txtPrice.Text & "', [stock] = '" & numStock.Value & "' WHERE [ID] = @ID", con)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = txtID.Text.Trim
            cmd.ExecuteNonQuery()
            Dim result = MessageBox.Show("Item Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                btnCancel.PerformClick()
            End If
        End Using
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        Populate()
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