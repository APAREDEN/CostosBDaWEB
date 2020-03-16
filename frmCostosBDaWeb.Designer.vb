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
        Me.pbProcesando = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomTabla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actupd_Actualizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActACTcomun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActCostos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsertCostos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFechaAct = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaAct = New System.Windows.Forms.Label()
        CType(Me.pbProcesando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 18)
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
        Me.btnProcesa.Location = New System.Drawing.Point(27, 221)
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
        Me.lbLogErrores.HorizontalScrollbar = True
        Me.lbLogErrores.Location = New System.Drawing.Point(391, 18)
        Me.lbLogErrores.Name = "lbLogErrores"
        Me.lbLogErrores.Size = New System.Drawing.Size(683, 160)
        Me.lbLogErrores.TabIndex = 21
        '
        'pbProcesando
        '
        Me.pbProcesando.Image = Global.CostosBDaWEB.My.Resources.Resources.Bandera
        Me.pbProcesando.Location = New System.Drawing.Point(12, 241)
        Me.pbProcesando.Name = "pbProcesando"
        Me.pbProcesando.Size = New System.Drawing.Size(98, 73)
        Me.pbProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProcesando.TabIndex = 22
        Me.pbProcesando.TabStop = False
        Me.pbProcesando.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomTabla, Me.Actupd_Actualizacion, Me.ActACTcomun, Me.ActCostos, Me.InsertCostos, Me.Updates})
        Me.DataGridView1.Location = New System.Drawing.Point(391, 269)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(683, 319)
        Me.DataGridView1.TabIndex = 23
        '
        'NomTabla
        '
        Me.NomTabla.DataPropertyName = "NomTabla"
        Me.NomTabla.HeaderText = "NomTabla"
        Me.NomTabla.Name = "NomTabla"
        Me.NomTabla.ReadOnly = True
        Me.NomTabla.Width = 150
        '
        'Actupd_Actualizacion
        '
        Me.Actupd_Actualizacion.DataPropertyName = "Actupd_Actualizacion"
        Me.Actupd_Actualizacion.HeaderText = "Temp.Local"
        Me.Actupd_Actualizacion.Name = "Actupd_Actualizacion"
        Me.Actupd_Actualizacion.ReadOnly = True
        '
        'ActACTcomun
        '
        Me.ActACTcomun.DataPropertyName = "ActACTcomun"
        Me.ActACTcomun.HeaderText = "Temp.Remoto"
        Me.ActACTcomun.Name = "ActACTcomun"
        Me.ActACTcomun.ReadOnly = True
        '
        'ActCostos
        '
        Me.ActCostos.DataPropertyName = "ActCostos"
        Me.ActCostos.HeaderText = "Produccion"
        Me.ActCostos.Name = "ActCostos"
        Me.ActCostos.ReadOnly = True
        '
        'InsertCostos
        '
        Me.InsertCostos.DataPropertyName = "InsertCostos"
        Me.InsertCostos.HeaderText = "Inserts"
        Me.InsertCostos.Name = "InsertCostos"
        Me.InsertCostos.ReadOnly = True
        '
        'Updates
        '
        Me.Updates.DataPropertyName = "UpdateCostos"
        Me.Updates.HeaderText = "Updates"
        Me.Updates.Name = "Updates"
        Me.Updates.ReadOnly = True
        '
        'dtFechaAct
        '
        Me.dtFechaAct.Enabled = False
        Me.dtFechaAct.Location = New System.Drawing.Point(516, 243)
        Me.dtFechaAct.Name = "dtFechaAct"
        Me.dtFechaAct.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaAct.TabIndex = 25
        '
        'lblFechaAct
        '
        Me.lblFechaAct.AutoSize = True
        Me.lblFechaAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAct.Location = New System.Drawing.Point(388, 249)
        Me.lblFechaAct.Name = "lblFechaAct"
        Me.lblFechaAct.Size = New System.Drawing.Size(103, 13)
        Me.lblFechaAct.TabIndex = 24
        Me.lblFechaAct.Text = "Actualiza Desde:"
        '
        'frmCostosBDaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 600)
        Me.Controls.Add(Me.dtFechaAct)
        Me.Controls.Add(Me.lblFechaAct)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pbProcesando)
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
        CType(Me.pbProcesando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pbProcesando As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NomTabla As DataGridViewTextBoxColumn
    Friend WithEvents Actupd_Actualizacion As DataGridViewTextBoxColumn
    Friend WithEvents ActACTcomun As DataGridViewTextBoxColumn
    Friend WithEvents ActCostos As DataGridViewTextBoxColumn
    Friend WithEvents InsertCostos As DataGridViewTextBoxColumn
    Friend WithEvents Updates As DataGridViewTextBoxColumn
    Friend WithEvents dtFechaAct As DateTimePicker
    Friend WithEvents lblFechaAct As Label
End Class
