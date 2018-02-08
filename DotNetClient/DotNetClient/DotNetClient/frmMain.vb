Imports System.Xml.Serialization
Imports System.Xml.Serialization.XmlSerializer
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmMain

    Dim oInfo As New Info With {.MyName = "Johe Smith", .Phone = "1188"}


    Private Sub btnSendToServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToServer.Click
        Try
            If Sock.CtlState <> MSWinsockLib.StateConstants.sckClosed Then
                Sock.Close()
                Application.DoEvents()
            End If
            Sock.RemoteHost = "10.211.55.2"
            Sock.RemotePort = 7777
            Sock.Connect()
            Dim ser As New Xml.Serialization.XmlSerializer(GetType(Info))
            Dim ms As New MemoryStream

            ser.Serialize(ms, oInfo)

            Dim data As Byte()
            ReDim data(ms.Length - 1)
            ms.Position = 0
            ms.Read(data, 0, ms.Length)

            Application.DoEvents()
            Sock.SendData(data)
            Application.DoEvents()

            Dim outStr As String
            Dim s As New System.Text.StringBuilder

            s.Append(System.Text.ASCIIEncoding.ASCII.GetString(data, 0, data.Length()))
            outStr = s.ToString

            Log(outStr)
            Log("Send to server.")

            ser = Nothing
            ms = Nothing
            Erase data

            Sock.Close()
            Application.DoEvents()
        Catch ex As Exception
            Log("Socket error:" & ex.Message)

        End Try


    End Sub

    Private Sub Log(ByVal msg As String)
        txtInfo.Text = txtInfo.Text & msg & vbCrLf
        txtInfo.SelectionStart = Len(txtInfo.Text) - 1
        txtInfo.SelectionLength = Len(txtInfo.Text)
        txtInfo.ScrollToCaret()
    End Sub

End Class
