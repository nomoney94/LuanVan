Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmTKKhachHang
    Private aTimKiem() As String = {"Mã khách hàng", "Tên khách hàng", "Khách hàng chưa thanh toán", "Khách hàng bị cắt điện"}
    Private dtKH As DataTable
    Private dtHD As DataTable
    Private frmTKHD As frmTKHoaDon
    Public MaKH As String
    Private dt As DataTable

    Private Sub frmTKKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTimKiem.Items.AddRange(aTimKiem)
        cboTimKiem.SelectedIndex = 0
        dtKH = frmMain.ds.Tables("KhachHang")
        dtHD = frmMain.ds.Tables("HoaDon")
    End Sub

    Private Sub btnTim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTim.Click
        dt = New DataTable
        dt = dtKH.Clone
        Dim newRow As DataRow
        lvwKH.Items.Clear()
        If cboTimKiem.Text = "Mã khách hàng" Then
            If txtMaKH.Text = "" Then
                MessageBox.Show("Nhập mã khách hàng")
                Exit Sub
            End If
            Dim strfind As String = "MaKH like '%" + txtMaKH.Text + "%'"
            Dim dr As DataRow
            Dim i As Integer
            For Each dr In dtKH.Select(strfind)
                newRow = dt.NewRow
                newRow = dr
                dt.Rows.Add(newRow.ItemArray)
                i = lvwKH.Items.Count
                lvwKH.Items.Add(dr("MaKH"))
                lvwKH.Items(i).SubItems.Add(dr("MaCT"))
                lvwKH.Items(i).SubItems.Add(dr("MaDT"))
                lvwKH.Items(i).SubItems.Add(dr("TenKH"))
                lvwKH.Items(i).SubItems.Add(dr("DiaChi"))
                lvwKH.Items(i).SubItems.Add(dr("TinhTrangSuDung"))
            Next
        ElseIf cboTimKiem.Text = "Tên khách hàng" Then
            If txtTenKH.Text = "" Then
                MessageBox.Show("Nhập tên khách hàng")
                Exit Sub
            End If
            Dim strfind As String = "TenKH like '%" + txtTenKH.Text + "%'"
            Dim dr As DataRow
            Dim i As Integer
            For Each dr In dtKH.Select(strfind)
                newRow = dt.NewRow
                newRow = dr
                dt.Rows.Add(newRow.ItemArray)
                i = lvwKH.Items.Count
                lvwKH.Items.Add(dr("MaKH"))
                lvwKH.Items(i).SubItems.Add(dr("MaCT"))
                lvwKH.Items(i).SubItems.Add(dr("MaDT"))
                lvwKH.Items(i).SubItems.Add(dr("TenKH"))
                lvwKH.Items(i).SubItems.Add(dr("DiaChi"))
                lvwKH.Items(i).SubItems.Add(dr("TinhTrangSuDung"))
            Next
        ElseIf cboTimKiem.Text = "Khách hàng chưa thanh toán" Then
            Dim strfind As String = "TinhTrangThanhToan = 'Chưa' or TinhTrangThanhToan = 'Lần 1' or TinhTrangThanhToan = 'Lần 2'"
            Dim strfind1 As String
            Dim dr, dr1 As DataRow
            Dim i As Integer
            For Each dr In dtHD.Select(strfind, "Ky ASC")
                strfind1 = "MaKH='" + dr("MaKH") + "'"
                For Each dr1 In dtKH.Select(strfind1)
                    newRow = dt.NewRow
                    newRow = dr
                    dt.Rows.Add(newRow.ItemArray)
                    i = lvwKH.Items.Count
                    If i > 0 Then
                        If dr1("MaKH") <> lvwKH.Items(i - 1).SubItems(0).Text Then
                            lvwKH.Items.Add(dr1("MaKH"))
                            lvwKH.Items(i).SubItems.Add(dr1("MaCT"))
                            lvwKH.Items(i).SubItems.Add(dr1("MaDT"))
                            lvwKH.Items(i).SubItems.Add(dr1("TenKH"))
                            lvwKH.Items(i).SubItems.Add(dr1("DiaChi"))
                            lvwKH.Items(i).SubItems.Add(dr1("TinhTrangSuDung"))
                            lvwKH.Items(i).SubItems.Add(dr("Ky"))
                        End If
                    Else
                        lvwKH.Items.Add(dr1("MaKH"))
                        lvwKH.Items(i).SubItems.Add(dr1("MaCT"))
                        lvwKH.Items(i).SubItems.Add(dr1("MaDT"))
                        lvwKH.Items(i).SubItems.Add(dr1("TenKH"))
                        lvwKH.Items(i).SubItems.Add(dr1("DiaChi"))
                        lvwKH.Items(i).SubItems.Add(dr1("TinhTrangSuDung"))
                        lvwKH.Items(i).SubItems.Add(dr("Ky"))
                    End If
                Next
            Next
        ElseIf cboTimKiem.Text = "Khách hàng bị cắt điện" Then
            Dim strfind As String = "TinhTrangSuDung='Cắt điện'"
            Dim dr, dr1 As DataRow
            Dim i As Integer
            For Each dr In dtKH.Select(strfind)
                For Each dr1 In dtHD.Select("MaKH='" + dr("MaKH") + "' and TinhTrangThanhToan <> 'rồi'", "Ky ASC")
                    newRow = dt.NewRow
                    newRow = dr
                    dt.Rows.Add(newRow.ItemArray)
                    i = lvwKH.Items.Count
                    If i > 0 Then
                        If dr("MaKH") <> lvwKH.Items(i - 1).SubItems(0).Text Then
                            lvwKH.Items.Add(dr("MaKH"))
                            lvwKH.Items(i).SubItems.Add(dr("MaCT"))
                            lvwKH.Items(i).SubItems.Add(dr("MaDT"))
                            lvwKH.Items(i).SubItems.Add(dr("TenKH"))
                            lvwKH.Items(i).SubItems.Add(dr("DiaChi"))
                            lvwKH.Items(i).SubItems.Add(dr("TinhTrangSuDung"))
                            lvwKH.Items(i).SubItems.Add(dr1("Ky"))
                        End If
                    Else
                        lvwKH.Items.Add(dr("MaKH"))
                        lvwKH.Items(i).SubItems.Add(dr("MaCT"))
                        lvwKH.Items(i).SubItems.Add(dr("MaDT"))
                        lvwKH.Items(i).SubItems.Add(dr("TenKH"))
                        lvwKH.Items(i).SubItems.Add(dr("DiaChi"))
                        lvwKH.Items(i).SubItems.Add(dr("TinhTrangSuDung"))
                        lvwKH.Items(i).SubItems.Add(dr1("Ky"))
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub cboTimKiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTimKiem.SelectedIndexChanged
        If lvwKH.Columns.Count - 1 = 6 Then
            lvwKH.Columns.RemoveAt(6)
        End If
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
            lvwKH.Columns.Add("Kỳ nợ")
        End If
    End Sub

    Private Sub btnXemhoadon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXemhoadon.Click
        If lvwKH.SelectedItems.Count <= 0 Then
            MsgBox("Chọn khách hàng muốn xem hóa đơn")
            Exit Sub
        End If
        frmTKHD = New frmTKHoaDon
        frmTKHD.MdiParent = frmMain
        frmTKHD.MaKH = lvwKH.SelectedItems(0).SubItems(0).Text
        frmTKHD.Show()
    End Sub

    Private Sub btnXuatDS_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click
        Try
            SaveFileDialog.FileName = ""
            SaveFileDialog.Filter = "Excel Workbook|*.xlsx"
            If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If dt.Rows.Count > 0 Then
                    Dim oXL As Excel.Application
                    Dim oWB As Excel.Workbook
                    Dim oSheet As Excel.Worksheet
                    Dim oRng As Excel.Range

                    ' Start Excel and get Application object.
                    oXL = CreateObject("Excel.Application")
                    oXL.Visible = True

                    ' Get a new workbook.
                    oWB = oXL.Workbooks.Add
                    oSheet = oWB.ActiveSheet

                    oSheet.Cells(1, 1).Value = "Mã khách hàng"
                    oSheet.Cells(1, 2).Value = "Mã công tơ"
                    oSheet.Cells(1, 3).Value = "Mã đối tượng"
                    oSheet.Cells(1, 4).Value = "Tên khách hàng"
                    oSheet.Cells(1, 5).Value = "Địa chỉ"
                    oSheet.Cells(1, 6).Value = "Số điện thoại"
                    oSheet.Cells(1, 7).Value = "Mã số thuế"

                    oSheet.Range("A2", "G" & dt.Rows.Count + 1).Value = ConvertDataTableToArray(dt)

                    oRng = oSheet.Range("A1", "G1")
                    oRng.EntireColumn.AutoFit()

                    oWB.SaveAs(SaveFileDialog.FileName)

                    oRng = Nothing
                    oSheet = Nothing
                    oWB = Nothing
                    oXL = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
        End Try
    End Sub

    Private Function ConvertDataTableToArray(dt As DataTable) As Array
        Dim aResult(dt.Rows.Count - 1, 6) As String
        Dim dr As DataRow
        Dim RowIndex As Integer = 0
        For Each dr In dt.Rows
            aResult(RowIndex, 0) = dr.Item(0)
            aResult(RowIndex, 1) = dr.Item(1)
            aResult(RowIndex, 2) = dr.Item(2)
            aResult(RowIndex, 3) = dr.Item(3)
            aResult(RowIndex, 4) = dr.Item(4)
            aResult(RowIndex, 5) = If(IsDBNull(dr.Item(5)), "", dr.Item(5))
            aResult(RowIndex, 6) = If(IsDBNull(dr.Item(6)), "", dr.Item(6))
            RowIndex += 1
        Next
        Return aResult
    End Function

End Class