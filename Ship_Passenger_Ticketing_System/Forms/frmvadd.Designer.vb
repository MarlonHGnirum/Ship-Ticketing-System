<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvadd))
        Me.bcancel = New System.Windows.Forms.Button
        Me.tvessel = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.badd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bcancel
        '
        Me.bcancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bcancel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancel.Location = New System.Drawing.Point(165, 75)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 30)
        Me.bcancel.TabIndex = 1
        Me.bcancel.Text = "&Close"
        Me.bcancel.UseVisualStyleBackColor = False
        '
        'tvessel
        '
        Me.tvessel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvessel.Location = New System.Drawing.Point(19, 28)
        Me.tvessel.Name = "tvessel"
        Me.tvessel.Size = New System.Drawing.Size(247, 24)
        Me.tvessel.TabIndex = 2
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badd.Location = New System.Drawing.Point(51, 75)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(75, 30)
        Me.badd.TabIndex = 0
        Me.badd.Text = "&Save"
        Me.badd.UseVisualStyleBackColor = False
        '
        'frmvadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(284, 123)
        Me.ControlBox = False
        Me.Controls.Add(Me.tvessel)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.badd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmvadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents tvessel As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents badd As System.Windows.Forms.Button
End Class
