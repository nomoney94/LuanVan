<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTinhTien
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpThang = New System.Windows.Forms.DateTimePicker()
        Me.txtMaCT = New System.Windows.Forms.TextBox()
        Me.txtChiso = New System.Windows.Forms.TextBox()
        Me.txtChisoCD = New System.Windows.Forms.TextBox()
        Me.txtChisoTD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTinhTien = New System.Windows.Forms.Button()
        Me.lvwKH = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lvwKH, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.11628!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.88372!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(489, 161)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpThang, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaCT, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChiso, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChisoCD, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChisoTD, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTinhTien, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(483, 58)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã công tơ"
        '
        'dtpThang
        '
        Me.dtpThang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpThang.CustomFormat = "MM/yyyy"
        Me.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThang.Location = New System.Drawing.Point(72, 4)
        Me.dtpThang.Name = "dtpThang"
        Me.dtpThang.Size = New System.Drawing.Size(100, 20)
        Me.dtpThang.TabIndex = 3
        '
        'txtMaCT
        '
        Me.txtMaCT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMaCT.Location = New System.Drawing.Point(72, 33)
        Me.txtMaCT.Name = "txtMaCT"
        Me.txtMaCT.Size = New System.Drawing.Size(100, 20)
        Me.txtMaCT.TabIndex = 8
        '
        'txtChiso
        '
        Me.txtChiso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtChiso.Location = New System.Drawing.Point(257, 33)
        Me.txtChiso.Name = "txtChiso"
        Me.txtChiso.Size = New System.Drawing.Size(70, 20)
        Me.txtChiso.TabIndex = 9
        '
        'txtChisoCD
        '
        Me.txtChisoCD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtChisoCD.Location = New System.Drawing.Point(333, 33)
        Me.txtChisoCD.Name = "txtChisoCD"
        Me.txtChisoCD.Size = New System.Drawing.Size(70, 20)
        Me.txtChisoCD.TabIndex = 10
        '
        'txtChisoTD
        '
        Me.txtChisoTD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtChisoTD.Location = New System.Drawing.Point(409, 33)
        Me.txtChisoTD.Name = "txtChisoTD"
        Me.txtChisoTD.Size = New System.Drawing.Size(70, 20)
        Me.txtChisoTD.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cao điểm"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(409, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Thấp điểm"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chỉ số"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Bình thường"
        '
        'btnTinhTien
        '
        Me.btnTinhTien.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTinhTien.Location = New System.Drawing.Point(186, 3)
        Me.btnTinhTien.Name = "btnTinhTien"
        Me.btnTinhTien.Size = New System.Drawing.Size(65, 23)
        Me.btnTinhTien.TabIndex = 6
        Me.btnTinhTien.Text = "Tính tiền"
        Me.btnTinhTien.UseVisualStyleBackColor = True
        '
        'lvwKH
        '
        Me.lvwKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwKH.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwKH.FullRowSelect = True
        Me.lvwKH.GridLines = True
        Me.lvwKH.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvwKH.Location = New System.Drawing.Point(3, 67)
        Me.lvwKH.Name = "lvwKH"
        Me.lvwKH.Size = New System.Drawing.Size(483, 91)
        Me.lvwKH.TabIndex = 1
        Me.lvwKH.UseCompatibleStateImageBehavior = False
        Me.lvwKH.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã CT"
        Me.ColumnHeader1.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên khách hàng"
        Me.ColumnHeader2.Width = 215
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Số điện thoại"
        Me.ColumnHeader3.Width = 113
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mã ĐT"
        Me.ColumnHeader4.Width = 81
        '
        'frmTinhTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(512, 183)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "frmTinhTien"
        Me.Text = "Tính tiền"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpThang As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTinhTien As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaCT As System.Windows.Forms.TextBox
    Friend WithEvents txtChiso As System.Windows.Forms.TextBox
    Friend WithEvents txtChisoCD As System.Windows.Forms.TextBox
    Friend WithEvents txtChisoTD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvwKH As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
