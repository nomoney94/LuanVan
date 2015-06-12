Imports System.Data.SqlClient
Public Class frmTKKhachHang
    Private aTimKiem() As String = {"Mã khách hàng", "Tên khách hàng", "Khách hàng chưa thanh toán", "Khách hàng bị cắt điện"}
    Private dtKH As DataTable
    Private dtHD As DataTable

    Private Sub frmTKKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTimKiem.Items.AddRange(aTimKiem)
        cboTimKiem.SelectedIndex = 0
        dtKH = frmMain.ds.Tables("KhachHang")
        dtHD = frmMain.ds.Tables("HoaDon")
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        If cboTimKiem.Text = "Mã khách hàng" Or cboTimKiem.Text = "Tên khách hàng" Then
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
            Dim strfind As String = "TinhTrangThanhToan ='False'"
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
End Class