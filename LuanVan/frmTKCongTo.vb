Imports System.Data.SqlClient

Public Class frmTKCongTo

#Region "Declares"
    Private aTimKiem() As String = {"Mã công tơ", "Ngày lắp đặt"}
    Private dtCT As DataTable
#End Region

#Region "Events"
    Private Sub frmTKCongTo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTimKiem.Items.AddRange(aTimKiem)
        cboTimKiem.SelectedIndex = 0
        dtCT = frmMain.ds.Tables("CongTo")
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
            For Each dr In dtCT.Select("MaCT like '%" + txtMaCT.Text + "%'")
                i = lvwCongto.Items.Count
                lvwCongto.Items.Add(dr("MaCT"))
                lvwCongto.Items(i).SubItems.Add(dr("MaTram"))
                lvwCongto.Items(i).SubItems.Add(dr("NgayLapDat"))
            Next
        Else
            Dim dr As DataRow
            Dim i As Integer
            lvwCongto.Items.Clear()
            For Each dr In dtCT.Select()
                If Month(dr("NgayLapDat")) = Month(dtpNgaylapdat.Text) And Year(dr("NgayLapDat")) = Year(dtpNgaylapdat.Text) Then
                    i = lvwCongto.Items.Count
                    lvwCongto.Items.Add(dr("MaCT"))
                    lvwCongto.Items(i).SubItems.Add(dr("MaTram"))
                    lvwCongto.Items(i).SubItems.Add(dr("NgayLapDat"))
                End If
            Next
        End If
    End Sub

    Private Sub cboTimKiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTimKiem.SelectedIndexChanged
        If cboTimKiem.SelectedIndex = 0 Then
            Label2.Visible = True
            Label3.Visible = False
            txtMaCT.Visible = True
            dtpNgaylapdat.Visible = False
        ElseIf cboTimKiem.SelectedIndex = 1 Then
            Label2.Visible = False
            Label3.Visible = True
            txtMaCT.Visible = False
            dtpNgaylapdat.Visible = True
        End If
    End Sub
#End Region

#Region "Functions/Subs"

#End Region

End Class