
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
            this.lockstats = new System.Windows.Forms.Label();
            this.delaylb = new System.Windows.Forms.Label();
            this.delaynud = new System.Windows.Forms.NumericUpDown();
            this.LockchkServicelb = new System.Windows.Forms.Label();
            this.DosdBar = new System.Windows.Forms.ProgressBar();
            this.timeschkbox = new System.Windows.Forms.CheckBox();
            this.sdtimesnud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delaynud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtimesnud)).BeginInit();
            this.SuspendLayout();
            // 
            // sdkeys
            // 
            this.sdkeys.Tick += new System.EventHandler(this.sdkey_Tick);
            // 
            // QDText
            // 
            this.QDText.Location = new System.Drawing.Point(121, 12);
            this.QDText.Name = "QDText";
            this.QDText.Size = new System.Drawing.Size(298, 31);
            this.QDText.TabIndex = 0;
            this.QDText.Text = "1";
            // 
            // sdtextlb
            // 
            this.sdtextlb.AutoSize = true;
            this.sdtextlb.Location = new System.Drawing.Point(12, 17);
            this.sdtextlb.Name = "sdtextlb";
            this.sdtextlb.Size = new System.Drawing.Size(94, 21);
            this.sdtextlb.TabIndex = 1;
            this.sdtextlb.Text = "目标文本";
            // 
            // sddlb
            // 
            this.sddlb.AutoSize = true;
            this.sddlb.Location = new System.Drawing.Point(12, 54);
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
            this.RtnType.Location = new System.Drawing.Point(121, 50);
            this.RtnType.Name = "RtnType";
            this.RtnType.Size = new System.Drawing.Size(298, 29);
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
            // lockstats
            // 
            this.lockstats.AutoSize = true;
            this.lockstats.ForeColor = System.Drawing.Color.Yellow;
            this.lockstats.Location = new System.Drawing.Point(258, 165);
            this.lockstats.Name = "lockstats";
            this.lockstats.Size = new System.Drawing.Size(120, 21);
            this.lockstats.TabIndex = 5;
            this.lockstats.Text = "lockstatus";
            // 
            // delaylb
            // 
            this.delaylb.AutoSize = true;
            this.delaylb.Location = new System.Drawing.Point(12, 92);
            this.delaylb.Name = "delaylb";
            this.delaylb.Size = new System.Drawing.Size(94, 21);
            this.delaylb.TabIndex = 6;
            this.delaylb.Text = "发送间隔";
            // 
            // delaynud
            // 
            this.delaynud.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.delaynud.Location = new System.Drawing.Point(121, 87);
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
            this.delaynud.Size = new System.Drawing.Size(298, 31);
            this.delaynud.TabIndex = 7;
            this.delaynud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delaynud.ValueChanged += new System.EventHandler(this.delaynud_ValueChanged);
            // 
            // LockchkServicelb
            // 
            this.LockchkServicelb.AutoSize = true;
            this.LockchkServicelb.Location = new System.Drawing.Point(22, 164);
            this.LockchkServicelb.Name = "LockchkServicelb";
            this.LockchkServicelb.Size = new System.Drawing.Size(238, 21);
            this.LockchkServicelb.TabIndex = 8;
            this.LockchkServicelb.Text = "- [Caps Lock] 检测器:";
            // 
            // DosdBar
            // 
            this.DosdBar.Location = new System.Drawing.Point(26, 271);
            this.DosdBar.Maximum = 10;
            this.DosdBar.Name = "DosdBar";
            this.DosdBar.Size = new System.Drawing.Size(377, 21);
            this.DosdBar.TabIndex = 9;
            // 
            // timeschkbox
            // 
            this.timeschkbox.AutoSize = true;
            this.timeschkbox.Location = new System.Drawing.Point(26, 193);
            this.timeschkbox.Name = "timeschkbox";
            this.timeschkbox.Size = new System.Drawing.Size(120, 25);
            this.timeschkbox.TabIndex = 10;
            this.timeschkbox.Text = "指定次数";
            this.timeschkbox.UseVisualStyleBackColor = true;
            this.timeschkbox.CheckedChanged += new System.EventHandler(this.timeschkbox_CheckedChanged);
            // 
            // sdtimesnud
            // 
            this.sdtimesnud.Location = new System.Drawing.Point(121, 224);
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
            this.sdtimesnud.Size = new System.Drawing.Size(120, 31);
            this.sdtimesnud.TabIndex = 11;
            this.sdtimesnud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "指定次数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdtimesnud);
            this.Controls.Add(this.timeschkbox);
            this.Controls.Add(this.DosdBar);
            this.Controls.Add(this.LockchkServicelb);
            this.Controls.Add(this.delaynud);
            this.Controls.Add(this.delaylb);
            this.Controls.Add(this.lockstats);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.RtnType);
            this.Controls.Add(this.sddlb);
            this.Controls.Add(this.sdtextlb);
            this.Controls.Add(this.QDText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "速发神器";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Active);
            this.Deactivate += new System.EventHandler(this.Form1_DeActive);
            ((System.ComponentModel.ISupportInitialize)(this.delaynud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtimesnud)).EndInit();
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
        private System.Windows.Forms.Label lockstats;
        private System.Windows.Forms.Label delaylb;
        private System.Windows.Forms.NumericUpDown delaynud;
        private System.Windows.Forms.Label LockchkServicelb;
        private System.Windows.Forms.ProgressBar DosdBar;
        private System.Windows.Forms.CheckBox timeschkbox;
        private System.Windows.Forms.NumericUpDown sdtimesnud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

