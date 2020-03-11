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

Public Class frmCostosBDaWeb
    Const DirData As String = "C:\Portable"
    Private Sub frmCostosBDaWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Principal()
    End Sub
    Private Sub Principal()
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

        '---------------------------------------------------------------
        '1  Lee Ultimo COrreo y baja el backup
        '---------------------------------------------------------------
        LeeUltimoCorreo()
        MailBee.Global.LicenseKey = "MN110-1C20DF387EA9952F661A118648FA-468F"
        '-----------------------------------------------------------------------------------------------------------------------------------------

        Dim imp As New Imap



        Try
            IniciaDatos()

            imp.Connect("mail.costosaplicaciones.com")
            imp.Login("receiver@costosaplicaciones.com", "costos2018#1")
            ' Select Inbox folder.
            imp.SelectFolder("INBOX")
            If imp.MessageCount = 0 Then
                MessageBox.Show("No hay Mensajes nuevos")
            Else
                Dim fic As String = "c:\Portable\Data.dat"
                Dim UltimaBase As EntityDatoTransaccion = LeeLog()
                Dim msg As MailMessage = imp.DownloadEntireMessage(imp.MessageCount, False)
                lblNombreArchivoZip.Text = msg.Subject
                lblSender.Text = msg.From
                lblFechaEnvio.Text = msg.DateReceived.ToString


                If Not (lblNombreArchivoZip.Text = UltimaBase.NombreArchivoZip And CDate(lblFechaEnvio.Text) <= CDate(UltimaBase.FechaEnvio)) Then
                    Dim sw As New System.IO.StreamWriter(fic, False, System.Text.Encoding.Default)
                    Dim sb As New StringBuilder
                    Dim elemento As New EntityDatoTransaccion
                    elemento.NombreArchivoZip = lblNombreArchivoZip.Text
                    elemento.EmailSender = lblSender.Text
                    elemento.FechaEnvio = lblFechaEnvio.Text
                    Dim texto As String = ArmastringBuilder(elemento)
                    sw.WriteLine(texto)
                    sw.Close()

                End If
            End If
            imp.Disconnect()
            Dim mensajeRAR As String = CopiaArchivo(lblNombreArchivoZip.Text)
            If mensajeRAR = "" Then
            Else
                lbLogErrores.Items.Add(mensajeRAR)
                IniciaDatos()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Function LeeUltimoCorreo() As EntityDatoTransaccion
        MailBee.Global.LicenseKey = "MN110-1C20DF387EA9952F661A118648FA-468F"
        Dim Rpta As String = ""
        Dim elemento As New EntityDatoTransaccion
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
            Debug.WriteLine("From: " & msg.From.AsString & ", To: " & msg.To.AsString)
            Debug.WriteLine("Subject: " & msg.Subject)
        Next

        ' Disconnect from POP3 server
        pop.Disconnect()

        Return elemento
    End Function
    Private Function LeeLog() As EntityDatoTransaccion

        Dim elemento As New EntityDatoTransaccion
        If Not My.Computer.FileSystem.FileExists(DirData & "\Data.dat") Then
            Return elemento
        End If

        Dim fileReader As System.IO.StreamReader

        fileReader = My.Computer.FileSystem.OpenTextFileReader(DirData & "Data.dat")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()

        Dim correos = Split(stringReader, ",")
        elemento.NombreArchivoZip = correos(0)
        elemento.EmailSender = correos(1)
        elemento.FechaEnvio = correos(2)
        fileReader.Close()
        Return elemento
    End Function
    Private Function CopiaArchivo(NombreRar As String) As String
        Try
            Dim archivo = RarArchive.Open("C:\Users\APN\Google Drive\DATOS\WEB DB\BK_COSTOSDB\" & Replace(UCase(NombreRar), ".RAR", "") & ".rar")
            For Each entry In archivo.Entries
                entry.WriteToDirectory(DirData)
            Next
            Return ""
        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function ArmastringBuilder(obj As EntityDatoTransaccion) As String
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

    End Sub

    Private Sub btnProcesa_Click(sender As Object, e As EventArgs) Handles btnProcesa.Click
        Principal()
    End Sub
End Class
