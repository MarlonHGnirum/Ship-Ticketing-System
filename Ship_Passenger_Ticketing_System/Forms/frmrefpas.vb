Imports MySql.Data.MySqlClient
Public Class frmrefpas
    Private Sub bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancel.Click
        Me.Close()
    End Sub

    Private Sub brefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brefund.Click
        If MessageBox.Show("Are you sure you want to refund the passenger?", "Passenger Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sdel As String = "Delete from tbpassenger where pid='" & frmrefund.dgvref.SelectedCells(0).Value & "'"
            Dim cmd As New MySqlCommand(sdel, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Passenger Refunded Successfully", MsgBoxStyle.Information)
            con.Close()
            frmrefund.pload()
        End If
    End Sub
End Class