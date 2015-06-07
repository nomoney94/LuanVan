Imports System.Data.SqlClient
Public Class frmTKKhachHang
    Private aTimKiem() As String = {"Mã khách hàng", "Tên khách hàng", "Khách hàng chưa thanh toán", "Khách hàng bị cắt điện"}

    Private Sub frmTKKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadComboBox()
        cboTimKiem.SelectedIndex = 0
    End Sub

    Private Sub loadComboBox()
        For Each s As String In aTimKiem
            cboTimKiem.Items.Add(s)
        Next
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click

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