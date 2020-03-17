Imports System.IO
Imports MailBee.ImapMail
Imports MailBee.Mime
Imports System.Text
Imports Microsoft.VisualBasic.FileIO
Imports SharpCompress.Archives
Imports SharpCompress.Archives.Rar
Imports SharpCompress.Common
Imports SharpCompress.Readers
Imports MailBee.Pop3Mail
Imports System.Data.SqlClient
Imports MailBee.SmtpMail

Public Class frmCostosBDaWeb
    Const DirData As String = "C:\Portable"
    Dim TemplatelistaTablas As New List(Of TablaComun)
    Dim listaTablas As New List(Of TablaComun)
    Dim Pasos() As String = {
        "Chequea ultimo correo recibido",
        "Consistencia ultimo correo recibido vs ultimo correo procesado",
        "Descomprime Backup",
        "Restaura Backup a SqlServer costosbd",
        "actualiza Informacion de Tablas comunes a la Web",
        "Respondiendo mail con resultado del proceso"
    }
    Private Sub frmCostosBDaWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Principal()
    End Sub
    Private Sub Principal()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        pnPaseAweb.Visible = True
        lblMsg1.Visible = False
        lblMsg2.Visible = False
        lblMsg3.Visible = False
        lblMsg4.Visible = False
        lblMsg5.Visible = False
        lblMsg6.Visible = False
        lblMsg7.Visible = False
        Application.DoEvents()
        '---------------------------------------------------------------
        '0  Borrar todo del directorio c:\portable (si no existe directorio crearlo)
        '---------------------------------------------------------------


        If (Not System.IO.Directory.Exists(DirData)) Then
            System.IO.Directory.CreateDirectory(DirData)
        End If
        Dim directoryName As String = DirData
        'For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
        '    File.Delete(deleteFile)
        'Next

        Dim terminaOk As Boolean = True


        Try
            pbProcesando.Visible = True
            Application.DoEvents()
            IniciaDatos()

            '---------------------------------------------------------------
            '0.1  Lee del Log el ultimo correo procesado
            '---------------------------------------------------------------
            Dim UltimaBase As DatoTransaccion = LeeLog()
            lblUltimoNombreArchivoZip.Text = UltimaBase.NombreArchivoZip
            lblUltimoSender.Text = UltimaBase.EmailSender
            lblUltimaFechaEnvio.Text = UltimaBase.FechaEnvio
            Application.DoEvents()

            '---------------------------------------------------------------
            '1  Lee Ultimo COrreo y baja el backup
            '---------------------------------------------------------------
            lblMsg1.Visible = True : Application.DoEvents()
            Dim elemento = LeeUltimoCorreo()

            If elemento.EmailSender = "ERROR" Then
                lbLogErrores.Items.Add(elemento.NombreArchivoZip)
                terminaOk = False
            Else
                Dim fic As String = DirData & "\Data.dat"

                If UltimaBase.EmailSender = "ERROR" Then
                    lbLogErrores.Items.Add(UltimaBase.NombreArchivoZip)
                    terminaOk = False
                Else
                    lblNombreArchivoZip.Text = elemento.NombreArchivoZip
                    lblSender.Text = elemento.EmailSender
                    lblFechaEnvio.Text = elemento.FechaEnvio
                    Application.DoEvents()
                    lblMsg2.Visible = True : Application.DoEvents()
                    Dim Pase As Boolean = False
                    If lblNombreArchivoZip.Text <> UltimaBase.NombreArchivoZip Then
                        Pase = True
                    ElseIf CDate(lblFechaEnvio.Text) > CDate(UltimaBase.FechaEnvio) Then
                        Pase = True
                    End If

                    If Pase Then
                        lblMsg3.Visible = True : Application.DoEvents()
                        Dim sw As New System.IO.StreamWriter(fic, False, System.Text.Encoding.Default)
                        Dim sb As New StringBuilder

                        elemento.NombreArchivoZip = lblNombreArchivoZip.Text
                        elemento.EmailSender = lblSender.Text
                        elemento.FechaEnvio = lblFechaEnvio.Text
                        Dim texto As String = ArmastringBuilder(elemento)
                        sw.WriteLine(texto)
                        sw.Close()
                        ' Descompacta Archivo en directorio definido en la variable DirData

                        Dim mensajeRAR As String = CopiaArchivo(lblNombreArchivoZip.Text)
                        If mensajeRAR <> "" Then
                            terminaOk = False
                            lbLogErrores.Items.Add(mensajeRAR)
                            'IniciaDatos()
                        Else
                            ' Restaura Backup
                            lblMsg4.Visible = True : Application.DoEvents()
                            Dim Restore As String = RestauraBackup(Replace(UCase(lblNombreArchivoZip.Text), ".ARJ", ""))
                            If Restore <> "" Then
                                terminaOk = False
                                lbLogErrores.Items.Add(Restore)
                                IniciaDatos()
                            Else                            ' Actualiza tablas comunes en la WEB
                                CargaBlanco()
                                lblMsg5.Visible = True : Application.DoEvents()
                                Dim ActWeb As String = ActualizarWeb(Mid(lblNombreArchivoZip.Text, 10, 8))
                                If ActWeb <> "" Then
                                    lbLogErrores.Items.Add(ActWeb)
                                    IniciaDatos()
                                    terminaOk = False
                                Else
                                    ' Borra Base de Datos de folder portable'
                                    lblMsg6.Visible = True : Application.DoEvents()
                                    Dim rrpp = BorraArchivo(lblNombreArchivoZip.Text)
                                    ' Envia correo con Status '
                                    lblMsg7.Visible = True : Application.DoEvents()
                                    Dim msg As String = ""
                                    If terminaOk Then
                                        msg = "Actualización de " & Replace(UCase(lblNombreArchivoZip.Text), ".ARJ", "") & " fue realizada con exito"
                                    Else
                                        msg = "Actualización de " & Replace(UCase(lblNombreArchivoZip.Text), ".ARJ", "") & " no fue realizada correctamente."
                                    End If
                                    EnviaRespuesta(lblSender.Text, msg)
                                End If
                            End If

                        End If
                    Else
                        terminaOk = False
                    End If
                End If
                pnPaseAweb.Visible = False
                Application.DoEvents()
            End If

        Catch ex As Exception
            lbLogErrores.Items.Add(ex.Message)
            IniciaDatos()

        End Try
        pbProcesando.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Application.DoEvents()
    End Sub
    Private Function RestauraBackup(pArchivo As String) As String
        Dim Rpta As String = ""
        Dim connection As SqlConnection = DB.GetConnection()

        Dim ExecStatement As String = "USE [master]; ALTER DATABASE [COSTOSBD] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;"

        ExecStatement = ExecStatement & "RESTORE DATABASE [COSTOSBD] FROM  DISK = N'" & DirData & "\" & pArchivo & "' WITH  FILE = 1,  " &
                                      "MOVE N'S10_Data' TO N'J:\Microsoft SQL Server 2012\MSSQL11.I2012\MSSQL\DATA\COSTOSBD_1.mdf',  " &
                                      "MOVE N'S10_Datos' TO N'J:\Microsoft SQL Server 2012\MSSQL11.I2012\MSSQL\DATA\COSTOSBD_2.ndf',  " &
                                      "MOVE N'S10_Log' TO N'J:\Microsoft SQL Server 2012\MSSQL11.I2012\MSSQL\DATA\COSTOSBD_3.ldf',  NOUNLOAD,  REPLACE,  STATS = 5;"

        ExecStatement = ExecStatement & "ALTER DATABASE [COSTOSBD] SET MULTI_USER;"



        Try
            Dim executeCommand As New SqlCommand(ExecStatement, connection)
            executeCommand.CommandType = CommandType.Text
            executeCommand.CommandTimeout = 0
            connection.Open()
            Dim count As Integer = executeCommand.ExecuteNonQuery
            connection.Close()
        Catch ex As Exception
            Rpta = "RestauraBackup : " & ex.Message
        End Try
        Return Rpta
    End Function


    Private Function LeeUltimoCorreo() As DatoTransaccion
        Dim elemento As New DatoTransaccion
        Try

            MailBee.Global.LicenseKey = "MN110-1C20DF387EA9952F661A118648FA-468F"
            Dim Rpta As String = ""
            elemento.FechaEnvio = CDate("2000-01-01")
            Dim pop As New Pop3
            MailBee.Global.LicenseKey = "MN110-1C20DF387EA9952F661A118648FA-468F"
            ' Connect to POP3 server
            pop.Connect("mail.costosaplicaciones.com")
            pop.Login("receiver@costosaplicaciones.com", "costos2018#1")

            ' Download headers for all messages
            Dim msgs As MailMessageCollection = pop.DownloadMessageHeaders()

            ' For each message, write its details to the console-
            Dim msg As MailMessage
            For Each msg In msgs
                If Mid(UCase(msg.Subject), 1, 8) = "COSTOSBD" AndAlso msg.DateReceived > CDate(elemento.FechaEnvio) Then
                    elemento.EmailSender = msg.From
                    elemento.FechaEnvio = msg.DateReceived
                    elemento.NombreArchivoZip = msg.Subject
                End If
                'Debug.WriteLine("From: " & msg.From.AsString & ", To: " & msg.To.AsString)
                'Debug.WriteLine("Subject: " & msg.Subject)
            Next

            ' Disconnect from POP3 server
            pop.Disconnect()

            Return elemento
        Catch ex As Exception
            elemento.EmailSender = "ERROR"
            elemento.NombreArchivoZip = ex.Message
            Return elemento
        End Try

    End Function
    Private Function EnviaRespuesta(Destino As String, msg As String) As Boolean

        Try

            MailBee.Global.LicenseKey = "MN110-1C20DF387EA9952F661A118648FA-468F"
            Dim mailer As Smtp = New Smtp()
            mailer.SmtpServers.Add("mail.costosaplicaciones.com", "receiver@costosaplicaciones.com", "costos2018#1")
            mailer.From.AsString = "receiver@costosaplicaciones.com"
            mailer.To.AsString = Destino
            mailer.Subject = "Requerimiento de actualizacion de costosbd"
            mailer.BodyPlainText = msg
            mailer.Send()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function LeeLog() As DatoTransaccion

        Dim elemento As New DatoTransaccion
        Try
            If Not My.Computer.FileSystem.FileExists(DirData & "\Data.dat") Then
                Return elemento
            End If

            Dim fileReader As System.IO.StreamReader

            fileReader = My.Computer.FileSystem.OpenTextFileReader(DirData & "\Data.dat")
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            If stringReader = "" Then
                elemento.FechaEnvio = CDate("2000-01-01")
                fileReader.Close()
                Return elemento
            End If
            Dim correos = Split(stringReader, ",")
            elemento.NombreArchivoZip = correos(0)
            elemento.EmailSender = correos(1)
            elemento.FechaEnvio = correos(2)
            fileReader.Close()
            Return elemento
        Catch ex As Exception
            elemento.EmailSender = "ERROR"
            elemento.NombreArchivoZip = "LeeLog : " & ex.Message
            Return elemento
        End Try

    End Function
    Private Function CopiaArchivo(NombreRar As String) As String
        Try
            Dim archivo = RarArchive.Open("C:\Users\APN\Google Drive\DATOS\WEB DB\BK_COSTOSDB\" & Replace(UCase(NombreRar), ".RAR", "") & ".RAR")
            For Each entry In archivo.Entries
                entry.WriteToDirectory(DirData)
            Next
            Return ""
        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Function BorraArchivo(NombreRar As String) As String
        Try
            Dim archivo = DirData & "\" & Replace(UCase(NombreRar), ".RAR", "")
            If System.IO.File.Exists(archivo) = True Then
                System.IO.File.Delete(archivo)
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function ArmastringBuilder(obj As DatoTransaccion) As String
        Dim rpt As String = ""
        Dim i As Integer = 0
        i = InStr(obj.EmailSender, "<")

        Dim Correo As String = Mid(obj.EmailSender, i + 1)
        Correo = Replace(Correo, ">", "")
        rpt = obj.NombreArchivoZip & "," & Correo & "," & obj.FechaEnvio
        Return rpt
    End Function
    Private Sub IniciaDatos()
        lblNombreArchivoZip.Text = ""
        lblSender.Text = ""
        lblFechaEnvio.Text = ""
        lblUltimoNombreArchivoZip.Text = ""
        lblUltimoSender.Text = ""
        lblUltimaFechaEnvio.Text = ""
        DataGridView1.DataSource = TemplatelistaTablas
        DataGridView1.Refresh()
        Application.DoEvents()
    End Sub

    Private Sub btnProcesa_Click(sender As Object, e As EventArgs) Handles btnProcesa.Click
        Principal()
    End Sub
    '----------------------------------------------------------------------------------------------------
    ' Actualiza Tablas Comunes
    '----------------------------------------------------------------------------------------------------
    Private Function ActualizarWeb(sFecha As String) As String
        Dim Rpta As String = ""
        Dim rptProceso As String = ""
        Try
            ' Maneja Fechas
            Dim Faux As Date = DateAdd("d", -15, Now.Date)
            Dim FechaAct As Date = DateAdd("d", -10, CDate(Mid(sFecha, 1, 4) + "-" + Mid(sFecha, 5, 2) + "-" + Mid(sFecha, 7, 2)))
            Dim dife As Integer = DateDiff(DateInterval.Day, Faux, FechaAct)
            If Math.Abs(dife) > 10 Then
                FechaAct = Faux
            End If
            dtFechaAct.Value = FechaAct
            Application.DoEvents()

            Dim filas = New String() {"IDEN", "CONT", "INSU", "MONE", "PROV", "UBIG", "UNID", "EQNT", "NOTA", "PTNT", "PRNT", "CARG"}
            Dim fecha = Format(dtFechaAct.Value, "yyyyMMdd")

            '1  Actualiza upd_Actualizacion
            Dim rpt = DB.ActTablasComunes(fecha).Trim
            If Mid(rptProceso, 1, 5) = "ERROR" Then
                Return rptProceso
            End If

            For Each x In listaTablas
                x.Actupd_Actualizacion = 0
                x.ActACTcomun = 0
                x.ActCostos = 0
                x.InsertCostos = 0
                x.UpdateCostos = 0
            Next
            DataGridView1.DataSource = listaTablas
            DataGridView1.Refresh()

            Dim i As Integer
            Dim j As Integer = 0
            For i = 0 To listaTablas.Count - 1
                j = j + 1
                listaTablas(i).Actupd_Actualizacion = Val(Mid(rpt, j * 11 - 10, 10))
            Next
            DataGridView1.DataSource = listaTablas
            DataGridView1.Refresh()

            '2  Actualiza de upd_Actualizacion a ACTcomun
            rptProceso = DB.ActACTComun().Trim
            If Mid(rptProceso, 1, 5) = "ERROR" Then
                Return rptProceso
            End If


            j = 0
            For i = 0 To listaTablas.Count - 1
                j = j + 1
                listaTablas(i).ActACTcomun = Val(Mid(rpt, j * 11 - 10, 10))
            Next
            DataGridView1.DataSource = listaTablas
            DataGridView1.Refresh()

            '3  Actualiza de  ACTcomun a Costos en Produccion
            rptProceso = DB.ActCostosDesdeACTComun().Trim
            If Mid(rptProceso, 1, 5) = "ERROR" Then
                Return rptProceso
            End If
            Dim lelemntos As String() = rptProceso.Split(New Char() {" "c})
            Dim ele As String
            For Each ele In lelemntos
                Dim pref As String = Mid(ele, 1, 4)
                Dim tip As String = Mid(ele, 5, 1)
                Dim valor As Integer = Val(Mid(ele, 6, 10))
                i = Array.FindIndex(filas, Function(x) x = pref)
                If tip = "U" Then
                    listaTablas(i).UpdateCostos = valor
                ElseIf tip = "I" Then
                    listaTablas(i).InsertCostos = valor
                End If

            Next
            For Each x In listaTablas
                x.ActCostos = x.InsertCostos + x.UpdateCostos
            Next

            DataGridView1.DataSource = listaTablas
            DataGridView1.Refresh()
            Application.DoEvents()

            ' Comprobacion de resultados
            Dim Epase As String = "Error Comprobacion"
            For Each x In listaTablas
                If (x.Actupd_Actualizacion <> x.ActACTcomun) Or (x.Actupd_Actualizacion <> x.ActCostos) Or (x.ActACTcomun <> x.ActCostos) Then
                    Epase = Epase + x.NomTabla & "  " & x.Actupd_Actualizacion & "/" & x.ActACTcomun & "/" & x.ActCostos
                    Return Epase
                End If
            Next

            pnPaseAweb.Visible = False
            Application.DoEvents()
        Catch ex As Exception
            Return ex.Message
        End Try



        Return ""
    End Function
    Private Sub CargaBlanco()

        Dim elemento As TablaComun
        listaTablas.Clear()

        elemento = New TablaComun() : elemento.NomTabla = "Identificador" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "Contacto" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "Insumo" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "Moneda" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "Proveedor" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "Ubicación Geográfica" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "unidad" : listaTablas.Add(elemento)

        elemento = New TablaComun() : elemento.NomTabla = "EquivalenciaNT" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "Nota" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "PartidaTituloNT" : listaTablas.Add(elemento)
        elemento = New TablaComun() : elemento.NomTabla = "PrefijoNT" : listaTablas.Add(elemento)

        elemento = New TablaComun() : elemento.NomTabla = "Cargo" : listaTablas.Add(elemento) '--

        DataGridView1.DataSource = listaTablas
    End Sub
End Class
