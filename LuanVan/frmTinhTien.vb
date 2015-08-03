Imports System.Data.SqlClient

Public Class frmTinhTien

#Region "Declares"
    Private dtCT As DataTable
    Private dtKH As DataTable
    Private dtDT As DataTable
    Private dtG6 As DataTable
    Private dtCSCT As DataTable
    Private dtHD As DataTable
    Private dtG3 As DataTable
    Private dtCTTT As DataTable
    Private gia As String
#End Region

#Region "Events"
    Private Sub frmTinhTien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtCT = frmMain.ds.Tables("CongTo")
        dtKH = frmMain.ds.Tables("KhachHang")
        dtDT = frmMain.ds.Tables("DoiTuongKH")
        dtG6 = frmMain.ds.Tables("Gia6")
        dtG3 = frmMain.ds.Tables("Gia3")
        dtCSCT = frmMain.ds.Tables("ChiSoCongTo")
        dtHD = frmMain.ds.Tables("HoaDon")
        dtCTTT = frmMain.ds.Tables("ChiTietThanhTien")
    End Sub

    Private Sub btnTinhTien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTinhTien.Click
        Dim dr, dr1, dr2, row, row1, row2 As DataRow
        Dim strfind, makh As String
        Dim chiso, chisoCD, chisoTD, chisoHD, chisoCT1, chisoCT2, chisoCT3, chisocu, chisoCDcu, chisoTDcu, thanhtien, thanhtientam, flagCT, ma As Integer
        Dim flag As Integer = 1
        'lvwHoadon.Items.Clear()
        If txtChiso.Text = "" Then
            txtChiso.Text = 0
        End If
        If txtChisoCD.Text = "" Then
            txtChisoCD.Text = 0
        End If
        If txtChisoTD.Text = "" Then
            txtChisoTD.Text = 0
        End If
        For Each dr In dtHD.Select("MaHD=Max(MaHD)")
            ma = CInt(dr("MaHD"))
        Next
        For Each dr In dtCSCT.Select("MaCT='" + txtMaCT.Text.Trim + "' AND Ky='" + Convert.ToString(CInt(Month(dtpThang.Text)) - 1) + "-" + Convert.ToString(Year(dtpThang.Text)) + "'")
            flagCT = 1
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
            chisocu = dr("ChiSo")
            chisoCDcu = dr("ChisoCD")
            chisoTDcu = dr("ChisoTD")
            chiso = CInt(txtChiso.Text) - dr("ChiSo")
            chisoCD = CInt(txtChisoCD.Text) - dr("ChisoCD")
            chisoTD = CInt(txtChisoTD.Text) - dr("ChisoTD")
            chisoHD = chiso + chisoCD + chisoTD
            chisoCT1 = txtChiso.Text
            chisoCT2 = txtChisoCD.Text
            chisoCT3 = txtChisoTD.Text
        Next
        If flagCT = 0 Then
            MessageBox.Show("Chọn sai kỳ")
            Exit Sub
        End If
        For Each dr In dtKH.Select("MaCT='" + txtMaCT.Text + "'")
            makh = dr("MaKH")
            strfind = "MaDT='" + dr("MaDT") + "'"
            If dr("MaDT") = "CDCTPK" Or dr("MaDT") = "CDCTPB" Or dr("MaDT") = "CDCTPM" Or dr("MaDT") = "CDCTTK" Or dr("MaDT") = "CDCTTB" Or dr("MaDT") = "CDCTTM" Or dr("MaDT") = "NTK" Or dr("MaDT") = "SHNT" Or dr("MaDT") = "SHBTTT" Or dr("MaDT") = "SHBT" Or dr("MaDT") = "TMSH" Then
                For Each dr2 In dtG6.Select(strfind)
                    row2 = dtCTTT.NewRow
                    If dr("MaDT") = "CDCTPK" Or dr("MaDT") = "CDCTTK" Or dr("MaDT") = "NTK" Or dr("MaDT") = "SHBTTT" Then
                        thanhtien += chiso * dr2("Gia")
                        row2("MaHD") = ma + 1
                        row2("ChiSo") = chisoHD
                        row2("Gia") = dr2("Gia")
                        row2("ThanhTien") = thanhtien
                        dtCTTT.Rows.Add(row2)
                        Exit For
                    End If
                    If chiso - dr2("DinhMuc") > 0 Then
                        If flag <> 6 Then
                            thanhtien += dr2("DinhMuc") * dr2("Gia")
                            thanhtientam = dr2("DinhMuc") * dr2("Gia")
                            row2("MaHD") = ma + 1
                            row2("ChiSo") = dr2("DinhMuc")
                            row2("Gia") = dr2("Gia")
                            row2("ThanhTien") = thanhtientam
                            dtCTTT.Rows.Add(row2)
                            chiso -= dr2("DinhMuc")
                            flag += 1
                        Else
                            thanhtien += chiso * dr2("Gia")
                            row2("MaHD") = ma + 1
                            row2("ChiSo") = chiso
                            row2("Gia") = dr2("Gia")
                            row2("ThanhTien") = thanhtientam
                            dtCTTT.Rows.Add(row2)
                        End If
                    Else
                        thanhtien += chiso * dr2("Gia")
                        thanhtientam = chiso * dr2("Gia")
                        row2("MaHD") = ma + 1
                        row2("ChiSo") = chiso
                        row2("Gia") = dr2("Gia")
                        row2("ThanhTien") = thanhtientam
                        dtCTTT.Rows.Add(row2)
                        Exit For
                    End If
                Next
            Else
                For Each dr3 In dtG3.Select(strfind)
                    thanhtien += chiso * dr3("GiaBT") + chisoCD * dr3("GiaCD") + chisoTD * dr3("GiaTD")
                    If dr("MaDT") = "BVT_T6" Or dr("MaDT") = "BVT_D6" Or dr("MaDT") = "CSHC_T6" Or dr("MaDT") = "CSHC_D6" Then
                        row2 = dtCTTT.NewRow
                        row2("MaHD") = ma + 1
                        row2("ChiSo") = chiso
                        row2("Gia") = dr3("GiaBT")
                        row2("ThanhTien") = chiso * dr3("GiaBT")
                        dtCTTT.Rows.Add(row2)
                    Else
                        row2 = dtCTTT.NewRow
                        row2("MaHD") = ma + 1
                        row2("ChiSo") = chiso
                        row2("Gia") = dr3("GiaBT")
                        row2("ThanhTien") = chiso * dr3("GiaBT")
                        dtCTTT.Rows.Add(row2)
                        row2 = dtCTTT.NewRow
                        row2("MaHD") = ma + 1
                        row2("ChiSo") = chisoCD
                        row2("Gia") = dr3("GiaCD")
                        row2("ThanhTien") = chisoCD * dr3("GiaCD")
                        dtCTTT.Rows.Add(row2)
                        row2 = dtCTTT.NewRow
                        row2("MaHD") = ma + 1
                        row2("ChiSo") = chisoTD
                        row2("Gia") = dr3("GiaTD")
                        row2("ThanhTien") = chisoTD * dr3("GiaTD")
                        dtCTTT.Rows.Add(row2)
                    End If
                Next
            End If
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
        row1("MaKH") = makh
        row1("DienNangTieuThu") = chisoHD
        row1("ThanhTien") = thanhtien
        row1("TinhTrangThanhToan") = "Chưa"
        row1("Ky") = dtpThang.Text
        dtHD.Rows.Add(row1)

        Try
            Dim comCSCT As New SqlCommandBuilder(frmMain.daChiSoCongTo)
            Dim comHD As New SqlCommandBuilder(frmMain.daHoaDon)
            Dim comCTTT As New SqlCommandBuilder(frmMain.daChiTietThanhTien)
            frmMain.con.Open()
            comCSCT.DataAdapter.Update(dtCSCT)
            comHD.DataAdapter.Update(dtHD)
            comCTTT.DataAdapter.Update(dtCTTT)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL", "Thông báo")
        End Try
    End Sub

    Private Sub txtMaCT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaCT.Leave
        If txtMaCT.Text = "" Then
            MessageBox.Show("Nhập mã công tơ")
            Exit Sub
        End If
        txtMaCT.Text = txtMaCT.Text.ToUpper
        Dim flag As Integer
        Dim dr, dr1 As DataRow
        For Each dr In dtKH.Select("MaCT='" + txtMaCT.Text.Trim + "'")
            flag = 1
            For Each dr1 In dtDT.Select("MaDT='" + dr("MaDT") + "'")
                lvwKH.Items(0).SubItems(0).Text = (txtMaCT.Text.Trim)
                lvwKH.Items(0).SubItems(1).Text = dr("TenKH")
                lvwKH.Items(0).SubItems(2).Text = If(IsDBNull(dr("SDT")), "", dr("SDT"))
                lvwKH.Items(0).SubItems(3).Text = dr1("MaDT")
                If dr("MaDT") = "CDCTPK" Or dr("MaDT") = "CDCTPB" Or dr("MaDT") = "CDCTPM" Or dr("MaDT") = "CDCTTK" Or dr("MaDT") = "CDCTTB" Or dr("MaDT") = "CDCTTM" Or dr("MaDT") = "NTK" Or dr("MaDT") = "SHNT" Or dr("MaDT") = "SHBTTT" Or dr("MaDT") = "SHBT" Or dr("MaDT") = "TMSH" Then
                    gia = "Gia6"
                    txtChisoCD.Text = 0
                    txtChisoTD.Text = 0
                    txtChisoCD.Enabled = False
                    txtChisoTD.Enabled = False
                Else
                    gia = "Gia3"
                    If dr("MaDT") = "BVT_T6" Or dr("MaDT") = "BVT_D6" Or dr("MaDT") = "CSHC_T6" Or dr("MaDT") = "CSHC_D6" Then
                        txtChisoCD.Text = 0
                        txtChisoTD.Text = 0
                        txtChisoCD.Enabled = False
                        txtChisoTD.Enabled = False
                    Else
                        txtChisoCD.Enabled = True
                        txtChisoTD.Enabled = True
                    End If
                End If
            Next
        Next
        If flag = 0 Then
            MsgBox("Mã công tơ sai")
        End If
    End Sub
#End Region

#Region "Functions/Subs"

#End Region

End Class