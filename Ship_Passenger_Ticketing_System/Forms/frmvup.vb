Imports MySql.Data.MySqlClient
Public Class frmvup
    Sub clr()
        vname.Text = Nothing
        torig.Text = Nothing
        tdest.Text = Nothing
    End Sub
    Private Sub frmvup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip3.SetToolTip(bupdate, "Click To Update")
        ToolTip3.SetToolTip(bref, "Click To Refresh")
        ToolTip3.SetToolTip(bclose, "Click To Close")
    End Sub
    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        Call clr()
    End Sub
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
        frmplace.Show()
    End Sub
    Private Sub bupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bupdate.Click
        'to make sure that all the fields are filled with data
        If vname.Text = Nothing Or torig.Text = Nothing Or tdest.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If
        If MessageBox.Show("Do you want to save?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim st As String = "Update tbvessel set vname='" & vname.Text & "',torig='" & torig.Text & "',tdest='" & tdest.Text & "',depart='" & Format(depart.Value, "hh:mm:ss") & "' where vid='" & lblid.Text & "'"
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Update Success!", MsgBoxStyle.Information, "Success")
            con.Close()
            frmplace.vuser()
        End If
    End Sub
End Class