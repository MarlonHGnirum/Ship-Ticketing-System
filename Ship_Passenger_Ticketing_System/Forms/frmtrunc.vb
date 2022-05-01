Imports MySql.Data.MySqlClient
Public Class frmtrunc
    Sub CRUD(ByVal qry As String)
        Dim cmd As New MySqlCommand(qry, con)
        If con.State = ConnectionState.Closed Then con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub updateSeat()
        Dim n As Integer = 0
        Dim sd As String = "UPDATE tbclass SET temp = '" & n & "'"
        con1.Close()
        Dim cmd As New MySqlCommand(sd, con1)
        con1.Open()
        cmd.ExecuteNonQuery()
        con1.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If MessageBox.Show("Are you sure you want to preset?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CRUD("Truncate Table tbpassenger")
            updateSeat()
            MsgBox("Preset Complete!", MsgBoxStyle.Information, "Success")
            con.Close()
        End If
    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If MessageBox.Show("Are you sure you want to preset?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CRUD("Truncate Table tbvessel")
            CRUD("Truncate Table tbves")
            CRUD("Truncate Table tbclass")
            MsgBox("Preset Complete!", MsgBoxStyle.Information, "Success")
            con.Close()
        End If
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If MessageBox.Show("Are you sure you want to preset?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CRUD("Truncate Table tbaccount")
            MsgBox("Preset Complete!", MsgBoxStyle.Information, "Success")
            con.Close()
        End If
    End Sub
    Private Sub frmtrunc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btn1, "Click To Preset Passengers Data")
        ToolTip1.SetToolTip(btn2, "Click To Preset Vessels Data")
        ToolTip1.SetToolTip(btn3, "Click To Preset User Accounts")
        ToolTip1.SetToolTip(btn4, "Click To Preset Passenger Discounts")
    End Sub
    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If MessageBox.Show("Are you sure you want to preset?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CRUD("Truncate Table tbpdiscount")
            CRUD("Truncate Table tbptype")
            MsgBox("Preset Complete!", MsgBoxStyle.Information, "Success")
            con.Close()
        End If
    End Sub
End Class