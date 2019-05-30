using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Globalization;

namespace MilaraRobotControl
{
    class ComConnection
    {
        SerialPort ComConnect;

        public void ConnectSet(string portname)
        {
            ComConnect = new SerialPort(portname, 19200, Parity.None, 8, StopBits.One);
            ComConnect.Encoding = Encoding.Default;
        }

        public void Open()
        {
            ComConnect.Open();
        }

        public void Close()
        {
            ComConnect.Close();
        }

        public bool IsOpen()
        {
            bool openChk = ComConnect.IsOpen;
            return openChk;
        }

        public void Write(byte[] input, int start, int length)
        {
            ComConnect.Write(input, start, length);
        }

        public void DiscardInBuffer()
        {
            ComConnect.DiscardInBuffer();
        }

        //public char[] Read
    }
}
