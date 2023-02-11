using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sd1Tool
{
    public partial class Counters : Form
    {
        List<UserControl> AllCount = new List<UserControl>();
        public Counters()
        {
            InitializeComponent();
        }
        public void SetAll()
        {
            int OldHg = 0; // 旧高度
            foreach (var ach in AllCount)
            {
                ach.Location = new Point(0, OldHg); //设置 UserControl 位置，防止重叠
                this.Controls.Add(ach); // 添加 UserControl 控件
                OldHg = ach.Height; // 设置旧的高度
            }
        }
        public void CountAdd(UserControl achievement)
        {
            AllCount.Add(achievement);
        }

        private void Counters_Load(object sender, EventArgs e)
        {
            // Init Achievements 初始化成就显示
            UserControl count1 = new counter("发送次数", Properties.Settings.Default.Sends);
            UserControl count2 = new counter(null, 0);
            CountAdd(count1);
            SetAll();
        }
    }
}
