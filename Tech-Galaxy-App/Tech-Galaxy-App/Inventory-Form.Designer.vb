<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSetting = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMain = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRemoveItem = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numStock = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnFilterChassis = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterPowerSupply = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterMemory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterVideoCard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterMotherboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterProcessor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterAll = New Guna.UI2.WinForms.Guna2Button()
        Me.grdItems = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddStock = New Guna.UI2.WinForms.Guna2Button()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSignOut.Location = New System.Drawing.Point(8, 593)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.ShadowDecoration.Parent = Me.btnSignOut
        Me.btnSignOut.Size = New System.Drawing.Size(35, 35)
        Me.btnSignOut.TabIndex = 22
        '
        'btnInventory
        '
        Me.btnInventory.Animated = True
        Me.btnInventory.BorderRadius = 3
        Me.btnInventory.Checked = True
        Me.btnInventory.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnInventory.CheckedState.Parent = Me.btnInventory
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Arrow
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
        Me.btnHistory.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnHistory.CheckedState.Parent = Me.btnHistory
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.Panel2.Controls.Add(Me.cmbCategory)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnRemoveItem)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.numStock)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtItemName)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(724, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 640)
        Me.Panel2.TabIndex = 2
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Animated = True
        Me.btnRemoveItem.BorderRadius = 3
        Me.btnRemoveItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnRemoveItem.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.CheckedState.Parent = Me.btnRemoveItem
        Me.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveItem.CustomImages.Parent = Me.btnRemoveItem
        Me.btnRemoveItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnRemoveItem.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnRemoveItem.HoverState.Parent = Me.btnRemoveItem
        Me.btnRemoveItem.Location = New System.Drawing.Point(134, 15)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.ShadowDecoration.Parent = Me.btnRemoveItem
        Me.btnRemoveItem.Size = New System.Drawing.Size(84, 28)
        Me.btnRemoveItem.TabIndex = 26
        Me.btnRemoveItem.Text = "Remove"
        Me.btnRemoveItem.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Stock"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numStock
        '
        Me.numStock.BackColor = System.Drawing.Color.Transparent
        Me.numStock.BorderRadius = 3
        Me.numStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numStock.DisabledState.Parent = Me.numStock
        Me.numStock.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numStock.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numStock.Enabled = False
        Me.numStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numStock.FocusedState.Parent = Me.numStock
        Me.numStock.Font = New System.Drawing.Font("Varela Round", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.numStock.ForeColor = System.Drawing.Color.Black
        Me.numStock.Location = New System.Drawing.Point(12, 274)
        Me.numStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 10)
        Me.numStock.Name = "numStock"
        Me.numStock.ShadowDecoration.Parent = Me.numStock
        Me.numStock.Size = New System.Drawing.Size(279, 36)
        Me.numStock.TabIndex = 19
        Me.numStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.numStock.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrice
        '
        Me.txtPrice.Animated = True
        Me.txtPrice.BorderRadius = 5
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.Enabled = False
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(11, 208)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(279, 36)
        Me.txtPrice.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtItemName
        '
        Me.txtItemName.Animated = True
        Me.txtItemName.BorderRadius = 5
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.Parent = Me.txtItemName
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.Enabled = False
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.FocusedState.Parent = Me.txtItemName
        Me.txtItemName.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.HoverState.Parent = Me.txtItemName
        Me.txtItemName.Location = New System.Drawing.Point(11, 74)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderText = ""
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.ShadowDecoration.Parent = Me.txtItemName
        Me.txtItemName.Size = New System.Drawing.Size(279, 36)
        Me.txtItemName.TabIndex = 15
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.BorderRadius = 3
        Me.btnEdit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.btnEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnEdit.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(224, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(66, 28)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnCancel.BorderRadius = 3
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.White
        Me.btnCancel.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(11, 588)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(131, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BorderRadius = 3
        Me.btnSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSave.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(150, 588)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(140, 40)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "SAVE"
        Me.btnSave.Visible = False
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
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.Location = New System.Drawing.Point(56, 14)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(110, 29)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "Inventory"
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
        Me.txtSearch.PlaceholderText = "Enter item name ..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(653, 36)
        Me.txtSearch.TabIndex = 5
        '
        'btnFilterChassis
        '
        Me.btnFilterChassis.Animated = True
        Me.btnFilterChassis.BorderRadius = 3
        Me.btnFilterChassis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterChassis.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterChassis.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterChassis.CheckedState.Parent = Me.btnFilterChassis
        Me.btnFilterChassis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterChassis.CustomImages.Parent = Me.btnFilterChassis
        Me.btnFilterChassis.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterChassis.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterChassis.ForeColor = System.Drawing.Color.Black
        Me.btnFilterChassis.HoverState.Parent = Me.btnFilterChassis
        Me.btnFilterChassis.Location = New System.Drawing.Point(637, 92)
        Me.btnFilterChassis.Name = "btnFilterChassis"
        Me.btnFilterChassis.ShadowDecoration.Parent = Me.btnFilterChassis
        Me.btnFilterChassis.Size = New System.Drawing.Size(77, 28)
        Me.btnFilterChassis.TabIndex = 18
        Me.btnFilterChassis.Text = "Chassis"
        '
        'btnFilterPowerSupply
        '
        Me.btnFilterPowerSupply.Animated = True
        Me.btnFilterPowerSupply.BorderRadius = 3
        Me.btnFilterPowerSupply.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterPowerSupply.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterPowerSupply.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterPowerSupply.CheckedState.Parent = Me.btnFilterPowerSupply
        Me.btnFilterPowerSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterPowerSupply.CustomImages.Parent = Me.btnFilterPowerSupply
        Me.btnFilterPowerSupply.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterPowerSupply.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterPowerSupply.ForeColor = System.Drawing.Color.Black
        Me.btnFilterPowerSupply.HoverState.Parent = Me.btnFilterPowerSupply
        Me.btnFilterPowerSupply.Location = New System.Drawing.Point(511, 92)
        Me.btnFilterPowerSupply.Name = "btnFilterPowerSupply"
        Me.btnFilterPowerSupply.ShadowDecoration.Parent = Me.btnFilterPowerSupply
        Me.btnFilterPowerSupply.Size = New System.Drawing.Size(120, 28)
        Me.btnFilterPowerSupply.TabIndex = 17
        Me.btnFilterPowerSupply.Text = "Power Supply"
        '
        'btnFilterMemory
        '
        Me.btnFilterMemory.Animated = True
        Me.btnFilterMemory.BorderRadius = 3
        Me.btnFilterMemory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterMemory.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterMemory.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterMemory.CheckedState.Parent = Me.btnFilterMemory
        Me.btnFilterMemory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterMemory.CustomImages.Parent = Me.btnFilterMemory
        Me.btnFilterMemory.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterMemory.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterMemory.ForeColor = System.Drawing.Color.Black
        Me.btnFilterMemory.HoverState.Parent = Me.btnFilterMemory
        Me.btnFilterMemory.Location = New System.Drawing.Point(428, 92)
        Me.btnFilterMemory.Name = "btnFilterMemory"
        Me.btnFilterMemory.ShadowDecoration.Parent = Me.btnFilterMemory
        Me.btnFilterMemory.Size = New System.Drawing.Size(77, 28)
        Me.btnFilterMemory.TabIndex = 16
        Me.btnFilterMemory.Text = "Memory"
        '
        'btnFilterVideoCard
        '
        Me.btnFilterVideoCard.Animated = True
        Me.btnFilterVideoCard.BorderRadius = 3
        Me.btnFilterVideoCard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterVideoCard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterVideoCard.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterVideoCard.CheckedState.Parent = Me.btnFilterVideoCard
        Me.btnFilterVideoCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterVideoCard.CustomImages.Parent = Me.btnFilterVideoCard
        Me.btnFilterVideoCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterVideoCard.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterVideoCard.ForeColor = System.Drawing.Color.Black
        Me.btnFilterVideoCard.HoverState.Parent = Me.btnFilterVideoCard
        Me.btnFilterVideoCard.Location = New System.Drawing.Point(322, 92)
        Me.btnFilterVideoCard.Name = "btnFilterVideoCard"
        Me.btnFilterVideoCard.ShadowDecoration.Parent = Me.btnFilterVideoCard
        Me.btnFilterVideoCard.Size = New System.Drawing.Size(100, 28)
        Me.btnFilterVideoCard.TabIndex = 15
        Me.btnFilterVideoCard.Text = "Video Card"
        '
        'btnFilterMotherboard
        '
        Me.btnFilterMotherboard.Animated = True
        Me.btnFilterMotherboard.BorderRadius = 3
        Me.btnFilterMotherboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterMotherboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterMotherboard.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterMotherboard.CheckedState.Parent = Me.btnFilterMotherboard
        Me.btnFilterMotherboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterMotherboard.CustomImages.Parent = Me.btnFilterMotherboard
        Me.btnFilterMotherboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterMotherboard.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterMotherboard.ForeColor = System.Drawing.Color.Black
        Me.btnFilterMotherboard.HoverState.Parent = Me.btnFilterMotherboard
        Me.btnFilterMotherboard.Location = New System.Drawing.Point(201, 92)
        Me.btnFilterMotherboard.Name = "btnFilterMotherboard"
        Me.btnFilterMotherboard.ShadowDecoration.Parent = Me.btnFilterMotherboard
        Me.btnFilterMotherboard.Size = New System.Drawing.Size(115, 28)
        Me.btnFilterMotherboard.TabIndex = 14
        Me.btnFilterMotherboard.Text = "Motherboard"
        '
        'btnFilterProcessor
        '
        Me.btnFilterProcessor.Animated = True
        Me.btnFilterProcessor.BorderRadius = 3
        Me.btnFilterProcessor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterProcessor.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterProcessor.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterProcessor.CheckedState.Parent = Me.btnFilterProcessor
        Me.btnFilterProcessor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterProcessor.CustomImages.Parent = Me.btnFilterProcessor
        Me.btnFilterProcessor.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterProcessor.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterProcessor.ForeColor = System.Drawing.Color.Black
        Me.btnFilterProcessor.HoverState.Parent = Me.btnFilterProcessor
        Me.btnFilterProcessor.Location = New System.Drawing.Point(105, 92)
        Me.btnFilterProcessor.Name = "btnFilterProcessor"
        Me.btnFilterProcessor.ShadowDecoration.Parent = Me.btnFilterProcessor
        Me.btnFilterProcessor.Size = New System.Drawing.Size(90, 28)
        Me.btnFilterProcessor.TabIndex = 13
        Me.btnFilterProcessor.Text = "Processor"
        '
        'btnFilterAll
        '
        Me.btnFilterAll.Animated = True
        Me.btnFilterAll.BorderRadius = 3
        Me.btnFilterAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFilterAll.Checked = True
        Me.btnFilterAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnFilterAll.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnFilterAll.CheckedState.Parent = Me.btnFilterAll
        Me.btnFilterAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterAll.CustomImages.Parent = Me.btnFilterAll
        Me.btnFilterAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnFilterAll.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnFilterAll.ForeColor = System.Drawing.Color.Black
        Me.btnFilterAll.HoverState.Parent = Me.btnFilterAll
        Me.btnFilterAll.Location = New System.Drawing.Point(61, 92)
        Me.btnFilterAll.Name = "btnFilterAll"
        Me.btnFilterAll.ShadowDecoration.Parent = Me.btnFilterAll
        Me.btnFilterAll.Size = New System.Drawing.Size(38, 28)
        Me.btnFilterAll.TabIndex = 12
        Me.btnFilterAll.Text = "All"
        '
        'grdItems
        '
        Me.grdItems.AllowUserToAddRows = False
        Me.grdItems.AllowUserToDeleteRows = False
        Me.grdItems.AllowUserToOrderColumns = True
        Me.grdItems.AllowUserToResizeColumns = False
        Me.grdItems.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdItems.BackgroundColor = System.Drawing.Color.White
        Me.grdItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colCategory, Me.colPrice, Me.colStock})
        Me.grdItems.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdItems.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdItems.EnableHeadersVisualStyles = False
        Me.grdItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdItems.Location = New System.Drawing.Point(61, 126)
        Me.grdItems.MultiSelect = False
        Me.grdItems.Name = "grdItems"
        Me.grdItems.ReadOnly = True
        Me.grdItems.RowHeadersVisible = False
        Me.grdItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.grdItems.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdItems.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.grdItems.RowTemplate.Height = 30
        Me.grdItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItems.Size = New System.Drawing.Size(653, 502)
        Me.grdItems.TabIndex = 19
        Me.grdItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.grdItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdItems.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdItems.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.grdItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.grdItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdItems.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.grdItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdItems.ThemeStyle.HeaderStyle.Height = 23
        Me.grdItems.ThemeStyle.ReadOnly = True
        Me.grdItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdItems.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.grdItems.ThemeStyle.RowsStyle.Height = 30
        Me.grdItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.grdItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BorderRadius = 3
        Me.btnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnAdd.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(648, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(66, 28)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        '
        'btnAddStock
        '
        Me.btnAddStock.Animated = True
        Me.btnAddStock.BorderRadius = 3
        Me.btnAddStock.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnAddStock.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnAddStock.CheckedState.Parent = Me.btnAddStock
        Me.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStock.CustomImages.Parent = Me.btnAddStock
        Me.btnAddStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnAddStock.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnAddStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnAddStock.HoverState.Parent = Me.btnAddStock
        Me.btnAddStock.Location = New System.Drawing.Point(539, 15)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.ShadowDecoration.Parent = Me.btnAddStock
        Me.btnAddStock.Size = New System.Drawing.Size(103, 28)
        Me.btnAddStock.TabIndex = 27
        Me.btnAddStock.Text = "Add Stock"
        '
        'colName
        '
        Me.colName.FillWeight = 152.2843!
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.FillWeight = 73.85786!
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'colStock
        '
        Me.colStock.FillWeight = 73.85786!
        Me.colStock.HeaderText = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Category"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderRadius = 3
        Me.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Enabled = False
        Me.cmbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCategory.FocusedState.Parent = Me.cmbCategory
        Me.cmbCategory.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.HoverState.Parent = Me.cmbCategory
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Items.AddRange(New Object() {"Processor", "Motherboard", "Video Card", "Memory", "Power Supply", "Chassis"})
        Me.cmbCategory.ItemsAppearance.Parent = Me.cmbCategory
        Me.cmbCategory.Location = New System.Drawing.Point(11, 139)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.ShadowDecoration.Parent = Me.cmbCategory
        Me.cmbCategory.Size = New System.Drawing.Size(279, 36)
        Me.cmbCategory.TabIndex = 29
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdItems)
        Me.Controls.Add(Me.btnFilterChassis)
        Me.Controls.Add(Me.btnFilterPowerSupply)
        Me.Controls.Add(Me.btnFilterMemory)
        Me.Controls.Add(Me.btnFilterVideoCard)
        Me.Controls.Add(Me.btnFilterMotherboard)
        Me.Controls.Add(Me.btnFilterProcessor)
        Me.Controls.Add(Me.btnFilterAll)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory_Form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFilterChassis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterPowerSupply As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterMemory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterVideoCard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterMotherboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterProcessor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grdItems As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numStock As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemoveItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStock As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
