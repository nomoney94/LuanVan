Imports System.Data.SqlClient

Public Class frmTKHoaDon
    Private aTimKiem() As String = {"Kỳ", "Hóa đơn chưa thanh toán theo kỳ", "Hóa đơn nhắc nhở lần 1", "Hóa đơn nhắc nhở lần 2", "Mã hóa đơn", "Mã khách hàng"}
    Private dtHD As DataTable
    Private dtKH As DataTable
    Private MaKH As String

    Private Sub frmTKHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTimKiem.Items.AddRange(aTimKiem)
        cboTimKiem.SelectedIndex = 0
        dtHD = frmMain.ds.Tables("HoaDon")
        dtKH = frmMain.ds.Tables("KhachHang")
    End Sub

    Private Sub btnTim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTim.Click
        Dim dr, dr1 As DataRow
        Dim i As Integer
        lvwHoadon.Items.Clear()
        If cboTimKiem.Text = "Kỳ" Then
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
        ElseIf cboTimKiem.Text = "Hóa đơn chưa thanh toán theo kỳ" Then
            For Each dr In dtHD.Select("Ky='" + dtpKy.Text + "' AND (TinhTrangThanhToan='Chưa' OR TinhTrangThanhToan='Lần 1' OR TinhTrangThanhToan='Lần 2')")
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
            lblTieuDe.Text = "Tìm theo kỳ/In hóa đơn theo kỳ"
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = True
            txtMaHD.Visible = False
            txtMaKH.Visible = False
            dtpKy.Visible = True
            btnInhoadon.Visible = True
            btnNhacnho.Visible = False
            btnDathanhtoan.Visible = False
        ElseIf cboTimKiem.SelectedIndex = 1 Then
            lblTieuDe.Text = "Tìm hóa đơn chưa thanh toán/Nhắc nhở"
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = True
            txtMaHD.Visible = False
            txtMaKH.Visible = False
            dtpKy.Visible = True
            btnInhoadon.Visible = False
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
            btnInhoadon.Visible = False
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
            btnInhoadon.Visible = False
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
            btnInhoadon.Visible = False
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
    End Sub

    Private Sub btnInhoadon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInhoadon.Click
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
    End Sub
End Class