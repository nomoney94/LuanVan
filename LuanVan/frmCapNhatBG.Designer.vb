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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLoai = New System.Windows.Forms.ComboBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.dgvBG3 = New System.Windows.Forms.DataGridView()
        Me.dgvBG6 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvBG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBG6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvBG3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvBG6, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(538, 430)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cboLoai, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnLuu, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(532, 32)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bảng giá:"
        '
        'cboLoai
        '
        Me.cboLoai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboLoai.FormattingEnabled = True
        Me.cboLoai.Location = New System.Drawing.Point(61, 5)
        Me.cboLoai.Name = "cboLoai"
        Me.cboLoai.Size = New System.Drawing.Size(121, 21)
        Me.cboLoai.TabIndex = 1
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLuu.Location = New System.Drawing.Point(188, 4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 23)
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'dgvBG3
        '
        Me.dgvBG3.AllowUserToOrderColumns = True
        Me.dgvBG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBG3.Location = New System.Drawing.Point(3, 41)
        Me.dgvBG3.Name = "dgvBG3"
        Me.dgvBG3.RowHeadersVisible = False
        Me.dgvBG3.Size = New System.Drawing.Size(532, 353)
        Me.dgvBG3.TabIndex = 3
        '
        'dgvBG6
        '
        Me.dgvBG6.AllowUserToOrderColumns = True
        Me.dgvBG6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBG6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBG6.Location = New System.Drawing.Point(3, 400)
        Me.dgvBG6.Name = "dgvBG6"
        Me.dgvBG6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBG6.Size = New System.Drawing.Size(532, 85)
        Me.dgvBG6.TabIndex = 4
        '
        'frmCapNhatBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(562, 454)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmCapNhatBG"
        Me.Text = "frmCapNhatBG"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dgvBG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBG6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboLoai As System.Windows.Forms.ComboBox
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents dgvBG3 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBG6 As System.Windows.Forms.DataGridView
End Class
