<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvup))
        Me.bclose = New System.Windows.Forms.Button
        Me.bref = New System.Windows.Forms.Button
        Me.bupdate = New System.Windows.Forms.Button
        Me.vname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.torig = New System.Windows.Forms.TextBox
        Me.tdest = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.depart = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bclose
        '
        Me.bclose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(235, 202)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(80, 35)
        Me.bclose.TabIndex = 7
        Me.bclose.Text = "&Close"
        Me.bclose.UseVisualStyleBackColor = True
        '
        'bref
        '
        Me.bref.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bref.Location = New System.Drawing.Point(235, 151)
        Me.bref.Name = "bref"
        Me.bref.Size = New System.Drawing.Size(80, 35)
        Me.bref.TabIndex = 6
        Me.bref.Text = "&Refresh"
        Me.bref.UseVisualStyleBackColor = True
        '
        'bupdate
        '
        Me.bupdate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bupdate.Location = New System.Drawing.Point(235, 98)
        Me.bupdate.Name = "bupdate"
        Me.bupdate.Size = New System.Drawing.Size(80, 35)
        Me.bupdate.TabIndex = 5
        Me.bupdate.Text = "&Update"
        Me.bupdate.UseVisualStyleBackColor = True
        '
        'vname
        '
        Me.vname.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vname.Location = New System.Drawing.Point(25, 75)
        Me.vname.Name = "vname"
        Me.vname.Size = New System.Drawing.Size(191, 24)
        Me.vname.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Destination"
        '
        'torig
        '
        Me.torig.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.torig.Location = New System.Drawing.Point(24, 126)
        Me.torig.Name = "torig"
        Me.torig.Size = New System.Drawing.Size(190, 24)
        Me.torig.TabIndex = 1
        '
        'tdest
        '
        Me.tdest.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdest.Location = New System.Drawing.Point(25, 179)
        Me.tdest.Name = "tdest"
        Me.tdest.Size = New System.Drawing.Size(191, 24)
        Me.tdest.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Vessel Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Origin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ID No."
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(22, 32)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(17, 17)
        Me.lblid.TabIndex = 38
        Me.lblid.Text = "#"
        '
        'depart
        '
        Me.depart.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.depart.Location = New System.Drawing.Point(24, 231)
        Me.depart.Name = "depart"
        Me.depart.Size = New System.Drawing.Size(190, 24)
        Me.depart.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Departure"
        '
        'frmvup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(331, 292)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.depart)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.bref)
        Me.Controls.Add(Me.bupdate)
        Me.Controls.Add(Me.vname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.torig)
        Me.Controls.Add(Me.tdest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vessel Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bclose As System.Windows.Forms.Button
    Friend WithEvents bref As System.Windows.Forms.Button
    Friend WithEvents bupdate As System.Windows.Forms.Button
    Friend WithEvents vname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents torig As System.Windows.Forms.TextBox
    Friend WithEvents tdest As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents depart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
