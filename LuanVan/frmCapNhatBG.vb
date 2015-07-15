Imports System.Data.SqlClient

Public Class frmCapNhatBG

#Region "Declares"
    Private aLoai() As String = {"SX-KD-HC", "SH-NT-CDC-TM"}
    Private aDTG6() As String = {"CDCTPK", "CDCTPB", "CDCTPM", "CDCTTK", "CDCTTB", "CDCTTM", "NTK", "SHNT", "SHBTTT", "SHBT", "TMSH"}
    Private aDTG3() As String = {"BVT_T6", "BVT_D6", "CSHC_T6", "CSHC_D6", "KD_T22", "KD_T6", "KD_D6", "SX_T110", "SX_T22", "SX_T6", "SX_D6"}
    Private dtBG3 As DataTable
    Private dtBG6 As DataTable
    Private change As Boolean = False
#End Region

#Region "Events"
    Private Sub frmCapNhatBG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLoai.Items.AddRange(aLoai)
        cboLoai.SelectedIndex = 0
        dtBG3 = frmMain.ds.Tables("Gia3")
        dtBG6 = frmMain.ds.Tables("Gia6")
        'dtDT = frmMain.ds.Tables("DoiTuongKH")
        LoadData_lsvBG3()
        LoadData_lsvBG6()
    End Sub

    Private Sub frmCapNhatBG_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If change Then
            Dim d As DialogResult = MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.YesNoCancel, "Thông báo")
            If d = DialogResult.Yes Then
                btnLuu.PerformClick()
            ElseIf d = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Try
            Dim comG3 As New SqlCommandBuilder(frmMain.daGia3)
            Dim comG6 As New SqlCommandBuilder(frmMain.daGia6)
            frmMain.con.Open()
            comG3.DataAdapter.Update(dtBG3)
            comG6.DataAdapter.Update(dtBG6)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL!", "Thông báo!")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtMaDV.Clear()
        txtTenLoai.Clear()
        txtGiaBT.Clear()
        txtGiaCD.Clear()
        txtGiaTD.Clear()
        txtDinhMuc.Clear()
        txtGia.Clear()
        txtMoTa.Clear()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If InputValidating() Then
            If cboLoai.SelectedIndex = 0 Then
                If lsvBG3.SelectedItems(0).SubItems(0).Text.Trim = txtMaDV.Text.Trim Then
                    Dim strFind As String = "MaLoaiDV='" & txtMaDV.Text & "'"
                    Dim dr As DataRow
                    For Each dr In dtBG3.Select(strFind)
                        dr("MaDT") = cboMaDT.Text
                        dr("TenLoai") = txtTenLoai.Text
                        dr("GiaBT") = txtGiaBT.Text
                        dr("GiaCD") = txtGiaCD.Text
                        dr("GiaTD") = txtGiaTD.Text
                        change = True
                    Next
                    LoadData_lsvBG3()
                    btnReset.PerformClick()
                Else
                    MsgBox("Mã loại dịch vụ không được thay đổi", MsgBoxStyle.OkOnly, "Thông báo!")
                End If
            Else
                If lsvBG6.SelectedItems(0).SubItems(0).Text.Trim = txtMaDV.Text.Trim Then
                    Dim strFind As String = "MaLoaiDV='" & txtMaDV.Text & "'"
                    Dim dr As DataRow
                    For Each dr In dtBG6.Select(strFind)
                        dr("MaDT") = cboMaDT.Text
                        dr("DinhMuc") = txtDinhMuc.Text
                        dr("Gia") = txtGia.Text
                        dr("MoTa") = txtMoTa.Text
                        change = True
                    Next
                    LoadData_lsvBG6()
                    btnReset.PerformClick()
                Else
                    MsgBox("Mã loại dịch vụ không được thay đổi", MsgBoxStyle.OkOnly, "Thông báo!")
                End If
            End If
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If InputValidating() Then
            If cboLoai.SelectedIndex = 0 Then
                Dim strFind As String = "MaLoaiDV='" & txtMaDV.Text & "'"
                If dtBG3.Select(strFind).Length <= 0 Then
                    Dim dr As DataRow = dtBG3.NewRow
                    dr("MaLoaiDV") = txtMaDV.Text
                    dr("MaDT") = cboMaDT.Text
                    dr("TenLoai") = txtTenLoai.Text
                    dr("GiaBT") = txtGiaBT.Text
                    dr("GiaCD") = txtGiaCD.Text
                    dr("GiaTD") = txtGiaTD.Text
                    dtBG3.Rows.Add(dr)
                    change = True
                    LoadData_lsvBG3()
                Else
                    MsgBox("Mã loại dịch vụ đã có trong CSDL", MsgBoxStyle.OkOnly, "Thông báo!")
                End If
            Else
                Dim strFind As String = "MaLoaiDV='" & txtMaDV.Text & "'"
                If dtBG6.Select(strFind).Length <= 0 Then
                    Dim dr As DataRow = dtBG6.NewRow
                    dr("MaLoaiDV") = txtMaDV.Text
                    dr("MaDT") = cboMaDT.Text
                    dr("DinhMuc") = txtDinhMuc.Text
                    dr("Gia") = txtGia.Text
                    dr("MoTa") = txtMoTa.Text
                    dtBG6.Rows.Add(dr)
                    change = True
                    LoadData_lsvBG6()
                Else
                    MsgBox("Mã loại dịch vụ đã có trong CSDL", MsgBoxStyle.OkOnly, "Thông báo!")
                End If
            End If
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If cboLoai.SelectedIndex = 0 Then
            If (lsvBG3.SelectedItems.Count <= 0) Then
                MessageBox.Show("Bạn chưa chọn mẫu tin cần xóa!")
                Exit Sub
            End If
            Dim i As Integer
            For i = 0 To lsvBG3.SelectedItems.Count - 1
                Dim s As String = lsvBG3.SelectedItems(i).Text
                Dim strFind As String = "MaLoaiDV='" + s + "'"
                Dim dr As DataRow
                For Each dr In dtBG3.Select(strFind)
                    dr.Delete()
                    change = True
                Next
                LoadData_lsvBG3()
                btnReset.PerformClick()
            Next
        Else
            If (lsvBG6.SelectedItems.Count <= 0) Then
                MessageBox.Show("Bạn chưa chọn mẫu tin cần xóa!")
                Exit Sub
            End If
            Dim i As Integer
            For i = 0 To lsvBG6.SelectedItems.Count - 1
                Dim s As String = lsvBG6.SelectedItems(i).Text
                Dim strFind As String = "MaLoaiDV='" + s + "'"
                Dim dr As DataRow
                For Each dr In dtBG6.Select(strFind)
                    dr.Delete()
                    change = True
                Next
                LoadData_lsvBG6()
                btnReset.PerformClick()
            Next
        End If
    End Sub

    Private Sub cboLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoai.SelectedIndexChanged
        btnReset.PerformClick()
        ClearError()
        LoadData_cboMaDT()
        If cboLoai.SelectedIndex = 0 Then
            txtTenLoai.Enabled = True
            txtGiaBT.Enabled = True
            txtGiaCD.Enabled = True
            txtGiaTD.Enabled = True
            txtDinhMuc.Enabled = False
            txtGia.Enabled = False
            txtMoTa.Enabled = False
            lsvBG3.Visible = True
            lsvBG6.Visible = False
        Else
            txtTenLoai.Enabled = False
            txtGiaBT.Enabled = False
            txtGiaCD.Enabled = False
            txtGiaTD.Enabled = False
            txtDinhMuc.Enabled = True
            txtGia.Enabled = True
            txtMoTa.Enabled = True
            lsvBG3.Visible = False
            lsvBG6.Visible = True
        End If
    End Sub

    Private Sub cboMaDT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaDT.SelectedIndexChanged
        If cboMaDT.SelectedItem = aDTG3(0) Or cboMaDT.SelectedItem = aDTG3(1) Or cboMaDT.SelectedItem = aDTG3(2) Or cboMaDT.SelectedItem = aDTG3(3) Then
            txtGiaCD.Enabled = False
            txtGiaTD.Enabled = False
        ElseIf cboMaDT.SelectedItem = aDTG3(4) Or cboMaDT.SelectedItem = aDTG3(5) Or cboMaDT.SelectedItem = aDTG3(6) Or cboMaDT.SelectedItem = aDTG3(7) Or cboMaDT.SelectedItem = aDTG3(8) Or cboMaDT.SelectedItem = aDTG3(9) Or cboMaDT.SelectedItem = aDTG3(10) Then
            txtGiaCD.Enabled = True
            txtGiaTD.Enabled = True
        End If
    End Sub

    Private Sub lsvBG3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvBG3.SelectedIndexChanged
        If lsvBG3.SelectedItems.Count > 0 Then
            txtMaDV.Text = lsvBG3.SelectedItems(0).SubItems(0).Text
            cboMaDT.Text = lsvBG3.SelectedItems(0).SubItems(1).Text
            txtTenLoai.Text = lsvBG3.SelectedItems(0).SubItems(2).Text
            txtGiaBT.Text = lsvBG3.SelectedItems(0).SubItems(3).Text
            txtGiaCD.Text = lsvBG3.SelectedItems(0).SubItems(4).Text
            txtGiaTD.Text = lsvBG3.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub lsvBG6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvBG6.SelectedIndexChanged
        If lsvBG6.SelectedItems.Count > 0 Then
            txtMaDV.Text = lsvBG6.SelectedItems(0).SubItems(0).Text
            cboMaDT.Text = lsvBG6.SelectedItems(0).SubItems(1).Text
            txtDinhMuc.Text = lsvBG6.SelectedItems(0).SubItems(2).Text
            txtGia.Text = lsvBG6.SelectedItems(0).SubItems(3).Text
            txtMoTa.Text = lsvBG6.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
#End Region

#Region "Functions/Subs"
    Private Sub LoadData_cboMaDT()
        If cboLoai.SelectedIndex = 0 Then
            cboMaDT.Items.Clear()
            cboMaDT.Items.AddRange(aDTG3)
        Else
            cboMaDT.Items.Clear()
            cboMaDT.Items.AddRange(aDTG6)
        End If
    End Sub

    Private Sub LoadData_lsvBG3()
        Dim read As DataTableReader = dtBG3.CreateDataReader
        Dim index As Integer
        lsvBG3.Items.Clear()
        While (read.Read)
            index = lsvBG3.Items.Count
            lsvBG3.Items.Add(read("MaLoaiDV"))
            lsvBG3.Items(index).SubItems.Add(read("MaDT"))
            lsvBG3.Items(index).SubItems.Add(read("TenLoai"))
            lsvBG3.Items(index).SubItems.Add(read("GiaBT"))
            lsvBG3.Items(index).SubItems.Add(read("GiaCD"))
            lsvBG3.Items(index).SubItems.Add(read("GiaTD"))
        End While
    End Sub

    Private Sub LoadData_lsvBG6()
        Dim read As DataTableReader = dtBG6.CreateDataReader
        Dim index As Integer
        lsvBG6.Items.Clear()
        While (read.Read)
            index = lsvBG6.Items.Count
            lsvBG6.Items.Add(read("MaLoaiDV"))
            lsvBG6.Items(index).SubItems.Add(read("MaDT"))
            lsvBG6.Items(index).SubItems.Add(read("DinhMuc"))
            lsvBG6.Items(index).SubItems.Add(read("Gia"))
            lsvBG6.Items(index).SubItems.Add(read("MoTa"))
        End While
    End Sub

    Private Sub ClearError()
        errLoi.SetError(txtMaDV, "")
        errLoi.SetError(cboMaDT, "")
        errLoi.SetError(txtTenLoai, "")
        errLoi.SetError(txtGiaBT, "")
        errLoi.SetError(txtGiaCD, "")
        errLoi.SetError(txtGiaTD, "")
        errLoi.SetError(txtDinhMuc, "")
        errLoi.SetError(txtGia, "")
        errLoi.SetError(txtMoTa, "")
    End Sub

#Region "Kiểm tra dữ liệu"
    Private Sub txtMaDV_Validating()
        If txtMaDV.Text = "" Then
            errLoi.SetError(txtMaDV, "Không được để trống")
        Else
            errLoi.SetError(txtMaDV, "")
        End If
    End Sub

    Private Sub txtGiaCD_Validating()
        If txtGiaCD.Text = "" Then
            errLoi.SetError(txtGiaCD, "Không được để trống")
        Else
            If IsNumeric(txtGiaCD.Text) Then
                If CInt(txtGiaCD.Text) >= 0 Then
                    errLoi.SetError(txtGiaCD, "")
                Else
                    errLoi.SetError(txtGiaCD, "Xin nhập số dương")
                End If
            Else
                errLoi.SetError(txtGiaCD, "Chỉ được nhập số")
            End If
        End If
    End Sub

    Private Sub txtGiaTD_Validating()
        If txtGiaTD.Text = "" Then
            errLoi.SetError(txtGiaTD, "Không được để trống")
        Else
            If IsNumeric(txtGiaTD.Text) Then
                If CInt(txtGiaTD.Text) >= 0 Then
                    errLoi.SetError(txtGiaTD, "")
                Else
                    errLoi.SetError(txtGiaTD, "Xin nhập số dương")
                End If
            Else
                errLoi.SetError(txtGiaTD, "Chỉ được nhập số")
            End If
        End If
    End Sub

    Private Sub txtGiaBT_Validating()
        If txtGiaBT.Text = "" Then
            errLoi.SetError(txtGiaBT, "Không được để trống")
        Else
            If IsNumeric(txtGiaBT.Text) Then
                If CInt(txtGiaBT.Text) >= 0 Then
                    errLoi.SetError(txtGiaBT, "")
                Else
                    errLoi.SetError(txtGiaBT, "Xin nhập số dương")
                End If
            Else
                errLoi.SetError(txtGiaBT, "Chỉ được nhập số")
            End If
        End If
    End Sub

    Private Sub txtTenLoai_Validating()
        If txtTenLoai.Text = "" Then
            errLoi.SetError(txtTenLoai, "Không được để trống")
        Else
            errLoi.SetError(txtTenLoai, "")
        End If
    End Sub

    Private Sub txtDinhMuc_Validating()
        If txtDinhMuc.Text = "" Then
            errLoi.SetError(txtDinhMuc, "Không được để trống")
        Else
            If IsNumeric(txtDinhMuc.Text) Then
                If CInt(txtDinhMuc.Text) >= 0 Then
                    errLoi.SetError(txtDinhMuc, "")
                Else
                    errLoi.SetError(txtDinhMuc, "Xin nhập số dương")
                End If
            Else
                errLoi.SetError(txtDinhMuc, "Chỉ được nhập số")
            End If
        End If
    End Sub

    Private Sub txtGia_Validating()
        If txtGia.Text = "" Then
            errLoi.SetError(txtGia, "Không được để trống")
        Else
            If IsNumeric(txtGia.Text) Then
                If CInt(txtGia.Text) >= 0 Then
                    errLoi.SetError(txtGia, "")
                Else
                    errLoi.SetError(txtGia, "Xin nhập số dương")
                End If
            Else
                errLoi.SetError(txtGia, "Chỉ được nhập số")
            End If
        End If
    End Sub

    Private Sub txtMoTa_Validating()
        If txtMoTa.Text = "" Then
            errLoi.SetError(txtMoTa, "Không được để trống")
        Else
            errLoi.SetError(txtMoTa, "")
        End If
    End Sub

    Private Function InputValidating() As Boolean
        Dim flag As Boolean = False

        txtMaDV_Validating()

        If cboLoai.SelectedIndex = 0 Then
            txtTenLoai_Validating()
            txtGiaBT_Validating()
            If cboMaDT.SelectedItem = aDTG3(4) Or cboMaDT.SelectedItem = aDTG3(5) Or cboMaDT.SelectedItem = aDTG3(6) Or cboMaDT.SelectedItem = aDTG3(7) Or cboMaDT.SelectedItem = aDTG3(8) Or cboMaDT.SelectedItem = aDTG3(9) Or cboMaDT.SelectedItem = aDTG3(10) Then
                txtGiaCD_Validating()
                txtGiaTD_Validating()
            End If
            If errLoi.GetError(txtGiaCD) = "" AndAlso errLoi.GetError(txtGiaTD) = "" AndAlso errLoi.GetError(txtTenLoai) = "" AndAlso errLoi.GetError(txtGiaBT) = "" AndAlso errLoi.GetError(txtMaDV) = "" Then
                flag = True
            Else
                flag = False
            End If
        Else
            txtDinhMuc_Validating()
            txtGia_Validating()
            txtMoTa_Validating()
            If errLoi.GetError(txtDinhMuc) = "" AndAlso errLoi.GetError(txtGia) = "" AndAlso errLoi.GetError(txtMoTa) = "" AndAlso errLoi.GetError(txtMaDV) = "" Then
                flag = True
            Else
                flag = False
            End If
        End If

        Return flag
    End Function
#End Region
#End Region

End Class