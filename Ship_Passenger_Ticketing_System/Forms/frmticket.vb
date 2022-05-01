Imports MySql.Data.MySqlClient
Public Class frmticket
    Sub clr()
        vname.Text = Nothing
        torig.Text = Nothing
        tdest.Text = Nothing
        cbclass.Text = Nothing
        tseat.Text = Nothing
        tfare.Text = Nothing
        dtpdate.Text = Nothing
        depart.Text = Nothing
        tfirst.Text = Nothing
        tlast.Text = Nothing
        cbgen.Text = Nothing
        tage.Text = Nothing
        type.Text = Nothing
        ttotal.Text = Nothing
        tmoney.Text = Nothing
        tchange.Text = Nothing
    End Sub
    Sub loadid()
        tid.Text = "OST-" & Format(AutoID("tbpassenger", "tid"), "0000000")
    End Sub
    Sub vessel()
        vname.Items.Clear()
        Dim sc As String = "select vname from tbvessel"
        Dim cmd As New MySqlCommand(sc, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                vname.Items.Add(dr(0).ToString)
            End While
        End If
        con.Close()
    End Sub
    Sub passtype()
        type.Items.Clear()
        Dim lc As String = "select ptype from tbpdiscount"
        Dim c As New MySqlCommand(lc, con)
        con.Open()
        Dim ds As MySqlDataReader = c.ExecuteReader
        If ds.HasRows Then
            While ds.Read
                type.Items.Add(ds(0).ToString)
            End While
        End If
        con.Close()
    End Sub
    Sub selecttype()
        Dim lc As String = "select ptype,discount from tbpdiscount where ptype='" & type.Text & "' "
        Dim c As New MySqlCommand(lc, con)
        con.Open()
        Dim dl As MySqlDataReader = c.ExecuteReader
        If dl.HasRows Then
            While dl.Read
                Dim disc As Double = Nothing
                disc = dl(1)
                Dim par As Double = 0
                Dim total As Double = 0
                Dim dis As Double = disc / 100

                par = Val(tfare.Text) * dis
                total = Val(tfare.Text) - par
                ttotal.Text = Format(total, "###,###.00")
            End While
        End If
        con.Close()
    End Sub
    Sub luser()
        Dim it As String = "SELECT vname, torig, tdest, depart FROM tbvessel where vname= '" & vname.Text & "'"
        Dim cmd As New MySqlCommand(it, con)
        con.Open()
        Dim ds As New DataSet
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                torig.Text = dr(1)
                tdest.Text = dr(2)
                depart.Text = dr(3)
            End While
        End If
        con.Close()
    End Sub
    Sub vclass()
        cbclass.Items.Clear()
        Dim sc As String = "SELECT vname,tclass FROM tbclass where vname = '" & vname.Text & "'"
        Dim cmd As New MySqlCommand(sc, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cbclass.Items.Add(dr(1).ToString)
            End While
        End If
        con.Close()
    End Sub
    Dim sls As Double = Nothing
    Dim temp2 As Integer = Nothing
    Sub seat()
        tseat.Items.Clear()
        Dim sc As String = "SELECT vname,tclass,tcapacity,tfare,temp FROM tbclass where vname='" & vname.Text & "' AND tclass='" & cbclass.Text & "'"
        Dim cmd As New MySqlCommand(sc, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                temp2 = dr(4) + 1
                tfare.Text = dr(3)
                If dr(4) = dr(2) Then
                    MsgBox("Class Already Full", MsgBoxStyle.Information, "System Checked")
                    cbclass.Focus()
                End If

                For i As Integer = temp2 To dr(2)
                    tseat.Items.Add(i.ToString)
                Next
            End While
            dr.Close()
        End If
        con.Close()
    End Sub
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
    End Sub
    Private Sub tfirst_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tfirst.Leave
        tfirst.Text = StrConv(tfirst.Text, VbStrConv.ProperCase)
    End Sub
    Private Sub tlast_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlast.Leave
        tlast.Text = StrConv(tlast.Text, VbStrConv.ProperCase)
    End Sub
    Function AutoID(ByVal Tablename As String, ByVal Fieldname As String) As Int32
        Dim cmd As New MySqlCommand
        Dim dr1 As MySqlDataReader
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " select " & Fieldname & " from " & Tablename & " Order by 1 Desc Limit 1 "
        If con.State = ConnectionState.Closed Then con.Open()
        dr1 = cmd.ExecuteReader
        If dr1.Read = True Then
            AutoID = Microsoft.VisualBasic.Right(dr1(0), 4) + 1
        Else
            AutoID = 1
        End If
        dr1.Close()
        con.Close()
    End Function
    Sub updateSeat()
        Dim sl As Double = sls + Val(ttotal.Text)
        Dim sd As String = "UPDATE tbclass SET temp = '" & tseat.Text & "' where vname='" & vname.Text & "' AND tclass='" & cbclass.Text & "'"
        con1.Close()
        Dim cmd As New MySqlCommand(sd, con1)
        con1.Open()
        cmd.ExecuteNonQuery()
        con1.Close()
    End Sub
    Sub save()
        'to make sure that all the fields are filled with data
        If tid.Text = Nothing Or tseat.Text = Nothing Or tlast.Text = Nothing Or tfirst.Text = Nothing Or tlast.Text = Nothing Or cbgen.Text = Nothing Or tage.Text = Nothing Or vname.Text = Nothing Or torig.Text = Nothing Or tdest.Text = Nothing Or cbclass.Text = Nothing Or tfare.Text = Nothing Or tmoney.Text = Nothing Or tchange.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        Else
            'used for confirming the save command
            Dim st As String = "INSERT into tbpassenger(tid,tfirst,tlast,type,cbgen,tage,tseat,vname,torig,tdest,cbclass,tfare,depart,dtpdate,ttotal,tmoney,tchange)values('" & tid.Text & "','" & tfirst.Text & "','" & tlast.Text & "','" & type.Text & "','" & cbgen.Text & "','" & tage.Text & "','" & tseat.Text & "','" & vname.Text & "','" & torig.Text & "','" & tdest.Text & "','" & cbclass.Text & "','" & tfare.Text & "','" & depart.Text & "','" & Format(dtpdate.Value, "MM/dd/yyyy") & "','" & ttotal.Text & "','" & tmoney.Text & "','" & tchange.Text & "')"
            con.Close()
            Dim cmd As New MySqlCommand(st, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            updateSeat()
            frmprint.printfo()
            frmprint.Show()
        End If
    End Sub
    Private Sub frmticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadid()
        vessel()
        passtype()
        Call clr()
        ToolTip1.SetToolTip(bprint, "Click To Print")
        ToolTip1.SetToolTip(bref, "Click To Refresh")
        ToolTip1.SetToolTip(bclose, "Click To Close")
    End Sub
    Private Sub bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click
        save()
    End Sub
    Sub compute()
        Dim change As Double
        change = Val(tmoney.Text) - Val(ttotal.Text)
        tchange.Text = Format(change, "###,###.00")
    End Sub
    Private Sub tmoney_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmoney.Leave
        If Val(tmoney.Text) < Val(ttotal.Text) Then
            MsgBox("Tendered Cash Amount is Insufficient!!", MsgBoxStyle.Exclamation, "System Checked")
            tmoney.Focus()
            Return
        End If
    End Sub
    Private Sub vname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vname.SelectedIndexChanged
        tseat.Items.Clear()
        cbclass.Items.Clear()
        vclass()
        luser()
    End Sub
    Private Sub tmoney_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmoney.TextChanged
        If Not IsNumeric(tmoney.Text) Then
            tmoney.Text = Nothing
            Return
        End If
        compute()
    End Sub
    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        seat()
    End Sub

    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        Call clr()
        loadid()
    End Sub
    Private Sub type_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles type.SelectedIndexChanged
        selecttype()
    End Sub
    Private Sub bclose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmplist.Show()
    End Sub
    Private Sub tage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tage.TextChanged
        If Not IsNumeric(tage.Text) Then
            tage.Text = Nothing
            Return
        End If
    End Sub
End Class
