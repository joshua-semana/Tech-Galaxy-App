﻿Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class dlgOrderName

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter the buyers name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Using cmd As New OleDbCommand("INSERT INTO tbl_transaction ([order_ID], [name], [Item], [date], [total], [vat]) VALUES(@ID, @name, @item, @date, @total, @vat)", con)
                With cmd.Parameters
                    .AddWithValue("@ID", frmMain.lblOrderNumber.Text)
                    .AddWithValue("@name", txtName.Text.ToUpper)
                    Dim Items As String = ""
                    For Each orders As DataGridViewRow In frmMain.grdOrders.Rows
                        Items = Items + orders.Cells(0).Value.ToString + "x " + orders.Cells(2).Value.ToString + " "
                    Next
                    .AddWithValue("@item", Items)
                    .AddWithValue("@date", StoreDate)
                    .AddWithValue("@total", frmMain.lblGtotal.Text)
                    .AddWithValue("@vat", frmMain.lblVAT.Text)
                End With
                cmd.ExecuteReader()
            End Using
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
