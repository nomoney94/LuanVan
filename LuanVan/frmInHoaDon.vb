Imports System.Data.SqlClient

Public Class frmInHoaDon

#Region "Declares"
    Private sqlCTHD As String = "SELECT KhachHang.MaKH, KhachHang.MaCT, KhachHang.MaDT, HoaDon.MaHD, HoaDon.DienNangTieuThu, HoaDon.ThanhTien, HoaDon.Ky, ChiSoCongTo.NgayDauKy, ChiSoCongTo.NgayCuoiKy, KhachHang.TenKH, KhachHang.DiaChi, KhachHang.SDT, KhachHang.MaSoThue, Tram.MaTram, ChiSoCongTo.ChiSo, ChiSoCongTo.ChisoCD, ChiSoCongTo.ChisoTD " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "DoiTuongKH ON KhachHang.MaDT = DoiTuongKH.MaDT INNER JOIN " & _
                        "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT  INNER JOIN " & _
                        "CongTo ON KhachHang.MaCT = CongTo.MaCT INNER JOIN " & _
                        "Tram ON CongTo.MaTram = Tram.MaTram " & _
                        "WHERE HoaDon.Ky = ChiSoCongTo.Ky "
    Private sqlCTTT As String = "SELECT ChiTietThanhTien.MaHD, ChiTietThanhTien.ChiSo, ChiTietThanhTien.Gia, ChiTietThanhTien.ThanhTien AS CTThanhTien " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "ChiTietThanhTien ON HoaDon.MaHD = ChiTietThanhTien.MaHD "
    Private sqlCSHD As String = "SELECT HoaDon.MaHD, ChiSoCongTo.ChiSo, ChiSoCongTo.ChisoCD, ChiSoCongTo.ChisoTD, ChiSoCongTo.Ky " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT INNER JOIN " & _
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
    Private rptHoaDon As New crpHoaDon
    Private dtHD As DataTable
    Private isChuaTT As Boolean = False
#End Region

#Region "Events"
    Private Sub frmInHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtHD = frmMain.ds.Tables("HoaDon")
        CreateReport()
    End Sub
#End Region

#Region "Functions/Subs"
    Public Sub CreateReport()
        sqlTemp = ""
        If TimKiem = "Ky" Then
            sqlTemp &= sqlCTHD & "AND MONTH(ChiSoCongTo.Ky) = " & DuLieu & " "
        ElseIf TimKiem = "ChuaTT" Then
            sqlTemp &= sqlCTHD & "AND HoaDon.TinhTrangThanhToan = N'Chưa' "
            isChuaTT = True
        ElseIf TimKiem = "NhacNho1" Then
            sqlTemp &= sqlCTHD & "AND HoaDon.TinhTrangThanhToan = N'Lần 1' "
        ElseIf TimKiem = "NhacNho2" Then
            sqlTemp &= sqlCTHD & "AND HoaDon.TinhTrangThanhToan = N'Lần 2' "
        ElseIf TimKiem = "MaKH" Then
            sqlTemp &= sqlCTHD & "AND KhachHang.MaKH = '" & DuLieu & "' "
        ElseIf TimKiem = "MaHD" Then
            sqlTemp &= sqlCTHD & "AND HoaDon.MaHD = " & DuLieu & " "
        End If

        con.Open()
        ds.Clear()
        com = New SqlCommand(sqlTemp, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTHoaDon")

        com = New SqlCommand(sqlDV, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "DonVi")

        com = New SqlCommand(sqlCTTT, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTThanhTien")

        com = New SqlCommand(sqlCSHD, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "ChiSoHD")

        con.Close()

        rptHoaDon.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rptHoaDon
        CrystalReportViewer1.Refresh()

        If isChuaTT Then
            UpdateTinhTrangThanhToan()
        End If
    End Sub

    Private Sub UpdateTinhTrangThanhToan()
        Dim dr As DataRow
        For Each dr In dtHD.Select("TinhTrangThanhToan='Chưa'")
            dr("TinhTrangThanhToan") = "Rồi"
        Next
        Try
            Dim comHD As New SqlCommandBuilder(frmMain.daHoaDon)
            frmMain.con.Open()
            comHD.DataAdapter.Update(dtHD)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL", "Thông báo")
        End Try
    End Sub
#End Region

End Class