Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Net
Imports System.IO.Ports
Imports System.Text
Imports System.Threading




Public Class frmMain
    Dim capturez As Capture = New Capture
    Dim rgbImg(,,) As Integer
    Dim grayImg(,) As Integer
    Dim Astr As String


    Delegate Sub setTextCallBack(ByVal inputString As String)




    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim imagez As Image(Of Bgr, Byte) = capturez.QueryFrame()
        PictureBox1.Image = imagez.ToBitmap

        'Dim InString As String
        'InString = ""
        'If RS232.IsOpen() Then

        '    RS232.ReadTimeout = 1000
        '    InString = RS232.ReadExisting()


        '    If InString Is Nothing Then
        '        Exit Sub

        '    Else
        '        tbReceive.Text = InString

        '    End If

        'End If

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click

        Try

            RS232.PortName = cmbCOM.SelectedItem.ToString
            RS232.Open()
        Catch ex As Exception

            Dim nameRS232 As String
            nameRS232 = RS232.PortName
            MsgBox("通訊" & nameRS232 & "已使用")


        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ' 搜尋 BitmapData.Scan0 可得程式碼
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"
        If (ofd.ShowDialog = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            PictureBox1.Width = PictureBox1.Image.Width
            PictureBox1.Height = PictureBox1.Image.Height
            ReDim rgbImg(PictureBox1.Width, PictureBox1.Height, 2)
            ReDim grayImg(PictureBox1.Width, PictureBox1.Height)
            ' Create a new bitmap.
            'Dim bmp As New Bitmap(ofd.FileName)
            Dim bmp As Bitmap = PictureBox1.Image
            ' Lock the bitmap’s bits.
            Dim rect As New Rectangle(0, 0, bmp.Width, bmp.Height)
            Dim bmpData As BitmapData = bmp.LockBits( _
            rect, _
            Drawing.Imaging.ImageLockMode.ReadWrite, _
            bmp.PixelFormat _
            )
            ' Get the address of the first line.
            Dim ptr As IntPtr = bmpData.Scan0
            ' Declare an array to hold the bytes of the bitmap.
            ' This code is specific to a bitmap with 24 bits per pixels.
            ' Stride = bmp.Width * 3
            Dim bytes As Integer = bmpData.Stride * bmp.Height
            Dim rgbValues(bytes - 1) As Byte
            ' Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy( _
            ptr, rgbValues, 0, bytes _
            )
            ' 轉換至 rgbImg
            Dim x As Integer, y As Integer
            x = 0 : y = 0
            For counter As Integer = 0 To rgbValues.Length - 1 Step 3
                rgbImg(x, y, 0) = rgbValues(counter)
                rgbImg(x, y, 1) = rgbValues(counter + 1)
                rgbImg(x, y, 2) = rgbValues(counter + 2)
                grayImg(x, y) = ( _
                rgbImg(x, y, 0) + _
                rgbImg(x, y, 1) + _
                rgbImg(x, y, 2) _
                ) / 3
                x += 1
                If x = PictureBox1.Width Then
                    x = 0
                    y += 1
                End If
            Next
            '可在以下紅色區域對 rgbImg 或 grayImg 或 rgbValues 進行影像處裡
            ' Set every third value to 255. A 24bpp image will look red.
            '(藍色濾鏡:0, 綠色濾鏡:1, 紅色濾鏡:2)
            For counter As Integer = 2 To rgbValues.Length - 1 Step 3
                rgbValues(counter) = 255
            Next
            x = 0 : y = 0
            For counter As Integer = 0 To rgbValues.Length - 1 Step 3
                '還原彩色影像
                rgbValues(counter) = rgbImg(x, y, 0)
                rgbValues(counter + 1) = rgbImg(x, y, 1)
                rgbValues(counter + 2) = rgbImg(x, y, 2)
                '還原灰階影像
                'rgbValues(counter) = grayImg(x, y)
                'rgbValues(counter + 1) = grayImg(x, y)
                'rgbValues(counter + 2) = grayImg(x, y)
                x += 1
                If x = PictureBox1.Width Then
                    x = 0
                    y += 1
                End If
            Next
            ' Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy( _
            rgbValues, 0, ptr, bytes _
            )
            ' Unlock the bits.
            bmp.UnlockBits(bmpData)
            ' Draw the modified image.
            PictureBox1.Image = Image.FromHbitmap(bmp.GetHbitmap())
            ' 存檔
            bmp.Save("c:\test1.jpg", ImageFormat.Jpeg)
        End If


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TSMIFileSystem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles TSMIConnection.Click

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmbCOM_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCOM.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For Each sp As String In SerialPort.GetPortNames
            cmbCOM.Items.Add(sp)
        Next
        cmbCOM.Sorted = True
        cmbCOM.SelectedIndex = 0
        RS232.PortName = cmbCOM.SelectedItem.ToString

        RS232.Encoding = Encoding.Default

    End Sub

    Private Sub btnBAL_Click(sender As System.Object, e As System.EventArgs) Handles btnDemo.Click
        Dim cmdDemo As String
        cmdDemo = "demo "

        If Not RS232.IsOpen Then
            MessageBox.Show("Error 尚未連線")
        Else


            RS232.Write(cmdDemo.ToString & txtDemoOrder.Text & vbCrLf)


        End If












    End Sub
   
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        Dim InString As String
        InString = ""
        Try
            RS232.ReadTimeout = 1000
            InString += RS232.ReadExisting

            If InString Is Nothing Then
                Exit Sub

            Else
                tbReceive.Text = InString

            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub btnBAL_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBAL.Click

        Dim cmdBAL = "BAL"
        'Dim BALOrder As Integer = txtBALOrder.Text - 1
        'Dim checkDataRecieved As Boolean


        If Not RS232.IsOpen Then
            MessageBox.Show("Error")
        Else

            Try
                ' manyBAL(txtBALOrder.Text)
                For i = 0 To txtBALOrder.Text - 1
                    RS232.Write(cmdBAL.ToString & vbCrLf)

                    System.Threading.Thread.Sleep(15000)
                Next

            Catch ex As Exception
                RS232.Write(cmdBAL.ToString & vbCrLf)
            End Try



        End If


        'For i = 0 To 
        '    RS232.Write(cmdBAL.ToString & vbCrLf)
        '    Do Until checkDataRecieved




        '    Loop


        '    Next

        'End If

    End Sub

    Private Sub btnHome_Click(sender As System.Object, e As System.EventArgs) Handles btnHome.Click
        Dim cmdHome As String


        cmdHome = "hom"

        If Not RS232.IsOpen Then
            MessageBox.Show("Error")
        Else


            RS232.Write(cmdHome.ToString & vbCrLf)
        End If
    End Sub

    Private Sub RS232_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles RS232.DataReceived
        If e.EventType <> SerialData.Chars Then Exit Sub

        Dim inData As String = RS232.ReadExisting
        'displaytext(inData)


    End Sub

    'Private Sub displaytext(ByVal comData As String)
    '    If Me.rtbDataRecevied.InvokeRequired Then
    '        Dim d As New setTextCallBack(AddressOf showString)
    '        Me.Invoke(d, New Object() {comData})
    '    Else
    '        showString(comData & vbNewLine)
    '    End If
    'End Sub
    Private Sub reBal(ByVal orderBal As Integer)
        Dim cmdReBal As String
        cmdReBal = "BAL"
        Try
            RS232.Write(cmdReBal.ToString & vbCrLf)
            For i = 0 To orderBal - 1

                'If Me.rtbDataRecevied.InvokeRequired Then
                '    Dim d1 As New setTextCallBack(AddressOf showString)
                '    Me.Invoke(d1, New Object() {orderBal})
                If Me.rtbDataRecevied.InvokeRequired Then
                    Dim d2 As New setTextCallBack(AddressOf manyBAL)
                    Me.Invoke(d2, New Object() {orderBal})
                Else

                End If
                'End If

            Next
        Catch ex As Exception
            RS232.Write(cmdReBal.ToString & vbCrLf)
        End Try

    End Sub

    Private Sub showString(ByVal comData As String)

        rtbDataRecevied.Text += comData

    End Sub

    Private Sub manyBAL(ByVal orderOfManyBal As Integer)
        Dim cmdReBal As String
        cmdReBal = "BAL"

    End Sub
    Private Sub txtDataReceived_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtBALOrder_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBALOrder.TextChanged

    End Sub

    Private Sub rtbDataRecevied_TextChanged(sender As System.Object, e As System.EventArgs) Handles rtbDataRecevied.TextChanged
        rtbDataRecevied.SelectionStart = rtbDataRecevied.TextLength

        rtbDataRecevied.ScrollToCaret()

    End Sub
End Class
