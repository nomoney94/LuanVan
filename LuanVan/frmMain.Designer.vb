<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbTTDonVi = New System.Windows.Forms.ToolStripButton()
        Me.tsbTimKiem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiTKKhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKCongTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKTram = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKHoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbThongKe = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiTKeLDTT = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKeDoanhThu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbCapNhatBangGia = New System.Windows.Forms.ToolStripButton()
        Me.tsbTinhTien = New System.Windows.Forms.ToolStripButton()
        Me.tsbNapDuLieu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiSQLServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbThoat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNapDuLieu, Me.tsbTTDonVi, Me.tsbCapNhatBangGia, Me.tsbTinhTien, Me.tsbTimKiem, Me.tsbThongKe, Me.tsbThoat})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(793, 81)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tsbTTDonVi
        '
        Me.tsbTTDonVi.AutoToolTip = False
        Me.tsbTTDonVi.Image = Global.LuanVan.My.Resources.Resources.Information_icon
        Me.tsbTTDonVi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbTTDonVi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTTDonVi.Name = "tsbTTDonVi"
        Me.tsbTTDonVi.Size = New System.Drawing.Size(99, 67)
        Me.tsbTTDonVi.Text = "Thông tin đơn vị"
        Me.tsbTTDonVi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbTimKiem
        '
        Me.tsbTimKiem.AutoToolTip = False
        Me.tsbTimKiem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTKKhachHang, Me.tsmiTKCongTo, Me.tsmiTKTram, Me.tsmiTKHoaDon})
        Me.tsbTimKiem.Image = Global.LuanVan.My.Resources.Resources.Zoom_icon
        Me.tsbTimKiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTimKiem.Name = "tsbTimKiem"
        Me.tsbTimKiem.Size = New System.Drawing.Size(70, 67)
        Me.tsbTimKiem.Text = "Tìm kiếm"
        Me.tsbTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiTKKhachHang
        '
        Me.tsmiTKKhachHang.Name = "tsmiTKKhachHang"
        Me.tsmiTKKhachHang.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKKhachHang.Text = "&Khách hàng"
        '
        'tsmiTKCongTo
        '
        Me.tsmiTKCongTo.Name = "tsmiTKCongTo"
        Me.tsmiTKCongTo.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKCongTo.Text = "&Công tơ"
        '
        'tsmiTKTram
        '
        Me.tsmiTKTram.Name = "tsmiTKTram"
        Me.tsmiTKTram.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKTram.Text = "&Trạm"
        '
        'tsmiTKHoaDon
        '
        Me.tsmiTKHoaDon.Name = "tsmiTKHoaDon"
        Me.tsmiTKHoaDon.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKHoaDon.Text = "&Hóa đơn"
        '
        'tsbThongKe
        '
        Me.tsbThongKe.AutoToolTip = False
        Me.tsbThongKe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTKeLDTT, Me.tsmiTKeDoanhThu})
        Me.tsbThongKe.Image = Global.LuanVan.My.Resources.Resources.Chart_icon
        Me.tsbThongKe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbThongKe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbThongKe.Name = "tsbThongKe"
        Me.tsbThongKe.Size = New System.Drawing.Size(70, 67)
        Me.tsbThongKe.Text = "Thống kê"
        Me.tsbThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiTKeLDTT
        '
        Me.tsmiTKeLDTT.Name = "tsmiTKeLDTT"
        Me.tsmiTKeLDTT.Size = New System.Drawing.Size(178, 22)
        Me.tsmiTKeLDTT.Text = "&Lượng điện tiêu thụ"
        '
        'tsmiTKeDoanhThu
        '
        Me.tsmiTKeDoanhThu.Name = "tsmiTKeDoanhThu"
        Me.tsmiTKeDoanhThu.Size = New System.Drawing.Size(178, 22)
        Me.tsmiTKeDoanhThu.Text = "&Doanh thu"
        '
        'tsbCapNhatBangGia
        '
        Me.tsbCapNhatBangGia.AutoToolTip = False
        Me.tsbCapNhatBangGia.Image = Global.LuanVan.My.Resources.Resources.Table_icon
        Me.tsbCapNhatBangGia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCapNhatBangGia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCapNhatBangGia.Name = "tsbCapNhatBangGia"
        Me.tsbCapNhatBangGia.Size = New System.Drawing.Size(108, 67)
        Me.tsbCapNhatBangGia.Text = "Cập nhật bảng giá"
        Me.tsbCapNhatBangGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbCapNhatBangGia.ToolTipText = "Cập nhật bảng giá"
        '
        'tsbTinhTien
        '
        Me.tsbTinhTien.AutoToolTip = False
        Me.tsbTinhTien.Image = Global.LuanVan.My.Resources.Resources.Cash_icon
        Me.tsbTinhTien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbTinhTien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTinhTien.Name = "tsbTinhTien"
        Me.tsbTinhTien.Size = New System.Drawing.Size(58, 67)
        Me.tsbTinhTien.Text = "Tính tiền"
        Me.tsbTinhTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbNapDuLieu
        '
        Me.tsbNapDuLieu.AutoToolTip = False
        Me.tsbNapDuLieu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSQLServer, Me.tsmiExcel})
        Me.tsbNapDuLieu.Image = Global.LuanVan.My.Resources.Resources.Load_icon
        Me.tsbNapDuLieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNapDuLieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNapDuLieu.Name = "tsbNapDuLieu"
        Me.tsbNapDuLieu.Size = New System.Drawing.Size(81, 67)
        Me.tsbNapDuLieu.Text = "Nạp dữ liệu"
        Me.tsbNapDuLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiSQLServer
        '
        Me.tsmiSQLServer.Name = "tsmiSQLServer"
        Me.tsmiSQLServer.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSQLServer.Text = "&SQL Server"
        '
        'tsmiExcel
        '
        Me.tsmiExcel.Name = "tsmiExcel"
        Me.tsmiExcel.Size = New System.Drawing.Size(152, 22)
        Me.tsmiExcel.Text = "&Excel"
        '
        'tsbThoat
        '
        Me.tsbThoat.AutoToolTip = False
        Me.tsbThoat.Image = Global.LuanVan.My.Resources.Resources.Shutdown_icon
        Me.tsbThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbThoat.Name = "tsbThoat"
        Me.tsbThoat.Size = New System.Drawing.Size(52, 67)
        Me.tsbThoat.Text = "Thoát"
        Me.tsbThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(793, 437)
        Me.Controls.Add(Me.ToolStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý hóa đơn tiền điện"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbTTDonVi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbTimKiem As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiTKKhachHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKCongTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKTram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKHoaDon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbThongKe As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiTKeLDTT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKeDoanhThu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbNapDuLieu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiSQLServer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbTinhTien As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCapNhatBangGia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbThoat As System.Windows.Forms.ToolStripButton

End Class
