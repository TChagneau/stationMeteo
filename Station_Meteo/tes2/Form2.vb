Imports System
Imports System.IO.Ports
Module var
    Public h = DateTime.Now.ToString("HH:mm")
    Public d = DateTime.Now.ToString("dd_MM_yyyy")
    Public fileName As String = "data" + d + ".txt"
    Public a As Boolean = False
End Module
Public Class Form2
    Dim comPORT As String
    Dim receivedData As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next

        If System.IO.Directory.Exists("C:\Station_Meteo") = False Then
            System.IO.Directory.CreateDirectory("C:\Station_Meteo")
        End If
        'If System.IO.Directory.Exists("C:\Station_Meteo\logs") = False Then
        'System.IO.Directory.CreateDirectory("C:\Station_Meteo\logs")
        'End If
        If System.IO.Directory.Exists("C:\Station_Meteo\receptionData") = False Then
            System.IO.Directory.CreateDirectory("C:\Station_Meteo\receptionData")
        End If

        ' Dim filepath As String = "C:\Station_Meteo\logs\" + fileName
        ' If Not System.IO.File.Exists(filepath) Then
        ' System.IO.File.Create(filepath).Dispose()
        ' End If
        Dim filepath2 As String = "C:\Station_Meteo\receptionData\" + fileName
        If Not System.IO.File.Exists(filepath2) Then
            System.IO.File.Create(filepath2).Dispose()
        End If


    End Sub
    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub
    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Receptoin: ON"
            Else
                MsgBox("Choisir en premier lieu un PortCOM")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Reception: OFF"
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        h = DateTime.Now.ToString("HH:mm")
        d = DateTime.Now.ToString("dd/MM/yyyy")
        ' receivedData = ReceiveSerialData()
        trieData()
    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    'Sub saveDataLogs()
    'Dim FILE_NAME As String = "C:\Station_Meteo\logs\" + fileName
    'If System.IO.File.Exists(FILE_NAME) = True Then
    ' Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
    '        objWriter.Write(RichTextBox1.Text)
    '        objWriter.Close()
    '       MsgBox("Data sauvegardé")
    'Else
    '       MsgBox("Le fichier n'existe pas")
    '   End If
    'End Sub

    Sub saveReceptionData()
        Dim FILE_NAME As String = "C:\Station_Meteo\receptionData\" + fileName
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(Logs.Text)
            objWriter.Close()
            ' MsgBox("Data sauvegardé")
        Else
            ' MsgBox("Le fichier n'existe pas")
        End If
    End Sub

    Public Sub trieData()

        'date(xx/xx/xx)|heure(xx:xx)
        'T:xxx°C
        'H:xxx%
        'P:xxxxHpascal
        'V:xxNoeuds|D:No

        Dim receive = SerialPort1.ReadExisting()
        Dim d1, d2, d3, d4
        'Logs.AppendText("date(" & d & ")|heure(" & h & ")" & vbCrLf)

        If receive = "T" Then
            Logs.AppendText("date(" & d & ")|heure(" & h & ")" & vbCrLf)
            System.Threading.Thread.Sleep(200)
            d1 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d2 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d3 = SerialPort1.ReadExisting()
            Logs.AppendText("T:" & d1 & d2 & d3 & "°c" & vbCrLf)
            System.Threading.Thread.Sleep(200)
        ElseIf receive = "H" Then
            System.Threading.Thread.Sleep(200)
            d1 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d2 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d3 = SerialPort1.ReadExisting()
            Logs.AppendText("H:" & d1 & d2 & d3 & "%" & vbCrLf)
            System.Threading.Thread.Sleep(200)
        ElseIf receive = "P" Then
            System.Threading.Thread.Sleep(200)
            d1 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d2 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d3 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d4 = SerialPort1.ReadExisting()
            Logs.AppendText("P:" & d1 & d2 & d3 & d4 & "Hpascal" & vbCrLf)
            System.Threading.Thread.Sleep(200)
        ElseIf receive = "V" Then
            System.Threading.Thread.Sleep(200)
            d1 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d2 = SerialPort1.ReadExisting()
            Logs.AppendText("V:" & d1 & d2 & "Noeuds" & vbCrLf)
            System.Threading.Thread.Sleep(200)
        ElseIf receive = "D" Then
            System.Threading.Thread.Sleep(200)
            d1 = SerialPort1.ReadExisting()
            System.Threading.Thread.Sleep(200)
            d2 = SerialPort1.ReadExisting()
            Logs.AppendText("D:" & d1 & d2 & "      " & vbCrLf)
            System.Threading.Thread.Sleep(200)
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If System.IO.Directory.Exists("C:\Station_Meteo") = False Then
            System.IO.Directory.CreateDirectory("C:\Station_Meteo")
        End If
        ' If System.IO.Directory.Exists("C:\Station_Meteo\logs") = False Then
        'System.IO.Directory.CreateDirectory("C:\Station_Meteo\logs")
        'End If
        If System.IO.Directory.Exists("C:\Station_Meteo\receptionData") = False Then
            System.IO.Directory.CreateDirectory("C:\Station_Meteo\receptionData")
        End If

        ' Dim filepath As String = "C:\Station_Meteo\logs\" + fileName
        ' If Not System.IO.File.Exists(filepath) Then
        ' System.IO.File.Create(filepath).Dispose()
        ' End If
        Dim filepath2 As String = "C:\Station_Meteo\receptionData\" + fileName
        If Not System.IO.File.Exists(filepath2) Then
            System.IO.File.Create(filepath2).Dispose()
        End If

        saveReceptionData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'saveDataLogs()
        Try
            saveReceptionData()
            MsgBox("Données sauvegardé")
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "log: visible" Then
            RichTextBox1.Visible = True
            Button2.Text = "log: invisible"
        Else
            RichTextBox1.Visible = False
            Button2.Text = "log: visible"
        End If
    End Sub

    Private Sub RafraichirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RafraichirToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        'saveDataLogs()
        saveReceptionData()
    End Sub

    Private Sub BoutonInvisibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoutonInvisibleToolStripMenuItem.Click

        If a = False Then
            Button2.Visible = True

            a = True
        ElseIf a = True Then
            Button2.Visible = False

            a = False
        End If


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        aidevb.Show()
    End Sub

    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click
        license.Show()
    End Sub

    Private Sub OuvrirLesFichierLocauxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLesFichierLocauxToolStripMenuItem.Click
        Process.Start("explorer.exe", "C:\Station_Meteo")
    End Sub
End Class