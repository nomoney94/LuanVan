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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpThang = New System.Windows.Forms.DateTimePicker()
        Me.btnTinhTien = New System.Windows.Forms.Button()
        Me.txtMaCT = New System.Windows.Forms.TextBox()
        Me.txtChiso = New System.Windows.Forms.TextBox()
        Me.txtChisoCD = New System.Windows.Forms.TextBox()
        Me.txtChisoTD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lvwHoadon = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lvwHoadon, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.61111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.38889!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(504, 360)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpThang, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTinhTien, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaCT, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChiso, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChisoCD, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChisoTD, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(498, 60)
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
        Me.Label2.Location = New System.Drawing.Point(3, 38)
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
        Me.dtpThang.Location = New System.Drawing.Point(78, 4)
        Me.dtpThang.Name = "dtpThang"
        Me.dtpThang.Size = New System.Drawing.Size(100, 20)
        Me.dtpThang.TabIndex = 3
        '
        'btnTinhTien
        '
        Me.btnTinhTien.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTinhTien.Location = New System.Drawing.Point(203, 3)
        Me.btnTinhTien.Name = "btnTinhTien"
        Me.btnTinhTien.Size = New System.Drawing.Size(61, 23)
        Me.btnTinhTien.TabIndex = 6
        Me.btnTinhTien.Text = "Tính tiền"
        Me.btnTinhTien.UseVisualStyleBackColor = True
        '
        'txtMaCT
        '
        Me.txtMaCT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMaCT.Location = New System.Drawing.Point(78, 34)
        Me.txtMaCT.Name = "txtMaCT"
        Me.txtMaCT.Size = New System.Drawing.Size(100, 20)
        Me.txtMaCT.TabIndex = 8
        '
        'txtChiso
        '
        Me.txtChiso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtChiso.Location = New System.Drawing.Point(278, 34)
        Me.txtChiso.Name = "txtChiso"
        Me.txtChiso.Size = New System.Drawing.Size(68, 20)
        Me.txtChiso.TabIndex = 9
        '
        'txtChisoCD
        '
        Me.txtChisoCD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtChisoCD.Location = New System.Drawing.Point(352, 34)
        Me.txtChisoCD.Name = "txtChisoCD"
        Me.txtChisoCD.Size = New System.Drawing.Size(68, 20)
        Me.txtChisoCD.TabIndex = 10
        '
        'txtChisoTD
        '
        Me.txtChisoTD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtChisoTD.Location = New System.Drawing.Point(426, 34)
        Me.txtChisoTD.Name = "txtChisoTD"
        Me.txtChisoTD.Size = New System.Drawing.Size(72, 20)
        Me.txtChisoTD.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cao điểm"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Thấp điểm"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chỉ số"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Bình thường"
        '
        'lvwHoadon
        '
        Me.lvwHoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwHoadon.FullRowSelect = True
        Me.lvwHoadon.GridLines = True
        Me.lvwHoadon.Location = New System.Drawing.Point(3, 69)
        Me.lvwHoadon.Name = "lvwHoadon"
        Me.lvwHoadon.Size = New System.Drawing.Size(498, 286)
        Me.lvwHoadon.TabIndex = 1
        Me.lvwHoadon.UseCompatibleStateImageBehavior = False
        Me.lvwHoadon.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Danh mục"
        Me.ColumnHeader1.Width = 164
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Thông tin"
        Me.ColumnHeader2.Width = 231
        '
        'frmTinhTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(528, 384)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmTinhTien"
        Me.Text = "frmTinhTien"
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
    Friend WithEvents lvwHoadon As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtChisoCD As System.Windows.Forms.TextBox
    Friend WithEvents txtChisoTD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
