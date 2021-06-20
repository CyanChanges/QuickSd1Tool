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
    public partial class counter : UserControl
    {
        public counter(String Name, int times,  String unit = "次")
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(CountingNamelb, Name);
            CountingNamelb.Text = Name;
            CountingTimeslb.Text = times.ToString() + unit;
        }
        public counter(String Name, int times, String tooltip, String unit = "次")
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(CountingNamelb, tooltip);
            CountingNamelb.Text = Name;
            CountingTimeslb.Text = times.ToString() + unit;
        }
    }
}
