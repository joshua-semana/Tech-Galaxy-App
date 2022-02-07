Imports System.Windows.Forms

Public Class dlgQuantity

    Private Sub Add_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If numQuantity.Value > numQuantity.Maximum Then
            MessageBox.Show("The input number has exceeded the total stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        numQuantity.Value = 1
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub dlgQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        numQuantity.Maximum = frmMain.grdItems.SelectedCells(3).Value
        numQuantity.Value = 1
    End Sub
End Class
