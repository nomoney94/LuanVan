Imports System.Data.SqlClient

Public Class frmTKCongTo
    Private aTimKiem() As String = {"Mã công tơ", "Cấp điện áp"}
    Private dtCSCT As DataTable

    Private Sub frmTKCongTo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTimKiem.Items.AddRange(aTimKiem)
        cboTimKiem.SelectedIndex = 0
        dtCSCT = frmMain.ds.Tables("ChiSoCongTo")
    End Sub

    Private Sub btnTim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTim.Click
        If cboTimKiem.Text = "Mã công tơ" Then
            If txtMaCT.Text = "" Then
                MessageBox.Show("Nhập mã công tơ")
                Exit Sub
            End If
            Dim dr As DataRow
            Dim i As Integer
            lvwCongto.Items.Clear()
            For Each dr In dtCSCT.Select("MaCT like '%" + txtMaCT.Text + "%'")
                i = lvwCongto.Items.Count
                lvwCongto.Items.Add(dr("MaCT"))
                lvwCongto.Items(i).SubItems.Add(dr("Ky"))
                lvwCongto.Items(i).SubItems.Add(dr("ChiSo"))
                lvwCongto.Items(i).SubItems.Add(dr("ChisoCD"))
                lvwCongto.Items(i).SubItems.Add(dr("ChisoTD"))
            Next
        End If
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