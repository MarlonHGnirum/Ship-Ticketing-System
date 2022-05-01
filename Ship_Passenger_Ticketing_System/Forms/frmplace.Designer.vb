<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmplace
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmplace))
        Me.Label3 = New System.Windows.Forms.Label
        Me.torig = New System.Windows.Forms.TextBox
        Me.tdest = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.badd = New System.Windows.Forms.Button
        Me.bref = New System.Windows.Forms.Button
        Me.bclose = New System.Windows.Forms.Button
        Me.dgv2 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.depart = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.ladd = New System.Windows.Forms.LinkLabel
        Me.vname = New System.Windows.Forms.ComboBox
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Destination"
        '
        'torig
        '
        Me.torig.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.torig.Location = New System.Drawing.Point(12, 87)
        Me.torig.Name = "torig"
        Me.torig.Size = New System.Drawing.Size(178, 24)
        Me.torig.TabIndex = 2
        '
        'tdest
        '
        Me.tdest.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdest.Location = New System.Drawing.Point(12, 140)
        Me.tdest.Name = "tdest"
        Me.tdest.Size = New System.Drawing.Size(178, 24)
        Me.tdest.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vessel Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Origin"
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badd.Location = New System.Drawing.Point(209, 87)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(80, 35)
        Me.badd.TabIndex = 5
        Me.badd.Text = "&Add"
        Me.badd.UseVisualStyleBackColor = False
        '
        'bref
        '
        Me.bref.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bref.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bref.Location = New System.Drawing.Point(209, 140)
        Me.bref.Name = "bref"
        Me.bref.Size = New System.Drawing.Size(80, 35)
        Me.bref.TabIndex = 6
        Me.bref.Text = "&Refresh"
        Me.bref.UseVisualStyleBackColor = False
        '
        'bclose
        '
        Me.bclose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bclose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(209, 190)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(80, 35)
        Me.bclose.TabIndex = 7
        Me.bclose.Text = "&Close"
        Me.bclose.UseVisualStyleBackColor = False
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv2.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv2.Location = New System.Drawing.Point(305, 16)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv2.Size = New System.Drawing.Size(556, 256)
        Me.dgv2.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AddClassToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 92)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AddClassToolStripMenuItem
        '
        Me.AddClassToolStripMenuItem.Name = "AddClassToolStripMenuItem"
        Me.AddClassToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AddClassToolStripMenuItem.Text = "Add Class"
        '
        'depart
        '
        Me.depart.CalendarFont = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depart.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.depart.Location = New System.Drawing.Point(10, 192)
        Me.depart.Name = "depart"
        Me.depart.ShowUpDown = True
        Me.depart.Size = New System.Drawing.Size(180, 24)
        Me.depart.TabIndex = 4
        Me.depart.Value = New Date(2017, 1, 21, 12, 9, 24, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Departure"
        '
        'ladd
        '
        Me.ladd.AutoSize = True
        Me.ladd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ladd.Location = New System.Drawing.Point(198, 44)
        Me.ladd.Name = "ladd"
        Me.ladd.Size = New System.Drawing.Size(35, 17)
        Me.ladd.TabIndex = 30
        Me.ladd.TabStop = True
        Me.ladd.Text = "Add"
        '
        'vname
        '
        Me.vname.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vname.FormattingEnabled = True
        Me.vname.Location = New System.Drawing.Point(13, 42)
        Me.vname.Name = "vname"
        Me.vname.Size = New System.Drawing.Size(179, 25)
        Me.vname.TabIndex = 1
        '
        'frmplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(878, 288)
        Me.Controls.Add(Me.vname)
        Me.Controls.Add(Me.ladd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.depart)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.tdest)
        Me.Controls.Add(Me.bref)
        Me.Controls.Add(Me.badd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.torig)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmplace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vessel Routes"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents torig As System.Windows.Forms.TextBox
    Friend WithEvents tdest As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents bref As System.Windows.Forms.Button
    Friend WithEvents bclose As System.Windows.Forms.Button
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents depart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ladd As System.Windows.Forms.LinkLabel
    Friend WithEvents vname As System.Windows.Forms.ComboBox
    Friend WithEvents AddClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
