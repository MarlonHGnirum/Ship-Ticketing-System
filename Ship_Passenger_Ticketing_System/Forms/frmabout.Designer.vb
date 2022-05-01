<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmabout))
        Me.version = New System.Windows.Forms.Label
        Me.copyright = New System.Windows.Forms.Label
        Me.proname = New System.Windows.Forms.Label
        Me.descr = New System.Windows.Forms.Label
        Me.pabout = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.pabout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.BackColor = System.Drawing.Color.Transparent
        Me.version.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.ForeColor = System.Drawing.Color.DarkRed
        Me.version.Location = New System.Drawing.Point(122, 51)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(107, 18)
        Me.version.TabIndex = 7
        Me.version.Text = "Version 1.0.0"
        '
        'copyright
        '
        Me.copyright.AutoSize = True
        Me.copyright.BackColor = System.Drawing.Color.Transparent
        Me.copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyright.ForeColor = System.Drawing.Color.DarkRed
        Me.copyright.Location = New System.Drawing.Point(121, 74)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(90, 18)
        Me.copyright.TabIndex = 8
        Me.copyright.Text = "Copyright :"
        '
        'proname
        '
        Me.proname.AutoSize = True
        Me.proname.BackColor = System.Drawing.Color.Transparent
        Me.proname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proname.ForeColor = System.Drawing.Color.DarkRed
        Me.proname.Location = New System.Drawing.Point(120, 24)
        Me.proname.Name = "proname"
        Me.proname.Size = New System.Drawing.Size(234, 25)
        Me.proname.TabIndex = 6
        Me.proname.Text = "Ocean Shipping Travel"
        '
        'descr
        '
        Me.descr.AutoSize = True
        Me.descr.BackColor = System.Drawing.Color.Transparent
        Me.descr.CausesValidation = False
        Me.descr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descr.ForeColor = System.Drawing.Color.DarkRed
        Me.descr.Location = New System.Drawing.Point(17, 117)
        Me.descr.Name = "descr"
        Me.descr.Size = New System.Drawing.Size(446, 80)
        Me.descr.TabIndex = 10
        Me.descr.Text = resources.GetString("descr.Text")
        '
        'pabout
        '
        Me.pabout.BackColor = System.Drawing.Color.Transparent
        Me.pabout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pabout.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.install_install_icon_36314
        Me.pabout.Location = New System.Drawing.Point(30, 15)
        Me.pabout.Name = "pabout"
        Me.pabout.Size = New System.Drawing.Size(88, 79)
        Me.pabout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pabout.TabIndex = 0
        Me.pabout.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(384, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmabout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(481, 267)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.copyright)
        Me.Controls.Add(Me.proname)
        Me.Controls.Add(Me.descr)
        Me.Controls.Add(Me.pabout)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmabout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About the System"
        CType(Me.pabout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pabout As System.Windows.Forms.PictureBox
    Friend WithEvents version As System.Windows.Forms.Label
    Friend WithEvents copyright As System.Windows.Forms.Label
    Friend WithEvents proname As System.Windows.Forms.Label
    Friend WithEvents descr As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
