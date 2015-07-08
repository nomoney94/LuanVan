<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInHoaDon
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.radCapDA = New System.Windows.Forms.RadioButton()
        Me.radKoCapDA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 77)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(942, 427)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(396, 30)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 1
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'radCapDA
        '
        Me.radCapDA.AutoSize = True
        Me.radCapDA.Location = New System.Drawing.Point(128, 33)
        Me.radCapDA.Name = "radCapDA"
        Me.radCapDA.Size = New System.Drawing.Size(98, 17)
        Me.radCapDA.TabIndex = 2
        Me.radCapDA.TabStop = True
        Me.radCapDA.Text = "Có cấp điện áp"
        Me.radCapDA.UseVisualStyleBackColor = True
        '
        'radKoCapDA
        '
        Me.radKoCapDA.AutoSize = True
        Me.radKoCapDA.Location = New System.Drawing.Point(247, 33)
        Me.radKoCapDA.Name = "radKoCapDA"
        Me.radKoCapDA.Size = New System.Drawing.Size(116, 17)
        Me.radKoCapDA.TabIndex = 3
        Me.radKoCapDA.TabStop = True
        Me.radKoCapDA.Text = "Không cấp điện áp"
        Me.radKoCapDA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "In hóa đơn"
        '
        'frmInHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 504)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radKoCapDA)
        Me.Controls.Add(Me.radCapDA)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmInHoaDon"
        Me.Text = "frmInHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents radCapDA As System.Windows.Forms.RadioButton
    Friend WithEvents radKoCapDA As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
