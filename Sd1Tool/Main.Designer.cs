
namespace Sd1Tool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.KeySender = new System.Windows.Forms.Timer(this.components);
            this.QDText = new System.Windows.Forms.TextBox();
            this.sdtextlb = new System.Windows.Forms.Label();
            this.sddlb = new System.Windows.Forms.Label();
            this.RtnType = new System.Windows.Forms.ComboBox();
            this.Tips = new System.Windows.Forms.Label();
            this.delaylb = new System.Windows.Forms.Label();
            this.delaynud = new System.Windows.Forms.NumericUpDown();
            this.DosdBar = new System.Windows.Forms.ProgressBar();
            this.timeschkbox = new System.Windows.Forms.CheckBox();
            this.sdtimesnud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.Timer(this.components);
            this.DESTORY = new System.Windows.Forms.Button();
            this.AchBtn = new System.Windows.Forms.Button();
            this.CountBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.delaynud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtimesnud)).BeginInit();
            this.SuspendLayout();
            // 
            // KeySender
            // 
            this.KeySender.Tick += new System.EventHandler(this.KeySend_Tick);
            // 
            // QDText
            // 
            resources.ApplyResources(this.QDText, "QDText");
            this.QDText.Name = "QDText";
            // 
            // sdtextlb
            // 
            resources.ApplyResources(this.sdtextlb, "sdtextlb");
            this.sdtextlb.Name = "sdtextlb";
            // 
            // sddlb
            // 
            resources.ApplyResources(this.sddlb, "sddlb");
            this.sddlb.Name = "sddlb";
            // 
            // RtnType
            // 
            resources.ApplyResources(this.RtnType, "RtnType");
            this.RtnType.FormattingEnabled = true;
            this.RtnType.Items.AddRange(new object[] {
            resources.GetString("RtnType.Items"),
            resources.GetString("RtnType.Items1")});
            this.RtnType.Name = "RtnType";
            this.RtnType.SelectedIndexChanged += new System.EventHandler(this.RtnType_SelectedIndexChanged);
            // 
            // Tips
            // 
            resources.ApplyResources(this.Tips, "Tips");
            this.Tips.Name = "Tips";
            // 
            // delaylb
            // 
            resources.ApplyResources(this.delaylb, "delaylb");
            this.delaylb.Name = "delaylb";
            // 
            // delaynud
            // 
            resources.ApplyResources(this.delaynud, "delaynud");
            this.delaynud.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.delaynud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.delaynud.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.delaynud.Name = "delaynud";
            this.delaynud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // DosdBar
            // 
            resources.ApplyResources(this.DosdBar, "DosdBar");
            this.DosdBar.Maximum = 10;
            this.DosdBar.Name = "DosdBar";
            // 
            // timeschkbox
            // 
            resources.ApplyResources(this.timeschkbox, "timeschkbox");
            this.timeschkbox.Name = "timeschkbox";
            this.timeschkbox.UseVisualStyleBackColor = true;
            this.timeschkbox.CheckedChanged += new System.EventHandler(this.TimesCheckBox_CheckedChanged);
            // 
            // sdtimesnud
            // 
            resources.ApplyResources(this.sdtimesnud, "sdtimesnud");
            this.sdtimesnud.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sdtimesnud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sdtimesnud.Name = "sdtimesnud";
            this.sdtimesnud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // times
            // 
            this.times.Tick += new System.EventHandler(this.Times_Tick);
            // 
            // DESTORY
            // 
            resources.ApplyResources(this.DESTORY, "DESTORY");
            this.DESTORY.BackColor = System.Drawing.Color.White;
            this.DESTORY.Cursor = System.Windows.Forms.Cursors.No;
            this.DESTORY.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DESTORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DESTORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DESTORY.ForeColor = System.Drawing.Color.Red;
            this.DESTORY.Name = "DESTORY";
            this.DESTORY.UseVisualStyleBackColor = false;
            this.DESTORY.Click += new System.EventHandler(this.DESTORY_Click);
            // 
            // AchBtn
            // 
            resources.ApplyResources(this.AchBtn, "AchBtn");
            this.AchBtn.Name = "AchBtn";
            this.AchBtn.UseVisualStyleBackColor = true;
            this.AchBtn.Click += new System.EventHandler(this.AchBtn_Click);
            // 
            // CountBtn
            // 
            resources.ApplyResources(this.CountBtn, "CountBtn");
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // AboutBtn
            // 
            resources.ApplyResources(this.AboutBtn, "AboutBtn");
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.AchBtn);
            this.Controls.Add(this.DESTORY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdtimesnud);
            this.Controls.Add(this.timeschkbox);
            this.Controls.Add(this.DosdBar);
            this.Controls.Add(this.delaynud);
            this.Controls.Add(this.delaylb);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.RtnType);
            this.Controls.Add(this.sddlb);
            this.Controls.Add(this.sdtextlb);
            this.Controls.Add(this.QDText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Active);
            this.Deactivate += new System.EventHandler(this.Form1_DeActive);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.delaynud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtimesnud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer KeySender;
        private System.Windows.Forms.TextBox QDText;
        private System.Windows.Forms.Label sdtextlb;
        private System.Windows.Forms.Label sddlb;
        private System.Windows.Forms.ComboBox RtnType;
        private System.Windows.Forms.Label Tips;
        private System.Windows.Forms.Label delaylb;
        private System.Windows.Forms.NumericUpDown delaynud;
        private System.Windows.Forms.ProgressBar DosdBar;
        private System.Windows.Forms.CheckBox timeschkbox;
        private System.Windows.Forms.NumericUpDown sdtimesnud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer times;
        private System.Windows.Forms.Button DESTORY;
        private System.Windows.Forms.Button AchBtn;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Button AboutBtn;
    }
}

