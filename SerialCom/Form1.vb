Imports System.IO.Ports

Public Class Form1
    Dim SerialPort1 As New SerialPort()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Button2.Enabled = False
        BtnDiscon.BringToFront()

        BtnDiscon.Enabled = False
        BtnDiscon.SendToBack()

        CmbBaud.SelectedItem = "9600"
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles BtnScan.Click
        CmbPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = System.IO.Ports.SerialPort.GetPortNames()
        CmbPort.Items.AddRange(myPort)
        i = CmbPort.Items.Count
        i = i - i
        Try
            CmbPort.SelectedIndex = i
        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("com port not detected", "Warning", MessageBoxButtons.OK)
            CmbPort.Text = ""
            CmbPort.Items.Clear()
            Call Form1_Load(Me, e)
        End Try
        Button2.Enabled = True
        Button2.BringToFront()
        CmbPort.DroppedDown = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Button2.Enabled = False
        Button2.SendToBack()

        SerialPort1.BaudRate = CmbBaud.SelectedItem
        SerialPort1.PortName = CmbPort.SelectedItem

        SerialPort1.Open()

        BtnDiscon.Enabled = True
        BtnDiscon.BringToFront()
    End Sub

    Private Sub BtnDiscon_Click(sender As Object, e As EventArgs) Handles BtnDiscon.Click
        BtnDiscon.Enabled = False
        BtnDiscon.SendToBack()

        SerialPort1.Close()

        Button2.Enabled = True
        Button2.BringToFront()

    End Sub
End Class
