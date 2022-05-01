Imports MySql.Data.MySqlClient
Public Class frmtype
    Dim b As Boolean = False
    Sub filter()
        Dim lc As String = "select ptype from tbptype where ptype='" & tptype.Text & "'"
        Dim c As New MySqlCommand(lc, con1)
        con1.Open()
        Dim d As MySqlDataReader = c.ExecuteReader
        If d.HasRows Then
            While d.Read
                b = True
            End While
        End If
        con1.Close()
    End Sub
    Private Sub badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles badd.Click
        If tptype.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If
        filter()
        If b = True Then
            MsgBox("Type Already Exist!!!", MsgBoxStyle.Information, "System Checked")
            tptype.Text = Nothing
            tptype.Focus()
            Return
        End If
        If MessageBox.Show("Do you want to add?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim st As String = "insert into tbptype(ptype)values('" & tptype.Text & "')"
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Type Added!", MsgBoxStyle.Information, "Success")
            con.Close()
        End If
    End Sub
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
        frmpdiscount.Types()
    End Sub
    Private Sub tptype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tptype.Leave
        tptype.Text = StrConv(tptype.Text, VbStrConv.ProperCase)
    End Sub
End Class