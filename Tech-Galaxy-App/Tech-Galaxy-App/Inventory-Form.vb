Public Class frmInventory

    Public Sub EnableEdit()
        txtItemName.Enabled = True
        cmbCategory.Enabled = True
        txtPrice.Enabled = True
        numStock.Enabled = True
        btnSave.Visible = True
        btnCancel.Visible = True
        btnRemoveItem.Visible = True

        btnAdd.Enabled = False
        btnAddStock.Enabled = False

        txtSearch.Enabled = False
        btnFilterAll.Enabled = False
        btnFilterChassis.Enabled = False
        btnFilterMemory.Enabled = False
        btnFilterMotherboard.Enabled = False
        btnFilterPowerSupply.Enabled = False
        btnFilterProcessor.Enabled = False
        btnFilterVideoCard.Enabled = False

        grdItems.Enabled = False

        btnMain.Enabled = False
        btnHistory.Enabled = False
        btnSetting.Enabled = False
    End Sub

    Public Sub DisableEdit()
        txtItemName.Enabled = False
        cmbCategory.Enabled = False
        txtPrice.Enabled = False
        numStock.Enabled = False
        btnSave.Visible = False
        btnCancel.Visible = False
        btnRemoveItem.Visible = False

        btnAdd.Enabled = True
        btnAddStock.Enabled = True

        txtSearch.Enabled = True
        btnFilterAll.Enabled = True
        btnFilterChassis.Enabled = True
        btnFilterMemory.Enabled = True
        btnFilterMotherboard.Enabled = True
        btnFilterPowerSupply.Enabled = True
        btnFilterProcessor.Enabled = True
        btnFilterVideoCard.Enabled = True

        grdItems.Enabled = True

        btnMain.Enabled = True
        btnHistory.Enabled = True
        btnSetting.Enabled = True
    End Sub

    Private Sub btnEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.CheckedChanged
        If btnEdit.Checked.Equals(True) Then
            EnableEdit()
        Else
            DisableEdit()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnEdit.Checked = False
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
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dlgAddItem.ShowDialog()
    End Sub

    Private Sub btnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStock.Click
        dlgAddStock.ShowDialog()
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please Enter Number Only", vbCritical)
        End If
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        Dim result = dlgConfirmation2.ShowDialog()
        If result = DialogResult.Yes Then
            RemoveItem()
            btnEdit.Checked = False
        End If
    End Sub

    Public Sub RemoveItem()

    End Sub

    Public Sub Populate()

    End Sub

End Class