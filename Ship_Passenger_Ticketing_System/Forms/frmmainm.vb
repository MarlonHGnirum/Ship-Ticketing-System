Imports MySql.Data.MySqlClient
Public Class frmmainm

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Use to display the date and time
        ldate.Text = Date.Now.ToString("MMMM,dd,yyyy")
        ltime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmabout.ShowDialog()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        frmacnt.ShowDialog()
    End Sub
    Private Sub PlaceDestinationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaceDestinationToolStripMenuItem.Click
        frmplace.ShowDialog()
    End Sub
    Private Sub TicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketToolStripMenuItem.Click
        frmticket.ShowDialog()
    End Sub
    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        frmplist.ShowDialog()
    End Sub
    Private Sub RefundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundToolStripMenuItem.Click
        frmrefund.ShowDialog()
    End Sub
    Private Sub EmptyPassengerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmptyPassengerListToolStripMenuItem.Click
        frmtrunc.ShowDialog()
    End Sub
    Dim c As Boolean
    Sub users()
        Dim sc As String = "Select atype,tuname,tupass from tbaccount"
        Dim cmd As New MySqlCommand(sc, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                c = True
            End While
        End If
        con.Close()
    End Sub
    Private Sub frmmainm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Enabled = False
        statdev.Enabled = False
        statwelcome.Text = "Offline"
        Label1.Enabled = False
        ldate.Enabled = False
        ltime.Enabled = False
        StatusStrip1.Enabled = False
        statwelcome.Enabled = False

        users()
        If c = True Then
            frmlogin.ShowDialog()
        End If

        If c = False Then
            If MessageBox.Show("No existing account yet, Do you want to add account?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                frmacnt.bclose2.Visible = True
                frmacnt.bclose.Visible = False
                frmacnt.tstandard.Enabled = False
                frmacnt.ShowDialog()
                frmacnt.bclose.Visible = True
                frmacnt.fresh()
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logouttool.Click
        statwelcome.Text = "Offline"
        Label1.Enabled = False
        ldate.Enabled = False
        mastertool.Enabled = False
        transactiontool.Enabled = False
        utiltool.Enabled = False
        logouttool.Enabled = False
        ltime.Enabled = False
        StatusStrip1.Enabled = False
        statwelcome.Enabled = False
        PlaceDestinationToolStripMenuItem.Enabled = True
        AddUserToolStripMenuItem.Enabled = True
        EmptyPassengerListToolStripMenuItem.Enabled = True
    End Sub
    Private Sub logintool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logintool.Click
        Frmlog.ShowDialog()
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        frmlogin.Close()
    End Sub
    Private Sub ReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem1.Click
        frmreports.ShowDialog()
    End Sub
    Private Sub PassengerDiscountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passDiscounts.Click
        frmpdiscount.ShowDialog()
    End Sub
End Class