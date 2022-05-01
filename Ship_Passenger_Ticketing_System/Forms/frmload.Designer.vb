<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmload))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pload = New System.Windows.Forms.PictureBox
        CType(Me.pload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'pload
        '
        Me.pload.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pload.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.ajax_loader_200x200_trans_blue
        Me.pload.Location = New System.Drawing.Point(113, 56)
        Me.pload.Name = "pload"
        Me.pload.Size = New System.Drawing.Size(144, 142)
        Me.pload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pload.TabIndex = 1
        Me.pload.TabStop = False
        '
        'frmload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(370, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.pload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        CType(Me.pload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pload As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
