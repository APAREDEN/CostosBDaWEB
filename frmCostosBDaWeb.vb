Imports System.IO
Imports MailBee.ImapMail
Imports MailBee.Mime
Public Class frmCostosBDaWeb
    Private Sub frmCostosBDaWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Principal()
    End Sub
    Private Sub Principal()
        '---------------------------------------------------------------
        '0  Borrar todo del directorio c:\portable (si no existe directorio crearlo)
        '---------------------------------------------------------------


        If (Not System.IO.Directory.Exists("C:\Portable")) Then
            System.IO.Directory.CreateDirectory("C:\Portable")
        End If
        Dim directoryName As String = "C:\Portable"
        For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        '---------------------------------------------------------------
        '1  Lee Ultimo COrreo y baja el backup
        '---------------------------------------------------------------

        MailBee.Global.LicenseKey = "MN110-1C20DF387EA9952F661A118648FA-468F"
        '-----------------------------------------------------------------------------------------------------------------------------------------
        Dim nombreAdunto As String
        Dim imp As New Imap

        imp.Connect("mail.costosaplicaciones.com")

        imp.Login("receiver@costosaplicaciones.com", "costos2018#1")

        ' Select Inbox folder.
        imp.SelectFolder("INBOX")
        If imp.MessageCount = 0 Then
            MessageBox.Show("No hay Mensajes nuevos")
        End If

        ' Download the last e-mail in the inbox.
        ' We assume that e-mail includes winmail.dat attachment.
        Dim msg As MailMessage = imp.DownloadEntireMessage(imp.MessageCount, False)
        If msg.HasAttachments Then
            nombreAdunto = msg.Attachments(0).Name
        End If

        Dim attach As Attachment
        For Each attach In msg.Attachments
            msg.Attachments.SaveAll("C:\Portable")
        Next
        imp.Disconnect()
    End Sub
End Class
