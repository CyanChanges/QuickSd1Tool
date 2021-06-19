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
        public achievement(String Achname, String Statusname)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AchName, Achname);
            AchName.Text = Achname;
            AchStatus.Text = Statusname;
        }
        /// <summary>
        /// 神奇 MagicKey 类，勿动！
        /// ———— Cyq20100313
        /// </summary>
        class MagicKey
        {
            public class MasterObj
            {
                string Name = "No Master";
                public int MagicPower = int.MinValue;
                public List<string> Skill = new List<string>();
                public String MasterName { get { return this.Name; } set { this.Name = value; } }
                
            }
            public string keyname;
            public List<String> Skill = new List<String>();
            public float MagicPower;
            MasterObj MasterObject;
            public string MasterName;
            public MagicKey(MasterObj master)
            {
                MasterObject = master;
                MasterName = MasterObject.MasterName;
            }
            public void Out()
            {
                MessageBox.Show("你的决心碎了亿地！","提示 - UNDER TOOLS");
            }
        }
        public achievement(String Achname, String Statusname, String tooltip)
        {
            // Magic Init Start
            MagicKey.MasterObj master = new MagicKey.MasterObj();
            master.MasterName = "Cyq20100313";
            MagicKey magickey = new MagicKey(master);
            magickey.Skill.Add("Control");
            // Magic Init End
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AchName, tooltip);
            AchName.Text = Achname;
            AchStatus.Text = Statusname;
        }
    }
}
