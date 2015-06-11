Imports System.Data.SqlClient
Public Class frmTTDonVi
    Private dtDV As DataTable
    ' Private change As Boolean = False

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim dr As DataRow
        Dim strfind As String = "MaSoThue='" + txtMSThue.Text.Trim + "'"
        For Each dr In dtDV.Select(strfind)
            dr("TenDV") = txtTenDV.Text
            dr("DiaChi") = txtDiaChi.Text
            dr("DienThoai") = txtDT.Text
            dr("DTSuaChua") = txtDTSC.Text
            'change = True
        Next
        Try
            Dim comDV As New SqlCommandBuilder(frmMain.daDonVi)
            frmMain.con.Open()
            comDV.DataAdapter.Update(dtDV)
            frmMain.con.Close()
            'change = False
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL", "Thông báo")
        End Try
        show_Donvi()
    End Sub

    Private Sub frmTTDonVi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtDV = frmMain.ds.Tables("DonVi")
        show_Donvi()
    End Sub

    Private Sub show_Donvi()
        Dim read As DataTableReader = dtDV.CreateDataReader()
        While (read.Read())
            txtTenDV.Text = read("TenDV").ToString()
            txtDiaChi.Text = read("DiaChi").ToString()
            txtDT.Text = read("DienThoai").ToString()
            txtDTSC.Text = read("DTSuaChua").ToString()
            txtMSThue.Text = read("MaSoThue").ToString()
        End While
    End Sub
End Class