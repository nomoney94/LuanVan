Imports System.Data.SqlClient

Public Class frmInHoaDon
    Private sqlStr As String = "SELECT KhachHang.MaKH, KhachHang.MaCT, KhachHang.MaDT, HoaDon.MaHD, HoaDon.DienNangTieuThu, HoaDon.ThanhTien, HoaDon.Ky, ChiSoCongTo.NgayDauKy, ChiSoCongTo.NgayCuoiKy, KhachHang.TenKH, KhachHang.DiaChi, KhachHang.SDT, KhachHang.MaSoThue, Tram.MaTram, ChiSoCongTo.ChiSo, ChiSoCongTo.ChisoCD, ChiSoCongTo.ChisoTD " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "DoiTuongKH ON KhachHang.MaDT = DoiTuongKH.MaDT INNER JOIN " & _
                        "ChiSoCongTo ON KhachHang.MaCT = ChiSoCongTo.MaCT  INNER JOIN " & _
                        "CongTo ON KhachHang.MaCT = CongTo.MaCT INNER JOIN " & _
                        "Tram ON CongTo.MaTram = Tram.MaTram " & _
                        "WHERE HoaDon.Ky = ChiSoCongTo.Ky "
    Private sqlStr2 As String = "SELECT ChiTietThanhTien.MaHD, ChiTietThanhTien.ChiSo, ChiTietThanhTien.Gia, ChiTietThanhTien.ThanhTien AS CTThanhTien " & _
                        "FROM KhachHang INNER JOIN " & _
                        "HoaDon ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN " & _
                        "ChiTietThanhTien ON HoaDon.MaHD = ChiTietThanhTien.MaHD "
    Private sqlStr3 As String = "SELECT * FROM DonVi"
    Private sqlStr4 As String
    Private sqlStr5 As String
    Private ds As New DataSet
    Private da As SqlDataAdapter
    Private com As SqlCommand
    Private con As SqlConnection = frmMain.con
    Public TimKiem As String
    Public DuLieu As String
    Private rpt3 As New crpHoaDon3
    Private rpt6 As New crpHoaDon6

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        sqlStr4 = ""
        sqlStr5 = ""
        If TimKiem = "Ky" Then
            sqlStr4 &= sqlStr & "AND MONTH(ChiSoCongTo.Ky) = " & DuLieu & " "
        ElseIf TimKiem = "ChuaTT" Then
            sqlStr4 &= sqlStr & "AND HoaDon.TinhTrangThanhToan = N'Chưa' "
        ElseIf TimKiem = "NhacNho1" Then
            sqlStr4 &= sqlStr & "AND HoaDon.TinhTrangThanhToan = N'Lần 1' "
        ElseIf TimKiem = "NhacNho2" Then
            sqlStr4 &= sqlStr & "AND HoaDon.TinhTrangThanhToan = N'Lần 2' "
        ElseIf TimKiem = "MaKH" Then
            sqlStr4 &= sqlStr & "AND KhachHang.MaKH = '" & DuLieu & "' "
        ElseIf TimKiem = "MaHD" Then
            sqlStr4 &= sqlStr & "AND HoaDon.MaHD = " & DuLieu & " "
        End If
        If radKoCapDA.Checked Then
            sqlStr5 = sqlStr4 & "AND (DoiTuongKH.MaDT = 'CDCTPK' OR DoiTuongKH.MaDT = 'CDCTPB' OR DoiTuongKH.MaDT = 'CDCTPM' OR DoiTuongKH.MaDT = 'CDCTTK' OR DoiTuongKH.MaDT = 'CDCTTB' OR DoiTuongKH.MaDT = 'CDCTTM' OR DoiTuongKH.MaDT = 'NTK' OR DoiTuongKH.MaDT = 'SHNT' OR DoiTuongKH.MaDT = 'SHBTTT' OR DoiTuongKH.MaDT = 'SHBT' OR DoiTuongKH.MaDT = 'TMSH')"
            CreateReportKoCapDA()
        Else
            sqlStr5 = sqlStr4 & "AND (DoiTuongKH.MaDT = 'BVT_T6' OR DoiTuongKH.MaDT = 'BVT_D6' OR DoiTuongKH.MaDT = 'CSHC_T6' OR DoiTuongKH.MaDT = 'CSHC_D6' OR DoiTuongKH.MaDT = 'KD_T22' OR DoiTuongKH.MaDT = 'KD_T6' OR DoiTuongKH.MaDT = 'KD_D6' OR DoiTuongKH.MaDT = 'SX_T110' OR DoiTuongKH.MaDT = 'SX_T22' OR DoiTuongKH.MaDT = 'SX_T6' OR DoiTuongKH.MaDT = 'SX_D6')"
            CreateReportCoCapDA()
        End If
    End Sub

    Private Sub CreateReportKoCapDA()
        con.Open()
        ds.Clear()
        com = New SqlCommand(sqlStr5, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTHoaDon")

        com = New SqlCommand(sqlStr3, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "DonVi")

        com = New SqlCommand(sqlStr2, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTThanhTien")

        con.Close()

        rpt6.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt6
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CreateReportCoCapDA()
        con.Open()
        ds.Clear()
        com = New SqlCommand(sqlStr5, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTHoaDon")

        com = New SqlCommand(sqlStr3, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "DonVi")

        com = New SqlCommand(sqlStr2, frmMain.con)
        da = New SqlDataAdapter(com)
        da.Fill(ds, "CTThanhTien")

        con.Close()

        rpt3.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt3
        CrystalReportViewer1.Refresh()
    End Sub
End Class