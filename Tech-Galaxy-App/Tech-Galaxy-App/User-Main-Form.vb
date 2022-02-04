Imports System.Data.OleDb
Public Class frmUserMain

    Private Sub btnAddToOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToOrder.Click
        dlgQuantity.ShowDialog()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Do Search
        End If
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

    Private Sub frmUserMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Public Sub Populate()
        Using da As New OleDbDataAdapter("SELECT ID AS Product_ID, item_name AS Name, category AS Category, price AS Price, stock AS Stock FROM tbl_items", con)
            Dim dt As New DataTable
            da.Fill(dt)
            grdItems.DataSource = dt.DefaultView
        End Using
    End Sub
End Class