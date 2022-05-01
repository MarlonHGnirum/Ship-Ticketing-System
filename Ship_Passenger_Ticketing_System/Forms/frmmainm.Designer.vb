<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmainm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmainm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ltime = New System.Windows.Forms.Label
        Me.ldate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statwelcome = New System.Windows.Forms.ToolStripStatusLabel
        Me.statdev = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mastertool = New System.Windows.Forms.ToolStripMenuItem
        Me.PlaceDestinationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.transactiontool = New System.Windows.Forms.ToolStripMenuItem
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.utiltool = New System.Windows.Forms.ToolStripMenuItem
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.passDiscounts = New System.Windows.Forms.ToolStripMenuItem
        Me.EmptyPassengerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.logstool = New System.Windows.Forms.ToolStripMenuItem
        Me.logintool = New System.Windows.Forms.ToolStripMenuItem
        Me.logouttool = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ltime)
        Me.Panel1.Controls.Add(Me.ldate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1375, 78)
        Me.Panel1.TabIndex = 0
        '
        'ltime
        '
        Me.ltime.AutoSize = True
        Me.ltime.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltime.ForeColor = System.Drawing.Color.GhostWhite
        Me.ltime.Location = New System.Drawing.Point(1224, 38)
        Me.ltime.Name = "ltime"
        Me.ltime.Size = New System.Drawing.Size(48, 19)
        Me.ltime.TabIndex = 3
        Me.ltime.Text = "Time :"
        '
        'ldate
        '
        Me.ldate.AutoSize = True
        Me.ldate.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldate.ForeColor = System.Drawing.Color.GhostWhite
        Me.ldate.Location = New System.Drawing.Point(1225, 10)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(48, 19)
        Me.ldate.TabIndex = 2
        Me.ldate.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ocean Shipping Travel"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statwelcome, Me.statdev})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 559)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1070, 28)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statwelcome
        '
        Me.statwelcome.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.statwelcome.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statwelcome.ForeColor = System.Drawing.Color.GhostWhite
        Me.statwelcome.Name = "statwelcome"
        Me.statwelcome.Size = New System.Drawing.Size(91, 23)
        Me.statwelcome.Text = "Welcome:"
        '
        'statdev
        '
        Me.statdev.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statdev.ForeColor = System.Drawing.Color.GhostWhite
        Me.statdev.Name = "statdev"
        Me.statdev.Size = New System.Drawing.Size(1054, 19)
        Me.statdev.Text = resources.GetString("statdev.Text")
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(0, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1380, 10)
        Me.Panel2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mastertool, Me.transactiontool, Me.utiltool, Me.logstool})
        Me.MenuStrip1.Location = New System.Drawing.Point(-3, 81)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(616, 31)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mastertool
        '
        Me.mastertool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaceDestinationToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ReportsToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.mastertool.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mastertool.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_11
        Me.mastertool.Name = "mastertool"
        Me.mastertool.Size = New System.Drawing.Size(116, 27)
        Me.mastertool.Text = "Master"
        '
        'PlaceDestinationToolStripMenuItem
        '
        Me.PlaceDestinationToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceDestinationToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources._038422_glossy_black_icon_transport_travel_transportation_cruise_ship
        Me.PlaceDestinationToolStripMenuItem.Name = "PlaceDestinationToolStripMenuItem"
        Me.PlaceDestinationToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.PlaceDestinationToolStripMenuItem.Text = "Vessel and Routes"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_1
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.ReportsToolStripMenuItem.Text = "Passengers"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.analytics_512
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(267, 28)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_6
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(267, 28)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'transactiontool
        '
        Me.transactiontool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketToolStripMenuItem, Me.RefundToolStripMenuItem})
        Me.transactiontool.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactiontool.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images1
        Me.transactiontool.Name = "transactiontool"
        Me.transactiontool.Size = New System.Drawing.Size(181, 27)
        Me.transactiontool.Text = "Transaction"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.unnamed
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(158, 28)
        Me.TicketToolStripMenuItem.Text = "Ticket"
        '
        'RefundToolStripMenuItem
        '
        Me.RefundToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_2
        Me.RefundToolStripMenuItem.Name = "RefundToolStripMenuItem"
        Me.RefundToolStripMenuItem.Size = New System.Drawing.Size(158, 28)
        Me.RefundToolStripMenuItem.Text = "Refund"
        '
        'utiltool
        '
        Me.utiltool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.passDiscounts, Me.EmptyPassengerListToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.utiltool.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.utiltool.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_31
        Me.utiltool.Name = "utiltool"
        Me.utiltool.Size = New System.Drawing.Size(90, 27)
        Me.utiltool.Text = "More"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images__9_
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(327, 28)
        Me.AddUserToolStripMenuItem.Text = "System User"
        '
        'passDiscounts
        '
        Me.passDiscounts.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.get_discount_512
        Me.passDiscounts.Name = "passDiscounts"
        Me.passDiscounts.Size = New System.Drawing.Size(327, 28)
        Me.passDiscounts.Text = "Passenger Discounts"
        '
        'EmptyPassengerListToolStripMenuItem
        '
        Me.EmptyPassengerListToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_3
        Me.EmptyPassengerListToolStripMenuItem.Name = "EmptyPassengerListToolStripMenuItem"
        Me.EmptyPassengerListToolStripMenuItem.Size = New System.Drawing.Size(327, 28)
        Me.EmptyPassengerListToolStripMenuItem.Text = "Data Engine"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_21
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(327, 28)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'logstool
        '
        Me.logstool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.logintool, Me.logouttool})
        Me.logstool.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logstool.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.software_grey
        Me.logstool.Name = "logstool"
        Me.logstool.Size = New System.Drawing.Size(129, 27)
        Me.logstool.Text = "Utility"
        '
        'logintool
        '
        Me.logintool.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_51
        Me.logintool.Name = "logintool"
        Me.logintool.Size = New System.Drawing.Size(158, 28)
        Me.logintool.Text = "Login"
        '
        'logouttool
        '
        Me.logouttool.Image = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.images_4
        Me.logouttool.Name = "logouttool"
        Me.logouttool.Size = New System.Drawing.Size(158, 28)
        Me.logouttool.Text = "Logout"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmmainm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Ship_Passenger_Ticketing_System.My.Resources.Resources.logo_ocean_shipping
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "frmmainm"
        Me.Text = "_Welcome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statwelcome As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mastertool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents transactiontool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents utiltool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logstool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaceDestinationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents ltime As System.Windows.Forms.Label
    Friend WithEvents RefundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmptyPassengerListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statdev As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents logintool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logouttool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents passDiscounts As System.Windows.Forms.ToolStripMenuItem
End Class
