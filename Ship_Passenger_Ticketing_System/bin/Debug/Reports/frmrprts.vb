Imports MySql.Data.MySqlClient
Public Class frmrprts
    Sub printrep()
        Dim dt As New DataTable
        Dim str As String = ("Select * from tbreports ORDER By rid")
        Dim data As New MySqlDataAdapter(str, con)
        data.Fill(dt)

        Dim strpath As String = Application.StartupPath & "\Reports\CrystalReport1.rpt"
        Dim rptdocu As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocu.Load(strpath)
        rptdocu.SetDataSource(dt)
        rptdocu.SetDatabaseLogon("root", "", "localhost", "dbship")
        CrystalReportViewer1.ReportSource = rptdocu
    End Sub
End Class