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
using System.Reflection;
using System.Configuration;

namespace Sd1Tool
{
    enum RtnKey
    {
        Enter = 0,
        CtrlEnter = 1
    }
    public partial class Main : Form
    {
        String UpdateLog = @"新内容：
1.新增更新检测
2.新增更新提示
3.新增降级检测
4.新增降级提示
5.新手教程(绝对不是懒得做才出错的 XD)";
        Version NowVersion = Assembly.GetExecutingAssembly().GetName().Version;
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
        private bool Upgrade()
        { if (NowVersion > Properties.Settings.Default.Version) { return true; } else { return false; } }
        private bool Demotion()
        { if (NowVersion < Properties.Settings.Default.Version) { return true; } else { return false; } }
        List<String> EmjLite = new List<String> { "OvO", "$o$", "XvX", "QAQ", "qvq", "AvA", "AwA", "xd", "XD", "XDD" };
        public Main()
        {
            if (Properties.Settings.Default.Version == null)
            {
                Properties.Settings.Default.Version = NowVersion;
                Random ran = new Random();
                MessageBox.Show("新手教程被吃了！\n" + EmjLite[ran.Next(100) % EmjLite.Count], "糟糕！出错了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ = EmjLite;
                _ = ran;
                goto Init;
            }
            if (Upgrade())
            {
                MessageBox.Show(UpdateLog, Properties.Settings.Default.Version + " -> " + NowVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Demotion())
                {
                    DialogResult msresult = MessageBox.Show("降级会导致程序数据无法加载或丢失？\n确定要继续吗？", "降级", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msresult == DialogResult.Yes)
                    { goto Init; }
                    else
                    { Application.Exit(); }
                }
            }
            Init:
            if (Properties.Settings.Default.Version != NowVersion)
            {
                Properties.Settings.Default.Version = NowVersion;
            }
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
            Properties.Settings.Default.Save();
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
