<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgViewHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItems = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BorderColor = System.Drawing.Color.DarkGray
        Me.pnlContainer.BorderThickness = 1
        Me.pnlContainer.Controls.Add(Me.lblVAT)
        Me.pnlContainer.Controls.Add(Me.Label4)
        Me.pnlContainer.Controls.Add(Me.lblTotalPrice)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.txtItems)
        Me.pnlContainer.Controls.Add(Me.btnClose)
        Me.pnlContainer.Controls.Add(Me.lblOrderNumber)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.FillColor = System.Drawing.Color.White
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlContainer.ShadowDecoration.Parent = Me.pnlContainer
        Me.pnlContainer.Size = New System.Drawing.Size(435, 346)
        Me.pnlContainer.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Items:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtItems
        '
        Me.txtItems.Animated = True
        Me.txtItems.BorderRadius = 5
        Me.txtItems.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItems.DefaultText = ""
        Me.txtItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItems.DisabledState.Parent = Me.txtItems
        Me.txtItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItems.FocusedState.Parent = Me.txtItems
        Me.txtItems.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txtItems.ForeColor = System.Drawing.Color.Black
        Me.txtItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItems.HoverState.Parent = Me.txtItems
        Me.txtItems.Location = New System.Drawing.Point(14, 66)
        Me.txtItems.Margin = New System.Windows.Forms.Padding(5)
        Me.txtItems.Multiline = True
        Me.txtItems.Name = "txtItems"
        Me.txtItems.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItems.PlaceholderText = ""
        Me.txtItems.ReadOnly = True
        Me.txtItems.SelectedText = ""
        Me.txtItems.ShadowDecoration.Parent = Me.txtItems
        Me.txtItems.Size = New System.Drawing.Size(407, 158)
        Me.txtItems.TabIndex = 26
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.BorderRadius = 3
        Me.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(151, 297)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(132, 36)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderNumber.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblOrderNumber.ForeColor = System.Drawing.Color.Black
        Me.lblOrderNumber.Location = New System.Drawing.Point(122, 11)
        Me.lblOrderNumber.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(190, 21)
        Me.lblOrderNumber.TabIndex = 14
        Me.lblOrderNumber.Text = "Order No. #"
        Me.lblOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Total Price:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.White
        Me.lblTotalPrice.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.Black
        Me.lblTotalPrice.Location = New System.Drawing.Point(114, 239)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(307, 21)
        Me.lblTotalPrice.TabIndex = 29
        Me.lblTotalPrice.Text = "0"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVAT
        '
        Me.lblVAT.BackColor = System.Drawing.Color.White
        Me.lblVAT.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.Black
        Me.lblVAT.Location = New System.Drawing.Point(114, 270)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(307, 21)
        Me.lblVAT.TabIndex = 31
        Me.lblVAT.Text = "0"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(13, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "VAT:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dlgViewHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 346)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View_History"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtItems As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
