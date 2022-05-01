Imports MySql.Data.MySqlClient
Public Class frmplist
    Sub CRUD(ByVal qry As String)
        Dim cmd As New MySqlCommand(qry, Con)
        If Con.State = ConnectionState.Closed Then Con.Open()
        cmd.ExecuteNonQuery()
        Con.Close()
    End Sub
    Sub display()
        Dim it As String = "select pid, tid, tfirst as FirstName, tlast as LastName, type as Type, cbgen as Gender, tage as Age, tseat as SeatNo, vname, torig, tdest, cbclass as Class, tfare, depart,dtpdate, ttotal, tmoney, tchange FROM tbpassenger"
        Dim da As New MySqlDataAdapter(it, con)
        Dim ds As New DataSet
        da.Fill(ds, "tbpassenger")
        da.Dispose()
        dgvlist.DataSource = ds.Tables(0)
        dgvlist.Columns(0).Visible = False
        dgvlist.Columns(1).Visible = False
        dgvlist.Columns(4).Visible = False
        dgvlist.Columns(8).Visible = False
        dgvlist.Columns(9).Visible = False
        dgvlist.Columns(10).Visible = False
        dgvlist.Columns(12).Visible = False
        dgvlist.Columns(13).Visible = False
        dgvlist.Columns(14).Visible = False
        dgvlist.Columns(15).Visible = False
        dgvlist.Columns(16).Visible = False
        dgvlist.Columns(17).Visible = False
        cnt()
        bprint.Enabled = False
        con.Close()
    End Sub
    Sub cnt()
        Dim count As String = 0
        For i As Integer = 0 To dgvlist.RowCount - 1
            count = count + 1

        Next
        lpass.Text = count
    End Sub
    Sub search()
        Dim st As String = "select pid, tid, tfirst as FirstName, tlast as LastName, type as Type, cbgen as Gender, tage as Age, tseat  as SeatNo, vname, torig, tdest, cbclass as Class, tfare, depart, dtpdate, ttotal, tmoney, tchange FROM tbpassenger where vname like '%" & vname.Text & "%' and dtpdate like '" & Format(dtpdate.Value, "MM/dd/yyyy") & "' "
        Dim dc As New MySqlDataAdapter(st, con1)
        Dim dm As New DataSet
        dc.Fill(dm, "tbpassenger")
        dc.Dispose()
        dgvlist.DataSource = dm.Tables(0)
        dgvlist.Columns(0).Visible = False
        dgvlist.Columns(1).Visible = False
        dgvlist.Columns(4).Visible = False
        dgvlist.Columns(8).Visible = False
        dgvlist.Columns(9).Visible = False
        dgvlist.Columns(10).Visible = False
        dgvlist.Columns(12).Visible = False
        dgvlist.Columns(13).Visible = False
        dgvlist.Columns(14).Visible = False
        dgvlist.Columns(15).Visible = False
        dgvlist.Columns(16).Visible = False
        dgvlist.Columns(17).Visible = False
        cnt()
        bprint.Enabled = True
        con1.Close()
    End Sub
    Sub marl()
        vname.Items.Clear()
        Dim lc As String = "select vname from tbvessel"
        Dim c As New MySqlCommand(lc, con1)
        con1.Open()
        Dim d As MySqlDataReader = c.ExecuteReader
        If d.HasRows Then
            While d.Read
                vname.Items.Add(d(0).ToString)
            End While
        End If
        con1.Close()
    End Sub
    Private Sub frmplist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        marl()
        display()
        ToolTip1.SetToolTip(bprint, "Click To Print")
        bprint.Enabled = False
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        frmticket.Show()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'to test if datagridview has no record to delete
        If dgvlist.Rows.Count = 0 Then
            MsgBox("Has No Record To Delete!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        'used to delete record in the table
        If MessageBox.Show("Are you sure you want to delete the record?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sdel As String = "Delete from tbpassenger where pid='" & dgvlist.SelectedCells(0).Value & "'"
            Dim cmd As New MySqlCommand(sdel, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Deleting Complete", MsgBoxStyle.Information)
            con.Close()
            display()
        End If
    End Sub
    Sub plist()
        frmplistup.lblid.Text = dgvlist.SelectedCells(0).Value
        frmplistup.tid.Text = dgvlist.SelectedCells(1).Value
        frmplistup.tfirst.Text = dgvlist.SelectedCells(2).Value
        frmplistup.tlast.Text = dgvlist.SelectedCells(3).Value
        frmplistup.type.Text = dgvlist.SelectedCells(4).Value
        frmplistup.cbgen.Text = dgvlist.SelectedCells(5).Value
        frmplistup.tage.Text = dgvlist.SelectedCells(6).Value
        frmplistup.tseat.Text = dgvlist.SelectedCells(7).Value
        frmplistup.vname.Text = dgvlist.SelectedCells(8).Value
        frmplistup.torig.Text = dgvlist.SelectedCells(9).Value
        frmplistup.tdest.Text = dgvlist.SelectedCells(10).Value
        frmplistup.cbclass.Text = dgvlist.SelectedCells(11).Value
        frmplistup.tfare.Text = dgvlist.SelectedCells(12).Value
        frmplistup.depart.Text = dgvlist.SelectedCells(13).Value
        frmplistup.dtpdate.Text = dgvlist.SelectedCells(14).Value
        frmplistup.ttotal.Text = dgvlist.SelectedCells(15).Value
        frmplistup.tmoney.Text = dgvlist.SelectedCells(16).Value
        frmplistup.tchange.Text = dgvlist.SelectedCells(17).Value
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If dgvlist.Rows.Count = 0 Then
            MsgBox("No Records to Edit!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        plist()
        frmplistup.Show()
    End Sub
    Private Sub tsearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vname.TextChanged
        display()
    End Sub
    Private Sub bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click
        CRUD("Truncate Table tbplist")
        For i As Integer = 0 To dgvlist.Rows.Count - 1
            Dim field1, field2, field3, field4, field5, field6 As String
            field1 = dgvlist.Rows(i).Cells(2).Value
            field2 = dgvlist.Rows(i).Cells(3).Value
            field3 = dgvlist.Rows(i).Cells(6).Value
            field4 = dgvlist.Rows(i).Cells(5).Value
            field5 = dgvlist.Rows(i).Cells(8).Value
            field6 = dgvlist.Rows(i).Cells(14).Value
            CRUD("INSERT INTO tbplist(tfirst,tlast,tage,tgender,vname,dtpdate) values ('" & field1 & "','" & field2 & "','" & field3 & "','" & field4 & "','" & field5 & "','" & field6 & "')")
        Next

        frmprintp.printpass()
        frmprintp.Show()
    End Sub
    Private Sub vsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vname.SelectedIndexChanged
        search()
    End Sub
    Private Sub dsearch_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdate.ValueChanged
        search()
    End Sub
    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        display()
        vname.Text = Nothing
    End Sub
End Class