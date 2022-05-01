Imports MySql.Data.MySqlClient
Public Class frmrefund
    Sub clr()
        tfirst.Text = Nothing
        tlast.Text = Nothing
    End Sub
    Sub pload()
        Dim it As String = "select pid as ID, vname as Vessel,tfirst as FirstName, tlast as LastName, type as Type, cbgen as Gender, ttotal as Payment from tbpassenger"
        Dim da As New MySqlDataAdapter(it, con)
        Dim ds As New DataSet
        da.Fill(ds, "tbpassenger")
        da.Dispose()
        dgvref.DataSource = ds.Tables(0)
        dgvref.Columns(0).Visible = False
        dgvref.Columns(1).Visible = False
        dgvref.Columns(4).Visible = False
        dgvref.Columns(5).Visible = False
        dgvref.Columns(6).Visible = False
        con.Close()
    End Sub
    Sub find()
        Dim it As String = "select pid as ID, vname as Vessel,tfirst as FirstName, tlast as LastName, type as Type, cbgen as Gender, ttotal as Payment from tbpassenger where tfirst like '" + tfirst.Text + "%' and tlast like '" + tlast.Text + "%'"
        Dim da As New MySqlDataAdapter(it, con)
        Dim ds As New DataSet
        da.Fill(ds, "tbpassenger")
        da.Dispose()
        dgvref.DataSource = ds.Tables(0)
        dgvref.Columns(0).Visible = False
        dgvref.Columns(1).Visible = False
        dgvref.Columns(4).Visible = False
        dgvref.Columns(5).Visible = False
        dgvref.Columns(6).Visible = False
        con.Close()
    End Sub

    Private Sub frmrefund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pload()
        ToolTip1.SetToolTip(bref, "Click To Refresh")
    End Sub

    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        Call clr()
    End Sub

    Private Sub RefundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundToolStripMenuItem.Click
        If dgvref.Rows.Count = 0 Then
            MsgBox("Has No Record To Refund!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        frmrefpas.tfname.Text = dgvref.SelectedCells(2).Value
        frmrefpas.tlname.Text = dgvref.SelectedCells(3).Value
        frmrefpas.tamount.Text = dgvref.SelectedCells(6).Value
        frmrefpas.Show()
    End Sub

    Private Sub tfirst_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tfirst.Leave
        tfirst.Text = StrConv(tfirst.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub tlast_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlast.Leave
        tlast.Text = StrConv(tlast.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub tfirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tfirst.TextChanged
        find()
    End Sub

    Private Sub tlast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlast.TextChanged
        find()
    End Sub

    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
    End Sub
End Class