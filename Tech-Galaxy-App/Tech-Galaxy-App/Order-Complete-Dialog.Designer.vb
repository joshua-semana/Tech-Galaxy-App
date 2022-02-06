<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOrderComplete
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
        Me.btnOkay = New Guna.UI2.WinForms.Guna2Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BorderColor = System.Drawing.Color.DarkGray
        Me.pnlContainer.BorderThickness = 1
        Me.pnlContainer.Controls.Add(Me.btnOkay)
        Me.pnlContainer.Controls.Add(Me.lblName)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.FillColor = System.Drawing.Color.White
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlContainer.ShadowDecoration.Parent = Me.pnlContainer
        Me.pnlContainer.Size = New System.Drawing.Size(300, 130)
        Me.pnlContainer.TabIndex = 4
        '
        'btnOkay
        '
        Me.btnOkay.Animated = True
        Me.btnOkay.BorderRadius = 3
        Me.btnOkay.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnOkay.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnOkay.CheckedState.Parent = Me.btnOkay
        Me.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkay.CustomImages.Parent = Me.btnOkay
        Me.btnOkay.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnOkay.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnOkay.ForeColor = System.Drawing.Color.Black
        Me.btnOkay.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnOkay.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnOkay.HoverState.Parent = Me.btnOkay
        Me.btnOkay.Location = New System.Drawing.Point(84, 74)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.ShadowDecoration.Parent = Me.btnOkay
        Me.btnOkay.Size = New System.Drawing.Size(132, 36)
        Me.btnOkay.TabIndex = 14
        Me.btnOkay.Text = "Great!"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(50, 14)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(201, 47)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Check out is successful!"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dlgOrderComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 130)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOrderComplete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order_Complete_Dialog"
        Me.pnlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnOkay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
