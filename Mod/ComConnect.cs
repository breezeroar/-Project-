using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Globalization;

namespace HPSC_1005_4_LS
{
    class LightSource
    {
        SerialPort ComConnect;
        ArrayList brightness = new ArrayList();

        public void ConnectSet(string portname)
        {
            ComConnect = new SerialPort(portname,19200,Parity.None,8,StopBits.One);
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

        public void ChangeBrightness(string idInput,int L1, int L2, int L3, int L4)
        {
            //read the input value.
            brightness.Add(0x40);//mark
            brightness.Add(0x0);//length
            brightness.Add(0x03);//deviceNO.

            byte id = byte.Parse(idInput, NumberStyles.HexNumber);
            brightness.Add(id);//deviceID

            if (L1>=0)
            {
                brightness.Add(0x1a);
                brightness.Add(0x0);
                brightness.Add(L1);
            }
            if (L2>=0)
            {
                brightness.Add(0x1a);
                brightness.Add(0x1);
                brightness.Add(L2);
            }
            if (L3>=0)
            {
                brightness.Add(0x1a);
                brightness.Add(0x2);
                brightness.Add(L3);
            }
            if (L4>=0)
            {
                brightness.Add(0x1a);
                brightness.Add(0x3);
                brightness.Add(L4);
            }

            int chkSum = 0x0;
            brightness[1] = brightness.Count - 2;

            for (int i = 0; i < brightness.Count; i++)
            {
                chkSum = chkSum + Convert.ToInt16(brightness[i]);
            }

            chkSum = chkSum % 0x100;
            brightness.Add(Convert.ToByte(chkSum));
            
            //write the input value.
            byte[] changebri = new byte[brightness.Count];

            for (int i = 0; i < changebri.Length; i++)
            {
                changebri[i] = Convert.ToByte(brightness[i]);
            }

            ComConnect.Write(changebri, 0, changebri.Length);
            brightness.Clear();
            ComConnect.DiscardInBuffer();
        }

        public byte[] ShowBrightness(string currentID)
        {
            byte[] readID = { 0x40, 0x04, 0x03, 0, 0x31, 0xff, 0};
            readID[3] = byte.Parse(currentID, NumberStyles.HexNumber);//deviceID

            for (int i = 0; i < readID.Length-1; i++)
            {
                readID[6] = (byte)(readID[6] + readID[i]);
            }//checkSum
            readID[6] = (byte)(readID[6] % 0x100);
            ComConnect.Write(readID, 0, readID.Length);

            byte[] readFromDevice = new byte[11];
            readFromDevice[10] = 0;

            if (ComConnect.BytesToRead > 0)
            {
                ComConnect.Read(readFromDevice, 0, readFromDevice.Length);
                readFromDevice[10] = 1;
            }

            return readFromDevice;
        }

        public void ChangeID(string ChangeSrc,string ChangeTo)
        {
            byte[] idChange = {0x40,0x4,0x3,0,0x9,0,0};
            idChange[3] = byte.Parse(ChangeSrc, NumberStyles.HexNumber);
            idChange[5] = byte.Parse(ChangeTo, NumberStyles.HexNumber);

            for (int i = 0; i < idChange.Length-1; i++)
            {
                idChange[6] = (byte)(idChange[6] + idChange[i]);
            }

            ComConnect.Write(idChange, 0, idChange.Length);
            Array.Clear(idChange, 0, idChange.Length);
        }
    }
}
