Imports System.Data.OleDb

Public Class frmHistory
    Public Sub EnableCustomDate()
        dtpFrom.Enabled = True
        dtpTo.Enabled = True
        dtpDaily.Enabled = False
    End Sub

    Public Sub DisableCustomDate()
        dtpFrom.Enabled = False
        dtpTo.Enabled = False
        dtpDaily.Enabled = True
    End Sub

    Private Sub frmHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Public Sub populate()
        Using da As New OleDbDataAdapter("SELECT order_ID As Order_ID, name AS Buyer_Name, item AS Order_Items, date AS Order_Date FROM tbl_transaction", con)
            Dim dt As New DataTable
            da.Fill(dt)
            grdTransactions.DataSource = dt.DefaultView
            grdTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grdTransactions.Sort(grdTransactions.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End Using
    End Sub

    Public Sub PopulateSales()
        Using cmd As New OleDbCommand("SELECT order_ID AS ID, date AS [Date], total AS Total, vat AS VAT FROM tbl_transaction WHERE [date] = @datee", con)
            cmd.Parameters.AddWithValue("@datee", Format(dtpDaily.Value, "short Date"))
            cmd.ExecuteNonQuery()
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                grdSales.DataSource = dt.DefaultView
                grdSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        End Using
    End Sub

    Public Sub PopulateSalesCustom()
        Using cmd As New OleDbCommand("SELECT order_ID AS ID, date AS [Date], total AS Total, vat AS VAT FROM tbl_transaction WHERE [date] BETWEEN ? AND ?", con)
            cmd.Parameters.AddWithValue("@1", Format(dtpFrom.Value, "short Date"))
            cmd.Parameters.AddWithValue("@2", Format(dtpTo.Value, "short Date"))
            cmd.ExecuteNonQuery()
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                grdSales.DataSource = dt.DefaultView
                grdSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        End Using
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Do Search
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        frmAccount.Show()
        Me.Close()
    End Sub

    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Dim result = dlgConfirmation3.ShowDialog()
        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        dlgViewHistory.ShowDialog()
    End Sub

    Private Sub btnCustom_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustom.CheckedChanged
        If btnCustom.Checked = True Then
            PopulateSalesCustom()
            EnableCustomDate()
        Else
            PopulateSales()
            DisableCustomDate()
        End If
    End Sub

    Private Sub dtpDaily_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDaily.ValueChanged
        PopulateSales()
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        PopulateSalesCustom()
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        PopulateSalesCustom()
    End Sub
End Class

'SELECT * FROM TABLE_NAME WHERE DATE_TIME_COLUMN
'BETWEEN 'STARTING_DATE_TIME' AND 'ENDING_DATE_TIME';