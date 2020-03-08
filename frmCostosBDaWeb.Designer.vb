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
        Me.lblArchivoZip = New System.Windows.Forms.Label()
        Me.lblNombreArchivoZip = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(27, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enviado por"
        '
        'lblArchivoZip
        '
        Me.lblArchivoZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArchivoZip.Location = New System.Drawing.Point(142, 18)
        Me.lblArchivoZip.Name = "lblArchivoZip"
        Me.lblArchivoZip.Size = New System.Drawing.Size(243, 23)
        Me.lblArchivoZip.TabIndex = 16
        '
        'lblNombreArchivoZip
        '
        Me.lblNombreArchivoZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreArchivoZip.Location = New System.Drawing.Point(142, 45)
        Me.lblNombreArchivoZip.Name = "lblNombreArchivoZip"
        Me.lblNombreArchivoZip.Size = New System.Drawing.Size(243, 23)
        Me.lblNombreArchivoZip.TabIndex = 17
        '
        'frmCostosBDaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 286)
        Me.Controls.Add(Me.lblNombreArchivoZip)
        Me.Controls.Add(Me.lblArchivoZip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmCostosBDaWeb"
        Me.Text = "Actualizar COSTOSBD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblArchivoZip As Label
    Friend WithEvents lblNombreArchivoZip As Label
End Class
