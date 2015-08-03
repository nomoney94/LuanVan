Imports System.Data.SqlClient
Public Class frmTKTram
    Private dtT As DataTable

    Private Sub frmTKTram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtT = frmMain.ds.Tables("Tram")
    End Sub

    Private Sub btnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim.Click
        If txtMaTram.Text = "" Then
            MessageBox.Show("Nhập mã trạm")
            Exit Sub
        End If
        Dim dr As DataRow
        Dim i As Integer
        lvwTram.Items.Clear()
        For Each dr In dtT.Select("MaTram like '%" + txtMaTram.Text + "%'")
            i = lvwTram.Items.Count
            lvwTram.Items.Add(dr("MaTram"))
            lvwTram.Items(i).SubItems.Add(dr("TenTram"))
        Next
    End Sub
End Class