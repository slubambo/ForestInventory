<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoldProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSoldProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DATALIST = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnLoadData = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DATALIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ManageUsersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.FileToolStripMenuItem.Text = "Account"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProductToolStripMenuItem, Me.ListOfProductsToolStripMenuItem})
        Me.ProductToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProductToolStripMenuItem.Text = "Project"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AddNewProductToolStripMenuItem.Text = "Project Summary"
        '
        'ListOfProductsToolStripMenuItem
        '
        Me.ListOfProductsToolStripMenuItem.Name = "ListOfProductsToolStripMenuItem"
        Me.ListOfProductsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ListOfProductsToolStripMenuItem.Text = "Results"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockinToolStripMenuItem, Me.StockoutToolStripMenuItem})
        Me.TransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.TransactionToolStripMenuItem.Text = "Item Usage"
        '
        'StockinToolStripMenuItem
        '
        Me.StockinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ReceiveProductsToolStripMenuItem})
        Me.StockinToolStripMenuItem.Name = "StockinToolStripMenuItem"
        Me.StockinToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StockinToolStripMenuItem.Text = "Stock-in"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddToolStripMenuItem.Text = "Stock-in Products"
        '
        'ReceiveProductsToolStripMenuItem
        '
        Me.ReceiveProductsToolStripMenuItem.Name = "ReceiveProductsToolStripMenuItem"
        Me.ReceiveProductsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReceiveProductsToolStripMenuItem.Text = "History"
        '
        'StockoutToolStripMenuItem
        '
        Me.StockoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoldProductToolStripMenuItem, Me.ListOfSoldProductsToolStripMenuItem})
        Me.StockoutToolStripMenuItem.Name = "StockoutToolStripMenuItem"
        Me.StockoutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StockoutToolStripMenuItem.Text = "Stock-out"
        '
        'SoldProductToolStripMenuItem
        '
        Me.SoldProductToolStripMenuItem.Name = "SoldProductToolStripMenuItem"
        Me.SoldProductToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SoldProductToolStripMenuItem.Text = "Stock-out Product"
        '
        'ListOfSoldProductsToolStripMenuItem
        '
        Me.ListOfSoldProductsToolStripMenuItem.Name = "ListOfSoldProductsToolStripMenuItem"
        Me.ListOfSoldProductsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListOfSoldProductsToolStripMenuItem.Text = "History"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.ReportsToolStripMenuItem.Text = "Inventory Reports"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search"
        '
        'DTGLIST
        '
        Me.DTGLIST.AllowUserToAddRows = False
        Me.DTGLIST.AllowUserToDeleteRows = False
        Me.DTGLIST.AllowUserToResizeColumns = False
        Me.DTGLIST.AllowUserToResizeRows = False
        Me.DTGLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DTGLIST.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DTGLIST.Location = New System.Drawing.Point(0, 39)
        Me.DTGLIST.Margin = New System.Windows.Forms.Padding(2)
        Me.DTGLIST.MaximumSize = New System.Drawing.Size(1080, 0)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGLIST.Size = New System.Drawing.Size(861, 0)
        Me.DTGLIST.TabIndex = 0
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.Location = New System.Drawing.Point(484, 9)
        Me.TXTSEARCH.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(364, 26)
        Me.TXTSEARCH.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(877, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnLoadData)
        Me.Panel1.Controls.Add(Me.DATALIST)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TXTSEARCH)
        Me.Panel1.Controls.Add(Me.DTGLIST)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 483)
        Me.Panel1.TabIndex = 21
        '
        'DATALIST
        '
        Me.DATALIST.AllowUserToAddRows = False
        Me.DATALIST.AllowUserToDeleteRows = False
        Me.DATALIST.AllowUserToResizeColumns = False
        Me.DATALIST.AllowUserToResizeRows = False
        Me.DATALIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DATALIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATALIST.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DATALIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALIST.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DATALIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DATALIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DATALIST.Location = New System.Drawing.Point(0, 39)
        Me.DATALIST.Margin = New System.Windows.Forms.Padding(2)
        Me.DATALIST.Name = "DATALIST"
        Me.DATALIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALIST.Size = New System.Drawing.Size(877, 442)
        Me.DATALIST.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(780, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 35)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(664, 432)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(98, 35)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(419, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Search :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(218, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 23)
        Me.Panel2.TabIndex = 22
        '
        'BtnLoadData
        '
        Me.BtnLoadData.Location = New System.Drawing.Point(83, 9)
        Me.BtnLoadData.Name = "BtnLoadData"
        Me.BtnLoadData.Size = New System.Drawing.Size(187, 23)
        Me.BtnLoadData.TabIndex = 22
        Me.BtnLoadData.Text = "Load Data"
        Me.BtnLoadData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ForestInventorySystem.My.Resources.Resources.Humboldt_County_Redwood_Trees_Near_Ferndale_CA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forest Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DATALIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoldProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSoldProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents DTGLIST As DataGridView
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DATALIST As DataGridView
    Friend WithEvents BtnLoadData As Button
End Class
