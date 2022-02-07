Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class dlgViewHistory

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dlgViewHistory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Using cmd As New OleDbCommand("SELECT * FROM tbl_transaction WHERE order_ID = @ID", con)
            cmd.Parameters.AddWithValue("@ID", frmHistory.grdTransactions.SelectedCells(0).Value)
            cmd.ExecuteNonQuery()
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                lblOrderNumber.Text = "Order No. #" + dt.Rows(0)(0).ToString()
                lblName.Text = "By: " + dt.Rows(0)(1).ToString()
                txtItems.Text = dt.Rows(0)(2).ToString()
                lblDate.Text = dt.Rows(0)(3).ToString()
                lblTotalPrice.Text = dt.Rows(0)(4).ToString()
                lblVAT.Text = dt.Rows(0)(5).ToString()
            End Using
        End Using
    End Sub
End Class
