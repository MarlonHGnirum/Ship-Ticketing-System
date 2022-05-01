Imports MySql.Data.MySqlClient
Public Class frmplistup
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
    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Sub vessel()
        Dim sc As String = "select vname from tbvessel"         'use for displaying data from other table
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
        Dim it As String = "select vname,torig, tdest, depart from tbvessel where vname= '" & vname.Text & "'"
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
        Dim sc As String = "select vname,tclass from tbclass where vname ='" & vname.Text & "' "
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
    Private Sub tfirst_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        tfirst.Text = StrConv(tfirst.Text, VbStrConv.ProperCase)
    End Sub
    Private Sub tlast_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        tlast.Text = StrConv(tlast.Text, VbStrConv.ProperCase)
    End Sub
    Private Sub bcompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tchange.Text = Val(tmoney.Text) - Val(tfare.Text)
    End Sub
    Private Sub frmplistup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        passtype()
        vessel()
        vclass()
        luser()
        ToolTip1.SetToolTip(bprint, "Click To Print")
        ToolTip1.SetToolTip(bref, "Click To Refresh")
        ToolTip1.SetToolTip(bclose, "Click To Close")
    End Sub
    Sub updateSeat()
        Dim sd As String = "UPDATE tbclass SET temp = '" & tseat.Text & "' where vname='" & vname.Text & "' AND tclass='" & cbclass.Text & "'"
        con1.Close()
        Dim cmd As New MySqlCommand(sd, con1)
        con1.Open()
        cmd.ExecuteNonQuery()
        con1.Close()
    End Sub
    Sub updt()
        'to make sure that all the fields are filled with data
        If tfirst.Text = Nothing Or tlast.Text = Nothing Or cbgen.Text = Nothing Or tage.Text = Nothing Or vname.Text = Nothing Or torig.Text = Nothing Or tdest.Text = Nothing Or cbclass.Text = Nothing Or tfare.Text = Nothing Or tmoney.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            Return
        End If

        'used for confirming the update command
        Dim st As String = "update tbpassenger set tid='" & tid.Text & "',tfirst='" & tfirst.Text & "',tlast='" & tlast.Text & "',type='" & type.Text & "',cbgen='" & cbgen.Text & "',tage='" & tage.Text & "',tseat='" & tseat.Text & "',vname='" & vname.Text & "',torig='" & torig.Text & "',tdest='" & tdest.Text & "',cbclass='" & cbclass.Text & "',tfare='" & tfare.Text & "',depart='" & depart.Text & "',dtpdate='" & Format(dtpdate.Value, "MM/dd/yyyy") & "',ttotal='" & ttotal.Text & "',tmoney='" & tmoney.Text & "',tchange='" & tchange.Text & "' where pid='" & lblid.Text & "'"
        Dim cmd As New MySqlCommand(st, con)
        con.Open()
        cmd.ExecuteNonQuery()
        updateSeat()
        con.Close()
        frmprint.print()
        frmprint.Show()
    End Sub
    Private Sub bclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Close()
        frmplist.Show()
    End Sub
    Private Sub bprint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click
        updt()
    End Sub
    Private Sub vname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vname.SelectedIndexChanged
        vclass()
        luser()
    End Sub
    Private Sub cbclass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbclass.Leave
        Dim par As Double = 0
        Dim total As Double

        If (Val(type.Text = "Regular")) Then
            total = Val(tfare.Text)
            ttotal.Text = Format(total, "###,###.00")
        ElseIf (Val(type.Text = "Student")) Then
            par = Val(tfare.Text) * 0.05
            total = Val(tfare.Text()) - par
            ttotal.Text = Format(total, "###,###.00")
        ElseIf (Val(type.Text = "Senior Citizen")) Then
            par = Val(tfare.Text) * 0.08
            total = Val(tfare.Text) - par
            ttotal.Text = Format(total, "###,###.00")
        End If
    End Sub
    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        seat()
    End Sub
    Private Sub bref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bref.Click
        Call clr()
    End Sub
    Private Sub type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.SelectedIndexChanged
        selecttype()
    End Sub
    Private Sub tmoney_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmoney.Leave
        If Val(tmoney.Text) < Val(ttotal.Text) Then
            MsgBox("Tendered Cash Amount is Insufficient!!", MsgBoxStyle.Exclamation, "System Checked")
            tmoney.Focus()
            Return
        End If
    End Sub
    Sub compute()
        Dim change As Double
        change = Val(tmoney.Text) - Val(ttotal.Text)
        tchange.Text = Format(change, "###,###.00")
    End Sub
    Private Sub tmoney_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmoney.TextChanged
        If Not IsNumeric(tmoney.Text) Then
            tmoney.Text = Nothing
            Return
        End If
        compute()
    End Sub
    Private Sub bclose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmplist.Show()
    End Sub
    Private Sub tseat_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles tseat.DropDown
        If tseat.Items.Count = 0 Then
            MsgBox("No more Available Seats, Class Already Full", MsgBoxStyle.Information, "System Checked")
        End If
    End Sub

    Private Sub tseat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tseat.Leave
        If tseat.Text = Nothing Then
            MsgBox("Fill the missing data", MsgBoxStyle.Exclamation, "System Checked")
            tseat.Focus()
            Return
        End If
    End Sub
    Private Sub tage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tage.TextChanged
        If Not IsNumeric(tage.Text) Then
            tage.Text = Nothing
            Return
        End If
    End Sub
End Class