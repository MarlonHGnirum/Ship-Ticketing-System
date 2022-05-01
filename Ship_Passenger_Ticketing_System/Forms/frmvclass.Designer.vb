<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvclass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvclass))
        Me.Label6 = New System.Windows.Forms.Label
        Me.bclose = New System.Windows.Forms.Button
        Me.tclass = New System.Windows.Forms.TextBox
        Me.bref = New System.Windows.Forms.Button
        Me.bsave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tcapacity = New System.Windows.Forms.TextBox
        Me.tfare = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.vname = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Capacity"
        '
        'bclose
        '
        Me.bclose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bclose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(231, 161)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(80, 35)
        Me.bclose.TabIndex = 7
        Me.bclose.Text = "&Close"
        Me.bclose.UseVisualStyleBackColor = False
        '
        'tclass
        '
        Me.tclass.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tclass.Location = New System.Drawing.Point(28, 84)
        Me.tclass.Name = "tclass"
        Me.tclass.Size = New System.Drawing.Size(178, 24)
        Me.tclass.TabIndex = 2
        '
        'bref
        '
        Me.bref.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bref.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bref.Location = New System.Drawing.Point(231, 111)
        Me.bref.Name = "bref"
        Me.bref.Size = New System.Drawing.Size(80, 35)
        Me.bref.TabIndex = 6
        Me.bref.Text = "&Refresh"
        Me.bref.UseVisualStyleBackColor = False
        '
        'bsave
        '
        Me.bsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bsave.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsave.Location = New System.Drawing.Point(231, 58)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(80, 35)
        Me.bsave.TabIndex = 5
        Me.bsave.Text = "&Save"
        Me.bsave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Vessel Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Class"
        '
        'tcapacity
        '
        Me.tcapacity.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcapacity.Location = New System.Drawing.Point(28, 139)
        Me.tcapacity.Name = "tcapacity"
        Me.tcapacity.Size = New System.Drawing.Size(178, 24)
        Me.tcapacity.TabIndex = 3
        '
        'tfare
        '
        Me.tfare.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfare.Location = New System.Drawing.Point(28, 196)
        Me.tfare.Name = "tfare"
        Me.tfare.Size = New System.Drawing.Size(178, 24)
        Me.tfare.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Fare"
        '
        'vname
        '
        Me.vname.BackColor = System.Drawing.Color.White
        Me.vname.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vname.Location = New System.Drawing.Point(28, 31)
        Me.vname.Name = "vname"
        Me.vname.ReadOnly = True
        Me.vname.Size = New System.Drawing.Size(178, 24)
        Me.vname.TabIndex = 1
        '
        'frmvclass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(332, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.vname)
        Me.Controls.Add(Me.tfare)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcapacity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.tclass)
        Me.Controls.Add(Me.bref)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvclass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vessel Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bclose As System.Windows.Forms.Button
    Friend WithEvents tclass As System.Windows.Forms.TextBox
    Friend WithEvents bref As System.Windows.Forms.Button
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tcapacity As System.Windows.Forms.TextBox
    Friend WithEvents tfare As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents vname As System.Windows.Forms.TextBox
End Class
