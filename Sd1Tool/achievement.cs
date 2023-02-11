using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security;
using System.Windows.Forms;

namespace Sd1Tool
{
    public partial class achievement : UserControl
    {
        public achievement(String Achname, String Statusname)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AchName, Achname);
            AchName.Text = Achname;
            AchStatus.Text = Statusname;
        }
        
        public achievement(String Achname, String Statusname, String tooltip)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AchName, tooltip);
            AchName.Text = Achname;
            AchStatus.Text = Statusname;
        }
    }
}
