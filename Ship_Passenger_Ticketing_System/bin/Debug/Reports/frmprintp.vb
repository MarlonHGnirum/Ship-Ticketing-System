Imports MySql.Data.MySqlClient
Public Class frmprintp
    Sub printpass()
        Dim dt As New DataTable
        Dim str As String = ("Select * from tbplist ORDER By pid")
        Dim data As New MySqlDataAdapter(str, con)
        data.Fill(dt)

        Dim strpath As String = Application.StartupPath & "\Reports\crpsgr.rpt"
        Dim rptdocu As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocu.Load(strpath)
        rptdocu.SetDataSource(dt)
        rptdocu.SetDatabaseLogon("root", "", "localhost", "dbship")
        CrystalReportViewer1.ReportSource = rptdocu
    End Sub

End Class