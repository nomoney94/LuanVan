Imports System.Data.SqlClient

Public Class frmTKCongTo
    Private aTimKiem() As String = {"Mã công tơ", "Cấp điện áp"}

    Private Sub frmTKCongTo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            txtMaCT.Visible = True
            cboCapDA.Visible = False
        ElseIf cboTimKiem.SelectedIndex = 1 Then
            Label2.Visible = False
            Label3.Visible = True
            txtMaCT.Visible = False
            cboCapDA.Visible = True
        End If
    End Sub
End Class