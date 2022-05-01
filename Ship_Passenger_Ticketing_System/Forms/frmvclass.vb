Imports MySql.Data.MySqlClient
Public Class frmvclass
    Sub clr()
        tclass.Text = Nothing
        tcapacity.Text = Nothing
        tfare.Text = Nothing
    End Sub
    Sub scan()
        Dim s As String = "select vname, tclass from tbclass where vname = '" & vname.Text & "' and tclass = '" & tclass.Text & "'"
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
    Private Sub frmvclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(bsave, "Click To Save")
        ToolTip1.SetToolTip(bref, "Click To Refresh")
        ToolTip1.SetToolTip(bclose, "Click To Close")
    End Sub
    Dim b As Boolean = False
    Private Sub tclass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tclass.Leave
        tclass.Text = StrConv(tclass.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsave.Click
        'to make sure that all the fields are filled with data
        If vname.Text = Nothing Or tclass.Text = Nothing Or tcapacity.Text = Nothing Or tfare.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If
        scan()
        If b = True Then
            MsgBox("Class Already Exist!!!", MsgBoxStyle.Information, "System Checked")
            tclass.Text = Nothing
            tcapacity.Text = Nothing
            tfare.Text = Nothing
            tclass.Focus()
            Return
        End If
        If MessageBox.Show("Do you want to save?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim st As String = "insert into tbclass(vname,tclass,tcapacity,tfare)values('" & vname.Text & "','" & tclass.Text & "','" & tcapacity.Text & "','" & tfare.Text & "')"
            con.Close()
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Class Successfully Save", MsgBoxStyle.Information, "Success")
        End If
        con.Close()
    End Sub
    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        Call clr()
    End Sub
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
    End Sub
    Private Sub tcapacity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcapacity.TextChanged
        If Not IsNumeric(tcapacity.Text) Then
            tcapacity.Text = Nothing
            Return
        End If
    End Sub
    Private Sub tfare_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tfare.TextChanged
        If Not IsNumeric(tfare.Text) Then
            tfare.Text = Nothing
            Return
        End If
    End Sub
End Class