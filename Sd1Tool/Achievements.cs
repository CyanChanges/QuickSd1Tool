using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sd1Tool
{
    public partial class Achievements : Form
    {
        List<UserControl> AllAch = new List<UserControl>();
        public Achievements()
        {
            InitializeComponent();
            SetTopLevel(true);
            TopLevel = true;
        }
        public void SetAll() 
        {
            int OldHg = 0; // 旧高度
            foreach (var ach in AllAch)
            {
                ach.Location = new Point(0, OldHg); //设置 UserControl 位置，防止重叠
                this.Controls.Add(ach); // 添加 UserControl 控件
                OldHg = ach.Height; // 设置旧的高度
            }
        }
        public void AchAdd(UserControl achievement)
        {
            AllAch.Add(achievement);
        }
        private void Achievements_Load(object sender, EventArgs e)
        {
            // Init Achievements 初始化成就显示
            UserControl ach1 = new achievement("???", Properties.Settings.Default.Achievement1 ? "已达成" : "未达成", "点击 ??? 按钮");
            UserControl ach2 = new achievement(null,null,null);
            AchAdd(ach1);
            SetAll();
        }

        private void GetUp_Tick(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
