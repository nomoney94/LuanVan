Imports System.Data.SqlClient

Public Class frmCapNhatBG
    Private aLoai() As String = {"SX-KD-HC", "SH-NT-CDC-TM"}
    Private dtBG3 As DataTable
    Private dtBG6 As DataTable
    Private dtBG As DataTable

    Private Sub frmCapNhatBG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()
        cboLoai.SelectedIndex = 0
        dtBG3 = frmMain.ds.Tables("Gia3")
        dtBG6 = frmMain.ds.Tables("Gia6")
        dgvBG3.DataSource = dtBG3
        dgvBG6.DataSource = dtBG6
        EditColumnHeaderTextBG3()
    End Sub

    Private Sub LoadComboBox()
        For Each s As String In aLoai
            cboLoai.Items.Add(s)
        Next
    End Sub

    Private Sub EditColumnHeaderTextBG3()
        dgvBG3.Columns(0).HeaderText = "Mã loại" & vbCrLf & "dịch vụ"
    End Sub

    Private Sub EditColumnHeaderTextBG6()

    End Sub

    Private Sub LoadComboBoxDataGridView()

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        dtBG3 = dgvBG3.DataSource
        dtBG6 = dgvBG6.DataSource
        Try
            Dim comG3 As New SqlCommandBuilder(frmMain.daGia3)
            Dim comG6 As New SqlCommandBuilder(frmMain.daGia6)
            frmMain.con.Open()
            comG3.DataAdapter.Update(dtBG3)
            comG6.DataAdapter.Update(dtBG6)
            frmMain.con.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể cập nhật CSDL!", "Thông báo")
        End Try

    End Sub

    Private Sub cboLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoai.SelectedIndexChanged
        If cboLoai.SelectedIndex = 0 Then
            dgvBG3.Visible = True
            dgvBG6.Visible = False
        Else
            dgvBG3.Visible = False
            dgvBG6.Visible = True
        End If
    End Sub

    'The CellValidating event handler is where you determine whether the value of a cell in the
    'CompanyName column is empty. If the cell value fails validation, set the Cancel property 
    'of the System.Windows.Forms.DataGridViewCellValidatingEventArgs class to true. This causes
    'the DataGridView control to prevent the cursor from leaving the cell. Set the ErrorText
    'property on the row to an explanatory string. This displays an error icon with a 'ToolTip'
    'that contains the error text. In the CellEndEdit event handler, set the 'ErrorText'
    'property on the row to the empty string. The CellEndEdit event occurs only when the cell
    'exits edit mode, which it cannot do if it fails validation.

    'https://msdn.microsoft.com/en-us/library/ykdxa0bc%28v=vs.90%29.aspx

    Private Sub dgvBG6_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvBG6.CellValidating
        Dim headerText As String = dgvBG6.Columns(e.ColumnIndex).HeaderText
        If Not headerText.Equals("MaLoaiDV") Then Return
        If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
            dgvBG6.Rows(e.RowIndex).ErrorText = "MaLoaiDV không được để trống"
            e.Cancel = True
        End If
    End Sub

    Private Sub dgvBG6_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBG6.CellEndEdit
        dgvBG6.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    'Private Sub dgvBG6_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBG6.CellLeave
    '    If e.ColumnIndex = 1 Then
    '        Dim value As Object = dgvBG6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '        Dim TextBoxCell As New DataGridViewTextBoxCell
    '        Me.BeginInvoke(New MethodInvoker(Sub()
    '                                             dgvBG6.Item(e.ColumnIndex, e.RowIndex) = TextBoxCell
    '                                             dgvBG6.Item(e.ColumnIndex, e.RowIndex).Value = value
    '                                         End Sub
    '        ))
    '    End If
    'End Sub

    'Private Sub dgvBG6_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBG6.CellEnter
    '    If e.ColumnIndex = 1 Then
    '        Dim value As Object = dgvBG6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '        Dim ComboBoxCell As New DataGridViewComboBoxCell
    '        ComboBoxCell.Items.AddRange(value)
    '        Me.BeginInvoke(New MethodInvoker(Sub()
    '                                             dgvBG6.Item(e.ColumnIndex, e.RowIndex) = ComboBoxCell
    '                                             dgvBG6.Item(e.ColumnIndex, e.RowIndex).Value = ComboBoxCell.Items(0)
    '                                         End Sub
    '        ))
    '    End If
    'End Sub

    Private Sub dgvBG6_Enter(sender As Object, e As EventArgs) Handles dgvBG6.Enter
        For Each row As DataGridViewRow In dgvBG6.Rows
            If row.Index <> dgvBG6.Rows.Count - 1 Then
                Dim value As Object = row.Cells(1).Value
                Dim ComboBoxCell As New DataGridViewComboBoxCell
                ComboBoxCell.Items.AddRange(value)
                dgvBG6.Item(1, row.Index) = ComboBoxCell
                dgvBG6.Item(1, row.Index).Value = ComboBoxCell.Items(0)
            Else
                Exit For
            End If
        Next
    End Sub

    Private Sub dgvBG6_Leave(sender As Object, e As EventArgs) Handles dgvBG6.Leave
        For Each row As DataGridViewRow In dgvBG6.Rows
            If row.Index <> dgvBG6.Rows.Count - 1 Then
                Dim value As Object = row.Cells(1).Value
                Dim TextBoxCell As New DataGridViewTextBoxCell
                dgvBG6.Item(1, row.Index) = TextBoxCell
                dgvBG6.Item(1, row.Index).Value = TextBoxCell.Value
            Else
                Exit For
            End If
        Next
    End Sub
End Class