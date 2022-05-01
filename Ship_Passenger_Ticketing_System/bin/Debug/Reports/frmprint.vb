Imports MySql.Data.MySqlClient
Public Class frmprint
    Sub printfo()
        Dim dt As New DataTable
        Dim str As String = ("Select * from tbpassenger where tid = '" & frmticket.tid.Text & "'")
        Dim data As New MySqlDataAdapter(str, con)
        data.Fill(dt)

        Dim strpath As String = Application.StartupPath & "\Reports\crship.rpt"
        Dim rptdocu As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocu.Load(strpath)
        rptdocu.SetDataSource(dt)
        rptdocu.SetDatabaseLogon("root", "", "localhost", "dbship")
        CrystalReportViewer1.ReportSource = rptdocu
    End Sub
    Sub print()
        Dim dt As New DataTable
        Dim str As String = ("Select * from tbpassenger where tid = '" & frmplistup.tid.Text & "'")
        Dim data As New MySqlDataAdapter(str, con)
        data.Fill(dt)

        Dim strpath As String = Application.StartupPath & "\Reports\crship.rpt"
        Dim rptdocu As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocu.Load(strpath)
        rptdocu.SetDataSource(dt)
        rptdocu.SetDatabaseLogon("root", "", "localhost", "dbship")
        CrystalReportViewer1.ReportSource = rptdocu
    End Sub
End Class