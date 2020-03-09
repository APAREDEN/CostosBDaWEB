Imports System.IO
Imports MailBee.ImapMail
Imports MailBee.Mime
Imports System.Text
Imports Microsoft.VisualBasic.FileIO
Public Class frmCostosBDaWeb
    Private Sub frmCostosBDaWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Principal()
    End Sub
    Private Sub Principal()
        '---------------------------------------------------------------
        '0  Borrar todo del directorio c:\portable (si no existe directorio crearlo)
        '---------------------------------------------------------------


        If (Not System.IO.Directory.Exists("C:\Portable")) Then
            System.IO.Directory.CreateDirectory("C:\Portable")
        End If
        Dim directoryName As String = "C:\Portable"
        'For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
        '    File.Delete(deleteFile)
        'Next

        '---------------------------------------------------------------
        '1  Lee Ultimo COrreo y baja el backup
        '---------------------------------------------------------------

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
        Catch ex As Exception

        End Try








    End Sub
    Private Function LeeLog() As EntityDatoTransaccion

        Dim elemento As New EntityDatoTransaccion
        If Not My.Computer.FileSystem.FileExists("c:\Portable\Data.dat") Then
            Return elemento
        End If

        Dim fileReader As System.IO.StreamReader

        fileReader = My.Computer.FileSystem.OpenTextFileReader("c:\Portable\Data.dat")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()

        Dim correos = Split(stringReader, ",")
        elemento.NombreArchivoZip = correos(0)
        elemento.EmailSender = correos(1)
        elemento.FechaEnvio = correos(2)
        fileReader.Close()
        Return elemento
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
