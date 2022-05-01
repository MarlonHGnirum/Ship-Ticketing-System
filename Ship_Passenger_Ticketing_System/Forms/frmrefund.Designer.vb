<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrefund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrefund))
        Me.tfirst = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tlast = New System.Windows.Forms.TextBox
        Me.dgvref = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.bref = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bclose = New System.Windows.Forms.Button
        CType(Me.dgvref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tfirst
        '
        Me.tfirst.AcceptsReturn = True
        Me.tfirst.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfirst.Location = New System.Drawing.Point(22, 37)
        Me.tfirst.Name = "tfirst"
        Me.tfirst.Size = New System.Drawing.Size(186, 24)
        Me.tfirst.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'tlast
        '
        Me.tlast.AcceptsReturn = True
        Me.tlast.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlast.Location = New System.Drawing.Point(22, 95)
        Me.tlast.Name = "tlast"
        Me.tlast.Size = New System.Drawing.Size(186, 24)
        Me.tlast.TabIndex = 1
        '
        'dgvref
        '
        Me.dgvref.AllowUserToAddRows = False
        Me.dgvref.AllowUserToDeleteRows = False
        Me.dgvref.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvref.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvref.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvref.Location = New System.Drawing.Point(230, 17)
        Me.dgvref.Name = "dgvref"
        Me.dgvref.ReadOnly = True
        Me.dgvref.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvref.Size = New System.Drawing.Size(395, 204)
        Me.dgvref.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefundToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 26)
        '
        'RefundToolStripMenuItem
        '
        Me.RefundToolStripMenuItem.Name = "RefundToolStripMenuItem"
        Me.RefundToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.RefundToolStripMenuItem.Text = "Refund"
        '
        'bref
        '
        Me.bref.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bref.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bref.Location = New System.Drawing.Point(53, 142)
        Me.bref.Name = "bref"
        Me.bref.Size = New System.Drawing.Size(72, 31)
        Me.bref.TabIndex = 3
        Me.bref.Text = "&Clear"
        Me.bref.UseVisualStyleBackColor = False
        '
        'bclose
        '
        Me.bclose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bclose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(136, 142)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(72, 31)
        Me.bclose.TabIndex = 7
        Me.bclose.Text = "&Close"
        Me.bclose.UseVisualStyleBackColor = False
        '
        'frmrefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(643, 237)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvref)
        Me.Controls.Add(Me.tlast)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tfirst)
        Me.Controls.Add(Me.bref)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrefund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refund Scheme"
        CType(Me.dgvref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tfirst As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tlast As System.Windows.Forms.TextBox
    Friend WithEvents dgvref As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bref As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents bclose As System.Windows.Forms.Button
End Class
