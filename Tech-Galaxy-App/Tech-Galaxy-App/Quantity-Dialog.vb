Imports System.Windows.Forms

Public Class dlgQuantity
    'Form Load
    Private Sub dlgQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMain.Visible = True Then
            numQuantity.Maximum = frmMain.grdItems.SelectedCells(4).Value
            numQuantity.Value = 1
        Else
            numQuantity.Maximum = frmUserMain.grdItems.SelectedCells(4).Value
            numQuantity.Value = 1
        End If
    End Sub
    'btn Add
    Private Sub Add_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If numQuantity.Value > numQuantity.Maximum Then
            MessageBox.Show("The input number has exceeded the total stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If frmMain.Visible = True Then
                Using cmd As New OleDb.OleDbCommand("UPDATE tbl_items SET [stock] = @stock WHERE ID = @id", con)
                    With cmd.Parameters
                        .AddWithValue("@stock", frmMain.grdItems.SelectedCells(4).Value - numQuantity.Value)
                        .AddWithValue("@id", frmMain.grdItems.SelectedCells(0).Value)
                    End With
                    cmd.ExecuteNonQuery()
                End Using
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
                Me.Close()
            Else
                Using cmd As New OleDb.OleDbCommand("UPDATE tbl_items SET [stock] = @stock WHERE ID = @id", con)
                    With cmd.Parameters
                        .AddWithValue("@stock", frmUserMain.grdItems.SelectedCells(4).Value - numQuantity.Value)
                        .AddWithValue("@id", frmUserMain.grdItems.SelectedCells(0).Value)
                    End With
                    cmd.ExecuteNonQuery()
                End Using
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
                Me.Close()
            End If
        End If
    End Sub
    'btn Cancel
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        numQuantity.Value = 1
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class
