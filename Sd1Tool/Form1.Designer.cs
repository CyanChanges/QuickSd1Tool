
namespace Sd1Tool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sdkeys = new System.Windows.Forms.Timer(this.components);
            this.QDText = new System.Windows.Forms.TextBox();
            this.sdtextlb = new System.Windows.Forms.Label();
            this.sddlb = new System.Windows.Forms.Label();
            this.RtnType = new System.Windows.Forms.ComboBox();
            this.Tips = new System.Windows.Forms.Label();
            this.chkkeyleave = new System.Windows.Forms.Timer(this.components);
            this.debug = new System.Windows.Forms.Label();
            this.delaylb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sdkeys
            // 
            this.sdkeys.Tick += new System.EventHandler(this.sdkey_Tick);
            // 
            // QDText
            // 
            this.QDText.Location = new System.Drawing.Point(122, 12);
            this.QDText.Name = "QDText";
            this.QDText.Size = new System.Drawing.Size(234, 31);
            this.QDText.TabIndex = 0;
            this.QDText.Text = "1";
            // 
            // sdtextlb
            // 
            this.sdtextlb.AutoSize = true;
            this.sdtextlb.Location = new System.Drawing.Point(22, 17);
            this.sdtextlb.Name = "sdtextlb";
            this.sdtextlb.Size = new System.Drawing.Size(94, 21);
            this.sdtextlb.TabIndex = 1;
            this.sdtextlb.Text = "抢答文本";
            // 
            // sddlb
            // 
            this.sddlb.AutoSize = true;
            this.sddlb.Location = new System.Drawing.Point(22, 57);
            this.sddlb.Name = "sddlb";
            this.sddlb.Size = new System.Drawing.Size(94, 21);
            this.sddlb.TabIndex = 2;
            this.sddlb.Text = "发送按键";
            // 
            // RtnType
            // 
            this.RtnType.FormattingEnabled = true;
            this.RtnType.Items.AddRange(new object[] {
            "Ctrl + Enter",
            "Enter"});
            this.RtnType.Location = new System.Drawing.Point(122, 53);
            this.RtnType.Name = "RtnType";
            this.RtnType.Size = new System.Drawing.Size(234, 29);
            this.RtnType.TabIndex = 3;
            this.RtnType.Text = "请选择";
            this.RtnType.SelectedIndexChanged += new System.EventHandler(this.RtnType_SelectedIndexChanged);
            // 
            // Tips
            // 
            this.Tips.AutoSize = true;
            this.Tips.Location = new System.Drawing.Point(22, 135);
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(237, 21);
            this.Tips.TabIndex = 4;
            this.Tips.Text = "- 使用 Caps Lock 启动";
            // 
            // chkkeyleave
            // 
            this.chkkeyleave.Interval = 500;
            this.chkkeyleave.Tick += new System.EventHandler(this.chkkeyleave_Tick);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(280, 105);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 21);
            this.debug.TabIndex = 5;
            // 
            // delaylb
            // 
            this.delaylb.AutoSize = true;
            this.delaylb.Location = new System.Drawing.Point(22, 94);
            this.delaylb.Name = "delaylb";
            this.delaylb.Size = new System.Drawing.Size(94, 21);
            this.delaylb.TabIndex = 6;
            this.delaylb.Text = "发送间隔";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 165);
            this.Controls.Add(this.delaylb);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.RtnType);
            this.Controls.Add(this.sddlb);
            this.Controls.Add(this.sdtextlb);
            this.Controls.Add(this.QDText);
            this.Name = "Form1";
            this.Text = "抢答神器";
            this.Activated += new System.EventHandler(this.Form1_Active);
            this.Deactivate += new System.EventHandler(this.Form1_DeActive);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer sdkeys;
        private System.Windows.Forms.TextBox QDText;
        private System.Windows.Forms.Label sdtextlb;
        private System.Windows.Forms.Label sddlb;
        private System.Windows.Forms.ComboBox RtnType;
        private System.Windows.Forms.Label Tips;
        private System.Windows.Forms.Timer chkkeyleave;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Label delaylb;
    }
}

