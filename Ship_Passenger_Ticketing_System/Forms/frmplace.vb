Imports MySql.Data.MySqlClient
Public Class frmplace
    Sub clr()
        vname.Text = Nothing
        tdest.Text = Nothing
        torig.Text = Nothing
        vessel()
    End Sub
    Sub fresh()
        vname.Text = Nothing
        torig.Text = Nothing
        tdest.Text = Nothing
        depart.Text = Nothing
        vname.Focus()
    End Sub
    Dim b As Boolean = False
    Sub scan()
        Dim s As String = "select vname from tbvessel where vname ='" & vname.Text & "'"
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
    Sub vessel()
        vname.Items.Clear()
        Dim lc As String = "select vname from tbves"
        Dim c As New MySqlCommand(lc, con)
        con.Open()
        Dim d As MySqlDataReader = c.ExecuteReader
        If d.HasRows Then
            While d.Read
                vname.Items.Add(d(0).ToString)
            End While
        End If
        con.Close()
    End Sub
    Sub vuser()
        Dim it As String = "select vid as ID, vname as Vessel, torig as Origin, tdest as Destination, depart as Departure from tbvessel"
        Dim da As New MySqlDataAdapter(it, con)
        con.Open()

        Dim ds As New DataSet
        da.Fill(ds, "tbvessel")
        da.Dispose()
        dgv2.DataSource = ds.Tables(0)
        dgv2.Columns(0).Visible = False
        con.Close()
    End Sub
    Sub velist()
        frmvup.lblid.Text = dgv2.SelectedCells(0).Value
        frmvup.vname.Text = dgv2.SelectedCells(1).Value
        frmvup.torig.Text = dgv2.SelectedCells(2).Value
        frmvup.tdest.Text = dgv2.SelectedCells(3).Value
        frmvup.depart.Text = dgv2.SelectedCells(4).Value
    End Sub
    Sub clist()
        frmvclass.vname.Text = dgv2.SelectedCells(1).Value
    End Sub
    Private Sub frmplace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vessel()
        vuser()
        ToolTip2.SetToolTip(badd, "Click To Add")
        ToolTip2.SetToolTip(bref, "Click To Refresh")
        ToolTip2.SetToolTip(bclose, "Click To Close")
    End Sub
    Private Sub badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles badd.Click
        'to confirm the password if correctly filled up
        'to make sure that all the fields are filled with data
        If vname.Text = Nothing Or torig.Text = Nothing Or tdest.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If
        scan()
        If b = True Then
            MsgBox("Already Exist!!!", MsgBoxStyle.Information, "System Checked")
            vname.Text = Nothing
            vname.Focus()
            Return
        End If
        If MessageBox.Show("Do you want to save?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim st As String = "insert into tbvessel(vname,torig,tdest,depart)values('" & vname.Text & "','" & torig.Text & "','" & tdest.Text & "','" & Format(depart.Value, "hh:mm:ss") & "')"
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Vessel Saved!", MsgBoxStyle.Information, "Success")
            con.Close()
            vuser()
        End If
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If dgv2.Rows.Count = 0 Then
            MsgBox("No Records to Edit!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        velist()
        frmvup.Show()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'to test if datagridview has no record to delete
        If dgv2.Rows.Count = 0 Then
            MsgBox("Has No Record To Delete!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        'used to delete record in the table
        If MessageBox.Show("Are you sure you want to delete the record?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sdel As String = "Delete from tbvessel where vid='" & dgv2.SelectedCells(0).Value & "'"
            Dim cmd As New MySqlCommand(sdel, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Deleting Complete", MsgBoxStyle.Information)
            con.Close()
            vuser()
            vessel()
        End If
    End Sub
    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        Call clr()
    End Sub
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
    End Sub
    Private Sub AddClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddClassToolStripMenuItem.Click
        If dgv2.Rows.Count = 0 Then
            MsgBox("No Records to Edit!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        clist()
        frmvclass.Show()
    End Sub
    Private Sub ladd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ladd.LinkClicked
        frmvadd.Show()
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        fresh()
    End Sub
    Private Sub torig_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles torig.Leave
        torig.Text = StrConv(torig.Text, VbStrConv.ProperCase)
    End Sub
    Private Sub tdest_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdest.Leave
        tdest.Text = StrConv(tdest.Text, VbStrConv.ProperCase)
    End Sub
End Class