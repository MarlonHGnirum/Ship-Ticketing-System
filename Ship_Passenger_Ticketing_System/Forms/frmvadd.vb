Imports MySql.Data.MySqlClient
Public Class frmvadd
    Dim b As Boolean = False
    Sub scan()
        Dim s As String = "select vname from tbves where vname ='" & tvessel.Text & "'"
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
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles badd.Click
        If tvessel.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If
        scan()
        If b = True Then
            MsgBox("Vessel Already Exist!!!", MsgBoxStyle.Information, "System Checked")
            tvessel.Text = Nothing
            tvessel.Focus()
            Return
        Else
            Dim st As String = "insert into tbves(vname)values('" & tvessel.Text & "')"
            Dim c As New MySqlCommand(st, con)
            con.Open()
            c.ExecuteNonQuery()
            MsgBox("Vessel Name Save", MsgBoxStyle.Information, "Success")
            con.Close()
        End If
    End Sub
    Private Sub bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancel.Click
        Me.Close()
        frmplace.Show()
        frmplace.vessel()
    End Sub
    Private Sub frmvadd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        frmplace.Refresh()
    End Sub
    Private Sub frmvadd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(badd, "Click To Save")
        ToolTip1.SetToolTip(bcancel, "Click To Close")
    End Sub
    Private Sub tvessel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvessel.Leave
        tvessel.Text = StrConv(tvessel.Text, VbStrConv.ProperCase)
    End Sub
End Class