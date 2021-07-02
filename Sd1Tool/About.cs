using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sd1Tool
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            List<String> ranlst = new List<String> { "View in Gayhub - 在 GayHub 中查看", "View in Github - 在 GitHub 中查看" };
            toolTip.SetToolTip(Createrlb, ranlst[new Random().Next(3)%ranlst.Count]);
        }

        private void Createrlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = "https://github.com/Chinese-Cyq20100313/";
            pro.Start();
            _ = pro;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
