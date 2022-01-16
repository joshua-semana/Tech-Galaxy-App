<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConfirmation
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
        Me.btnNo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnYes = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BorderColor = System.Drawing.Color.DarkGray
        Me.pnlContainer.BorderThickness = 1
        Me.pnlContainer.Controls.Add(Me.btnNo)
        Me.pnlContainer.Controls.Add(Me.btnYes)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.FillColor = System.Drawing.Color.White
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlContainer.ShadowDecoration.Parent = Me.pnlContainer
        Me.pnlContainer.Size = New System.Drawing.Size(300, 130)
        Me.pnlContainer.TabIndex = 1
        '
        'btnNo
        '
        Me.btnNo.Animated = True
        Me.btnNo.BackColor = System.Drawing.Color.Transparent
        Me.btnNo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnNo.BorderRadius = 3
        Me.btnNo.BorderThickness = 1
        Me.btnNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnNo.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnNo.CheckedState.Parent = Me.btnNo
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.CustomImages.Parent = Me.btnNo
        Me.btnNo.FillColor = System.Drawing.Color.White
        Me.btnNo.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.Black
        Me.btnNo.HoverState.Parent = Me.btnNo
        Me.btnNo.Location = New System.Drawing.Point(12, 80)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.ShadowDecoration.Parent = Me.btnNo
        Me.btnNo.Size = New System.Drawing.Size(132, 36)
        Me.btnNo.TabIndex = 15
        Me.btnNo.Text = "No"
        '
        'btnYes
        '
        Me.btnYes.Animated = True
        Me.btnYes.BorderRadius = 3
        Me.btnYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnYes.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnYes.CheckedState.Parent = Me.btnYes
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.CustomImages.Parent = Me.btnYes
        Me.btnYes.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnYes.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.Black
        Me.btnYes.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnYes.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnYes.HoverState.Parent = Me.btnYes
        Me.btnYes.Location = New System.Drawing.Point(156, 80)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.ShadowDecoration.Parent = Me.btnYes
        Me.btnYes.Size = New System.Drawing.Size(132, 36)
        Me.btnYes.TabIndex = 14
        Me.btnYes.Text = "Yes"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 47)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Are you sure you want to clear the order list?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dlgConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 130)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConfirmation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirmation_Dialog"
        Me.pnlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnNo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnYes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
