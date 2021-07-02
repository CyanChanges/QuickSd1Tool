using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        static readonly Version NowVersion = Assembly.GetExecutingAssembly().GetName().Version;
        public RegistryVersion RegVerSaver = new RegistryVersion(NowVersion);
        public bool CheckRun() { return Control.IsKeyLocked(Keys.CapsLock); }
        private About FAbout = new About();
        String UpdateLog = @"新内容：
1.修改了▩▩▩▩▩的▩▩
   - 将会在▩▩之日时候▩▩▩▩";
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        Size ssize;
        RtnKey Rtn = RtnKey.CtrlEnter;
        private void BackKey()
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,(UIntPtr)0);
            _ = KEYEVENTF_EXTENDEDKEY;
            _ = KEYEVENTF_KEYUP;
        }
        private void CkUp() 
        {
            if (Upgrade())
            {
                MessageBox.Show(UpdateLog, RegVerSaver.Version + " -> " + NowVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                goto Init;
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
            if (RegVerSaver.Version == null)
            {
                Random ran = new Random();
                MessageBox.Show("新手教程被吃了！\n" + EmjLite[ran.Next(100) % EmjLite.Count], "糟糕！出错了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ = EmjLite;
                _ = ran;
            }
            Init:;
        }
        private void ChangeVer() 
        {
            if (RegVerSaver.Version != NowVersion)
            {
                RegVerSaver.Version = new Version(NowVersion.Major, NowVersion.Minor, NowVersion.Build, NowVersion.Revision);
                RegVerSaver.Setvalue();
            }
            Properties.Settings.Default.Save();
        }
        private void UnknownBtnctl() 
        {
            DateTime Now = DateTime.Now;
            if (Now.Month is 4 && Now.Day is 1)
            {
                DESTORY.Visible = true;
                DESTORY.Enabled = false;
            }
            else { DESTORY.Visible = false; }
        }
        private bool Upgrade()
        { if (NowVersion > RegVerSaver.Version) { return true; } else { return false; } }
        private bool Demotion()
        { if (NowVersion < RegVerSaver.Version) { return true; } else { return false; } }
        List<String> EmjLite = new List<String> { "OvO", "$o$", "XvX", "QAQ", "qvq", "AvA", "AwA", "xd", "XD", "XDD" };
        public Main()
        {
            //MessageBox.Show(RegVerSaver.Version.ToString());
            CkUp();
            InitializeComponent();
            UnknownBtnctl();
            ChangeVer();
            Text += " " + NowVersion;
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
            Properties.Settings.Default.Sends++;
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
            if (Opacity != 0.42)
            {
                lockstats.ForeColor = Color.Green;
            }
            chkkeyleave.Enabled = true;
        }

        private void chkkeyleave_Tick(object sender, EventArgs e)
        {
            if (!timeschkbox.Checked)
            {
                runtimes = 0;
                if (CheckRun())
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

        private void Times_Tick(object sender, EventArgs e)
        {
            if (!(sdtimesnud.Value > runtimes))
            {
                DosdBar.Value = runtimes;
                sdkeys.Enabled = false;
                BackKey();
                runtimes = 0;
            }
            if (CheckRun() && sdtimesnud.Value > runtimes)
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
            RegVerSaver.Close();
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
            DESTORY.Visible = true;
            timeschkbox.Enabled = false;
            delaynud.Enabled = false;
            delaynud.Value = 5;
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
            Form achs = new Achievements();
            achs.FormClosed += new FormClosedEventHandler(ActiveAchBtn);
            btnself.Enabled = false;
            achs.ShowDialog();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            if (!FAbout.Visible)
            {
                FAbout.FormClosed += new FormClosedEventHandler(FAbout_FormClosed);
                ((Button)sender).Enabled = false;
                FAbout.ShowDialog();
            }
        }

        private void FAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            AboutBtn.Enabled = true;
        }

        /// <summary>
        /// 神奇  MagicKey  类，勿动！
        /// ———— Cyq20100313
        /// </summary>
        class MagicKey
        {
            public void Test()
            {
                // Magic codes Init Start
                MagicKey.MasterObj master = new MagicKey.MasterObj { MasterName = "Cyq20100313", MagicPower = 2333333333.333 };
                MagicKey magickey = new MagicKey(master) { keyname = "The Magic Key", MagicPower = 233333.33F };
                // 中二的技能增加了  ！ 
                magickey.Skill.Add(" T h e  C o n t r o l l e r ");
                master.Skill.Add("T h e   M A S T E R");
                MagicKey.MasterObj BadBoy = new MagicKey.MasterObj { MasterName = "popbob" };
                BadBoy.Skill.Add(" O p   P l u g i n ! ");
                BadBoy.Skill.Add(" H a c k e r ");
                //badboy.Out(); 
                // Magic codes Init End
            }
            public enum DoAffects
            {
                Nothing = 0,
                Error = 1,
                Successful = 2,
                NoOwn = 3
            }
            public class MasterObj
            {
                public DoAffects Fight(MasterObj MasterObj1, MasterObj MasterObj2)
                {
                    if (MasterObj1.Tags.Contains("Dead")  || MasterObj2.Tags.Contains("Dead")  || MasterObj1.Tags.Contains("Fighting") || MasterObj2.Tags.Contains("Fighting")){ return DoAffects.Error; }
                    MasterObj1.Tags.Add("Fighting");
                    MasterObj2.Tags.Add("Fighting");
                    return DoAffects.Successful;
                }
                public DoAffects Fight(MasterObj targetMasterObj)
                {
                    if (Tags.Contains("Dead")  || targetMasterObj.Tags.Contains("Dead") || Tags.Contains("Fighting") || targetMasterObj.Tags.Contains("Fighting")){ return DoAffects.Error; }
                    Tags.Add("Fighting");
                    targetMasterObj.Tags.Add("Fighting");
                    return DoAffects.Successful;
                }
                string Name = "No Master";
                public Double MagicPower = int.MinValue;
                public List<string> Skill = new List<string>();
                public String MasterName { get { return this.Name; } set { this.Name = value; } }
                public List<MagicKey> OwnKeys = new List<MagicKey>();
                public List<String> Tags = new List<String>();
                public void Out()
                { Tags.Add("Dead"); MessageBox.Show("你的决心碎了亿地！", "提示 - UNDER TOOLS"); }
                public DoAffects UseKey(MagicKey ownkey, String SkillName)
                {
                    if (!(ownkey.MasterName == Name && ownkey.MasterObject == this) && this.OwnKeys.Exists(t => t == ownkey))
                    { return DoAffects.NoOwn; }
                    if (ownkey.Skill.Exists(t => t == SkillName))
                    {
                        return DoAffects.Successful;
                    }
                    else { return DoAffects.Nothing; }
                }
            }
            public string keyname = "Magic Key";
            public List<String> Skill = new List<String>();
            public float MagicPower;
            readonly MasterObj MasterObject;
            public string MasterName;
            public MagicKey(MasterObj master)
            {
                master.OwnKeys.Add(this);
                MasterObject = master;
                MasterName = MasterObject.MasterName;
            }
            public MagicKey()
            {
                MasterObject = new MasterObj();
                MasterName = MasterObject.MasterName;
            }
        }
        public void Counter_Closed(object sender, FormClosedEventArgs e)
        {
            CountBtn.Enabled = true;
        }
        private void CountBtn_Click(object sender, EventArgs e)
        {
            Counters counter = new Counters();
            counter.FormClosed += new FormClosedEventHandler(Counter_Closed);
            ((Button)sender).Enabled = false;
            counter.ShowDialog();
        }
        public class RegistryVersion 
        {
            public Version Version;
            private static RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey regcontroller;
            Version SelfVersion;
            public RegistryVersion(Version NowVersion)
            {
                SelfVersion = NowVersion;
                RegistryKey ck = HKCU.OpenSubKey("SOFTWARE\\Sd1Tool\\", true);
                if (ck != null)
                { regcontroller = ck; }
                else
                { regcontroller = HKCU.CreateSubKey("SOFTWARE\\Sd1Tool\\", true); }
                object value = regcontroller.GetValue("Version");
                if (value == null)
                { regcontroller.SetValue("Version", SelfVersion); Version = null; }
                else 
                { Version = new Version(value.ToString()); }
            }
            public void Setvalue()
            {
                regcontroller.SetValue("Version", SelfVersion);
                Version = SelfVersion;
            }
            public void Setvalue(Version NewVersion)
            {
                regcontroller.SetValue("Version", NewVersion);
                Version = NewVersion;
            }
            public void Close()
            {regcontroller.Close();}
        }
        Random Destoryubtn_rand = new Random();
        private void DESTORY_MouseEnter(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            int posx = Destoryubtn_rand.Next() % (Size.Width - 20) -10;
            int posy = Destoryubtn_rand.Next() % Size.Height;
            while (true) {
                posy = Destoryubtn_rand.Next() % Size.Height;
               if (posy >= 30) { continue; } else { break; }
            }
            Point point = new Point(posx, posy);
            ((Button)sender).Location = point;
            //MessageBox.Show(point.ToString());
        }

        private void DESTORY_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
