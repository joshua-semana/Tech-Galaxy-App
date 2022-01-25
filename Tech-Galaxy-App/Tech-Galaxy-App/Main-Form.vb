Imports System.Data.OleDb
Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populate()
        lblDate.Text = Format(Date.Now(), "D")
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
            Dim item As String = grdItems.SelectedCells(0).Value
            Dim subtotal As Integer = grdItems.SelectedCells(2).Value * quantity
            Dim total As Integer = subtotal + lblTotal.Text
            If quantity <> 0 Then
                grdOrders.Rows.Add(quantity, item, subtotal)
                lblTotal.Text = total
            End If
        End If
    End Sub

    Private Sub btnClearOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOrder.Click
        Dim result = dlgConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            grdOrders.Rows.Clear()
            lblTotal.Text = 0
            populate()
        End If
    End Sub

    Private Sub grdOrders_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdOrders.RowsAdded
        DisableNavigation()
    End Sub

    Private Sub grdOrders_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdOrders.RowsRemoved
        If grdOrders.Rows.Count < 1 Then
            EnableNavigation()
        End If
    End Sub

    Private Sub btnRemoveOrderItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOrderItem.Click
        Dim result = dlgConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            If grdOrders.Rows.Count > 0 Then
                lblTotal.Text = lblTotal.Text - grdOrders.SelectedCells(2).Value
                grdOrders.Rows.Remove(grdOrders.SelectedRows(0))
            End If
        End If
    End Sub
    'method for table item to data grid view
    Public Sub populate()
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items", con)
            Dim dt As New DataTable
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
    Private Sub btnFilterAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterAll.Click
        populate()
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterProcessor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterProcessor.Click
        Dim r As String = "Processor"
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + r + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterMotherboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterMotherboard.Click
        Dim r As String = "Motherboard"
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + r + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterVideoCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterVideoCard.Click
        Dim r As String = "Video Card"
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + r + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterMemory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterMemory.Click
        Dim r As String = "Memory"
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + r + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterPowerSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterPowerSupply.Click
        Dim r As String = "Power Supply"
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + r + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
    Private Sub btnFilterChassis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterChassis.Click
        Dim r As String = "Chassis"
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items WHERE category LIKE '%" + r + "%'", con)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
        txtSearch.Text = ""
    End Sub
End Class