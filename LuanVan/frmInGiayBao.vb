Imports System.Data.SqlClient

Public Class frmInGiayBao
    Public sqlStr As String

    Private Sub frmInGiayBao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet()
        Dim da As SqlDataAdapter
        Dim com As SqlCommand
        Dim con As SqlConnection = frmMain.con

        con.Open()

        com = New SqlCommand(sqlStr, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTHoaDon")

        sqlStr = "SELECT * FROM DonVi"
        com = New SqlCommand(sqlStr, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "DonVi")

        con.Close()

        Dim rpt As New crpGiayBao6
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class