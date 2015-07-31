<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTKHoaDon
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTimKiem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpKy = New System.Windows.Forms.DateTimePicker()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnNhacnho = New System.Windows.Forms.Button()
        Me.btnDathanhtoan = New System.Windows.Forms.Button()
        Me.btnXemHD = New System.Windows.Forms.Button()
        Me.btnXemGB = New System.Windows.Forms.Button()
        Me.lvwHoadon = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblTieuDe, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lvwHoadon, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 403)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblTieuDe
        '
        Me.lblTieuDe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.Location = New System.Drawing.Point(353, 0)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(0, 20)
        Me.lblTieuDe.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaHD, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cboTimKiem, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaKH, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpKy, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTim, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNhacnho, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDathanhtoan, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnXemHD, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnXemGB, 6, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(701, 107)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtMaHD
        '
        Me.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMaHD.Location = New System.Drawing.Point(105, 84)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(154, 20)
        Me.txtMaHD.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mã hóa đơn:"
        '
        'cboTimKiem
        '
        Me.cboTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimKiem.FormattingEnabled = True
        Me.cboTimKiem.Location = New System.Drawing.Point(105, 4)
        Me.cboTimKiem.Name = "cboTimKiem"
        Me.cboTimKiem.Size = New System.Drawing.Size(154, 21)
        Me.cboTimKiem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tìm kiếm theo:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã khách hàng:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMaKH.Location = New System.Drawing.Point(105, 58)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(154, 20)
        Me.txtMaKH.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kỳ"
        '
        'dtpKy
        '
        Me.dtpKy.CustomFormat = "MM/yyyy"
        Me.dtpKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKy.Location = New System.Drawing.Point(105, 32)
        Me.dtpKy.Name = "dtpKy"
        Me.dtpKy.Size = New System.Drawing.Size(154, 20)
        Me.dtpKy.TabIndex = 0
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(265, 3)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(62, 23)
        Me.btnTim.TabIndex = 6
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnNhacnho
        '
        Me.btnNhacnho.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnNhacnho.Location = New System.Drawing.Point(333, 3)
        Me.btnNhacnho.Name = "btnNhacnho"
        Me.btnNhacnho.Size = New System.Drawing.Size(94, 23)
        Me.btnNhacnho.TabIndex = 10
        Me.btnNhacnho.Text = "Chưa thanh toán"
        Me.btnNhacnho.UseVisualStyleBackColor = True
        '
        'btnDathanhtoan
        '
        Me.btnDathanhtoan.Location = New System.Drawing.Point(433, 3)
        Me.btnDathanhtoan.Name = "btnDathanhtoan"
        Me.btnDathanhtoan.Size = New System.Drawing.Size(83, 23)
        Me.btnDathanhtoan.TabIndex = 12
        Me.btnDathanhtoan.Text = "Đã thanh toán"
        Me.btnDathanhtoan.UseVisualStyleBackColor = True
        '
        'btnXemHD
        '
        Me.btnXemHD.Location = New System.Drawing.Point(522, 3)
        Me.btnXemHD.Name = "btnXemHD"
        Me.btnXemHD.Size = New System.Drawing.Size(84, 23)
        Me.btnXemHD.TabIndex = 13
        Me.btnXemHD.Text = "Xem hóa đơn"
        Me.btnXemHD.UseVisualStyleBackColor = True
        '
        'btnXemGB
        '
        Me.btnXemGB.Location = New System.Drawing.Point(612, 3)
        Me.btnXemGB.Name = "btnXemGB"
        Me.btnXemGB.Size = New System.Drawing.Size(86, 23)
        Me.btnXemGB.TabIndex = 14
        Me.btnXemGB.Text = "Xem giấy báo"
        Me.btnXemGB.UseVisualStyleBackColor = True
        '
        'lvwHoadon
        '
        Me.lvwHoadon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwHoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwHoadon.FullRowSelect = True
        Me.lvwHoadon.GridLines = True
        Me.lvwHoadon.Location = New System.Drawing.Point(3, 136)
        Me.lvwHoadon.Name = "lvwHoadon"
        Me.lvwHoadon.Size = New System.Drawing.Size(701, 264)
        Me.lvwHoadon.TabIndex = 1
        Me.lvwHoadon.UseCompatibleStateImageBehavior = False
        Me.lvwHoadon.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã HD"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên khách hàng"
        Me.ColumnHeader2.Width = 117
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Địa chỉ"
        Me.ColumnHeader3.Width = 132
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mã KH"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Kỳ"
        Me.ColumnHeader5.Width = 63
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ĐNTT"
        Me.ColumnHeader6.Width = 58
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Thành tiền"
        Me.ColumnHeader7.Width = 74
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Tình trạng TT"
        Me.ColumnHeader8.Width = 84
        '
        'frmTKHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(714, 425)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "frmTKHoaDon"
        Me.Text = "Tìm kiếm hóa đơn"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpKy As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvwHoadon As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNhacnho As System.Windows.Forms.Button
    Friend WithEvents lblTieuDe As System.Windows.Forms.Label
    Friend WithEvents btnDathanhtoan As System.Windows.Forms.Button
    Friend WithEvents btnXemHD As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnXemGB As System.Windows.Forms.Button
End Class
