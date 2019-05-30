<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RS232 = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSMIFileSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbCOM = New System.Windows.Forms.ComboBox()
        Me.btnBAL = New System.Windows.Forms.Button()
        Me.tbReceive = New System.Windows.Forms.TextBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.rtbDataRecevied = New System.Windows.Forms.RichTextBox()
        Me.txtBALOrder = New System.Windows.Forms.TextBox()
        Me.txtDemoOrder = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 217)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnStart.Location = New System.Drawing.Point(302, 60)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 33)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "連線"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(668, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RS232
        '
        Me.RS232.BaudRate = 115200
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIFileSystem, Me.TSMIConnection})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1271, 35)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSMIFileSystem
        '
        Me.TSMIFileSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIOpenFile})
        Me.TSMIFileSystem.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TSMIFileSystem.Name = "TSMIFileSystem"
        Me.TSMIFileSystem.Size = New System.Drawing.Size(91, 31)
        Me.TSMIFileSystem.Text = "檔案(&F)"
        '
        'TSMIOpenFile
        '
        Me.TSMIOpenFile.Name = "TSMIOpenFile"
        Me.TSMIOpenFile.Size = New System.Drawing.Size(168, 32)
        Me.TSMIOpenFile.Text = "開啟舊檔"
        '
        'TSMIConnection
        '
        Me.TSMIConnection.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TSMIConnection.Name = "TSMIConnection"
        Me.TSMIConnection.Size = New System.Drawing.Size(94, 31)
        Me.TSMIConnection.Text = "連結(&C)"
        '
        'cmbCOM
        '
        Me.cmbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCOM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCOM.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmbCOM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCOM.FormattingEnabled = True
        Me.cmbCOM.Location = New System.Drawing.Point(302, 12)
        Me.cmbCOM.Name = "cmbCOM"
        Me.cmbCOM.Size = New System.Drawing.Size(94, 29)
        Me.cmbCOM.TabIndex = 4
        '
        'btnBAL
        '
        Me.btnBAL.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnBAL.Location = New System.Drawing.Point(302, 115)
        Me.btnBAL.Name = "btnBAL"
        Me.btnBAL.Size = New System.Drawing.Size(94, 34)
        Me.btnBAL.TabIndex = 5
        Me.btnBAL.Text = "BAL"
        Me.btnBAL.UseVisualStyleBackColor = True
        '
        'tbReceive
        '
        Me.tbReceive.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbReceive.Location = New System.Drawing.Point(668, 256)
        Me.tbReceive.Name = "tbReceive"
        Me.tbReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbReceive.Size = New System.Drawing.Size(297, 33)
        Me.tbReceive.TabIndex = 6
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnHome.Location = New System.Drawing.Point(302, 231)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(94, 34)
        Me.btnHome.TabIndex = 5
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnDemo
        '
        Me.btnDemo.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnDemo.Location = New System.Drawing.Point(302, 172)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(94, 34)
        Me.btnDemo.TabIndex = 5
        Me.btnDemo.Text = "Demo 5"
        Me.btnDemo.UseVisualStyleBackColor = True
        '
        'rtbDataRecevied
        '
        Me.rtbDataRecevied.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDataRecevied.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rtbDataRecevied.Location = New System.Drawing.Point(40, 425)
        Me.rtbDataRecevied.Name = "rtbDataRecevied"
        Me.rtbDataRecevied.ReadOnly = True
        Me.rtbDataRecevied.Size = New System.Drawing.Size(1198, 252)
        Me.rtbDataRecevied.TabIndex = 9
        Me.rtbDataRecevied.Text = ""
        '
        'txtBALOrder
        '
        Me.txtBALOrder.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtBALOrder.Location = New System.Drawing.Point(433, 115)
        Me.txtBALOrder.Name = "txtBALOrder"
        Me.txtBALOrder.Size = New System.Drawing.Size(100, 35)
        Me.txtBALOrder.TabIndex = 10
        '
        'txtDemoOrder
        '
        Me.txtDemoOrder.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtDemoOrder.Location = New System.Drawing.Point(433, 172)
        Me.txtDemoOrder.Name = "txtDemoOrder"
        Me.txtDemoOrder.Size = New System.Drawing.Size(100, 35)
        Me.txtDemoOrder.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 688)
        Me.Controls.Add(Me.txtDemoOrder)
        Me.Controls.Add(Me.txtBALOrder)
        Me.Controls.Add(Me.rtbDataRecevied)
        Me.Controls.Add(Me.tbReceive)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBAL)
        Me.Controls.Add(Me.cmbCOM)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RS232 As System.IO.Ports.SerialPort
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TSMIFileSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIConnection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbCOM As System.Windows.Forms.ComboBox
    Friend WithEvents btnBAL As System.Windows.Forms.Button
    Friend WithEvents tbReceive As System.Windows.Forms.TextBox
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnDemo As System.Windows.Forms.Button
    Friend WithEvents rtbDataRecevied As System.Windows.Forms.RichTextBox
    Friend WithEvents txtBALOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtDemoOrder As System.Windows.Forms.TextBox

End Class
