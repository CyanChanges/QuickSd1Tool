using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sd1Tool
{
    enum RtnKey
    {
        Enter = 0,
        CtrlEnter = 1
    }
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        Size ssize;
        RtnKey Rtn = RtnKey.CtrlEnter;
        private void CapsLock()
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,(UIntPtr)0);
        }
        private void timessd()
        {
            while (timeschkbox.Checked)
            {
                if (Control.IsKeyLocked(Keys.CapsLock) && sdtimesnud.Value >= runtimes)
                {
                    sdkeys.Enabled = true;
                }
                else
                { sdkeys.Enabled = false; }
            }
            return;
        }
        public Form1()
        {
            InitializeComponent();
            ssize = Size;
        }
        readonly Dictionary<RtnKey, String> keydict = new Dictionary<RtnKey, String>
        {
                {RtnKey.CtrlEnter, "^{Enter}"},
                {RtnKey.Enter, "{Enter}"}
        };
        int runtimes = 0;
        private void sdkey_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(QDText.Text + keydict[Rtn]);
            runtimes++;
        }

        private void RtnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Select = RtnType.SelectedIndex;
            if (Select == -1)
            {
                Rtn = RtnKey.CtrlEnter;
            }
            else if (Select == 0)
            {
                Rtn = RtnKey.CtrlEnter;
            }
            else if (Select == 1)
            {
                Rtn = RtnKey.Enter;
            }
        }

        private void Form1_Active(object sender, EventArgs e)
        {
            lockstats.Text = "Stopped";
            lockstats.ForeColor = Color.Red;
            chkkeyleave.Enabled = false;
        }
        private void Form1_DeActive(object sender, EventArgs e)
        {
            lockstats.Text = "Running";
            lockstats.ForeColor = Color.Green;
            chkkeyleave.Enabled = true;
        }

        private void chkkeyleave_Tick(object sender, EventArgs e)
        {
            if (!timeschkbox.Checked)
            {
                runtimes = 0;
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    sdkeys.Enabled = true;
                }
                else
                {
                    sdkeys.Enabled = false;
                }
            }

        }

        private void delaynud_ValueChanged(object sender, EventArgs e)
        {
            if (delaynud.Value < 2)
            {
                delaynud.Value = 100;
            }
            sdkeys.Interval = (int)delaynud.Value;
            if (sdkeys.Interval < 2)
            {
                sdkeys.Interval = 100;
            }
        }
        Thread thread1;
        private void timeschkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (timeschkbox.Checked)
            { thread1 = new Thread(new ThreadStart(timessd)); thread1.Start(); Size = new Size(Size.Width, ssize.Height + 45); }
            else 
            { thread1.Abort(); Size = new Size(Size.Width, ssize.Height); }
        }
    }
}
