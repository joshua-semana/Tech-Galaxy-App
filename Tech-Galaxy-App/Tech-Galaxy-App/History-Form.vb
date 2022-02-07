Imports System.Data.OleDb

Public Class frmHistory
    Public Sub EnableCustomDate()
        dtpFrom.Enabled = True
        dtpTo.Enabled = True
    End Sub

    Public Sub DisableCustomDate()
        dtpFrom.Enabled = False
        dtpTo.Enabled = False
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

    Private Sub btnCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustom.CheckedChanged
        If btnCustom.Enabled = True Then
            EnableCustomDate()
        End If
    End Sub

    Private Sub btnDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaily.Click
        DisableCustomDate()
    End Sub

    Private Sub btnWeekly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeekly.Click
        DisableCustomDate()
    End Sub

    Private Sub btnMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthly.Click
        DisableCustomDate()
    End Sub

    Private Sub btnYearly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYearly.Click
        DisableCustomDate()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        dlgViewHistory.ShowDialog()
    End Sub
End Class

'SELECT * FROM TABLE_NAME WHERE DATE_TIME_COLUMN
'BETWEEN 'STARTING_DATE_TIME' AND 'ENDING_DATE_TIME';