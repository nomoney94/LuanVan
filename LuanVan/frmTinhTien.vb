﻿Imports System.Data.SqlClient
Public Class frmTinhTien
    Private dtCT As DataTable
    Private dtKH As DataTable
    Private dtDT As DataTable
    'Private dtBG As DataTable
    Private dtG6 As DataTable
    Private dtCSCT As DataTable
    Private dtHD As DataTable
    Private dtG3 As DataTable

    Private Sub frmTinhTien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtCT = frmMain.ds.Tables("CongTo")
        dtKH = frmMain.ds.Tables("KhachHang")
        dtDT = frmMain.ds.Tables("DoiTuongKH")
        'dtBG = frmMain.ds.Tables("BangGia")
        dtG6 = frmMain.ds.Tables("Gia6")
        dtG3 = frmMain.ds.Tables("Gia3")
        dtCSCT = frmMain.ds.Tables("ChiSoCongTo")
        dtHD = frmMain.ds.Tables("HoaDon")
    End Sub

    Private Sub btnTinhTien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTinhTien.Click
        Dim dr, dr1, dr2, row, row1 As DataRow
        Dim strfind As String
        Dim chiso, chisoCD, chisoTD, chisoHD, chisoCT1, chisoCT2, chisoCT3 As Integer
        Dim flag As Integer = 1
        Dim thanhtien As Integer = 0
        Dim ma As Integer = 0
        Dim i As Integer = 0
        lvwHoadon.Items.Clear()
        If txtChiso.Text = "" Then
            txtChiso.Text = 0
        End If
        If txtChisoCD.Text = "" Then
            txtChisoCD.Text = 0
        End If
        If txtChisoTD.Text = "" Then
            txtChisoTD.Text = 0
        End If
        For Each dr In dtCSCT.Select("MaCT='" + txtMaCT.Text.Trim + "' AND Ky='" + Convert.ToString(CInt(Month(dtpThang.Text)) - 1) + "-" + Convert.ToString(Year(dtpThang.Text)) + "'")
            If CInt(txtChiso.Text) < dr("ChiSo") Or CInt(txtChisoCD.Text) < dr("ChiSoCD") Or CInt(txtChisoTD.Text) < dr("ChiSoTD") Then
                MessageBox.Show("Chỉ số nhập sai")
                Exit Sub
            End If
            For Each dr1 In dtCSCT.Select("MaCT='" + txtMaCT.Text.Trim + "' AND Ky='" + dtpThang.Text + "'")
                If dr1("Ky") = dtpThang.Text Then
                    MessageBox.Show("Công tơ kỳ này đã ghi")
                    Exit Sub
                End If
            Next
            chiso = CInt(txtChiso.Text) - dr("ChiSo")
            chisoCD = CInt(txtChisoCD.Text) - dr("ChisoCD")
            chisoTD = CInt(txtChisoTD.Text) - dr("ChisoTD")
            chisoHD = chiso + chisoCD + chisoTD
            chisoCT1 = txtChiso.Text
            chisoCT2 = txtChisoCD.Text
            chisoCT3 = txtChisoTD.Text
        Next
        For Each dr In dtKH.Select("MaCT='" + txtMaCT.Text + "'")
            lvwHoadon.Items.Add("Tên KH")
            lvwHoadon.Items(i).SubItems.Add(dr("TenKH"))
            i += 1
            lvwHoadon.Items.Add("Địa chỉ")
            lvwHoadon.Items(i).SubItems.Add(dr("DiaChi"))
            i += 1
            lvwHoadon.Items.Add("Mã KH")
            lvwHoadon.Items(i).SubItems.Add(dr("MaKH"))
            i += 1
            lvwHoadon.Items.Add("Tháng/Năm")
            lvwHoadon.Items(i).SubItems.Add(dtpThang.Text)
            i += 1
            lvwHoadon.Items.Add("Chỉ số tiêu thụ bình thường")
            lvwHoadon.Items(i).SubItems.Add(chiso)
            i += 1
            lvwHoadon.Items.Add("Chỉ số tiêu thụ giờ cao điểm")
            lvwHoadon.Items(i).SubItems.Add(chisoCD)
            i += 1
            lvwHoadon.Items.Add("Chỉ số tiêu thụ giờ thấp điểm")
            lvwHoadon.Items(i).SubItems.Add(chisoTD)
            i += 1
            For Each dr1 In dtDT.Select("MaDT='" + dr("MaDT") + "'")
                If dr("MaDT") = "DT42" Or dr("MaDT") = "DT52" Or dr("MaDT") = "DT612" Or dr("MaDT") = "DT622" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='" + dr1("MaBangGia") + "0'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT41" Or dr("MaDT") = "DT51" Or dr("MaDT") = "DT71" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV<>'" + dr1("MaBangGia") + "0'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT6111" Or dr("MaDT") = "DT6211" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV like '" + dr1("MaBangGia") + "1%'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT6112" Or dr("MaDT") = "DT6212" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV like '" + dr1("MaBangGia") + "2%'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT11" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='SX1'"
                ElseIf dr("MaDT") = "DT12" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='SX2'"
                ElseIf dr("MaDT") = "DT13" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='SX3'"
                ElseIf dr("MaDT") = "DT14" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='SX4'"
                ElseIf dr("MaDT") = "DT211" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='HC11'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT212" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='HC12'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT221" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='HC21'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT222" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='HC22'"
                    lvwHoadon.Items.RemoveAt(i - 1)
                    lvwHoadon.Items.RemoveAt(i - 2)
                    i -= 2
                    chisoHD = chiso
                    chisoCD = 0
                    chisoTD = 0
                ElseIf dr("MaDT") = "DT31" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='KD1'"
                ElseIf dr("MaDT") = "DT32" Then
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='KD2'"
                Else
                    strfind = "MaBangGia='" + dr1("MaBangGia") + "' and MaLoaiDV='KD3'"
                End If
                If dr1("MaBangGia") = "SH" Or dr1("MaBangGia") = "NT" Or dr1("MaBangGia") = "CDCTP" Or dr1("MaBangGia") = "CDCTT" Or dr1("MaBangGia") = "TM" Then
                    For Each dr2 In dtG6.Select(strfind)
                        If dr1("MaDT") = "DT42" Or dr1("MaDT") = "DT52" Or dr1("MaDT") = "DT612" Or dr1("MaDT") = "DT622" Then
                            thanhtien += chiso * dr2("Gia")
                            lvwHoadon.Items.Add("Thành tiền")
                            lvwHoadon.Items(i).SubItems.Add(thanhtien)
                            Exit For
                        End If
                        If chiso - dr2("DinhMuc") > 0 Then
                            If flag <> 6 Then
                                thanhtien += dr2("DinhMuc") * dr2("Gia")
                                chiso -= dr2("DinhMuc")
                                flag += 1
                            Else
                                thanhtien += chiso * dr2("Gia")
                                lvwHoadon.Items.Add("Thành tiền")
                                lvwHoadon.Items(i).SubItems.Add(thanhtien)
                            End If
                        Else
                            thanhtien += chiso * dr2("Gia")
                            lvwHoadon.Items.Add("Thành tiền")
                            lvwHoadon.Items(i).SubItems.Add(thanhtien)
                            Exit For
                        End If
                    Next
                Else
                    For Each dr3 In dtG3.Select(strfind)
                        thanhtien += chiso * dr3("GiaBT") + chisoCD * dr3("GiaCD") + chisoTD * dr3("GiaTD")
                        lvwHoadon.Items.Add("Thành tiền")
                        lvwHoadon.Items(i).SubItems.Add(thanhtien)
                    Next
                End If
            Next
        Next
        For Each dr In dtHD.Select("MaHD=Max(MaHD)")
            ma = CInt(dr("MaHD"))
        Next
        row = dtCSCT.NewRow
        row("MaCT") = txtMaCT.Text
        row("Ky") = dtpThang.Text
        row("ChiSo") = chisoCT1
        row("ChisoCD") = chisoCT2
        row("ChisoTD") = chisoCT3
        row("NgayDauKy") = Convert.ToString(CInt(Month(dtpThang.Text)) - 1) + "-" + Convert.ToString(Year(dtpThang.Text))
        row("NgayCuoiKy") = dtpThang.Text
        dtCSCT.Rows.Add(row)
        row1 = dtHD.NewRow
        row1("MaHD") = ma + 1
        row1("MaKH") = lvwHoadon.Items(2).SubItems(1).Text
        row1("DienNangTieuThu") = chisoHD
        row1("ThanhTien") = thanhtien
        row1("TinhTrangThanhToan") = "Chưa"
        row1("Ky") = dtpThang.Text
        dtHD.Rows.Add(row1)
        Try
            Dim comCSCT As New SqlCommandBuilder(frmMain.daChiSoCongTo)
            Dim comHD As New SqlCommandBuilder(frmMain.daHoaDon)
            frmMain.con.Open()
            comCSCT.DataAdapter.Update(dtCSCT)
            comHD.DataAdapter.Update(dtHD)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL", "Thông báo")
        End Try
    End Sub
End Class