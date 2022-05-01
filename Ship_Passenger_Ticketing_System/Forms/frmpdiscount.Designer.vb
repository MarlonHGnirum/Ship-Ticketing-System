<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpdiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpdiscount))
        Me.passtype = New System.Windows.Forms.ComboBox
        Me.linkadd = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.b2 = New System.Windows.Forms.Button
        Me.passdiscount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvdisc = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lid = New System.Windows.Forms.Label
        Me.b1 = New System.Windows.Forms.Button
        CType(Me.dgvdisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'passtype
        '
        Me.passtype.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtype.FormattingEnabled = True
        Me.passtype.Location = New System.Drawing.Point(16, 56)
        Me.passtype.Name = "passtype"
        Me.passtype.Size = New System.Drawing.Size(196, 25)
        Me.passtype.TabIndex = 1
        '
        'linkadd
        '
        Me.linkadd.AutoSize = True
        Me.linkadd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkadd.Location = New System.Drawing.Point(218, 59)
        Me.linkadd.Name = "linkadd"
        Me.linkadd.Size = New System.Drawing.Size(35, 17)
        Me.linkadd.TabIndex = 1
        Me.linkadd.TabStop = True
        Me.linkadd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Passenger Type"
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.b2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.Location = New System.Drawing.Point(137, 164)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(75, 33)
        Me.b2.TabIndex = 4
        Me.b2.Text = "Close"
        Me.b2.UseVisualStyleBackColor = False
        '
        'passdiscount
        '
        Me.passdiscount.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passdiscount.ForeColor = System.Drawing.Color.Blue
        Me.passdiscount.Location = New System.Drawing.Point(16, 119)
        Me.passdiscount.Name = "passdiscount"
        Me.passdiscount.Size = New System.Drawing.Size(134, 24)
        Me.passdiscount.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discount(%)"
        '
        'dgvdisc
        '
        Me.dgvdisc.AllowUserToAddRows = False
        Me.dgvdisc.AllowUserToDeleteRows = False
        Me.dgvdisc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdisc.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvdisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdisc.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvdisc.Location = New System.Drawing.Point(259, 12)
        Me.dgvdisc.Name = "dgvdisc"
        Me.dgvdisc.ReadOnly = True
        Me.dgvdisc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdisc.Size = New System.Drawing.Size(315, 183)
        Me.dgvdisc.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 70)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'lid
        '
        Me.lid.AutoSize = True
        Me.lid.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lid.Location = New System.Drawing.Point(16, 9)
        Me.lid.Name = "lid"
        Me.lid.Size = New System.Drawing.Size(26, 17)
        Me.lid.TabIndex = 1
        Me.lid.Text = "ID"
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.b1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.Location = New System.Drawing.Point(48, 164)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 33)
        Me.b1.TabIndex = 3
        Me.b1.Text = "Save"
        Me.b1.UseVisualStyleBackColor = False
        '
        'frmpdiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(586, 209)
        Me.Controls.Add(Me.lid)
        Me.Controls.Add(Me.dgvdisc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.passdiscount)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.linkadd)
        Me.Controls.Add(Me.passtype)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpdiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Passenger Discount"
        CType(Me.dgvdisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passtype As System.Windows.Forms.ComboBox
    Friend WithEvents linkadd As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents passdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dgvdisc As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lid As System.Windows.Forms.Label
    Friend WithEvents b1 As System.Windows.Forms.Button
End Class
