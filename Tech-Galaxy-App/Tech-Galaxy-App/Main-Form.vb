Imports System.Data.OleDb
Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Populate grdItems
        'btnMain.PerformClick()
        populate()
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
        dlgQuantity.ShowDialog()
        grdOrders.Rows.Add(New String() {"AMD Ryzen 3", "P1,000", "5"})
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Do Search
        End If
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

    Private Sub btnClearOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOrder.Click
        Dim result = dlgConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            grdOrders.Rows.Clear()
        End If
    End Sub

    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Dim result = dlgConfirmation3.ShowDialog()
        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
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
        If grdOrders.Rows.Count > 0 Then
            grdOrders.Rows.Remove(grdOrders.SelectedRows(0))
        End If
    End Sub

    Public Sub populate()
        Using da As New OleDbDataAdapter("SELECT item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items", con)
            Dim dt As New DataTable
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
            grdItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        populate()
    End Sub
End Class