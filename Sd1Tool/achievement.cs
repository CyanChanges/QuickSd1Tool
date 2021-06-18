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
    public partial class achievement : UserControl
    {
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
