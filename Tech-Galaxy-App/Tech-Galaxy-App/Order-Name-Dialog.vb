Imports System.Windows.Forms

Public Class dlgOrderName

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter the buyers name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtName.Text = ""
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub dlgOrderName_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtName.Text = ""
    End Sub
End Class
