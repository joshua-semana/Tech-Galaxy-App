Imports System.Windows.Forms

Public Class dlgAddStock

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Using cmd As New OleDb.OleDbCommand("UPDATE tbl_items SET [stock] = @stock WHERE ID = @id", con)
            With cmd.Parameters
                .AddWithValue("@stock", numQuantity.Value + frmInventory.numStock.Value)
                .AddWithValue("@id", frmInventory.grdItems.SelectedCells(0).Value)
            End With
            cmd.ExecuteNonQuery()
        End Using
        frmInventory.btnFilterAll.PerformClick()
        frmInventory.grdItems_CellClick(frmInventory.grdItems, New DataGridViewCellEventArgs(0, 0))
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        numQuantity.Value = 1
        Me.Close()
    End Sub

    Private Sub dlgAddStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        numQuantity.Value = 1
    End Sub
End Class
