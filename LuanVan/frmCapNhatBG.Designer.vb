<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhatBG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lsvBG3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvBG6 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLoai = New System.Windows.Forms.ComboBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaDV = New System.Windows.Forms.TextBox()
        Me.cboMaDT = New System.Windows.Forms.ComboBox()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.txtGiaBT = New System.Windows.Forms.TextBox()
        Me.txtGiaCD = New System.Windows.Forms.TextBox()
        Me.txtGiaTD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDinhMuc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.errLoi = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.errLoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lsvBG3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lsvBG6, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 217)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(538, 241)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lsvBG3
        '
        Me.lsvBG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvBG3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvBG3.FullRowSelect = True
        Me.lsvBG3.GridLines = True
        Me.lsvBG3.Location = New System.Drawing.Point(3, 3)
        Me.lsvBG3.Name = "lsvBG3"
        Me.lsvBG3.Size = New System.Drawing.Size(532, 234)
        Me.lsvBG3.TabIndex = 5
        Me.lsvBG3.UseCompatibleStateImageBehavior = False
        Me.lsvBG3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã loại dịch vụ"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã đối tượng"
        Me.ColumnHeader2.Width = 75
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên loại"
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Giá bình thường"
        Me.ColumnHeader4.Width = 88
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Giá cao điểm"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Giá thấp điểm"
        Me.ColumnHeader6.Width = 88
        '
        'lsvBG6
        '
        Me.lsvBG6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvBG6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lsvBG6.FullRowSelect = True
        Me.lsvBG6.GridLines = True
        Me.lsvBG6.Location = New System.Drawing.Point(3, 243)
        Me.lsvBG6.Name = "lsvBG6"
        Me.lsvBG6.Size = New System.Drawing.Size(532, 115)
        Me.lsvBG6.TabIndex = 6
        Me.lsvBG6.UseCompatibleStateImageBehavior = False
        Me.lsvBG6.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Mã loại dịch vụ"
        Me.ColumnHeader7.Width = 89
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Mã đối tượng"
        Me.ColumnHeader8.Width = 78
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Định mức"
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Giá"
        Me.ColumnHeader10.Width = 70
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Mô tả"
        Me.ColumnHeader11.Width = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bảng giá:"
        '
        'cboLoai
        '
        Me.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoai.FormattingEnabled = True
        Me.cboLoai.Location = New System.Drawing.Point(177, 18)
        Me.cboLoai.Name = "cboLoai"
        Me.cboLoai.Size = New System.Drawing.Size(106, 21)
        Me.cboLoai.TabIndex = 1
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(455, 21)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 52)
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã loại dịch vụ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã đối tượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tên loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Giá bình thường"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Giá cao điểm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Giá thấp điểm"
        '
        'txtMaDV
        '
        Me.txtMaDV.Location = New System.Drawing.Point(177, 48)
        Me.txtMaDV.Name = "txtMaDV"
        Me.txtMaDV.Size = New System.Drawing.Size(106, 20)
        Me.txtMaDV.TabIndex = 9
        '
        'cboMaDT
        '
        Me.cboMaDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaDT.FormattingEnabled = True
        Me.cboMaDT.Location = New System.Drawing.Point(177, 74)
        Me.cboMaDT.Name = "cboMaDT"
        Me.cboMaDT.Size = New System.Drawing.Size(106, 21)
        Me.cboMaDT.TabIndex = 10
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(177, 101)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(106, 20)
        Me.txtTenLoai.TabIndex = 11
        '
        'txtGiaBT
        '
        Me.txtGiaBT.Location = New System.Drawing.Point(177, 127)
        Me.txtGiaBT.Name = "txtGiaBT"
        Me.txtGiaBT.Size = New System.Drawing.Size(106, 20)
        Me.txtGiaBT.TabIndex = 12
        '
        'txtGiaCD
        '
        Me.txtGiaCD.Location = New System.Drawing.Point(177, 153)
        Me.txtGiaCD.Name = "txtGiaCD"
        Me.txtGiaCD.Size = New System.Drawing.Size(106, 20)
        Me.txtGiaCD.TabIndex = 13
        '
        'txtGiaTD
        '
        Me.txtGiaTD.Location = New System.Drawing.Point(177, 179)
        Me.txtGiaTD.Name = "txtGiaTD"
        Me.txtGiaTD.Size = New System.Drawing.Size(106, 20)
        Me.txtGiaTD.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Định mức"
        '
        'txtDinhMuc
        '
        Me.txtDinhMuc.Location = New System.Drawing.Point(403, 101)
        Me.txtDinhMuc.Name = "txtDinhMuc"
        Me.txtDinhMuc.Size = New System.Drawing.Size(106, 20)
        Me.txtDinhMuc.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(334, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Giá"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Mô tả"
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(403, 153)
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(106, 20)
        Me.txtMoTa.TabIndex = 19
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(403, 127)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(106, 20)
        Me.txtGia.TabIndex = 20
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(395, 50)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(54, 23)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(335, 21)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(54, 23)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(395, 21)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(54, 23)
        Me.btnXoa.TabIndex = 23
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(335, 50)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(54, 23)
        Me.btnSua.TabIndex = 24
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'errLoi
        '
        Me.errLoi.ContainerControl = Me
        '
        'frmCapNhatBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(568, 466)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.txtMoTa)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDinhMuc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGiaTD)
        Me.Controls.Add(Me.txtGiaCD)
        Me.Controls.Add(Me.txtGiaBT)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.cboMaDT)
        Me.Controls.Add(Me.txtMaDV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cboLoai)
        Me.Controls.Add(Me.btnLuu)
        Me.MaximizeBox = False
        Me.Name = "frmCapNhatBG"
        Me.Text = "frmCapNhatBG"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.errLoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboLoai As System.Windows.Forms.ComboBox
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents lsvBG3 As System.Windows.Forms.ListView
    Friend WithEvents lsvBG6 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaDV As System.Windows.Forms.TextBox
    Friend WithEvents cboMaDT As System.Windows.Forms.ComboBox
    Friend WithEvents txtTenLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaBT As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaCD As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaTD As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDinhMuc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMoTa As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents errLoi As System.Windows.Forms.ErrorProvider
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
End Class
