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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.NạpDữLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSQLServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTTDonVi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCapNhatBG = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKKhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKCongTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKTram = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKHoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThốngKêToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKeLDTT = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTKeDoanhThu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTinhTien = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NạpDữLiệuToolStripMenuItem, Me.tsmiTTDonVi, Me.tsmiCapNhatBG, Me.tsmiTinhTien, Me.TìmKiếmToolStripMenuItem, Me.ThốngKêToolStripMenuItem, Me.tsmiThoat})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(793, 71)
        Me.MenuStrip.TabIndex = 2
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'NạpDữLiệuToolStripMenuItem
        '
        Me.NạpDữLiệuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSQLServer, Me.tsmiExcel})
        Me.NạpDữLiệuToolStripMenuItem.Image = Global.LuanVan.My.Resources.Resources.Load_icon
        Me.NạpDữLiệuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NạpDữLiệuToolStripMenuItem.Name = "NạpDữLiệuToolStripMenuItem"
        Me.NạpDữLiệuToolStripMenuItem.Size = New System.Drawing.Size(80, 67)
        Me.NạpDữLiệuToolStripMenuItem.Text = "Nạp dữ liệu"
        Me.NạpDữLiệuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiSQLServer
        '
        Me.tsmiSQLServer.Name = "tsmiSQLServer"
        Me.tsmiSQLServer.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSQLServer.Text = "SQLServer"
        '
        'tsmiExcel
        '
        Me.tsmiExcel.Name = "tsmiExcel"
        Me.tsmiExcel.Size = New System.Drawing.Size(152, 22)
        Me.tsmiExcel.Text = "Excel"
        '
        'tsmiTTDonVi
        '
        Me.tsmiTTDonVi.Image = Global.LuanVan.My.Resources.Resources.Information_icon
        Me.tsmiTTDonVi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmiTTDonVi.Name = "tsmiTTDonVi"
        Me.tsmiTTDonVi.Size = New System.Drawing.Size(107, 67)
        Me.tsmiTTDonVi.Text = "Thông tin đơn vị"
        Me.tsmiTTDonVi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiCapNhatBG
        '
        Me.tsmiCapNhatBG.Image = Global.LuanVan.My.Resources.Resources.Table_icon
        Me.tsmiCapNhatBG.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmiCapNhatBG.Name = "tsmiCapNhatBG"
        Me.tsmiCapNhatBG.Size = New System.Drawing.Size(116, 67)
        Me.tsmiCapNhatBG.Text = "Cập nhật bảng giá"
        Me.tsmiCapNhatBG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTKKhachHang, Me.tsmiTKCongTo, Me.tsmiTKTram, Me.tsmiTKHoaDon})
        Me.TìmKiếmToolStripMenuItem.Image = Global.LuanVan.My.Resources.Resources.Zoom_icon
        Me.TìmKiếmToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(69, 67)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm kiếm"
        Me.TìmKiếmToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiTKKhachHang
        '
        Me.tsmiTKKhachHang.Name = "tsmiTKKhachHang"
        Me.tsmiTKKhachHang.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKKhachHang.Text = "Khách hàng"
        '
        'tsmiTKCongTo
        '
        Me.tsmiTKCongTo.Name = "tsmiTKCongTo"
        Me.tsmiTKCongTo.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKCongTo.Text = "Công tơ"
        '
        'tsmiTKTram
        '
        Me.tsmiTKTram.Name = "tsmiTKTram"
        Me.tsmiTKTram.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKTram.Text = "Trạm"
        '
        'tsmiTKHoaDon
        '
        Me.tsmiTKHoaDon.Name = "tsmiTKHoaDon"
        Me.tsmiTKHoaDon.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTKHoaDon.Text = "Hóa đơn"
        '
        'ThốngKêToolStripMenuItem
        '
        Me.ThốngKêToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTKeLDTT, Me.tsmiTKeDoanhThu})
        Me.ThốngKêToolStripMenuItem.Image = Global.LuanVan.My.Resources.Resources.Chart_icon
        Me.ThốngKêToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ThốngKêToolStripMenuItem.Name = "ThốngKêToolStripMenuItem"
        Me.ThốngKêToolStripMenuItem.Size = New System.Drawing.Size(69, 67)
        Me.ThốngKêToolStripMenuItem.Text = "Thống kê"
        Me.ThốngKêToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiTKeLDTT
        '
        Me.tsmiTKeLDTT.Name = "tsmiTKeLDTT"
        Me.tsmiTKeLDTT.Size = New System.Drawing.Size(178, 22)
        Me.tsmiTKeLDTT.Text = "Lượng điện tiêu thụ"
        '
        'tsmiTKeDoanhThu
        '
        Me.tsmiTKeDoanhThu.Name = "tsmiTKeDoanhThu"
        Me.tsmiTKeDoanhThu.Size = New System.Drawing.Size(178, 22)
        Me.tsmiTKeDoanhThu.Text = "Doanh thu"
        '
        'tsmiThoat
        '
        Me.tsmiThoat.Image = Global.LuanVan.My.Resources.Resources.Shutdown_icon
        Me.tsmiThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmiThoat.Name = "tsmiThoat"
        Me.tsmiThoat.Size = New System.Drawing.Size(60, 67)
        Me.tsmiThoat.Text = "Thoát"
        Me.tsmiThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmiTinhTien
        '
        Me.tsmiTinhTien.Image = Global.LuanVan.My.Resources.Resources.Cash_icon
        Me.tsmiTinhTien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmiTinhTien.Name = "tsmiTinhTien"
        Me.tsmiTinhTien.Size = New System.Drawing.Size(66, 67)
        Me.tsmiTinhTien.Text = "Tính tiền"
        Me.tsmiTinhTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(793, 437)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý hóa đơn tiền điện"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents NạpDữLiệuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSQLServer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTTDonVi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCapNhatBG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTinhTien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKKhachHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKCongTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKTram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKHoaDon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThốngKêToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKeLDTT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKeDoanhThu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiThoat As System.Windows.Forms.ToolStripMenuItem

End Class
