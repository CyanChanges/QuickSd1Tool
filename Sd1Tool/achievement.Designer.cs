
namespace Sd1Tool
{
    partial class achievement
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AchNamelb = new System.Windows.Forms.Label();
            this.AchName = new System.Windows.Forms.Label();
            this.AchStatuslb = new System.Windows.Forms.Label();
            this.AchStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AchNamelb
            // 
            this.AchNamelb.AutoSize = true;
            this.AchNamelb.Location = new System.Drawing.Point(4, 4);
            this.AchNamelb.Name = "AchNamelb";
            this.AchNamelb.Size = new System.Drawing.Size(74, 21);
            this.AchNamelb.TabIndex = 0;
            this.AchNamelb.Text = "成就: ";
            // 
            // AchName
            // 
            this.AchName.AutoSize = true;
            this.AchName.Location = new System.Drawing.Point(56, 4);
            this.AchName.Name = "AchName";
            this.AchName.Size = new System.Drawing.Size(52, 21);
            this.AchName.TabIndex = 1;
            this.AchName.Tag = "";
            this.AchName.Text = "成就";
            // 
            // AchStatuslb
            // 
            this.AchStatuslb.AutoSize = true;
            this.AchStatuslb.Location = new System.Drawing.Point(4, 37);
            this.AchStatuslb.Name = "AchStatuslb";
            this.AchStatuslb.Size = new System.Drawing.Size(74, 21);
            this.AchStatuslb.TabIndex = 2;
            this.AchStatuslb.Text = "状态: ";
            // 
            // AchStatus
            // 
            this.AchStatus.AutoSize = true;
            this.AchStatus.Location = new System.Drawing.Point(56, 37);
            this.AchStatus.Name = "AchStatus";
            this.AchStatus.Size = new System.Drawing.Size(52, 21);
            this.AchStatus.TabIndex = 3;
            this.AchStatus.Text = "状态";
            // 
            // achievement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AchStatus);
            this.Controls.Add(this.AchStatuslb);
            this.Controls.Add(this.AchName);
            this.Controls.Add(this.AchNamelb);
            this.Name = "achievement";
            this.Size = new System.Drawing.Size(268, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AchNamelb;
        private System.Windows.Forms.Label AchName;
        private System.Windows.Forms.Label AchStatuslb;
        private System.Windows.Forms.Label AchStatus;
    }
}
