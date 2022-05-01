<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtype
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtype))
        Me.tptype = New System.Windows.Forms.TextBox
        Me.bclose = New System.Windows.Forms.Button
        Me.badd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tptype
        '
        Me.tptype.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tptype.Location = New System.Drawing.Point(32, 33)
        Me.tptype.Name = "tptype"
        Me.tptype.Size = New System.Drawing.Size(231, 24)
        Me.tptype.TabIndex = 0
        '
        'bclose
        '
        Me.bclose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(188, 84)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(75, 33)
        Me.bclose.TabIndex = 6
        Me.bclose.Text = "&Close"
        Me.bclose.UseVisualStyleBackColor = True
        '
        'badd
        '
        Me.badd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badd.Location = New System.Drawing.Point(94, 84)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(75, 33)
        Me.badd.TabIndex = 5
        Me.badd.Text = "&Add"
        Me.badd.UseVisualStyleBackColor = True
        '
        'frmtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(293, 139)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.badd)
        Me.Controls.Add(Me.tptype)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passenger Types"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tptype As System.Windows.Forms.TextBox
    Friend WithEvents bclose As System.Windows.Forms.Button
    Friend WithEvents badd As System.Windows.Forms.Button
End Class
