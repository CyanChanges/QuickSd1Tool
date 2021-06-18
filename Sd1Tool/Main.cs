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
    public partial class Main : Form
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
            _ = KEYEVENTF_EXTENDEDKEY;
            _ = KEYEVENTF_KEYUP;
        }
        public Main()
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
            else
            { times.Enabled = true; }
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
        private void timeschkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (timeschkbox.Checked)
            { Size = new Size(Size.Width, ssize.Height + 46); }
            else 
            { Size = new Size(Size.Width, ssize.Height); }
        }

        private void times_Tick(object sender, EventArgs e)
        {
            if (!(sdtimesnud.Value > runtimes))
            {
                DosdBar.Value = runtimes;
                sdkeys.Enabled = false;
                CapsLock();
                runtimes = 0;
            }
            if (Control.IsKeyLocked(Keys.CapsLock) && sdtimesnud.Value > runtimes)
            {
                DosdBar.Maximum = (int)sdtimesnud.Value;
                sdkeys.Enabled = true;
                DosdBar.Value = runtimes;
            }
            else { sdkeys.Enabled = false; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ = runtimes;
            _ = Rtn;
            _ = Rtn;
            _ = this;
        }

        private void DESTORY_Click(object sender, EventArgs e)
        {
            Opacity = 0.42;
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            DESTORY.Enabled = false;
            timeschkbox.Enabled = false;
            delaynud.Enabled = false;
            delaynud.Value = 2910;
            _ = this;
            if (!Properties.Settings.Default.Achievement1)
            {
                Properties.Settings.Default.Achievement1 = true;
            }
        }
        public void ActiveAchBtn(object sender, FormClosedEventArgs e)
        {
            AchBtn.Enabled = true;
        }
        private void AchBtn_Click(object sender, EventArgs e)
        {
            Button btnself = (Button)sender;
            btnself.Enabled = false;
            Form achs = new Achievements();
            achs.FormClosed += new FormClosedEventHandler(ActiveAchBtn);
            achs.Show();
        }
    }
}
