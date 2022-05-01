Imports MySql.Data.MySqlClient
Public Class frmacnt
    Sub fresh()
        tuname.Text = Nothing
        tupass.Text = Nothing
        tconf.Text = Nothing
        tadmin.Checked = False
        tstandard.Checked = False
        check.CheckState = False
        icheck.Visible = False
        tuname.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        fresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsave.Click
        'to make sure that all the fields are filled with data
        If tuname.Text = Nothing Or tupass.Text = Nothing Or tconf.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If
        If MessageBox.Show("Do you want to save?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If tadmin.Checked = True Then
                tadmin.Text = "Administrator"
                Dim st As String = "insert into tbaccount(atype,tuname,tupass)values('" & tadmin.Text & "','" & tuname.Text & "','" & tupass.Text & "')"
                Dim cmd As New MySqlCommand(st, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Account Saved!", MsgBoxStyle.Information, "Success")
                con.Close()
            End If
            If tstandard.Checked = True Then
                tstandard.Text = "Standard User"
                Dim st As String = "insert into tbaccount(atype,tuname,tupass)values('" & tstandard.Text & "','" & tuname.Text & "','" & tupass.Text & "')"
                Dim cmd As New MySqlCommand(st, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Account Saved!", MsgBoxStyle.Information, "Success")
                con.Close()
            End If
        End If
    End Sub
    Dim b As Boolean = False
    Sub scan()
        Dim s As String = "select tuname from tbaccount where tuname = '" & tuname.Text & "'"
        Dim cmd As New MySqlCommand(s, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                b = True
            End While
        End If
        con.Close()
    End Sub
    Private Sub frmacnt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        icheck.Visible = False
        iwrong.Visible = False
        tuname.Focus()
        tupass.PasswordChar = "*"
        tconf.PasswordChar = "*"
        ToolTip1.SetToolTip(bsave, "Click To Add")
        ToolTip1.SetToolTip(bref, "Click To Refresh")
        ToolTip1.SetToolTip(bclose, "Click To Close")
    End Sub
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
        tstandard.Enabled = True
    End Sub
    Private Sub tupass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tupass.Leave
        Dim S As String
        S = tupass.Text
        If (S.Length < 5) Or (S.Length > 15) Then
            MsgBox("5 to 15 Characters", MsgBoxStyle.Information, "System Checked")
            tupass.Text = ""
            Return
        End If
    End Sub
    Private Sub show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check.CheckedChanged
        If check.Checked = True Then
            tupass.PasswordChar = ""
        Else
            tupass.PasswordChar = "*"
        End If
        If check.CheckAlign = True Then
            tconf.PasswordChar = ""
        Else
            tconf.PasswordChar = "*"
        End If
    End Sub
    Private Sub tconf_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tconf.Leave
        If Not tupass.Text = tconf.Text Then
            MsgBox("Password doesn't match", MsgBoxStyle.Information, "System Checked")
            tconf.Text = Nothing
            Return
        Else
            icheck.Visible = True
        End If
    End Sub
    Private Sub tuname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tuname.Leave
        scan()
        If b = True Then
            MsgBox("Username Already Exist", MsgBoxStyle.Exclamation, "System Checked")
            fresh()
            tuname.Text = Nothing
            b = False
            Return
        End If
    End Sub
    Private Sub bclose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose2.Click
        Me.Hide()
        bclose2.Visible = False
        tstandard.Enabled = True
        frmmainm.SendToBack()
        frmlogin.ShowDialog()
    End Sub
    Private Sub tconf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tconf.TextChanged
        icheck.Visible = False
        iwrong.Visible = False
        If Not (tupass.Text = tconf.Text) Then
            iwrong.Visible = True
        ElseIf (tupass.Text = tconf.Text) Then
            icheck.Visible = True
        End If
    End Sub
End Class