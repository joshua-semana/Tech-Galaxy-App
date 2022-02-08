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
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.grdSales = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnCustom = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpDaily = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.grdTransactions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.grdSales, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.Guna2Separator3)
        Me.Panel2.Controls.Add(Me.grdSales)
        Me.Panel2.Controls.Add(Me.btnCustom)
        Me.Panel2.Controls.Add(Me.dtpDaily)
        Me.Panel2.Controls.Add(Me.lblSales)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Guna2Separator2)
        Me.Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Panel2.Controls.Add(Me.lblVAT)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dtpTo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtpFrom)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(724, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 640)
        Me.Panel2.TabIndex = 2
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.FillColor = System.Drawing.Color.LightGray
        Me.Guna2Separator3.Location = New System.Drawing.Point(11, 554)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(277, 10)
        Me.Guna2Separator3.TabIndex = 61
        '
        'grdSales
        '
        Me.grdSales.AllowUserToAddRows = False
        Me.grdSales.AllowUserToDeleteRows = False
        Me.grdSales.AllowUserToOrderColumns = True
        Me.grdSales.AllowUserToResizeColumns = False
        Me.grdSales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.grdSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdSales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdSales.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSales.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdSales.EnableHeadersVisualStyles = False
        Me.grdSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdSales.Location = New System.Drawing.Point(9, 206)
        Me.grdSales.MultiSelect = False
        Me.grdSales.Name = "grdSales"
        Me.grdSales.ReadOnly = True
        Me.grdSales.RowHeadersVisible = False
        Me.grdSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdSales.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.grdSales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdSales.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.grdSales.RowTemplate.Height = 30
        Me.grdSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSales.Size = New System.Drawing.Size(279, 342)
        Me.grdSales.TabIndex = 60
        Me.grdSales.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.grdSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdSales.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdSales.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdSales.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.grdSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdSales.ThemeStyle.HeaderStyle.Height = 23
        Me.grdSales.ThemeStyle.ReadOnly = True
        Me.grdSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdSales.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.grdSales.ThemeStyle.RowsStyle.Height = 30
        Me.grdSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.grdSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnCustom
        '
        Me.btnCustom.Animated = True
        Me.btnCustom.BorderRadius = 3
        Me.btnCustom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.btnCustom.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCustom.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnCustom.CheckedState.Parent = Me.btnCustom
        Me.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustom.CustomImages.Parent = Me.btnCustom
        Me.btnCustom.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnCustom.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnCustom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCustom.HoverState.Parent = Me.btnCustom
        Me.btnCustom.Location = New System.Drawing.Point(165, 15)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.ShadowDecoration.Parent = Me.btnCustom
        Me.btnCustom.Size = New System.Drawing.Size(123, 28)
        Me.btnCustom.TabIndex = 59
        Me.btnCustom.Text = "Custom Date"
        '
        'dtpDaily
        '
        Me.dtpDaily.Animated = True
        Me.dtpDaily.BorderRadius = 5
        Me.dtpDaily.CheckedState.Parent = Me.dtpDaily
        Me.dtpDaily.CustomFormat = ""
        Me.dtpDaily.FillColor = System.Drawing.Color.White
        Me.dtpDaily.Font = New System.Drawing.Font("Varela Round", 11.0!)
        Me.dtpDaily.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDaily.HoverState.Parent = Me.dtpDaily
        Me.dtpDaily.Location = New System.Drawing.Point(11, 48)
        Me.dtpDaily.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDaily.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDaily.Name = "dtpDaily"
        Me.dtpDaily.ShadowDecoration.Parent = Me.dtpDaily
        Me.dtpDaily.Size = New System.Drawing.Size(277, 36)
        Me.dtpDaily.TabIndex = 58
        Me.dtpDaily.Value = New Date(2022, 2, 8, 0, 0, 0, 0)
        '
        'lblSales
        '
        Me.lblSales.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblSales.ForeColor = System.Drawing.Color.Black
        Me.lblSales.Location = New System.Drawing.Point(68, 598)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(220, 29)
        Me.lblSales.TabIndex = 56
        Me.lblSales.Text = "0"
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 602)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Sales"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.LightGray
        Me.Guna2Separator2.Location = New System.Drawing.Point(11, 190)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(277, 10)
        Me.Guna2Separator2.TabIndex = 54
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2Separator1.Location = New System.Drawing.Point(11, 90)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(277, 10)
        Me.Guna2Separator1.TabIndex = 53
        '
        'lblVAT
        '
        Me.lblVAT.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblVAT.ForeColor = System.Drawing.Color.Black
        Me.lblVAT.Location = New System.Drawing.Point(68, 567)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(220, 29)
        Me.lblVAT.TabIndex = 52
        Me.lblVAT.Text = "0"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 571)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "VAT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "To:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTo
        '
        Me.dtpTo.Animated = True
        Me.dtpTo.BorderRadius = 5
        Me.dtpTo.CheckedState.Parent = Me.dtpTo
        Me.dtpTo.CustomFormat = ""
        Me.dtpTo.Enabled = False
        Me.dtpTo.FillColor = System.Drawing.Color.White
        Me.dtpTo.Font = New System.Drawing.Font("Varela Round", 11.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.HoverState.Parent = Me.dtpTo
        Me.dtpTo.Location = New System.Drawing.Point(68, 148)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShadowDecoration.Parent = Me.dtpTo
        Me.dtpTo.Size = New System.Drawing.Size(220, 36)
        Me.dtpTo.TabIndex = 45
        Me.dtpTo.Value = New Date(2022, 2, 7, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "From:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFrom
        '
        Me.dtpFrom.Animated = True
        Me.dtpFrom.BorderRadius = 5
        Me.dtpFrom.CheckedState.Parent = Me.dtpFrom
        Me.dtpFrom.CustomFormat = ""
        Me.dtpFrom.Enabled = False
        Me.dtpFrom.FillColor = System.Drawing.Color.White
        Me.dtpFrom.Font = New System.Drawing.Font("Varela Round", 11.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.HoverState.Parent = Me.dtpFrom
        Me.dtpFrom.Location = New System.Drawing.Point(68, 106)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShadowDecoration.Parent = Me.dtpFrom
        Me.dtpFrom.Size = New System.Drawing.Size(220, 36)
        Me.dtpFrom.TabIndex = 7
        Me.dtpFrom.Value = New Date(2022, 2, 7, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sales"
        '
        'btnView
        '
        Me.btnView.Animated = True
        Me.btnView.BorderRadius = 3
        Me.btnView.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnView.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnView.CheckedState.Parent = Me.btnView
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.CustomImages.Parent = Me.btnView
        Me.btnView.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnView.Font = New System.Drawing.Font("Varela Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnView.HoverState.Parent = Me.btnView
        Me.btnView.Location = New System.Drawing.Point(648, 15)
        Me.btnView.Name = "btnView"
        Me.btnView.ShadowDecoration.Parent = Me.btnView
        Me.btnView.Size = New System.Drawing.Size(66, 28)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Varela Round", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.Location = New System.Drawing.Point(56, 14)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(87, 29)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "History"
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdTransactions.BackgroundColor = System.Drawing.Color.White
        Me.grdTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Varela Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTransactions.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Varela Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTransactions.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdTransactions.EnableHeadersVisualStyles = False
        Me.grdTransactions.GridColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransactions.Location = New System.Drawing.Point(61, 90)
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
        Me.grdTransactions.Size = New System.Drawing.Size(653, 538)
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
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.btnView)
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
        CType(Me.grdSales, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents dtpDaily As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnCustom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents grdSales As Guna.UI2.WinForms.Guna2DataGridView
End Class
