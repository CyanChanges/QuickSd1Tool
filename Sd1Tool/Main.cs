using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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
        static readonly Version CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version;
        public RegistryVersion RegVerSaver = new RegistryVersion(CurrentVersion);
        public bool Sending = false;

        public void KeyHandler(object sender, KeyEventArgs args)
        {
            
            // Debugger.Log(0, "Info", ((Control.ModifierKeys & Keys.Control) != 0) + " " +args.KeyData.ToString() + " \n");
            if (
                (Control.ModifierKeys & Keys.Shift) != 0 
                && args.KeyCode == Keys.F2
                )


            {
                Sending = !Sending;

                KeySender.Enabled = Sending;
                if (Sending & timeschkbox.Checked)
                {
                    KeySender.Enabled = false;
                    times.Enabled = true;
                }
                else
                {
                    times.Enabled = false;
                }
            }
        }

        private KeyBoardListener keyBoardListener;
        About FAbout = new About();
        String UpdateLog = @"新内容：
1.修复版本检测存储问题";
        Size ssize;
        RtnKey Rtn = RtnKey.CtrlEnter;
        private void BackKey()
        {
            Sending = !Sending;
        }
        private bool Upgrade()
        { if (CurrentVersion > RegVerSaver.Version) { return true; } else { return false; } }
        private bool Demotion()
        { if (CurrentVersion < RegVerSaver.Version) { return true; } else { return false; } }
        List<String> EmjLite = new List<String> { "OvO", "$o$", "XvX", "QAQ", "qvq", "AvA", "AwA", "xd", "XD", "XDD" };
        
        public Main()
        {
            //MessageBox.Show(RegVerSaver.Version.ToString());

            if (Upgrade())
            {
                MessageBox.Show(UpdateLog, RegVerSaver.Version + " -> " + CurrentVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Init:
            InitializeComponent();
            keyBoardListener = new KeyBoardListener(KeyHandler);
            keyBoardListener.Start();
            if (RegVerSaver.Version != CurrentVersion)
            {
                RegVerSaver.Version = new Version(CurrentVersion.Major,CurrentVersion.Minor,CurrentVersion.Build,CurrentVersion.Revision);
                RegVerSaver.Setvalue();
            }

            Properties.Settings.Default.Save();
            Text += " " + CurrentVersion;
            ssize = Size;
        }
        readonly Dictionary<RtnKey, String> keydict = new Dictionary<RtnKey, String>
        {
                {RtnKey.CtrlEnter, "^{Enter}"},
                {RtnKey.Enter, "{Enter}"}
        };
        int runtimes = 0;
        
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
            Sending = false;
        }
        private void Form1_DeActive(object sender, EventArgs e)
        {
            // Nothing to do yet.
        }
        

        private void times_Tick(object sender, EventArgs e)
        {
            if (!(sdtimesnud.Value > runtimes))
            {
                DosdBar.Value = runtimes;
                KeySender.Enabled = false;
                BackKey();
                runtimes = 0;
            }
            if (Sending && sdtimesnud.Value > runtimes)
            {
                DosdBar.Maximum = (int)sdtimesnud.Value;
                KeySender.Enabled = true;
                DosdBar.Value = runtimes;
            }
            else { KeySender.Enabled = false; }
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
            Button BtnSelf = (Button)sender;
            Form achs = new Achievements();
            achs.FormClosed += new FormClosedEventHandler(ActiveAchBtn);
            BtnSelf.Enabled = false;
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

        /*/// <summary>
        /// 随便乱写的，勿动！
        /// </summary>
        class MagicKey
        {
            public void Test()
            {
                // Magic codes Init Start
                MagicKey.MasterObj master = new MagicKey.MasterObj();
                master.MasterName = "CyanC";
                MagicKey magickey = new MagicKey(master);
                magickey.keyname = "The Magic Key";
                magickey.Skill.Add("Controller");
                magickey.MagicPower = 233333.33F;
                master.MagicPower = 2333333333.333;
                master.Skill.Add("T h e   M A S T E R");
                //master.Out(); 
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
                string Name = "No Master";
                public Double MagicPower = int.MinValue;
                public List<string> Skill = new List<string>();
                public String MasterName { get { return this.Name; } set { this.Name = value; } }
                public List<MagicKey> OwnKeys = new List<MagicKey>();
                bool Cksame(String n, String SkillName)
                {
                    if (n == SkillName)
                    { return true; }
                    else { return false; }
                }
                public void Out()
                { // 什么玩意儿啊
                    MessageBox.Show("你的决心碎了亿地！", "提示 - UNDER TOOLS");
                }
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
            MasterObj MasterObject;
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
        }*/
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
            static RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey regcontroller;
            public RegistryVersion(Version NowVersion)
            {
                Version = NowVersion;
                RegistryKey ck = HKCU.OpenSubKey("SOFTWARE\\Sd1Tool\\", true);
                if (ck != null)
                { regcontroller = ck; }
                else
                { regcontroller = HKCU.CreateSubKey("SOFTWARE\\Sd1Tool\\", true); }
                object value = regcontroller.GetValue("Version");
                if (value == null)
                { regcontroller.SetValue("Version",NowVersion); }
            }
            public void Setvalue()
            {
                regcontroller.SetValue("Version", Version);
            }
            public void Setvalue(Version NewVersion)
            { 
                regcontroller.SetValue("Version", NewVersion);
            }
            public void Close()
            {
                regcontroller.Close();
            }
        }

        private void KeySend_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(QDText.Text + keydict[Rtn]);
            runtimes++;
            Properties.Settings.Default.Sends++;
        }

        private void TimesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (timeschkbox.Checked)
            { Size = new Size(Size.Width, ssize.Height + 46); }
            else
            { Size = new Size(Size.Width, ssize.Height); }
        }

        private void Times_Tick(object sender, EventArgs e)
        {
            if (sdtimesnud.Value >= runtimes)
            {
                DosdBar.Value = runtimes;
                KeySender.Enabled = false;
                runtimes = 0;
                BackKey();
            }
            if (Sending && sdtimesnud.Value > runtimes)
            {
                DosdBar.Maximum = (int)sdtimesnud.Value;
                KeySender.Enabled = true;
                DosdBar.Value = runtimes;
            }
            else { KeySender.Enabled = false; }
        }
    }


    class KeyboardHook
    {
        public event KeyEventHandler KeyDownEvent;
        public event KeyPressEventHandler KeyPressEvent;
        public event KeyEventHandler KeyUpEvent;

        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        static int hKeyboardHook = 0; //声明键盘钩子处理的初始值
        //值在Microsoft SDK的Winuser.h里查询
        public const int WH_KEYBOARD_LL = 13;   //线程键盘钩子监听鼠标消息设为2，全局键盘监听鼠标消息设为13
        HookProc KeyboardHookProcedure; //声明KeyboardHookProcedure作为HookProc类型
        //键盘结构
        [StructLayout(LayoutKind.Sequential)]
        public class KeyboardHookStruct
        {
            public int vkCode;  //定一个虚拟键码。该代码必须有一个价值的范围1至254
            public int scanCode; // 指定的硬件扫描码的关键
            public int flags;  // 键标志
            public int time; // 指定的时间戳记的这个讯息
            public int dwExtraInfo; // 指定额外信息相关的信息
        }
        //使用此功能，安装了一个钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);


        //调用此函数卸载钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);


        //使用此功能，通过信息钩子继续下一个钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);

        // 取得当前线程编号（线程钩子需要用到）
        [DllImport("kernel32.dll")]
        static extern int GetCurrentThreadId();

        //使用WINDOWS API函数代替获取当前实例的函数,防止钩子失效
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        public void Start()
        {
            // 安装键盘钩子
            if (hKeyboardHook == 0)
            {
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName), 0);
                //hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
                //************************************
                //键盘线程钩子
                SetWindowsHookEx(13, KeyboardHookProcedure, IntPtr.Zero, GetCurrentThreadId());//指定要监听的线程idGetCurrentThreadId(),
                //键盘全局钩子,需要引用空间(using System.Reflection;)
                //SetWindowsHookEx( 13,MouseHookProcedure,Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]),0);
                //
                //关于SetWindowsHookEx (int idHook, HookProc lpfn, IntPtr hInstance, int threadId)函数将钩子加入到钩子链表中，说明一下四个参数：
                //idHook 钩子类型，即确定钩子监听何种消息，上面的代码中设为2，即监听键盘消息并且是线程钩子，如果是全局钩子监听键盘消息应设为13，
                //线程钩子监听鼠标消息设为7，全局钩子监听鼠标消息设为14。lpfn 钩子子程的地址指针。如果dwThreadId参数为0 或是一个由别的进程创建的
                //线程的标识，lpfn必须指向DLL中的钩子子程。 除此以外，lpfn可以指向当前进程的一段钩子子程代码。钩子函数的入口地址，当钩子钩到任何
                //消息后便调用这个函数。hInstance应用程序实例的句柄。标识包含lpfn所指的子程的DLL。如果threadId 标识当前进程创建的一个线程，而且子
                //程代码位于当前进程，hInstance必须为NULL。可以很简单的设定其为本应用程序的实例句柄。threaded 与安装的钩子子程相关联的线程的标识符
                //如果为0，钩子子程与所有的线程关联，即为全局钩子
                //************************************
                //如果SetWindowsHookEx失败
                if (hKeyboardHook == 0)
                {
                    Stop();
                    throw new Exception("安装键盘钩子失败");
                }
            }
        }
        public void Stop()
        {
            bool retKeyboard = true;


            if (hKeyboardHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
            }

            if (!(retKeyboard)) throw new Exception("卸载钩子失败！");
        }
        //ToAscii职能的转换指定的虚拟键码和键盘状态的相应字符或字符
        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, //[in] 指定虚拟关键代码进行翻译。
                                         int uScanCode, // [in] 指定的硬件扫描码的关键须翻译成英文。高阶位的这个值设定的关键，如果是（不压）
                                         byte[] lpbKeyState, // [in] 指针，以256字节数组，包含当前键盘的状态。每个元素（字节）的数组包含状态的一个关键。如果高阶位的字节是一套，关键是下跌（按下）。在低比特，如果设置表明，关键是对切换。在此功能，只有肘位的CAPS LOCK键是相关的。在切换状态的NUM个锁和滚动锁定键被忽略。
                                         byte[] lpwTransKey, // [out] 指针的缓冲区收到翻译字符或字符。
                                         int fuState); // [in] Specifies whether a menu is active. This parameter must be 1 if a menu is active, or 0 otherwise.

        //获取按键的状态
        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern short GetKeyState(int vKey);

        private const int WM_KEYDOWN = 0x100;//KEYDOWN
        private const int WM_KEYUP = 0x101;//KEYUP
        private const int WM_SYSKEYDOWN = 0x104;//SYSKEYDOWN
        private const int WM_SYSKEYUP = 0x105;//SYSKEYUP

        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            // 侦听键盘事件
            if ((nCode >= 0) && (KeyDownEvent != null || KeyUpEvent != null || KeyPressEvent != null))
            {
                KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                // raise KeyDown
                if (KeyDownEvent != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyDownEvent(this, e);
                }

                //键盘按下
                if (KeyPressEvent != null && wParam == WM_KEYDOWN)
                {
                    byte[] keyState = new byte[256];
                    GetKeyboardState(keyState);

                    byte[] inBuffer = new byte[2];
                    if (ToAscii(MyKeyboardHookStruct.vkCode, MyKeyboardHookStruct.scanCode, keyState, inBuffer, MyKeyboardHookStruct.flags) == 1)
                    {
                        KeyPressEventArgs e = new KeyPressEventArgs((char)inBuffer[0]);
                        KeyPressEvent(this, e);
                    }
                }

                // 键盘抬起
                if (KeyUpEvent != null && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyUpEvent(this, e);
                }

            }
            //如果返回1，则结束消息，这个消息到此为止，不再传递。
            //如果返回0或调用CallNextHookEx函数则消息出了这个钩子继续往下传递，也就是传给消息真正的接受者
            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }
        ~KeyboardHook()
        {
            Stop();
        }
    }

    internal class KeyBoardListener
    {
        private KeyboardHook k_hook = new KeyboardHook();
        private KeyEventHandler keyEventHandler;

        public KeyBoardListener(KeyEventHandler eventHandler)
        {
            this.keyEventHandler = eventHandler;
        }

        public void Start()
        {
            k_hook.KeyDownEvent += keyEventHandler;
            k_hook.Start();
        }
        public void Stop()
        {
            if (keyEventHandler != null)
            {
                k_hook.KeyDownEvent -= keyEventHandler;//取消按键事件
                k_hook.Stop();
            }
        }
    }

}
