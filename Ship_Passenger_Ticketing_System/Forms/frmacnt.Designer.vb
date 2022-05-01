<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmacnt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmacnt))
        Me.tuname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tupass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tconf = New System.Windows.Forms.TextBox
        Me.bsave = New System.Windows.Forms.Button
        Me.bref = New System.Windows.Forms.Button
        Me.tadmin = New System.Windows.Forms.RadioButton
        Me.tstandard = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bclose = New System.Windows.Forms.Button
        Me.check = New System.Windows.Forms.CheckBox
        Me.bclose2 = New System.Windows.Forms.Button
        Me.iwrong = New System.Windows.Forms.PictureBox
        Me.icheck = New System.Windows.Forms.PictureBox
        CType(Me.iwrong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tuname
        '
        Me.tuname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuname.Location = New System.Drawing.Point(128, 29)
        Me.tuname.Name = "tuname"
        Me.tuname.Size = New System.Drawing.Size(228, 22)
        Me.tuname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password :"
        '
        'tupass
        '
        Me.tupass.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tupass.Location = New System.Drawing.Point(127, 64)
        Me.tupass.Name = "tupass"
        Me.tupass.Size = New System.Drawing.Size(228, 22)
        Me.tupass.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm :"
        '
        'tconf
        '
        Me.tconf.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tconf.Location = New System.Drawing.Point(128, 113)
        Me.tconf.Name = "tconf"
        Me.tconf.Size = New System.Drawing.Size(228, 22)
        Me.tconf.TabIndex = 2
        '
        'bsave
        '
        Me.bsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bsave.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bsave.Location = New System.Drawing.Point(61, 254)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(89, 37)
        Me.bsave.TabIndex = 5
        Me.bsave.Text = "&Save"
        Me.bsave.UseVisualStyleBackColor = False
        '
        'bref
        '
        Me.bref.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bref.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bref.Location = New System.Drawing.Point(168, 254)
        Me.bref.Name = "bref"
        Me.bref.Size = New System.Drawing.Size(88, 37)
        Me.bref.TabIndex = 6
        Me.bref.Text = "&Refresh"
        Me.bref.UseVisualStyleBackColor = False
        '
        'tadmin
        '
        Me.tadmin.AutoSize = True
        Me.tadmin.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tadmin.ForeColor = System.Drawing.Color.White
        Me.tadmin.Location = New System.Drawing.Point(35, 187)
        Me.tadmin.Name = "tadmin"
        Me.tadmin.Size = New System.Drawing.Size(156, 22)
        Me.tadmin.TabIndex = 3
        Me.tadmin.TabStop = True
        Me.tadmin.Text = "Administrator"
        Me.tadmin.UseVisualStyleBackColor = True
        '
        'tstandard
        '
        Me.tstandard.AutoSize = True
        Me.tstandard.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstandard.ForeColor = System.Drawing.Color.White
        Me.tstandard.Location = New System.Drawing.Point(35, 216)
        Me.tstandard.Name = "tstandard"
        Me.tstandard.Size = New System.Drawing.Size(156, 22)
        Me.tstandard.TabIndex = 4
        Me.tstandard.TabStop = True
        Me.tstandard.Text = "Standard User"
        Me.tstandard.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Type of Account"
        '
        'bclose
        '
        Me.bclose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bclose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(275, 254)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(88, 37)
        Me.bclose.TabIndex = 7
        Me.bclose.Text = "&Close"
        Me.bclose.UseVisualStyleBackColor = False
        '
        'check
        '
        Me.check.AutoSize = True
        Me.check.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check.Location = New System.Drawing.Point(303, 95)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(52, 17)
        Me.check.TabIndex = 8
        Me.check.Text = "Show"
        Me.check.UseVisualStyleBackColor = True
        '
        'bclose2
        '
        Me.bclose2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bclose2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bclose2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose2.Location = New System.Drawing.Point(276, 254)
        Me.bclose2.Name = "bclose2"
        Me.bclose2.Size = New System.Drawing.Size(88, 37)
        Me.bclose2.TabIndex = 11
        Me.bclose2.Text = "&Close"
        Me.bclose2.UseVisualStyleBackColor = False
        '
        'iwrong
        '
        Me.iwrong.BackgroundImage = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.kreuz
        Me.iwrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.iwrong.Location = New System.Drawing.Point(362, 100)
        Me.iwrong.Name = "iwrong"
        Me.iwrong.Size = New System.Drawing.Size(38, 33)
        Me.iwrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iwrong.TabIndex = 13
        Me.iwrong.TabStop = False
        '
        'icheck
        '
        Me.icheck.BackgroundImage = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.unnamed1
        Me.icheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icheck.Location = New System.Drawing.Point(361, 100)
        Me.icheck.Name = "icheck"
        Me.icheck.Size = New System.Drawing.Size(38, 33)
        Me.icheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.icheck.TabIndex = 12
        Me.icheck.TabStop = False
        '
        'frmacnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.CancelButton = Me.bclose
        Me.ClientSize = New System.Drawing.Size(406, 311)
        Me.Controls.Add(Me.iwrong)
        Me.Controls.Add(Me.icheck)
        Me.Controls.Add(Me.bclose2)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tstandard)
        Me.Controls.Add(Me.tadmin)
        Me.Controls.Add(Me.bref)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tconf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tupass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tuname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmacnt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Account"
        CType(Me.iwrong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tuname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tupass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tconf As System.Windows.Forms.TextBox
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents bref As System.Windows.Forms.Button
    Friend WithEvents tadmin As System.Windows.Forms.RadioButton
    Friend WithEvents tstandard As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents bclose As System.Windows.Forms.Button
    Friend WithEvents check As System.Windows.Forms.CheckBox
    Friend WithEvents bclose2 As System.Windows.Forms.Button
    Friend WithEvents icheck As System.Windows.Forms.PictureBox
    Friend WithEvents iwrong As System.Windows.Forms.PictureBox
End Class
