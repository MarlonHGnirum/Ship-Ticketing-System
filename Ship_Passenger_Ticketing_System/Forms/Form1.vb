Imports MySql.Data.MySqlClient
Public Class frmlogin
    Private Sub bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancel.Click
        Me.Close()
        frmmainm.Close()
    End Sub
    Private Sub blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogin.Click
        frmacnt.bclose2.Visible = False
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
            frmmainm.Enabled = True
            frmmainm.Label1.Enabled = True
            frmmainm.ldate.Enabled = True
            frmmainm.ltime.Enabled = True
            frmmainm.MenuStrip1.Enabled = True
            frmmainm.StatusStrip1.Enabled = True
            frmmainm.statwelcome.Enabled = True
            frmmainm.statdev.Enabled = True
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
            frmmainm.MenuStrip1.Enabled = True
            frmmainm.StatusStrip1.Enabled = True
            frmmainm.statwelcome.Enabled = True
            frmmainm.statdev.Enabled = True
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
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(blogin, "Click To Login")
        ToolTip1.SetToolTip(bcancel, "Click To Cancel")
    End Sub
End Class
