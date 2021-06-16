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
    enum RtnKey
    {
        Enter = 0,
        CtrlEnter = 1
    }
    public partial class Form1 : Form
    {
        RtnKey Rtn = RtnKey.CtrlEnter;
        public Form1()
        {
            InitializeComponent();
        }
        readonly Dictionary<RtnKey, String> keydict = new Dictionary<RtnKey, String>
        {
                {RtnKey.CtrlEnter, "^{Enter}"},
                {RtnKey.Enter, "{Enter}"}
        };
        private void sdkey_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(QDText.Text + keydict[Rtn]);
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
            logchk.Text = "Stopped";
            logchk.ForeColor = Color.Red;
            chkkeyleave.Enabled = false;
        }

        private void Form1_DeActive(object sender, EventArgs e)
        {
            logchk.Text = "Running";
            logchk.ForeColor = Color.Green;
            chkkeyleave.Enabled = true;
        }

        private void chkkeyleave_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                sdkeys.Enabled = true;
            }
            else
            {
                sdkeys.Enabled = false;
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
    }
}
