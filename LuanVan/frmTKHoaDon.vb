Imports System.Data.SqlClient

Public Class frmTKHoaDon
    Private aTimKiem() As String = {"Kỳ", "Hóa đơn chưa thanh toán", "Hóa đơn nhắc nhở lần 1", "Hóa đơn nhắc nhở lần 2", "Mã hóa đơn", "Mã khách hàng"}
    Private dtHD As DataTable
    Private dtKH As DataTable
    Public MaKH As String
    Private TimKiem As String
    Private DuLieu As String
    Private frmInHD As frmInHoaDon

    Private Sub frmTKHoaDon_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim ky As Date
        Dim flag As Integer
        cboTimKiem.Items.AddRange(aTimKiem)
        dtHD = frmMain.ds.Tables("HoaDon")
        dtKH = frmMain.ds.Tables("KhachHang")
        For Each dr In dtHD.Select("Ky=Max(Ky)")
            ky = dr("Ky")
            If dr("TinhTrangThanhToan") = "Rồi" Then
                flag = 1
                Exit For
            End If
        Next
        If flag = 1 Then
            MessageBox.Show("Kỳ ghi điện mới nhất là: " & Month(ky) & "/" & Year(ky) & " (Đã in hóa đơn)", "Thông báo")
        Else
            MessageBox.Show("Kỳ ghi điện mới nhất là: " & Month(ky) & "/" & Year(ky) & " (Chưa in hóa đơn)", "Thông báo")
            dtpKy.Text = ky
        End If
        If MaKH <> "" Then
            cboTimKiem.SelectedIndex = 5
            txtMaKH.Text = MaKH
            btnTim.PerformClick()
        Else
            cboTimKiem.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnTim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTim.Click
        Dim dr, dr1 As DataRow
        Dim i As Integer
        lvwHoadon.Items.Clear()
        If cboTimKiem.Text = "Kỳ" Then
            TimKiem = "Ky"
            DuLieu = dtpKy.Value.Month.ToString
            For Each dr In dtHD.Select("Ky='" + dtpKy.Text + "'")
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    i = lvwHoadon.Items.Count
                    lvwHoadon.Items.Add(dr1("TenKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("DiaChi"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("MaKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr("Ky"))
                    lvwHoadon.Items(i).SubItems.Add(dr("DienNangTieuThu"))
                    lvwHoadon.Items(i).SubItems.Add(dr("ThanhTien"))
                    lvwHoadon.Items(i).SubItems.Add(dr("TinhTrangThanhToan"))
                Next
            Next
        ElseIf cboTimKiem.Text = "Hóa đơn chưa thanh toán" Then
            TimKiem = "ChuaTT"
            For Each dr In dtHD.Select("TinhTrangThanhToan='Chưa' OR TinhTrangThanhToan='Lần 1' OR TinhTrangThanhToan='Lần 2'")
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    i = lvwHoadon.Items.Count
                    lvwHoadon.Items.Add(dr1("TenKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("DiaChi"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("MaKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr("Ky"))
                    lvwHoadon.Items(i).SubItems.Add(dr("DienNangTieuThu"))
                    lvwHoadon.Items(i).SubItems.Add(dr("ThanhTien"))
                    lvwHoadon.Items(i).SubItems.Add(dr("TinhTrangThanhToan"))
                Next
            Next
        ElseIf cboTimKiem.Text = "Hóa đơn nhắc nhở lần 1" Then
            TimKiem = "NhacNho1"
            For Each dr In dtHD.Select("TinhTrangThanhToan='Lần 1'")
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    i = lvwHoadon.Items.Count
                    lvwHoadon.Items.Add(dr1("TenKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("DiaChi"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("MaKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr("Ky"))
                    lvwHoadon.Items(i).SubItems.Add(dr("DienNangTieuThu"))
                    lvwHoadon.Items(i).SubItems.Add(dr("ThanhTien"))
                    lvwHoadon.Items(i).SubItems.Add(dr("TinhTrangThanhToan"))
                Next
            Next
        ElseIf cboTimKiem.Text = "Hóa đơn nhắc nhở lần 2" Then
            TimKiem = "NhacNho2"
            For Each dr In dtHD.Select("TinhTrangThanhToan='Lần 2'")
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    i = lvwHoadon.Items.Count
                    lvwHoadon.Items.Add(dr1("TenKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("DiaChi"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("MaKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr("Ky"))
                    lvwHoadon.Items(i).SubItems.Add(dr("DienNangTieuThu"))
                    lvwHoadon.Items(i).SubItems.Add(dr("ThanhTien"))
                    lvwHoadon.Items(i).SubItems.Add(dr("TinhTrangThanhToan"))
                Next
            Next
        ElseIf cboTimKiem.Text = "Mã hóa đơn" Then
            If txtMaHD.Text = "" Then
                MessageBox.Show("Nhập mã hóa đơn")
                Exit Sub
            End If
            TimKiem = "MaHD"
            DuLieu = txtMaHD.Text
            For Each dr In dtHD.Select("MaHD='" + txtMaHD.Text + "'")
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    i = lvwHoadon.Items.Count
                    lvwHoadon.Items.Add(dr1("TenKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("DiaChi"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("MaKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr("Ky"))
                    lvwHoadon.Items(i).SubItems.Add(dr("DienNangTieuThu"))
                    lvwHoadon.Items(i).SubItems.Add(dr("ThanhTien"))
                    lvwHoadon.Items(i).SubItems.Add(dr("TinhTrangThanhToan"))
                Next
            Next
        ElseIf cboTimKiem.Text = "Mã khách hàng" Then
            If txtMaKH.Text = "" Then
                MessageBox.Show("Nhập mã khách hàng")
                Exit Sub
            End If
            TimKiem = "MaKH"
            DuLieu = txtMaKH.Text
            For Each dr In dtHD.Select("MaKH='" + txtMaKH.Text + "'")
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    i = lvwHoadon.Items.Count
                    lvwHoadon.Items.Add(dr1("TenKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("DiaChi"))
                    lvwHoadon.Items(i).SubItems.Add(dr1("MaKH"))
                    lvwHoadon.Items(i).SubItems.Add(dr("Ky"))
                    lvwHoadon.Items(i).SubItems.Add(dr("DienNangTieuThu"))
                    lvwHoadon.Items(i).SubItems.Add(dr("ThanhTien"))
                    lvwHoadon.Items(i).SubItems.Add(dr("TinhTrangThanhToan"))
                Next
            Next
        End If
    End Sub

    Private Sub cboTimKiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTimKiem.SelectedIndexChanged
        If cboTimKiem.SelectedIndex = 0 Then
            lblTieuDe.Text = "Tìm theo kỳ"
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = True
            txtMaHD.Visible = False
            txtMaKH.Visible = False
            dtpKy.Visible = True
            btnNhacnho.Visible = False
            btnDathanhtoan.Visible = False
        ElseIf cboTimKiem.SelectedIndex = 1 Then
            lblTieuDe.Text = "Tìm hóa đơn chưa thanh toán/Nhắc nhở"
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            txtMaHD.Visible = False
            txtMaKH.Visible = False
            dtpKy.Visible = False
            btnNhacnho.Visible = True
            btnDathanhtoan.Visible = True
        ElseIf cboTimKiem.SelectedIndex = 2 Or cboTimKiem.SelectedIndex = 3 Then
            lblTieuDe.Text = "Tìm hóa đơn đã nhắc nhở/Nhắc nhở hoặc cắt điện"
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            txtMaHD.Visible = False
            txtMaKH.Visible = False
            dtpKy.Visible = False
            btnNhacnho.Visible = True
            btnDathanhtoan.Visible = True
        ElseIf cboTimKiem.SelectedIndex = 4 Then
            lblTieuDe.Text = "Tìm theo mã hóa đơn/Đánh dấu chưa thanh toán"
            Label2.Visible = False
            Label3.Visible = True
            Label4.Visible = False
            txtMaHD.Visible = True
            txtMaKH.Visible = False
            dtpKy.Visible = False
            btnNhacnho.Visible = True
            btnDathanhtoan.Visible = False
        ElseIf cboTimKiem.SelectedIndex = 5 Then
            lblTieuDe.Text = "Tìm theo mã khách hàng"
            Label2.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            txtMaHD.Visible = False
            txtMaKH.Visible = True
            dtpKy.Visible = False
            btnNhacnho.Visible = False
            btnDathanhtoan.Visible = False
        End If
    End Sub

    Private Sub btnNhacnho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhacnho.Click
        If lvwHoadon.SelectedItems.Count = 0 Then
            MessageBox.Show("Chọn hóa đơn")
            Exit Sub
        End If
        Dim dr, dr1 As DataRow
        For Each dr In dtHD.Select("MaKH='" + lvwHoadon.SelectedItems(0).SubItems(2).Text + "' AND Ky='" + lvwHoadon.SelectedItems(0).SubItems(3).Text + "'")
            If dr("TinhTrangThanhToan") = "Rồi" Then
                dr("TinhTrangThanhToan") = "Chưa"
            ElseIf dr("TinhTrangThanhToan") = "Chưa" Then
                dr("TinhTrangThanhToan") = "Lần 1"
            ElseIf dr("TinhTrangThanhToan") = "Lần 1" Then
                dr("TinhTrangThanhToan") = "Lần 2"
            ElseIf dr("TinhTrangThanhToan") = "Lần 2" Then
                For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                    dr1("TinhTrangSuDung") = "Cắt điện"
                Next
            End If
        Next
        Try
            Dim comHD As New SqlCommandBuilder(frmMain.daHoaDon)
            Dim comKH As New SqlCommandBuilder(frmMain.daKhachHang)
            frmMain.con.Open()
            comKH.DataAdapter.Update(dtKH)
            comHD.DataAdapter.Update(dtHD)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL", "Thông báo")
        End Try
        btnTim.PerformClick()
    End Sub

    Private Sub InHoaDon()
        If frmInHD Is Nothing OrElse frmInHD.IsDisposed Then
            frmInHD = New frmInHoaDon
            frmInHD.MdiParent = frmMain
            frmInHD.TimKiem = Me.TimKiem
            frmInHD.DuLieu = Me.DuLieu
            frmInHD.Show()
        Else
            frmInHD.TimKiem = Me.TimKiem
            frmInHD.DuLieu = Me.DuLieu
        End If
        Dim dr As DataRow
        For Each dr In dtHD.Select("Ky='" + dtpKy.Text + "'")
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

    Private Sub btnDathanhtoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDathanhtoan.Click
        If lvwHoadon.SelectedItems.Count = 0 Then
            MessageBox.Show("Chọn hóa đơn")
            Exit Sub
        End If
        Dim dr As DataRow
        For Each dr In dtHD.Select("MaKH='" + lvwHoadon.SelectedItems(0).SubItems(2).Text + "' AND Ky='" + lvwHoadon.SelectedItems(0).SubItems(3).Text + "'")
            dr("TinhTrangThanhToan") = "Rồi"
            For Each dr1 In dtKH.Select("MaKH='" + dr("MaKH") + "'")
                If dr1("TinhTrangSuDung") = "Cắt điện" Then
                    dr1("TinhTrangSuDung") = "Hoạt động"
                End If
            Next
        Next
        Try
            Dim comHD As New SqlCommandBuilder(frmMain.daHoaDon)
            Dim comKH As New SqlCommandBuilder(frmMain.daKhachHang)
            frmMain.con.Open()
            comKH.DataAdapter.Update(dtKH)
            comHD.DataAdapter.Update(dtHD)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL", "Thông báo")
        End Try
        btnTim.PerformClick()
    End Sub

    Private Sub btnXemHD_Click(sender As Object, e As EventArgs) Handles btnXemHD.Click
        If IsItemsListViewExit() Then
            InHoaDon()
        Else
            MsgBox("Không có dữ liệu để xem!")
        End If
    End Sub

    Private Function IsItemsListViewExit() As Boolean
        If lvwHoadon.Items.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class