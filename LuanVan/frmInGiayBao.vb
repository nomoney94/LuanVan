Imports System.Data.SqlClient

Public Class frmInGiayBao

#Region "Declares"
    Private sqlGB As String = "SELECT KhachHang.MaKH, KhachHang.MaCT, HoaDon.MaHD, HoaDon.DienNangTieuThu, HoaDon.ThanhTien, HoaDon.Ky, ChiSoCongTo.NgayDauKy, ChiSoCongTo.NgayCuoiKy, KhachHang.TenKH, KhachHang.DiaChi " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT " & _
                        "WHERE HoaDon.Ky = ChiSoCongTo.Ky "
    Private sqlCS As String = "SELECT HoaDon.MaHD, HoaDon.DienNangTieuThu, HoaDon.ThanhTien, ChiSoCongTo.ChiSo, ChiSoCongTo.ChisoCD, ChiSoCongTo.ChisoTD, ChiSoCongTo.Ky " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT " & _
                        "WHERE MONTH(ChiSoCongTo.Ky) = MONTH(HoaDon.Ky) OR MONTH(ChiSoCongTo.Ky) = MONTH(HoaDon.Ky) - 1 " & _
                        "ORDER BY HoaDon.MaHD ASC, ChiSoCongTo.Ky DESC"
    Private sqlDV As String = "SELECT * FROM DonVi"
    Private sqlTemp As String

    Private ds As New DataSet
    Private da As SqlDataAdapter
    Private com As SqlCommand
    Private con As SqlConnection = frmMain.con
    Public TimKiem As String
    Public DuLieu As String
#End Region

#Region "Events"
    Private Sub frmInGiayBao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateReport()
    End Sub
#End Region

#Region "Functions/Subs"
    Public Sub CreateReport()
        sqlTemp = ""
        If TimKiem = "Ky" Then
            sqlTemp &= sqlGB & "AND MONTH(ChiSoCongTo.Ky) = " & DuLieu & " "
        ElseIf TimKiem = "ChuaTT" Then
            sqlTemp &= sqlGB & "AND HoaDon.TinhTrangThanhToan = N'Chưa' "
        ElseIf TimKiem = "NhacNho1" Then
            sqlTemp &= sqlGB & "AND HoaDon.TinhTrangThanhToan = N'Lần 1' "
        ElseIf TimKiem = "NhacNho2" Then
            sqlTemp &= sqlGB & "AND HoaDon.TinhTrangThanhToan = N'Lần 2' "
        ElseIf TimKiem = "MaKH" Then
            sqlTemp &= sqlGB & "AND KhachHang.MaKH = " & DuLieu & " "
        ElseIf TimKiem = "MaHD" Then
            sqlTemp &= sqlGB & "AND HoaDon.MaHD = " & DuLieu & " "
        End If

        con.Open()
        ds.Clear()
        com = New SqlCommand(sqlTemp, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTGiayBao")


        com = New SqlCommand(sqlDV, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "DonVi")

        com = New SqlCommand(sqlCS, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "ChiSoGB")

        con.Close()

        Dim rpt As New crpGiayBao
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub
#End Region

End Class