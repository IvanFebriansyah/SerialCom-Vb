<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnScan = New System.Windows.Forms.Button()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbBaud = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnDiscon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnScan
        '
        Me.BtnScan.Location = New System.Drawing.Point(12, 22)
        Me.BtnScan.Name = "BtnScan"
        Me.BtnScan.Size = New System.Drawing.Size(93, 26)
        Me.BtnScan.TabIndex = 0
        Me.BtnScan.Text = "Scan Port"
        Me.BtnScan.UseVisualStyleBackColor = True
        '
        'CmbPort
        '
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(120, 25)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(176, 23)
        Me.CmbPort.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baud Rate :"
        '
        'CmbBaud
        '
        Me.CmbBaud.AutoCompleteCustomSource.AddRange(New String() {"1200", "2400", "4800", "19200", "38400", "57600", "115200"})
        Me.CmbBaud.FormattingEnabled = True
        Me.CmbBaud.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.CmbBaud.Location = New System.Drawing.Point(120, 54)
        Me.CmbBaud.Name = "CmbBaud"
        Me.CmbBaud.Size = New System.Drawing.Size(176, 23)
        Me.CmbBaud.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 53)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Connect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnDiscon
        '
        Me.BtnDiscon.Location = New System.Drawing.Point(21, 89)
        Me.BtnDiscon.Name = "BtnDiscon"
        Me.BtnDiscon.Size = New System.Drawing.Size(75, 53)
        Me.BtnDiscon.TabIndex = 5
        Me.BtnDiscon.Text = "Disconnect"
        Me.BtnDiscon.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 184)
        Me.Controls.Add(Me.BtnDiscon)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbBaud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbPort)
        Me.Controls.Add(Me.BtnScan)
        Me.Name = "Form1"
        Me.Text = "SerialCom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnScan As Button
    Friend WithEvents CmbPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbBaud As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnDiscon As Button
End Class
