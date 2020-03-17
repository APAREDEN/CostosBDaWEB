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
        Me.btnProcesa = New System.Windows.Forms.Button()
        Me.lbLogErrores = New System.Windows.Forms.ListBox()
        Me.pbProcesando = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFechaEnvio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.lblNombreArchivoZip = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUltimaFechaEnvio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUltimoSender = New System.Windows.Forms.Label()
        Me.lblUltimoNombreArchivoZip = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnPaseAweb = New System.Windows.Forms.Panel()
        Me.dtFechaAct = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaAct = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomTabla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actupd_Actualizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActACTcomun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActCostos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsertCostos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnStatus = New System.Windows.Forms.Panel()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.lblMsg2 = New System.Windows.Forms.Label()
        Me.lblMsg3 = New System.Windows.Forms.Label()
        Me.lblMsg4 = New System.Windows.Forms.Label()
        Me.lblMsg5 = New System.Windows.Forms.Label()
        Me.lblMsg6 = New System.Windows.Forms.Label()
        Me.lblMsg7 = New System.Windows.Forms.Label()
        CType(Me.pbProcesando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnPaseAweb.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProcesa
        '
        Me.btnProcesa.Location = New System.Drawing.Point(24, 126)
        Me.btnProcesa.Name = "btnProcesa"
        Me.btnProcesa.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesa.TabIndex = 18
        Me.btnProcesa.Text = "Procesa"
        Me.btnProcesa.UseVisualStyleBackColor = True
        '
        'lbLogErrores
        '
        Me.lbLogErrores.FormattingEnabled = True
        Me.lbLogErrores.HorizontalScrollbar = True
        Me.lbLogErrores.Location = New System.Drawing.Point(432, 12)
        Me.lbLogErrores.Name = "lbLogErrores"
        Me.lbLogErrores.Size = New System.Drawing.Size(706, 225)
        Me.lbLogErrores.TabIndex = 21
        '
        'pbProcesando
        '
        Me.pbProcesando.Image = Global.CostosBDaWEB.My.Resources.Resources.Bandera
        Me.pbProcesando.Location = New System.Drawing.Point(332, 126)
        Me.pbProcesando.Name = "pbProcesando"
        Me.pbProcesando.Size = New System.Drawing.Size(69, 39)
        Me.pbProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProcesando.TabIndex = 22
        Me.pbProcesando.TabStop = False
        Me.pbProcesando.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblFechaEnvio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblSender)
        Me.GroupBox1.Controls.Add(Me.lblNombreArchivoZip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 108)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mail a procesar"
        '
        'lblFechaEnvio
        '
        Me.lblFechaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaEnvio.Location = New System.Drawing.Point(115, 47)
        Me.lblFechaEnvio.Name = "lblFechaEnvio"
        Me.lblFechaEnvio.Size = New System.Drawing.Size(243, 23)
        Me.lblFechaEnvio.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Fecha de envío"
        '
        'lblSender
        '
        Me.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSender.Location = New System.Drawing.Point(115, 70)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(243, 23)
        Me.lblSender.TabIndex = 37
        '
        'lblNombreArchivoZip
        '
        Me.lblNombreArchivoZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreArchivoZip.Location = New System.Drawing.Point(115, 24)
        Me.lblNombreArchivoZip.Name = "lblNombreArchivoZip"
        Me.lblNombreArchivoZip.Size = New System.Drawing.Size(243, 23)
        Me.lblNombreArchivoZip.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Enviado por"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Nombre Archivo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.lblUltimaFechaEnvio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblUltimoSender)
        Me.GroupBox2.Controls.Add(Me.lblUltimoNombreArchivoZip)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 108)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ultimo mail Procesado"
        '
        'lblUltimaFechaEnvio
        '
        Me.lblUltimaFechaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUltimaFechaEnvio.Location = New System.Drawing.Point(115, 47)
        Me.lblUltimaFechaEnvio.Name = "lblUltimaFechaEnvio"
        Me.lblUltimaFechaEnvio.Size = New System.Drawing.Size(243, 23)
        Me.lblUltimaFechaEnvio.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Fecha de envío"
        '
        'lblUltimoSender
        '
        Me.lblUltimoSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUltimoSender.Location = New System.Drawing.Point(115, 70)
        Me.lblUltimoSender.Name = "lblUltimoSender"
        Me.lblUltimoSender.Size = New System.Drawing.Size(243, 23)
        Me.lblUltimoSender.TabIndex = 37
        '
        'lblUltimoNombreArchivoZip
        '
        Me.lblUltimoNombreArchivoZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUltimoNombreArchivoZip.Location = New System.Drawing.Point(115, 24)
        Me.lblUltimoNombreArchivoZip.Name = "lblUltimoNombreArchivoZip"
        Me.lblUltimoNombreArchivoZip.Size = New System.Drawing.Size(243, 23)
        Me.lblUltimoNombreArchivoZip.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Enviado por"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nombre Archivo"
        '
        'pnPaseAweb
        '
        Me.pnPaseAweb.BackColor = System.Drawing.Color.White
        Me.pnPaseAweb.Controls.Add(Me.dtFechaAct)
        Me.pnPaseAweb.Controls.Add(Me.lblFechaAct)
        Me.pnPaseAweb.Controls.Add(Me.DataGridView1)
        Me.pnPaseAweb.Location = New System.Drawing.Point(432, 250)
        Me.pnPaseAweb.Name = "pnPaseAweb"
        Me.pnPaseAweb.Size = New System.Drawing.Size(706, 376)
        Me.pnPaseAweb.TabIndex = 30
        Me.pnPaseAweb.Visible = False
        '
        'dtFechaAct
        '
        Me.dtFechaAct.Enabled = False
        Me.dtFechaAct.Location = New System.Drawing.Point(132, 18)
        Me.dtFechaAct.Name = "dtFechaAct"
        Me.dtFechaAct.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaAct.TabIndex = 28
        '
        'lblFechaAct
        '
        Me.lblFechaAct.AutoSize = True
        Me.lblFechaAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAct.Location = New System.Drawing.Point(23, 18)
        Me.lblFechaAct.Name = "lblFechaAct"
        Me.lblFechaAct.Size = New System.Drawing.Size(103, 13)
        Me.lblFechaAct.TabIndex = 27
        Me.lblFechaAct.Text = "Actualiza Desde:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomTabla, Me.Actupd_Actualizacion, Me.ActACTcomun, Me.ActCostos, Me.InsertCostos, Me.Updates})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(683, 319)
        Me.DataGridView1.TabIndex = 26
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
        'pnStatus
        '
        Me.pnStatus.BackColor = System.Drawing.Color.White
        Me.pnStatus.Controls.Add(Me.lblMsg7)
        Me.pnStatus.Controls.Add(Me.lblMsg6)
        Me.pnStatus.Controls.Add(Me.lblMsg5)
        Me.pnStatus.Controls.Add(Me.lblMsg4)
        Me.pnStatus.Controls.Add(Me.lblMsg3)
        Me.pnStatus.Controls.Add(Me.lblMsg2)
        Me.pnStatus.Controls.Add(Me.lblMsg1)
        Me.pnStatus.Location = New System.Drawing.Point(12, 411)
        Me.pnStatus.Name = "pnStatus"
        Me.pnStatus.Size = New System.Drawing.Size(414, 215)
        Me.pnStatus.TabIndex = 32
        '
        'lblMsg1
        '
        Me.lblMsg1.AutoSize = True
        Me.lblMsg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg1.Location = New System.Drawing.Point(12, 22)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(153, 13)
        Me.lblMsg1.TabIndex = 32
        Me.lblMsg1.Text = "Chequea ultimo correo recibido"
        Me.lblMsg1.Visible = False
        '
        'lblMsg2
        '
        Me.lblMsg2.AutoSize = True
        Me.lblMsg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg2.Location = New System.Drawing.Point(12, 48)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(300, 13)
        Me.lblMsg2.TabIndex = 33
        Me.lblMsg2.Text = "Consistencia ultimo correo recibido vs ultimo correo procesado"
        Me.lblMsg2.Visible = False
        '
        'lblMsg3
        '
        Me.lblMsg3.AutoSize = True
        Me.lblMsg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg3.Location = New System.Drawing.Point(12, 74)
        Me.lblMsg3.Name = "lblMsg3"
        Me.lblMsg3.Size = New System.Drawing.Size(111, 13)
        Me.lblMsg3.TabIndex = 34
        Me.lblMsg3.Text = "Descomprime Backup"
        Me.lblMsg3.Visible = False
        '
        'lblMsg4
        '
        Me.lblMsg4.AutoSize = True
        Me.lblMsg4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg4.Location = New System.Drawing.Point(12, 100)
        Me.lblMsg4.Name = "lblMsg4"
        Me.lblMsg4.Size = New System.Drawing.Size(194, 13)
        Me.lblMsg4.TabIndex = 35
        Me.lblMsg4.Text = "Restaura Backup a SqlServer costosbd"
        Me.lblMsg4.Visible = False
        '
        'lblMsg5
        '
        Me.lblMsg5.AutoSize = True
        Me.lblMsg5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg5.Location = New System.Drawing.Point(12, 126)
        Me.lblMsg5.Name = "lblMsg5"
        Me.lblMsg5.Size = New System.Drawing.Size(249, 13)
        Me.lblMsg5.TabIndex = 36
        Me.lblMsg5.Text = "actualiza Informacion de Tablas comunes a la Web"
        Me.lblMsg5.Visible = False
        '
        'lblMsg6
        '
        Me.lblMsg6.AutoSize = True
        Me.lblMsg6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg6.Location = New System.Drawing.Point(12, 152)
        Me.lblMsg6.Name = "lblMsg6"
        Me.lblMsg6.Size = New System.Drawing.Size(189, 13)
        Me.lblMsg6.TabIndex = 37
        Me.lblMsg6.Text = "Borra Base de datos de folder Portable"
        Me.lblMsg6.Visible = False
        '
        'lblMsg7
        '
        Me.lblMsg7.AutoSize = True
        Me.lblMsg7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg7.Location = New System.Drawing.Point(12, 178)
        Me.lblMsg7.Name = "lblMsg7"
        Me.lblMsg7.Size = New System.Drawing.Size(222, 13)
        Me.lblMsg7.TabIndex = 38
        Me.lblMsg7.Text = "Respondiendo mail con resultado del proceso"
        Me.lblMsg7.Visible = False
        '
        'frmCostosBDaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 640)
        Me.Controls.Add(Me.pnStatus)
        Me.Controls.Add(Me.pnPaseAweb)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbProcesando)
        Me.Controls.Add(Me.lbLogErrores)
        Me.Controls.Add(Me.btnProcesa)
        Me.Name = "frmCostosBDaWeb"
        Me.Text = "Actualizar COSTOSBD"
        CType(Me.pbProcesando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnPaseAweb.ResumeLayout(False)
        Me.pnPaseAweb.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnStatus.ResumeLayout(False)
        Me.pnStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProcesa As Button
    Friend WithEvents lbLogErrores As ListBox
    Friend WithEvents pbProcesando As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFechaEnvio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSender As Label
    Friend WithEvents lblNombreArchivoZip As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblUltimaFechaEnvio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUltimoSender As Label
    Friend WithEvents lblUltimoNombreArchivoZip As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pnPaseAweb As Panel
    Friend WithEvents dtFechaAct As DateTimePicker
    Friend WithEvents lblFechaAct As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NomTabla As DataGridViewTextBoxColumn
    Friend WithEvents Actupd_Actualizacion As DataGridViewTextBoxColumn
    Friend WithEvents ActACTcomun As DataGridViewTextBoxColumn
    Friend WithEvents ActCostos As DataGridViewTextBoxColumn
    Friend WithEvents InsertCostos As DataGridViewTextBoxColumn
    Friend WithEvents Updates As DataGridViewTextBoxColumn
    Friend WithEvents pnStatus As Panel
    Friend WithEvents lblMsg7 As Label
    Friend WithEvents lblMsg6 As Label
    Friend WithEvents lblMsg5 As Label
    Friend WithEvents lblMsg4 As Label
    Friend WithEvents lblMsg3 As Label
    Friend WithEvents lblMsg2 As Label
    Friend WithEvents lblMsg1 As Label
End Class
