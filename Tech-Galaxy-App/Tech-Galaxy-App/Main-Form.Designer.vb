<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSetting = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMain = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRemoveOrderItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddToOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCheckOut = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnFilterAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterProcessor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterMotherboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterVideoCard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterMemory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterPowerSupply = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFilterChassis = New Guna.UI2.WinForms.Guna2Button()
        Me.grdItems = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdOrders = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
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
        Me.btnSignOut.TabIndex = 18
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
        Me.btnInventory.TabIndex = 17
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
        Me.btnHistory.TabIndex = 16
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
        Me.btnSetting.TabIndex = 15
        '
        'btnMain
        '
        Me.btnMain.Animated = True
        Me.btnMain.BorderRadius = 3
        Me.btnMain.Checked = True
        Me.btnMain.CheckedState.FillColor = System.Drawing.Color.LightGray
        Me.btnMain.CheckedState.Parent = Me.btnMain
        Me.btnMain.Cursor = System.Windows.Forms.Cursors.Arrow
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
        Me.btnMain.TabIndex = 14
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
        Me.Panel2.Controls.Add(Me.btnRemoveOrderItem)
        Me.Panel2.Controls.Add(Me.btnClearOrder)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnAddToOrder)
        Me.Panel2.Controls.Add(Me.btnCheckOut)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(724, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 640)
        Me.Panel2.TabIndex = 1
        '
        'btnRemoveOrderItem
        '
        Me.btnRemoveOrderItem.Animated = True
        Me.btnRemoveOrderItem.BorderRadius = 3
        Me.btnRemoveOrderItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnRemoveOrderItem.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnRemoveOrderItem.CheckedState.Parent = Me.btnRemoveOrderItem
        Me.btnRemoveOrderItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveOrderItem.CustomImages.Parent = Me.btnRemoveOrderItem
        Me.btnRemoveOrderItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnRemoveOrderItem.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnRemoveOrderItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnRemoveOrderItem.HoverState.Parent = Me.btnRemoveOrderItem
        Me.btnRemoveOrderItem.Location = New System.Drawing.Point(137, 15)
        Me.btnRemoveOrderItem.Name = "btnRemoveOrderItem"
        Me.btnRemoveOrderItem.ShadowDecoration.Parent = Me.btnRemoveOrderItem
        Me.btnRemoveOrderItem.Size = New System.Drawing.Size(81, 28)
        Me.btnRemoveOrderItem.TabIndex = 14
        Me.btnRemoveOrderItem.Text = "Remove"
        '
        'btnClearOrder
        '
        Me.btnClearOrder.Animated = True
        Me.btnClearOrder.BorderRadius = 3
        Me.btnClearOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClearOrder.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnClearOrder.CheckedState.Parent = Me.btnClearOrder
        Me.btnClearOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearOrder.CustomImages.Parent = Me.btnClearOrder
        Me.btnClearOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnClearOrder.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnClearOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnClearOrder.HoverState.Parent = Me.btnClearOrder
        Me.btnClearOrder.Location = New System.Drawing.Point(224, 15)
        Me.btnClearOrder.Name = "btnClearOrder"
        Me.btnClearOrder.ShadowDecoration.Parent = Me.btnClearOrder
        Me.btnClearOrder.Size = New System.Drawing.Size(66, 28)
        Me.btnClearOrder.TabIndex = 12
        Me.btnClearOrder.Text = "Clear"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(86, 510)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(212, 29)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddToOrder
        '
        Me.btnAddToOrder.Animated = True
        Me.btnAddToOrder.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnAddToOrder.BorderRadius = 3
        Me.btnAddToOrder.BorderThickness = 1
        Me.btnAddToOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnAddToOrder.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnAddToOrder.CheckedState.Parent = Me.btnAddToOrder
        Me.btnAddToOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddToOrder.CustomImages.Parent = Me.btnAddToOrder
        Me.btnAddToOrder.FillColor = System.Drawing.Color.White
        Me.btnAddToOrder.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnAddToOrder.ForeColor = System.Drawing.Color.Black
        Me.btnAddToOrder.HoverState.Parent = Me.btnAddToOrder
        Me.btnAddToOrder.Location = New System.Drawing.Point(11, 588)
        Me.btnAddToOrder.Name = "btnAddToOrder"
        Me.btnAddToOrder.ShadowDecoration.Parent = Me.btnAddToOrder
        Me.btnAddToOrder.Size = New System.Drawing.Size(279, 40)
        Me.btnAddToOrder.TabIndex = 13
        Me.btnAddToOrder.Text = "ADD TO ORDER"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Animated = True
        Me.btnCheckOut.BorderRadius = 3
        Me.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.CheckedState.Parent = Me.btnCheckOut
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.CustomImages.Parent = Me.btnCheckOut
        Me.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCheckOut.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.HoverState.Parent = Me.btnCheckOut
        Me.btnCheckOut.Location = New System.Drawing.Point(11, 542)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.ShadowDecoration.Parent = Me.btnCheckOut
        Me.btnCheckOut.Size = New System.Drawing.Size(279, 40)
        Me.btnCheckOut.TabIndex = 12
        Me.btnCheckOut.Text = "CHECK OUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Orders"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblOrderNumber.Location = New System.Drawing.Point(56, 14)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(177, 29)
        Me.lblOrderNumber.TabIndex = 2
        Me.lblOrderNumber.Text = "Order No. #001"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(383, 21)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(337, 21)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Friday, 14 Jan 2022"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtSearch.PlaceholderText = "Enter item name or code ..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(653, 36)
        Me.txtSearch.TabIndex = 4
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
        Me.btnFilterAll.TabIndex = 5
        Me.btnFilterAll.Text = "All"
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
        Me.btnFilterProcessor.TabIndex = 6
        Me.btnFilterProcessor.Text = "Processor"
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
        Me.btnFilterMotherboard.TabIndex = 7
        Me.btnFilterMotherboard.Text = "Motherboard"
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
        Me.btnFilterVideoCard.TabIndex = 8
        Me.btnFilterVideoCard.Text = "Video Card"
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
        Me.btnFilterMemory.TabIndex = 9
        Me.btnFilterMemory.Text = "Memory"
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
        Me.btnFilterPowerSupply.TabIndex = 10
        Me.btnFilterPowerSupply.Text = "Power Supply"
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
        Me.btnFilterChassis.TabIndex = 11
        Me.btnFilterChassis.Text = "Chassis"
        '
        'grdItems
        '
        Me.grdItems.AllowUserToAddRows = False
        Me.grdItems.AllowUserToDeleteRows = False
        Me.grdItems.AllowUserToOrderColumns = True
        Me.grdItems.AllowUserToResizeColumns = False
        Me.grdItems.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.grdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdItems.BackgroundColor = System.Drawing.Color.White
        Me.grdItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colPrice, Me.colStock})
        Me.grdItems.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdItems.DefaultCellStyle = DataGridViewCellStyle15
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
        Me.grdItems.TabIndex = 12
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
        'colName
        '
        Me.colName.FillWeight = 152.2843!
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
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
        'grdOrders
        '
        Me.grdOrders.AllowUserToAddRows = False
        Me.grdOrders.AllowUserToDeleteRows = False
        Me.grdOrders.AllowUserToOrderColumns = True
        Me.grdOrders.AllowUserToResizeColumns = False
        Me.grdOrders.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.grdOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.grdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colQuantity, Me.colOrderName, Me.colSubTotal})
        Me.grdOrders.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdOrders.DefaultCellStyle = DataGridViewCellStyle18
        Me.grdOrders.EnableHeadersVisualStyles = False
        Me.grdOrders.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdOrders.Location = New System.Drawing.Point(735, 49)
        Me.grdOrders.MultiSelect = False
        Me.grdOrders.Name = "grdOrders"
        Me.grdOrders.ReadOnly = True
        Me.grdOrders.RowHeadersVisible = False
        Me.grdOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdOrders.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.grdOrders.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdOrders.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.grdOrders.RowTemplate.Height = 30
        Me.grdOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrders.Size = New System.Drawing.Size(279, 458)
        Me.grdOrders.TabIndex = 13
        Me.grdOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.grdOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdOrders.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdOrders.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdOrders.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.grdOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdOrders.ThemeStyle.HeaderStyle.Height = 23
        Me.grdOrders.ThemeStyle.ReadOnly = True
        Me.grdOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdOrders.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.grdOrders.ThemeStyle.RowsStyle.Height = 30
        Me.grdOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.grdOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'colQuantity
        '
        Me.colQuantity.FillWeight = 41.48817!
        Me.colQuantity.HeaderText = "#"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        '
        'colOrderName
        '
        Me.colOrderName.FillWeight = 161.8181!
        Me.colOrderName.HeaderText = "Name"
        Me.colOrderName.Name = "colOrderName"
        Me.colOrderName.ReadOnly = True
        '
        'colSubTotal
        '
        Me.colSubTotal.FillWeight = 115.4754!
        Me.colSubTotal.HeaderText = "Sub-Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.grdOrders)
        Me.Controls.Add(Me.grdItems)
        Me.Controls.Add(Me.btnFilterChassis)
        Me.Controls.Add(Me.btnFilterPowerSupply)
        Me.Controls.Add(Me.btnFilterMemory)
        Me.Controls.Add(Me.btnFilterVideoCard)
        Me.Controls.Add(Me.btnFilterMotherboard)
        Me.Controls.Add(Me.btnFilterProcessor)
        Me.Controls.Add(Me.btnFilterAll)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tech Galaxy"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFilterAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterProcessor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterMotherboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterVideoCard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterMemory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterPowerSupply As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilterChassis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddToOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grdItems As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents grdOrders As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemoveOrderItem As Guna.UI2.WinForms.Guna2Button
End Class
