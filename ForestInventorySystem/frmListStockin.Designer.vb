﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListStockin
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DTPFROM = New System.Windows.Forms.DateTimePicker()
        Me.DTPTO = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(476, 465)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 29)
        Me.btnRefresh.TabIndex = 48
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(631, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "To"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(441, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "From"
        '
        'DTPFROM
        '
        Me.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFROM.Location = New System.Drawing.Point(487, 101)
        Me.DTPFROM.Name = "DTPFROM"
        Me.DTPFROM.Size = New System.Drawing.Size(139, 20)
        Me.DTPFROM.TabIndex = 44
        '
        'DTPTO
        '
        Me.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTO.Location = New System.Drawing.Point(660, 101)
        Me.DTPTO.Name = "DTPTO"
        Me.DTPTO.Size = New System.Drawing.Size(132, 20)
        Me.DTPTO.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 468)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Search :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(717, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(636, 464)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 41
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.BackColor = System.Drawing.Color.Cyan
        Me.TXTSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.Location = New System.Drawing.Point(79, 465)
        Me.TXTSEARCH.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(392, 26)
        Me.TXTSEARCH.TabIndex = 39
        '
        'DTGLIST
        '
        Me.DTGLIST.AllowUserToAddRows = False
        Me.DTGLIST.AllowUserToDeleteRows = False
        Me.DTGLIST.AllowUserToResizeColumns = False
        Me.DTGLIST.AllowUserToResizeRows = False
        Me.DTGLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DTGLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DTGLIST.Location = New System.Drawing.Point(11, 141)
        Me.DTGLIST.Margin = New System.Windows.Forms.Padding(2)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.RowHeadersVisible = False
        Me.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGLIST.Size = New System.Drawing.Size(781, 318)
        Me.DTGLIST.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 46)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "List of Received Items"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(557, 464)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 29)
        Me.btnNew.TabIndex = 50
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmListStockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 506)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DTPFROM)
        Me.Controls.Add(Me.DTPTO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.TXTSEARCH)
        Me.Controls.Add(Me.DTGLIST)
        Me.Name = "frmListStockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stockin"
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DTPFROM As DateTimePicker
    Friend WithEvents DTPTO As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents DTGLIST As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNew As Button
End Class
