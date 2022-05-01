<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtrunc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtrunc))
        Me.btn1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn3 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(52, 55)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(177, 39)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Passengers List"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select what to Preset"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(52, 109)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(177, 39)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Vessel Datas"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 51)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Note: Preseting will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "remove all the datas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         in it.."
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(52, 163)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(177, 39)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "User Accounts"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn4.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(52, 215)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(177, 39)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "Discounts"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'frmtrunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(284, 346)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmtrunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn4 As System.Windows.Forms.Button
End Class
