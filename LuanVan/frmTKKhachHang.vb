Imports System.Data.SqlClient
Public Class frmTKKhachHang
    Private aTimKiem() As String = {"Mã khách hàng", "Tên khách hàng", "Khách hàng chưa thanh toán", "Khách hàng bị cắt điện"}
    Private dtKH As DataTable
    Private dtHD As DataTable
    Private frmTKHD As frmTKHoaDon
    Public MaKH As String

    Private Sub frmTKKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTimKiem.Items.AddRange(aTimKiem)
        cboTimKiem.SelectedIndex = 0
        dtKH = frmMain.ds.Tables("KhachHang")
        dtHD = frmMain.ds.Tables("HoaDon")
    End Sub

    Private Sub btnTim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTim.Click
        If cboTimKiem.Text = "Mã khách hàng" Or cboTimKiem.Text = "Tên khách hàng" Then
            If txtMaKH.Text = "" And txtTenKH.Text = "" Then
                MessageBox.Show("Nhập thông tin cần tìm")
                Exit Sub
            End If
            Dim strfind As String = "TenKH like '%" + txtTenKH.Text + "%' and MaKH like '%" + txtMaKH.Text + "%'"
            Dim dr As DataRow
            Dim i As Integer
            lvwKH.Items.Clear()
            For Each dr In dtKH.Select(strfind)
                i = lvwKH.Items.Count
                lvwKH.Items.Add(dr("MaKH"))
                lvwKH.Items(i).SubItems.Add(dr("MaCT"))
                lvwKH.Items(i).SubItems.Add(dr("MaDT"))
                lvwKH.Items(i).SubItems.Add(dr("TenKH"))
                lvwKH.Items(i).SubItems.Add(dr("DiaChi"))
            Next
        ElseIf cboTimKiem.Text = "Khách hàng chưa thanh toán" Then
            Dim strfind As String = "TinhTrangThanhToan ='Chưa' or TinhTrangThanhToan ='Lần 1' or TinhTrangThanhToan ='Lần 2'"
            Dim strfind1 As String
            Dim dr, dr1 As DataRow
            Dim i As Integer
            lvwKH.Items.Clear()
            For Each dr In dtHD.Select(strfind)
                strfind1 = "MaKH='" + dr("MaKH") + "'"
                For Each dr1 In dtKH.Select(strfind1)
                    i = lvwKH.Items.Count
                    lvwKH.Items.Add(dr1("MaKH"))
                    lvwKH.Items(i).SubItems.Add(dr1("MaCT"))
                    lvwKH.Items(i).SubItems.Add(dr1("MaDT"))
                    lvwKH.Items(i).SubItems.Add(dr1("TenKH"))
                    lvwKH.Items(i).SubItems.Add(dr1("DiaChi"))
                Next
            Next
        ElseIf cboTimKiem.Text = "Khách hàng bị cắt điện" Then
            Dim strfind As String = "TinhTrangSuDung='Cắt điện'"
            Dim dr As DataRow
            Dim i As Integer
            For Each dr In dtKH.Select(strfind)
                i = lvwKH.Items.Count
                lvwKH.Items.Add(dr("MaKH"))
                lvwKH.Items(i).SubItems.Add(dr("MaCT"))
                lvwKH.Items(i).SubItems.Add(dr("MaDT"))
                lvwKH.Items(i).SubItems.Add(dr("TenKH"))
                lvwKH.Items(i).SubItems.Add(dr("DiaChi"))
            Next
        End If
    End Sub

    Private Sub cboTimKiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTimKiem.SelectedIndexChanged
        If cboTimKiem.SelectedIndex = 0 Then
            Label2.Visible = True
            Label3.Visible = False
            txtMaKH.Visible = True
            txtTenKH.Visible = False
        ElseIf cboTimKiem.SelectedIndex = 1 Then
            Label2.Visible = False
            Label3.Visible = True
            txtMaKH.Visible = False
            txtTenKH.Visible = True
        Else
            Label2.Visible = False
            Label3.Visible = False
            txtMaKH.Visible = False
            txtTenKH.Visible = False
        End If
    End Sub

    Private Sub btnXemhoadon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXemhoadon.Click
        frmTKHD = New frmTKHoaDon
        frmTKHD.MdiParent = frmMain
        frmTKHD.Show()
    End Sub
End Class