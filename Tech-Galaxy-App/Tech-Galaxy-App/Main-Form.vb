Imports System.Data.OleDb
Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populate()
        lblDate.Text = Format(Date.Now(), "D")
        StoreDate = Date.Now.ToString("MM-dd-yyyy")
    End Sub

    Public Sub EnableNavigation()
        btnInventory.Enabled = True
        btnHistory.Enabled = True
        btnSetting.Enabled = True
    End Sub

    Public Sub DisableNavigation()
        btnInventory.Enabled = False
        btnHistory.Enabled = False
        btnSetting.Enabled = False
    End Sub

    Private Sub btnAddToOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToOrder.Click
        Dim result = dlgQuantity.ShowDialog()
        If result = Windows.Forms.DialogResult.Yes Then
            Dim quantity As Integer = dlgQuantity.numQuantity.Value
            Dim item As String = grdItems.SelectedCells(1).Value
            Dim subtotal As Integer = grdItems.SelectedCells(3).Value * quantity
            Dim total As Integer = subtotal + lblTotal.Text
            Dim vat As Integer = total * 0.02
            Dim Gtotal As Integer = vat + total
            Dim id As String = grdItems.SelectedCells(0).Value
            If quantity <> 0 Then
                grdOrders.Rows.Add(quantity, id, item, subtotal)
                lblTotal.Text = total
                lblVAT.Text = vat
                lblGtotal.Text = Gtotal
                btnFilterAll.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnRemoveOrderItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOrderItem.Click
        Dim currentstock As Integer
        Dim result = dlgConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            If grdOrders.Rows.Count > 0 Then
                lblTotal.Text = lblTotal.Text - grdOrders.SelectedCells(3).Value
                Dim vat As Integer = lblTotal.Text * 0.02
                Dim Gtotal As Integer = vat + lblTotal.Text
                lblVAT.Text = vat
                lblGtotal.Text = Gtotal
                Using cmd As New OleDbCommand("SELECT stock FROM tbl_items WHERE ID=@ID", con)
                    cmd.Parameters.AddWithValue("@ID", grdOrders.SelectedCells(1).Value)
                    Dim result1 = cmd.ExecuteScalar()
                    If result1 > 0 Then
                        Dim reader As OleDbDataReader
                        reader = cmd.ExecuteReader
                        reader.Read()
                        If reader.HasRows Then
                            currentstock = reader.Item(0)
                        End If
                    End If
                End Using
                Using cmd As New OleDb.OleDbCommand("UPDATE tbl_items SET [stock] = @stock WHERE ID = @id", con)
                    With cmd.Parameters
                        .AddWithValue("@stock", currentstock + grdOrders.SelectedCells(0).Value)
                        .AddWithValue("@id", grdOrders.SelectedCells(1).Value)
                    End With
                    cmd.ExecuteNonQuery()
                End Using
                grdOrders.Rows.Remove(grdOrders.SelectedRows(0))
                btnFilterAll.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnClearOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOrder.Click
        Dim result = dlgConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            grdOrders.Rows.Clear()
            lblTotal.Text = 0
            lblVAT.Text = 0
            lblGtotal.Text = 0
            populate()
        End If
    End Sub

    Private Sub grdOrders_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdOrders.RowsAdded
        DisableNavigation()
        btnCheckOut.Enabled = True
    End Sub

    Private Sub grdOrders_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdOrders.RowsRemoved
        If grdOrders.Rows.Count < 1 Then
            EnableNavigation()
            btnCheckOut.Enabled = False
        End If
    End Sub

    
    'method for table item to data grid view
    Public Sub populate()
        Using da As New OleDbDataAdapter("SELECT ID, item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items", con)
            Dim dt As New DataTable
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grdItems.Sort(grdItems.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End Using
    End Sub
    'side panel
    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        populate()
    End Sub
    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.Show()
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
    'search btn
    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE item_name LIKE '%" + txtSearch.Text + "%'", con)
                Dim dt As New DataTable
                dt.Clear()
                da.Fill(dt)
                grdItems.DataSource = dt.DefaultView
                grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        End If
    End Sub
    'filters
    Public Sub Filter(ByVal name As String)
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + name + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterAll.Click
        populate()
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
        Filter("Others")
    End Sub

    Private Sub btnCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click
        Dim result = dlgOrderName.ShowDialog()
        If result = DialogResult.Yes Then
            Dim result1 = dlgOrderComplete.ShowDialog()
            If result1 = DialogResult.Yes Then
                btnFilterAll.PerformClick()
            End If
        End If
    End Sub
End Class