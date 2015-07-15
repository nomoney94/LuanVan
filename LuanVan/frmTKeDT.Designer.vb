<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTKeDT
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
        Me.lblDash = New System.Windows.Forms.Label()
        Me.dtpNamKT = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNamBD = New System.Windows.Forms.DateTimePicker()
        Me.cboThongKe = New System.Windows.Forms.ComboBox()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.crvTKe = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(235, 46)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(10, 13)
        Me.lblDash.TabIndex = 13
        Me.lblDash.Text = "-"
        '
        'dtpNamKT
        '
        Me.dtpNamKT.CustomFormat = "yyyy"
        Me.dtpNamKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNamKT.Location = New System.Drawing.Point(251, 40)
        Me.dtpNamKT.Name = "dtpNamKT"
        Me.dtpNamKT.Size = New System.Drawing.Size(84, 20)
        Me.dtpNamKT.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Thống kê theo:"
        '
        'dtpNamBD
        '
        Me.dtpNamBD.CustomFormat = "yyyy"
        Me.dtpNamBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNamBD.Location = New System.Drawing.Point(145, 40)
        Me.dtpNamBD.Name = "dtpNamBD"
        Me.dtpNamBD.Size = New System.Drawing.Size(84, 20)
        Me.dtpNamBD.TabIndex = 10
        '
        'cboThongKe
        '
        Me.cboThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThongKe.FormattingEnabled = True
        Me.cboThongKe.Location = New System.Drawing.Point(145, 13)
        Me.cboThongKe.Name = "cboThongKe"
        Me.cboThongKe.Size = New System.Drawing.Size(84, 21)
        Me.cboThongKe.TabIndex = 9
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(251, 11)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(84, 23)
        Me.btnThongKe.TabIndex = 8
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'crvTKe
        '
        Me.crvTKe.ActiveViewIndex = -1
        Me.crvTKe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvTKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvTKe.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvTKe.Location = New System.Drawing.Point(4, 84)
        Me.crvTKe.Name = "crvTKe"
        Me.crvTKe.ShowCloseButton = False
        Me.crvTKe.Size = New System.Drawing.Size(787, 367)
        Me.crvTKe.TabIndex = 7
        '
        'frmTKeDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 454)
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.dtpNamKT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpNamBD)
        Me.Controls.Add(Me.cboThongKe)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.crvTKe)
        Me.Name = "frmTKeDT"
        Me.Text = "Thống kê doanh thu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents dtpNamKT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpNamBD As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboThongKe As System.Windows.Forms.ComboBox
    Friend WithEvents btnThongKe As System.Windows.Forms.Button
    Friend WithEvents crvTKe As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
