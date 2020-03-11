<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostosBDaWeb
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreArchivoZip = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.btnProcesa = New System.Windows.Forms.Button()
        Me.lblFechaEnvio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbLogErrores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nombre Archivo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enviado por"
        '
        'lblNombreArchivoZip
        '
        Me.lblNombreArchivoZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreArchivoZip.Location = New System.Drawing.Point(142, 18)
        Me.lblNombreArchivoZip.Name = "lblNombreArchivoZip"
        Me.lblNombreArchivoZip.Size = New System.Drawing.Size(243, 23)
        Me.lblNombreArchivoZip.TabIndex = 16
        '
        'lblSender
        '
        Me.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSender.Location = New System.Drawing.Point(142, 77)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(243, 23)
        Me.lblSender.TabIndex = 17
        '
        'btnProcesa
        '
        Me.btnProcesa.Location = New System.Drawing.Point(27, 251)
        Me.btnProcesa.Name = "btnProcesa"
        Me.btnProcesa.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesa.TabIndex = 18
        Me.btnProcesa.Text = "Procesa"
        Me.btnProcesa.UseVisualStyleBackColor = True
        '
        'lblFechaEnvio
        '
        Me.lblFechaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaEnvio.Location = New System.Drawing.Point(142, 49)
        Me.lblFechaEnvio.Name = "lblFechaEnvio"
        Me.lblFechaEnvio.Size = New System.Drawing.Size(243, 23)
        Me.lblFechaEnvio.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha de envío"
        '
        'lbLogErrores
        '
        Me.lbLogErrores.FormattingEnabled = True
        Me.lbLogErrores.Location = New System.Drawing.Point(467, 18)
        Me.lbLogErrores.Name = "lbLogErrores"
        Me.lbLogErrores.Size = New System.Drawing.Size(607, 95)
        Me.lbLogErrores.TabIndex = 21
        '
        'frmCostosBDaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 286)
        Me.Controls.Add(Me.lbLogErrores)
        Me.Controls.Add(Me.lblFechaEnvio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnProcesa)
        Me.Controls.Add(Me.lblSender)
        Me.Controls.Add(Me.lblNombreArchivoZip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmCostosBDaWeb"
        Me.Text = "Actualizar COSTOSBD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreArchivoZip As Label
    Friend WithEvents lblSender As Label
    Friend WithEvents btnProcesa As Button
    Friend WithEvents lblFechaEnvio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbLogErrores As ListBox
End Class
