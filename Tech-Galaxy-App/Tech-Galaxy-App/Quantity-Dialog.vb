Imports System.Windows.Forms

Public Class dlgQuantity

    Private Sub Add_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        numQuantity.Value = 1
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        numQuantity.Value = 1
        Me.Close()
    End Sub

End Class
