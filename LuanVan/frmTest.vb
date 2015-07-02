Imports System.Data.SqlClient

Public Class frmTest

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet("Test")
        Dim da As SqlDataAdapter
        Dim com As SqlCommand
        Dim con As SqlConnection = frmMain.con
        Dim sqlStr As String

        con.Open()

        sqlStr = "SELECT KhachHang.MaKH, KhachHang.MaCT, KhachHang.MaDT, HoaDon.MaHD, HoaDon.DienNangTieuThu, HoaDon.ThanhTien, HoaDon.Ky, ChiSoCongTo.NgayDauKy, ChiSoCongTo.NgayCuoiKy, KhachHang.TenKH, KhachHang.DiaChi, KhachHang.SDT, KhachHang.MaSoThue, Tram.MaTram, ChiSoCongTo.ChiSo " & _
                "FROM KhachHang INNER JOIN " & _
                "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                "DoiTuongKH ON KhachHang.MaDT = DoiTuongKH.MaDT INNER JOIN " & _
                "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT  INNER JOIN " & _
                "CongTo ON KhachHang.MaCT = CongTo.MaCT INNER JOIN " & _
                "Tram ON CongTo.MaTram = Tram.MaTram " & _
                "where NgayCuoiKy=(select max(NgayCuoiKy) from ChiSoCongTo)"

        'sqlStr = "SELECT KhachHang.MaKH, KhachHang.MaCT, KhachHang.MaDT, HoaDon.MaHD, HoaDon.DienNangTieuThu, HoaDon.ThanhTien, HoaDon.Ky, ChiSoCongTo.NgayDauKy, ChiSoCongTo.NgayCuoiKy, KhachHang.TenKH, KhachHang.DiaChi, KhachHang.SDT, KhachHang.MaSoThue, Tram.MaTram, ChiTietThanhTien.ChiSo, ChiTietThanhTien.Gia, ChiTietThanhTien.ThanhTien AS CTThanhTien " & _
        '        "FROM KhachHang INNER JOIN " & _
        '        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
        '        "DoiTuongKH ON KhachHang.MaDT = DoiTuongKH.MaDT INNER JOIN " & _
        '        "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT INNER JOIN " & _
        '        "CongTo ON KhachHang.MaCT = CongTo.MaCT AND ChiSoCongTo.MaCT = CongTo.MaCT INNER JOIN " & _
        '        "Tram ON CongTo.MaTram = Tram.MaTram INNER JOIN " & _
        '        "ChiTietThanhTien ON HoaDon.MaHD = ChiTietThanhTien.MaHD " & _
        '        "where NgayCuoiKy=(select max(NgayCuoiKy) from ChiSoCongTo)"

        com = New SqlCommand(sqlStr, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTHoaDon")

        sqlStr = "SELECT * FROM DonVi"
        com = New SqlCommand(sqlStr, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "DonVi")

        sqlStr = "SELECT ChiTietThanhTien.MaHD, ChiTietThanhTien.ChiSo, ChiTietThanhTien.Gia, ChiTietThanhTien.ThanhTien AS CTThanhTien " & _
                "FROM KhachHang INNER JOIN " & _
                "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                "ChiTietThanhTien ON HoaDon.MaHD = ChiTietThanhTien.MaHD " & _
        "WHERE HoaDon.MaHD = 1"
        com = New SqlCommand(sqlStr, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTThanhTien")

        con.Close()

        Dim rpt As New crpHoaDon1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class