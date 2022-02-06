Imports System.Windows.Forms

Public Class dlgAddStock

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Using cmd As New OleDb.OleDbCommand("UPDATE tbl_items SET [stock] = @stock WHERE ID = @id", con)
            With cmd.Parameters
                .AddWithValue("@stock", numQuantity.Value + frmInventory.numStock.Value)
                .AddWithValue("@id", frmInventory.grdItems.SelectedCells(0).Value)
            End With
            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Information has been updated.", "Notice", MessageBoxButtons.OK)
            End If
        End Using
        frmInventory.btnFilterAll.PerformClick()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        numQuantity.Value = 1
        Me.Close()
    End Sub
End Class
