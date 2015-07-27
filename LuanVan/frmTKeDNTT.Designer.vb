<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTKeDNTT
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
        Me.crvTKe = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.cboThongKe = New System.Windows.Forms.ComboBox()
        Me.dtpNamBD = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNamKT = New System.Windows.Forms.DateTimePicker()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'crvTKe
        '
        Me.crvTKe.ActiveViewIndex = -1
        Me.crvTKe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvTKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvTKe.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvTKe.Location = New System.Drawing.Point(4, 67)
        Me.crvTKe.Name = "crvTKe"
        Me.crvTKe.ShowCloseButton = False
        Me.crvTKe.Size = New System.Drawing.Size(1153, 440)
        Me.crvTKe.TabIndex = 0
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(616, 12)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(84, 23)
        Me.btnThongKe.TabIndex = 1
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'cboThongKe
        '
        Me.cboThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThongKe.FormattingEnabled = True
        Me.cboThongKe.Location = New System.Drawing.Point(510, 14)
        Me.cboThongKe.Name = "cboThongKe"
        Me.cboThongKe.Size = New System.Drawing.Size(84, 21)
        Me.cboThongKe.TabIndex = 2
        '
        'dtpNamBD
        '
        Me.dtpNamBD.CustomFormat = "yyyy"
        Me.dtpNamBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNamBD.Location = New System.Drawing.Point(510, 41)
        Me.dtpNamBD.Name = "dtpNamBD"
        Me.dtpNamBD.Size = New System.Drawing.Size(84, 20)
        Me.dtpNamBD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Thống kê theo:"
        '
        'dtpNamKT
        '
        Me.dtpNamKT.CustomFormat = "yyyy"
        Me.dtpNamKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNamKT.Location = New System.Drawing.Point(616, 41)
        Me.dtpNamKT.Name = "dtpNamKT"
        Me.dtpNamKT.Size = New System.Drawing.Size(84, 20)
        Me.dtpNamKT.TabIndex = 5
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(600, 47)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(10, 13)
        Me.lblDash.TabIndex = 6
        Me.lblDash.Text = "-"
        '
        'frmTKeDNTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 511)
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.dtpNamKT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpNamBD)
        Me.Controls.Add(Me.cboThongKe)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.crvTKe)
        Me.Name = "frmTKeDNTT"
        Me.Text = "Thống kê điện năng tiêu thụ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvTKe As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnThongKe As System.Windows.Forms.Button
    Friend WithEvents cboThongKe As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpNamBD As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNamKT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDash As System.Windows.Forms.Label
End Class
