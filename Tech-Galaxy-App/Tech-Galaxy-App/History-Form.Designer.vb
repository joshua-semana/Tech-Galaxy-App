<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSetting = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMain = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPreview = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.grdTransactions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colOrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItems = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.grdTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSignOut)
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.btnSetting)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 640)
        Me.Panel1.TabIndex = 1
        '
        'btnSignOut
        '
        Me.btnSignOut.Animated = True
        Me.btnSignOut.BorderRadius = 3
        Me.btnSignOut.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnSignOut.CheckedState.Parent = Me.btnSignOut
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.CustomImages.Parent = Me.btnSignOut
        Me.btnSignOut.FillColor = System.Drawing.Color.Transparent
        Me.btnSignOut.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.HoverState.Parent = Me.btnSignOut
        Me.btnSignOut.Image = Global.Tech_Galaxy.My.Resources.Resources.icons8_logout_50
        Me.btnSignOut.Location = New System.Drawing.Point(8, 592)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.ShadowDecoration.Parent = Me.btnSignOut
        Me.btnSignOut.Size = New System.Drawing.Size(35, 35)
        Me.btnSignOut.TabIndex = 22
        '
        'btnInventory
        '
        Me.btnInventory.Animated = True
        Me.btnInventory.BorderRadius = 3
        Me.btnInventory.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnInventory.CheckedState.Parent = Me.btnInventory
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.CustomImages.Parent = Me.btnInventory
        Me.btnInventory.FillColor = System.Drawing.Color.Transparent
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.HoverState.Parent = Me.btnInventory
        Me.btnInventory.Image = Global.Tech_Galaxy.My.Resources.Resources.icons8_inventory_flow_60
        Me.btnInventory.Location = New System.Drawing.Point(8, 282)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.ShadowDecoration.Parent = Me.btnInventory
        Me.btnInventory.Size = New System.Drawing.Size(35, 35)
        Me.btnInventory.TabIndex = 21
        '
        'btnHistory
        '
        Me.btnHistory.Animated = True
        Me.btnHistory.BorderRadius = 3
        Me.btnHistory.Checked = True
        Me.btnHistory.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnHistory.CheckedState.Parent = Me.btnHistory
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnHistory.CustomImages.Parent = Me.btnHistory
        Me.btnHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.HoverState.Parent = Me.btnHistory
        Me.btnHistory.Image = Global.Tech_Galaxy.My.Resources.Resources.icons8_activity_history_48
        Me.btnHistory.Location = New System.Drawing.Point(8, 323)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.Parent = Me.btnHistory
        Me.btnHistory.Size = New System.Drawing.Size(35, 35)
        Me.btnHistory.TabIndex = 20
        '
        'btnSetting
        '
        Me.btnSetting.Animated = True
        Me.btnSetting.BorderRadius = 3
        Me.btnSetting.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnSetting.CheckedState.Parent = Me.btnSetting
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.CustomImages.Parent = Me.btnSetting
        Me.btnSetting.FillColor = System.Drawing.Color.Transparent
        Me.btnSetting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSetting.ForeColor = System.Drawing.Color.White
        Me.btnSetting.HoverState.Parent = Me.btnSetting
        Me.btnSetting.Image = Global.Tech_Galaxy.My.Resources.Resources.icons8_gear_100
        Me.btnSetting.Location = New System.Drawing.Point(8, 364)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.ShadowDecoration.Parent = Me.btnSetting
        Me.btnSetting.Size = New System.Drawing.Size(35, 35)
        Me.btnSetting.TabIndex = 19
        '
        'btnMain
        '
        Me.btnMain.Animated = True
        Me.btnMain.BorderRadius = 3
        Me.btnMain.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnMain.CheckedState.Parent = Me.btnMain
        Me.btnMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMain.CustomImages.Parent = Me.btnMain
        Me.btnMain.FillColor = System.Drawing.Color.Transparent
        Me.btnMain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMain.ForeColor = System.Drawing.Color.White
        Me.btnMain.HoverState.Parent = Me.btnMain
        Me.btnMain.Image = Global.Tech_Galaxy.My.Resources.Resources.icons8_pos_terminal_50
        Me.btnMain.Location = New System.Drawing.Point(8, 241)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.ShadowDecoration.Parent = Me.btnMain
        Me.btnMain.Size = New System.Drawing.Size(35, 35)
        Me.btnMain.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tech_Galaxy.My.Resources.Resources.icons8_planet_64
        Me.PictureBox1.Location = New System.Drawing.Point(8, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtPreview)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(724, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 640)
        Me.Panel2.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(8, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(167, 21)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Preview"
        '
        'txtPreview
        '
        Me.txtPreview.BorderThickness = 0
        Me.txtPreview.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPreview.DefaultText = "1x AMD Ryzen 5, 1x Asrock 320M, 1x MSI RX 570, 2x Kingston 4GB 2666 Mhz, 1x Coole" & _
            "r Master 450w, 1x Fortress Armor D206"
        Me.txtPreview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreview.DisabledState.Parent = Me.txtPreview
        Me.txtPreview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreview.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtPreview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreview.FocusedState.Parent = Me.txtPreview
        Me.txtPreview.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPreview.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreview.HoverState.Parent = Me.txtPreview
        Me.txtPreview.Location = New System.Drawing.Point(11, 73)
        Me.txtPreview.Margin = New System.Windows.Forms.Padding(3, 4, 1, 4)
        Me.txtPreview.Multiline = True
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPreview.PlaceholderText = ""
        Me.txtPreview.ReadOnly = True
        Me.txtPreview.SelectedText = ""
        Me.txtPreview.SelectionStart = 118
        Me.txtPreview.ShadowDecoration.Parent = Me.txtPreview
        Me.txtPreview.Size = New System.Drawing.Size(279, 554)
        Me.txtPreview.TabIndex = 5
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.Location = New System.Drawing.Point(56, 14)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(212, 29)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "Transaction History"
        '
        'txtSearch
        '
        Me.txtSearch.Animated = True
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(61, 48)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.txtSearch.PlaceholderText = "Enter order number ..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(653, 36)
        Me.txtSearch.TabIndex = 5
        '
        'grdTransactions
        '
        Me.grdTransactions.AllowUserToAddRows = False
        Me.grdTransactions.AllowUserToDeleteRows = False
        Me.grdTransactions.AllowUserToOrderColumns = True
        Me.grdTransactions.AllowUserToResizeColumns = False
        Me.grdTransactions.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdTransactions.BackgroundColor = System.Drawing.Color.White
        Me.grdTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOrderNumber, Me.colItems})
        Me.grdTransactions.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTransactions.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdTransactions.EnableHeadersVisualStyles = False
        Me.grdTransactions.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransactions.Location = New System.Drawing.Point(61, 92)
        Me.grdTransactions.MultiSelect = False
        Me.grdTransactions.Name = "grdTransactions"
        Me.grdTransactions.ReadOnly = True
        Me.grdTransactions.RowHeadersVisible = False
        Me.grdTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdTransactions.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.grdTransactions.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdTransactions.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.grdTransactions.RowTemplate.Height = 30
        Me.grdTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTransactions.Size = New System.Drawing.Size(653, 536)
        Me.grdTransactions.TabIndex = 13
        Me.grdTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.grdTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransactions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdTransactions.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.grdTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.grdTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdTransactions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.grdTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTransactions.ThemeStyle.HeaderStyle.Height = 23
        Me.grdTransactions.ThemeStyle.ReadOnly = True
        Me.grdTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdTransactions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.grdTransactions.ThemeStyle.RowsStyle.Height = 30
        Me.grdTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.grdTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'colOrderNumber
        '
        Me.colOrderNumber.FillWeight = 57.39649!
        Me.colOrderNumber.HeaderText = "Order Number"
        Me.colOrderNumber.Name = "colOrderNumber"
        Me.colOrderNumber.ReadOnly = True
        '
        'colItems
        '
        Me.colItems.FillWeight = 168.7457!
        Me.colItems.HeaderText = "Items"
        Me.colItems.Name = "colItems"
        Me.colItems.ReadOnly = True
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.grdTransactions)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History_Form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grdTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents grdTransactions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtPreview As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents colOrderNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItems As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
End Class
