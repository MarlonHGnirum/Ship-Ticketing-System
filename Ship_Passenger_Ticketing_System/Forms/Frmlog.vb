Imports MySql.Data.MySqlClient
Public Class Frmlog
    Private Sub bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancel.Click
        Me.Close()
    End Sub
    Private Sub blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogin.Click
        If type.Text = Nothing Or tuname.Text = Nothing Or tupass.Text = Nothing Then
            MsgBox("Fill The Missing  data!", MsgBoxStyle.Information, "System Checked!")
            Return
        End If
        'calling the function/procedure scan
        scan()
        If b = True And type.SelectedItem = "Administrator" Then
            Me.Hide()
            frmmainm.SendToBack()
            frmload.ShowDialog()
            frmmainm.Label1.Enabled = True
            frmmainm.ldate.Enabled = True
            frmmainm.mastertool.Enabled = True
            frmmainm.transactiontool.Enabled = True
            frmmainm.utiltool.Enabled = True
            frmmainm.logouttool.Enabled = True
            frmmainm.ltime.Enabled = True
            frmmainm.StatusStrip1.Enabled = True
            frmmainm.statwelcome.Enabled = True
            frmmainm.logouttool.Enabled = True
            frmmainm.PlaceDestinationToolStripMenuItem.Enabled = True
            frmmainm.AddUserToolStripMenuItem.Enabled = True
            frmmainm.EmptyPassengerListToolStripMenuItem.Enabled = True
            frmmainm.statwelcome.Text = type.Text + " is Online : " + tuname.Text
            Me.Close()
        ElseIf b = True And type.SelectedItem = "Standard User" Then
            Me.Hide()
            frmmainm.SendToBack()
            frmload.ShowDialog()
            frmmainm.Enabled = True
            frmmainm.Label1.Enabled = True
            frmmainm.ldate.Enabled = True
            frmmainm.ltime.Enabled = True
            frmmainm.StatusStrip1.Enabled = True
            frmmainm.statwelcome.Enabled = True
            frmmainm.statdev.Enabled = True
            frmmainm.mastertool.Enabled = True
            frmmainm.transactiontool.Enabled = True
            frmmainm.utiltool.Enabled = True
            frmmainm.logouttool.Enabled = True
            frmmainm.PlaceDestinationToolStripMenuItem.Enabled = False
            frmmainm.AddUserToolStripMenuItem.Enabled = False
            frmmainm.passDiscounts.Enabled = False
            frmmainm.EmptyPassengerListToolStripMenuItem.Enabled = False
            frmmainm.statwelcome.Text = type.Text + " is Online : " + tuname.Text
            Me.Close()
        Else
            MsgBox("Invalid Input!!", MsgBoxStyle.Information, "System Checked")
            tupass.Text = Nothing
            tupass.Focus()
            Return
        End If
    End Sub
    Dim b As Boolean = False
    Sub scan()
        Dim sc As String = "Select atype,tuname,tupass from tbaccount where atype='" & type.Text & "' and tuname='" & tuname.Text & "' and tupass='" & tupass.Text & "' "
        Dim cmd As New MySqlCommand(sc, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                b = True
            End While
        End If
        con.Close()
    End Sub

    Private Sub tupass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tupass.TextChanged
        tupass.PasswordChar = "*"
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
    Private Sub Frmlog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(blogin, "Click To Login")
        ToolTip1.SetToolTip(bcancel, "Click To Cancel")
        tuname.Text = Nothing
        tupass.Text = Nothing
        users()
        If c = False Then
            If MessageBox.Show("No existing account yet, Do you want to add account?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                frmacnt.bclose2.Visible = False
                frmacnt.bclose.Visible = True
                frmacnt.tstandard.Enabled = False
                frmacnt.ShowDialog()
                frmacnt.fresh()
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class