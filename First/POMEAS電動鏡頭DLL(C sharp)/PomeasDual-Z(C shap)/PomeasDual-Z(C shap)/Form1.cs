using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PomeasDual_Z_C_shap_
{
    public partial class Pomeas : Form
    {
        [DllImport("PomeasDualDll.dll")]
        public static extern bool Pomeas_OpenComm(int DrvIndex,int port);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_CloseComm(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveLimit(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveHome(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveStop(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveUp(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveDown(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveRest(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern void Pomeas_MoveGoto(int DrvIndex,long dest);

        [DllImport("PomeasDualDll.dll")]
        public static extern int Pomeas_MoveStatus(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern int Pomeas_MoveMaxLength(int DrvIndex);

        [DllImport("PomeasDualDll.dll")]
        public static extern int Pomeas_MovePos(int DrvIndex);

        public Pomeas()
        {
            InitializeComponent();
        }

        private void Pomeas_Load(object sender, EventArgs e)
        {
            mComSelectcomboBox.SelectedIndex = 0;
        }

        private void mComSelectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pomeas_CloseComm(0);
            if (!Pomeas_OpenComm(0,mComSelectcomboBox.SelectedIndex))
            {
                MessageBox.Show("打开串口失败！");
                return;
            }

            int mMaxLength = Pomeas_MoveMaxLength(0);

            string _strMaxLength = Convert.ToString(mMaxLength);
            MessageBox.Show(_strMaxLength);

            int mPos = Pomeas_MovePos(0);

            string _strPos = Convert.ToString(mPos);
            MessageBox.Show(_strPos);

            int mStatus = Pomeas_MoveStatus(0);

            string _strStatus = Convert.ToString(mStatus);
            MessageBox.Show(_strStatus);
        }

        private void Pomeas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pomeas_CloseComm(0);
        }
    }
}
