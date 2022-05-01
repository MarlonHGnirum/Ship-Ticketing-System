<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrefpas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrefpas))
        Me.brefund = New System.Windows.Forms.Button
        Me.tfname = New System.Windows.Forms.TextBox
        Me.tamount = New System.Windows.Forms.TextBox
        Me.bcancel = New System.Windows.Forms.Button
        Me.tlname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'brefund
        '
        Me.brefund.BackColor = System.Drawing.Color.WhiteSmoke
        Me.brefund.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brefund.Location = New System.Drawing.Point(108, 206)
        Me.brefund.Name = "brefund"
        Me.brefund.Size = New System.Drawing.Size(75, 35)
        Me.brefund.TabIndex = 0
        Me.brefund.Text = "&Proceed"
        Me.brefund.UseVisualStyleBackColor = False
        '
        'tfname
        '
        Me.tfname.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfname.Location = New System.Drawing.Point(30, 41)
        Me.tfname.Name = "tfname"
        Me.tfname.Size = New System.Drawing.Size(236, 26)
        Me.tfname.TabIndex = 1
        '
        'tamount
        '
        Me.tamount.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tamount.ForeColor = System.Drawing.Color.Red
        Me.tamount.Location = New System.Drawing.Point(30, 152)
        Me.tamount.Name = "tamount"
        Me.tamount.ReadOnly = True
        Me.tamount.Size = New System.Drawing.Size(153, 26)
        Me.tamount.TabIndex = 2
        '
        'bcancel
        '
        Me.bcancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bcancel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancel.Location = New System.Drawing.Point(193, 206)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 35)
        Me.bcancel.TabIndex = 3
        Me.bcancel.Text = "&Close"
        Me.bcancel.UseVisualStyleBackColor = False
        '
        'tlname
        '
        Me.tlname.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlname.Location = New System.Drawing.Point(30, 94)
        Me.tlname.Name = "tlname"
        Me.tlname.Size = New System.Drawing.Size(238, 26)
        Me.tlname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Refund Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lastname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Firstname"
        '
        'frmrefpas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(293, 255)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tlname)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.tamount)
        Me.Controls.Add(Me.tfname)
        Me.Controls.Add(Me.brefund)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrefpas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refund Passenger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents brefund As System.Windows.Forms.Button
    Friend WithEvents tfname As System.Windows.Forms.TextBox
    Friend WithEvents tamount As System.Windows.Forms.TextBox
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents tlname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
