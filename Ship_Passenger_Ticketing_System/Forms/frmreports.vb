Imports MySql.Data.MySqlClient
Public Class frmreports
    Sub CRUD(ByVal qry As String)
        Dim cmd As New MySqlCommand(qry, con)
        If con.State = ConnectionState.Closed Then con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub display()
        Dim it As String = "select pid,tid,tfirst as FirstName,tlast as LastName,type as Type,cbgen,tage,tseat,vname,torig,tdest,cbclass as Class,tfare as Fare,depart,dtpdate,ttotal as Payment,tmoney,tchange FROM tbpassenger"
        Dim da As New MySqlDataAdapter(it, con)
        Dim ds As New DataSet
        da.Fill(ds, "tbpassenger")
        da.Dispose()
        dgvreport.DataSource = ds.Tables(0)
        dgvreport.Columns(0).Visible = False
        dgvreport.Columns(1).Visible = False
        dgvreport.Columns(5).Visible = False
        dgvreport.Columns(6).Visible = False
        dgvreport.Columns(7).Visible = False
        dgvreport.Columns(8).Visible = False
        dgvreport.Columns(9).Visible = False
        dgvreport.Columns(10).Visible = False
        dgvreport.Columns(13).Visible = False
        dgvreport.Columns(14).Visible = False
        dgvreport.Columns(16).Visible = False
        dgvreport.Columns(17).Visible = False
        btnprint.Enabled = False
        con.Close()
    End Sub
    Sub find()
        Dim st As String = "select pid,tid,tfirst as FirstName,tlast as LastName,type as Type,cbgen,tage,tseat,vname,torig,tdest,cbclass as Class,tfare as Fare,depart,dtpdate,ttotal as Payment,tmoney,tchange FROM tbpassenger where vname like '%" & vessels.Text & "%' and dtpdate >= '" & Format(dtpfrom.Value, "MM/dd/yyyy") & "' and dtpdate <= '" & Format(dtpto.Value, "MM/dd/yyyy") & "'"
        Dim dc As New MySqlDataAdapter(st, con)
        Dim dm As New DataSet
        dc.Fill(dm, "tbpassenger")
        dc.Dispose()
        dgvreport.DataSource = dm.Tables(0)
        dgvreport.Columns(0).Visible = False
        dgvreport.Columns(1).Visible = False
        dgvreport.Columns(5).Visible = False
        dgvreport.Columns(6).Visible = False
        dgvreport.Columns(7).Visible = False
        dgvreport.Columns(8).Visible = False
        dgvreport.Columns(9).Visible = False
        dgvreport.Columns(10).Visible = False
        dgvreport.Columns(13).Visible = False
        dgvreport.Columns(14).Visible = False
        dgvreport.Columns(16).Visible = False
        dgvreport.Columns(17).Visible = False
        btnprint.Enabled = True
        con.Close()
    End Sub
    Sub vessel()
        vessels.Items.Clear()
        Dim sc As String = "select vname from tbvessel"
        Dim cmd As New MySqlCommand(sc, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                vessels.Items.Add(dr(0).ToString)
            End While
        End If
        con.Close()
    End Sub
    Private Sub frmreports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display()
        vessel()
        btnprint.Enabled = False
    End Sub
    Private Sub vname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vessels.TextChanged
        display()
    End Sub
    Private Sub bview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bview.Click
        find()
    End Sub
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        CRUD("Truncate Table tbreports")
        For i As Integer = 0 To dgvreport.Rows.Count - 1
            Dim field1, field2, field3, field4, field5, field6, field7, field8, field9, field10, field11 As String
            field1 = dgvreport.Rows(i).Cells(8).Value
            field2 = dgvreport.Rows(i).Cells(2).Value
            field3 = dgvreport.Rows(i).Cells(3).Value
            field4 = dgvreport.Rows(i).Cells(4).Value
            field5 = dgvreport.Rows(i).Cells(11).Value
            field6 = dgvreport.Rows(i).Cells(12).Value
            field7 = dgvreport.Rows(i).Cells(15).Value
            field8 = dgvreport.Rows(i).Cells(16).Value
            field9 = dgvreport.Rows(i).Cells(17).Value
            field10 = Format(dtpfrom.Value, "MM/dd/yyyy")
            field11 = Format(dtpto.Value, "MM/dd/yyyy")
            CRUD("INSERT INTO tbreports(vname,tfirst,tlast,type,tclass,tfare,ttotal,tmoney,tchange,dfrom,dto) values ('" & field1 & "','" & field2 & "','" & field3 & "','" & field4 & "','" & field5 & "','" & field6 & "','" & field7 & "','" & field8 & "','" & field9 & "','" & field10 & "','" & field11 & "')")
        Next

        frmrprts.printrep()
        frmrprts.Show()
    End Sub
End Class