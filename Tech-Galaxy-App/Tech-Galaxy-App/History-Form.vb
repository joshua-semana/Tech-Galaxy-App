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
        With grdTransactions
            .Rows.Add(New String() {"#001", "Joshua", "1x AMD Ryzen 3, 1x Motherbaord, 2x Memory, 1x Power Supply, 1x Case, 1x Others"})
            .Rows.Add(New String() {"#002", "Roen", "1x AMD Ryzen 3, 1x Motherbaord, 2x Memory, 1x Power Supply, 1x Case, 1x Others"})
            .Rows.Add(New String() {"#003", "Jacob", "1x AMD Ryzen 3, 1x Motherbaord, 2x Memory, 1x Power Supply, 1x Case, 1x Others"})
            .Rows.Add(New String() {"#004", "Mick", "1x AMD Ryzen 3, 1x Motherbaord, 2x Memory, 1x Power Supply, 1x Case, 1x Others"})
            .Rows.Add(New String() {"#005", "Gabriel Luna", "1x AMD Ryzen 3, 1x Motherbaord, 2x Memory, 1x Power Supply, 1x Case, 1x Others"})
        End With
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