
namespace Sd1Tool
{
    partial class counter
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
            this.CountingNamelb = new System.Windows.Forms.Label();
            this.CountingTimeslb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountingNamelb
            // 
            this.CountingNamelb.AutoSize = true;
            this.CountingNamelb.Location = new System.Drawing.Point(4, 6);
            this.CountingNamelb.Name = "CountingNamelb";
            this.CountingNamelb.Size = new System.Drawing.Size(52, 21);
            this.CountingNamelb.TabIndex = 0;
            this.CountingNamelb.Text = "统计";
            // 
            // CountingTimeslb
            // 
            this.CountingTimeslb.AutoSize = true;
            this.CountingTimeslb.Location = new System.Drawing.Point(4, 39);
            this.CountingTimeslb.Name = "CountingTimeslb";
            this.CountingTimeslb.Size = new System.Drawing.Size(74, 21);
            this.CountingTimeslb.TabIndex = 2;
            this.CountingTimeslb.Text = "状态: ";
            // 
            // counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountingTimeslb);
            this.Controls.Add(this.CountingNamelb);
            this.Name = "counter";
            this.Size = new System.Drawing.Size(268, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountingNamelb;
        private System.Windows.Forms.Label CountingTimeslb;
    }
}
