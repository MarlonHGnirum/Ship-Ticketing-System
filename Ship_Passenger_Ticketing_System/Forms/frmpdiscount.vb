Imports MySql.Data.MySqlClient
Public Class frmpdiscount
    Sub clr()
        passtype.Text = Nothing
        passdiscount.Text = Nothing
    End Sub
    Sub Types()
        passtype.Items.Clear()
        Dim lc As String = "select ptype from tbptype"
        Dim c As New MySqlCommand(lc, con)
        con.Open()
        Dim d As MySqlDataReader = c.ExecuteReader
        If d.HasRows Then
            While d.Read
                passtype.Items.Add(d(0).ToString)
            End While
        End If
        con.Close()
    End Sub
    Dim b As Boolean = False
    Sub scan()
        Dim s As String = "select ptype from tbpdiscount where ptype ='" & passtype.Text & "'"
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
    Sub discs()
        Dim it As String = "select id as ID, ptype as PassengerType, discount as DiscountPercent FROM tbpdiscount"
        Dim da As New MySqlDataAdapter(it, con)
        con.Open()

        Dim ds As New DataSet
        da.Fill(ds, "tbpdiscount")
        da.Dispose()
        dgvdisc.DataSource = ds.Tables(0)
        dgvdisc.Columns(0).Visible = False
        con.Close()
    End Sub
    Private Sub frmpdiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lid.Visible = False
        Types()
        discs()
        ToolTip1.SetToolTip(b1, "Click To Save")
        ToolTip1.SetToolTip(b2, "Click To Close")
    End Sub
    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        If b2.Text = "Close" Then
            Me.Close()
        Else
            Call clr()
            lid.Visible = False
            b1.Text = "Save"
            b2.Text = "Close"
        End If
    End Sub
    Private Sub linkadd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkadd.LinkClicked
        frmtype.Show()
    End Sub
    Sub save()
        If passtype.Text = Nothing Or passdiscount.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Call clr()
            Return
        End If
        scan()
        If b = True Then
            MsgBox("Passenger Type Already Exist!!!", MsgBoxStyle.Information, "System Checked")
            Call clr()
            passtype.Focus()
            Return
        End If
        If MessageBox.Show("Do you want to save?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim st As String = "insert into tbpdiscount(ptype,discount)values('" & passtype.Text & "','" & passdiscount.Text & "')"
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Passenger Type Discount Saved!", MsgBoxStyle.Information, "Success")
            con.Close()
            Call clr()
            discs()
        End If
    End Sub
    Private Sub passdiscount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles passdiscount.Leave
        If Val(passdiscount.Text) > 50 Then
            MsgBox("Invalid Value, Maximum of 50% Only!!!", MsgBoxStyle.Information, "System Checked")
            passdiscount.Text = Nothing
            passdiscount.Focus()
        End If
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Call clr()
        passtype.Focus()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If dgvdisc.Rows.Count = 0 Then
            MsgBox("Has No Record To Delete!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        'used to delete record in the table
        If MessageBox.Show("Are you sure you want to delete the record?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sdel As String = "Delete from tbpdiscount where id='" & dgvdisc.SelectedCells(0).Value & "'"
            Dim cmd As New MySqlCommand(sdel, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Deleting Complete", MsgBoxStyle.Information)
            con.Close()
            discs()
        End If
    End Sub
    Sub dlist()
        lid.Text = dgvdisc.SelectedCells(0).Value
        passtype.Text = dgvdisc.SelectedCells(1).Value
        passdiscount.Text = dgvdisc.SelectedCells(2).Value
    End Sub
    Sub updt()
        If passtype.Text = Nothing Or passdiscount.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
        End If
        If MessageBox.Show("Do you want to update?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim st As String = "update tbpdiscount set ptype='" & passtype.Text & "',discount='" & passdiscount.Text & "' where id='" & lid.Text & "'"
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Passenger Type Discount Updated!", MsgBoxStyle.Information, "Success")
            con.Close()
            discs()
            Call clr()
            b1.Text = "Save"
            b2.Text = "Close"
            lid.Visible = False
        End If
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        lid.Visible = True
        If dgvdisc.Rows.Count = 0 Then
            MsgBox("No Records to Edit!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        b1.Text = "Update"
        b2.Text = "Cancel"
        dlist()
    End Sub
    Private Sub passdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passdiscount.TextChanged
        If Not IsNumeric(passdiscount.Text) Then
            passdiscount.Text = Nothing
            Return
        End If
    End Sub
    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        If b1.Text = "Save" Then
            save()
        ElseIf b1.Text = "Update" Then
            updt()
        End If
    End Sub
End Class