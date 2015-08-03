Imports System.Data.SqlClient

Public Class frmTKeDT

#Region "Declares"
    Private aThongKe() As String = {"Tháng", "Quý", "Năm"}
    Private dt As DataTable
#End Region

#Region "Events"
    Private Sub frmTKeDT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboThongKe.Items.AddRange(aThongKe)
        cboThongKe.SelectedIndex = 0
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim sqlString As String
        If cboThongKe.SelectedIndex = 0 Then
            sqlString = "SELECT DATEPART(MONTH, Ky) [Thang], SUM(ThanhTien) [DoanhThu] " & _
                    "FROM HoaDon " & _
                    "WHERE YEAR(Ky) = '" & dtpNamBD.Value.Year & "' AND TinhTrangThanhToan = N'Rồi' " & _
                    "GROUP BY DATEPART(MONTH, Ky) " & _
                    "ORDER BY 1"
            Dim com As New SqlCommand(sqlString, frmMain.con)
            Dim da As New SqlDataAdapter(com)
            dt = New DataTable
            da.Fill(dt)
            Dim rptThongKe As New crpTK_DT_Thang
            rptThongKe.SetDataSource(dt)
            crvTKe.ReportSource = rptThongKe
            crvTKe.Refresh()
        ElseIf cboThongKe.SelectedIndex = 1 Then
            sqlString = "SELECT DATEPART(QUARTER, Ky) [Quy], SUM(ThanhTien) [DoanhThu] " & _
                    "FROM HoaDon " & _
                    "WHERE YEAR(Ky) = '" & dtpNamBD.Value.Year & "' AND TinhTrangThanhToan = N'Rồi'" & _
                    "GROUP BY DATEPART(QUARTER, Ky) " & _
                    "ORDER BY 1"
            Dim com As New SqlCommand(sqlString, frmMain.con)
            Dim da As New SqlDataAdapter(com)
            dt = New DataTable
            da.Fill(dt)
            Dim rptThongKe As New crpTK_DT_Quy
            rptThongKe.SetDataSource(dt)
            crvTKe.ReportSource = rptThongKe
            crvTKe.Refresh()
        Else
            sqlString = "SELECT DATEPART(YEAR, Ky) [Nam], SUM(ThanhTien) [DoanhThu] " & _
                    "FROM HoaDon " & _
                    "WHERE DATEPART(YEAR, Ky) BETWEEN '" & dtpNamBD.Value.Year & "' AND '" & dtpNamKT.Value.Year & "' AND TinhTrangThanhToan = N'Rồi' " & _
                    "GROUP BY DATEPART(YEAR, Ky) " & _
                    "ORDER BY 1"
            Dim com As New SqlCommand(sqlString, frmMain.con)
            Dim da As New SqlDataAdapter(com)
            dt = New DataTable
            da.Fill(dt)
            Dim rptThongKe As New crpTK_DT_Nam
            rptThongKe.SetDataSource(dt)
            crvTKe.ReportSource = rptThongKe
            crvTKe.Refresh()
        End If
    End Sub

    Private Sub cboThongKe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboThongKe.SelectedIndexChanged
        If cboThongKe.SelectedIndex = 0 Then
            lblDash.Visible = False
            dtpNamKT.Visible = False
        ElseIf cboThongKe.SelectedIndex = 1 Then
            lblDash.Visible = False
            dtpNamKT.Visible = False
        Else
            lblDash.Visible = True
            dtpNamKT.Visible = True
        End If
    End Sub
#End Region

#Region "Functions/Subs"

#End Region

End Class