Imports System.Data.SqlClient

Public Class frmMain

#Region "Declares"
    Private frmTKCT As frmTKCongTo
    Private frmTKHD As frmTKHoaDon
    Private frmTKKH As frmTKKhachHang
    Private frmTKDT As frmTKeDT
    Private frmTKDNTT As frmTKeDNTT
    Private frmTTDV As frmTTDonVi
    Private frmTTD As frmTinhTien
    Private frmCNBG As frmCapNhatBG
    Private frmInHD As frmInHoaDon

    Public daChiSoCongTo As SqlDataAdapter
    Public daCongTo As SqlDataAdapter
    Public daDoiTuongKH As SqlDataAdapter
    Public daDonVi As SqlDataAdapter
    Public daGia6 As SqlDataAdapter
    Public daGia3 As SqlDataAdapter
    Public daHoaDon As SqlDataAdapter
    Public daKhachHang As SqlDataAdapter
    Public daTram As SqlDataAdapter
    Public daChiTietThanhTien As SqlDataAdapter

    Public ds As DataSet
    Public con As SqlConnection
#End Region

#Region "Events"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectSQLServer_InitializeDataSet()
    End Sub

    Private Sub tsmiTTDonVi_Click(sender As Object, e As EventArgs) Handles tsmiTTDonVi.Click
        If frmTTDV Is Nothing OrElse frmTTDV.IsDisposed Then
            frmTTDV = New frmTTDonVi
            frmTTDV.MdiParent = Me
            frmTTDV.Show()
        Else
            frmTTDV.Focus()
        End If
    End Sub

    Private Sub tsmiTKKhachHang_Click(sender As Object, e As EventArgs) Handles tsmiTKKhachHang.Click
        If frmTKKH Is Nothing OrElse frmTKKH.IsDisposed Then
            frmTKKH = New frmTKKhachHang
            frmTKKH.MdiParent = Me
            frmTKKH.Show()
        Else
            frmTKKH.Focus()
        End If
    End Sub

    Private Sub tsmiTKCongTo_Click(sender As Object, e As EventArgs) Handles tsmiTKCongTo.Click
        If frmTKCT Is Nothing OrElse frmTKCT.IsDisposed Then
            frmTKCT = New frmTKCongTo
            frmTKCT.MdiParent = Me
            frmTKCT.Show()
        Else
            frmTKCT.Focus()
        End If
    End Sub

    Private Sub tsmiTKHoaDon_Click(sender As Object, e As EventArgs) Handles tsmiTKHoaDon.Click
        If frmTKHD Is Nothing OrElse frmTKHD.IsDisposed Then
            frmTKHD = New frmTKHoaDon
            frmTKHD.MdiParent = Me
            frmTKHD.Show()
        Else
            frmTKHD.Focus()
        End If
    End Sub

    Private Sub tsmiTKeDNTT_Click(sender As Object, e As EventArgs) Handles tsmiTKeDNTT.Click
        If frmTKDNTT Is Nothing OrElse frmTKDNTT.IsDisposed Then
            frmTKDNTT = New frmTKeDNTT
            frmTKDNTT.MdiParent = Me
            frmTKDNTT.Show()
        Else
            frmTKDNTT.Focus()
        End If
    End Sub

    Private Sub tsmiTKeDoanhThu_Click(sender As Object, e As EventArgs) Handles tsmiTKeDoanhThu.Click
        If frmTKDT Is Nothing OrElse frmTKDT.IsDisposed Then
            frmTKDT = New frmTKeDT
            frmTKDT.MdiParent = Me
            frmTKDT.Show()
        Else
            frmTKDT.Focus()
        End If
    End Sub

    Private Sub tsmiTinhTien_Click(sender As Object, e As EventArgs) Handles tsmiTinhTien.Click
        If frmTTD Is Nothing OrElse frmTTD.IsDisposed Then
            frmTTD = New frmTinhTien
            frmTTD.MdiParent = Me
            frmTTD.Show()
        Else
            frmTTD.Focus()
        End If
    End Sub

    Private Sub tsmiCapNhatBG_Click(sender As Object, e As EventArgs) Handles tsmiCapNhatBG.Click
        If frmCNBG Is Nothing OrElse frmCNBG.IsDisposed Then
            frmCNBG = New frmCapNhatBG
            frmCNBG.MdiParent = Me
            frmCNBG.Show()
        Else
            frmCNBG.Focus()
        End If
    End Sub

    Private Sub tsmiThoat_Click(sender As Object, e As EventArgs) Handles tsmiThoat.Click
        Close()
    End Sub
#End Region

#Region "Functions/Subs"
    Private Sub ConnectSQLServer_InitializeDataSet()
        Try
            Dim strCon As String
            'strCon = "Data Source=3P1MT9VVKDZGJZR\SQLEXPRESS;Initial Catalog=QLHDTD;Integrated Security=True"
            strCon = "Data Source=(local)\SQLEXPRESS;Initial Catalog=QLHDTD;Integrated Security=True"
            con = New SqlConnection(strCon)
            con.Open()
            con.Close()
            ds = New DataSet("QLHDTD")
            InitializeDataAdapter_FillItIntoDataSet()
        Catch ex As Exception
            MenuStrip.Enabled = False
            MsgBox("Không thể kết nối đến SQL Server!")
        End Try
    End Sub

    Private Sub InitializeDataAdapter_FillItIntoDataSet()
        Dim com As SqlCommand

        com = New SqlCommand("Select * From ChiSoCongTo", con)
        daChiSoCongTo = New SqlDataAdapter(com)
        daChiSoCongTo.Fill(ds, "ChiSoCongTo")

        com = New SqlCommand("Select * From CongTo", con)
        daCongTo = New SqlDataAdapter(com)
        daCongTo.Fill(ds, "CongTo")

        com = New SqlCommand("Select * From DoiTuongKH", con)
        daDoiTuongKH = New SqlDataAdapter(com)
        daDoiTuongKH.Fill(ds, "DoiTuongKH")

        com = New SqlCommand("Select * From DonVi", con)
        daDonVi = New SqlDataAdapter(com)
        daDonVi.Fill(ds, "DonVi")

        com = New SqlCommand("Select * From Gia_SH_NT_CDC_TM", con)
        daGia6 = New SqlDataAdapter(com)
        daGia6.Fill(ds, "Gia6")

        com = New SqlCommand("Select * From Gia_SX_KD_HC", con)
        daGia3 = New SqlDataAdapter(com)
        daGia3.Fill(ds, "Gia3")

        com = New SqlCommand("Select * From HoaDon", con)
        daHoaDon = New SqlDataAdapter(com)
        daHoaDon.Fill(ds, "HoaDon")

        com = New SqlCommand("Select * From KhachHang", con)
        daKhachHang = New SqlDataAdapter(com)
        daKhachHang.Fill(ds, "KhachHang")

        com = New SqlCommand("Select * From Tram", con)
        daTram = New SqlDataAdapter(com)
        daTram.Fill(ds, "Tram")

        com = New SqlCommand("Select * From ChiTietThanhTien", con)
        daChiTietThanhTien = New SqlDataAdapter(com)
        daChiTietThanhTien.Fill(ds, "ChiTietThanhTien")

        'InitializeDataRelation()
    End Sub

    Private Sub InitializeDataRelation()
        Dim re As DataRelation

        re = New DataRelation("Tram_CongTo", ds.Tables("Tram").Columns("MaTram"), ds.Tables("CongTo").Columns("MaTram"))
        ds.Tables("Tram").ChildRelations.Add(re)

        re = New DataRelation("CongTo_ChiSoCongTo", ds.Tables("CongTo").Columns("MaCT"), ds.Tables("ChiSoCongTo").Columns("MaCT"))
        ds.Tables("CongTo").ChildRelations.Add(re)

        re = New DataRelation("CongTo_KhachHang", ds.Tables("CongTo").Columns("MaCT"), ds.Tables("KhachHang").Columns("MaCT"))
        ds.Tables("CongTo").ChildRelations.Add(re)

        re = New DataRelation("DoiTuongKH_KhachHang", ds.Tables("DoiTuongKH").Columns("MaDT"), ds.Tables("KhachHang").Columns("MaDT"))
        ds.Tables("DoiTuongKH").ChildRelations.Add(re)

        re = New DataRelation("DoiTuongKH_Gia_SH_NT_CDC_TM", ds.Tables("DoiTuongKH").Columns("MaDT"), ds.Tables("Gia6").Columns("MaDT"))
        ds.Tables("DoiTuongKH").ChildRelations.Add(re)

        re = New DataRelation("DoiTuongKH_Gia_SX_KD_HC", ds.Tables("DoiTuongKH").Columns("MaDT"), ds.Tables("Gia3").Columns("MaDT"))
        ds.Tables("DoiTuongKH").ChildRelations.Add(re)

        re = New DataRelation("KhachHang_HoaDon", ds.Tables("KhachHang").Columns("MaKH"), ds.Tables("HoaDon").Columns("MaKH"))
        ds.Tables("KhachHang").ChildRelations.Add(re)

        re = New DataRelation("HoaDon_ChiTietThanhTien", ds.Tables("HoaDon").Columns("MaHD"), ds.Tables("ChiTietThanhTien").Columns("MaHD"))
        ds.Tables("HoaDon").ChildRelations.Add(re)
    End Sub
#End Region

End Class