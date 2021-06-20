
namespace Sd1Tool
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mlb = new System.Windows.Forms.Label();
            this.Createrlb = new System.Windows.Forms.LinkLabel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mlb
            // 
            this.Mlb.AutoSize = true;
            this.Mlb.Location = new System.Drawing.Point(47, 36);
            this.Mlb.Name = "Mlb";
            this.Mlb.Size = new System.Drawing.Size(74, 21);
            this.Mlb.TabIndex = 0;
            this.Mlb.Text = "作者: ";
            // 
            // Createrlb
            // 
            this.Createrlb.AutoSize = true;
            this.Createrlb.Location = new System.Drawing.Point(108, 36);
            this.Createrlb.Name = "Createrlb";
            this.Createrlb.Size = new System.Drawing.Size(219, 21);
            this.Createrlb.TabIndex = 1;
            this.Createrlb.TabStop = true;
            this.Createrlb.Text = "Chinese-Cyq20100313";
            this.Createrlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Createrlb_LinkClicked);
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(140, 302);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 43);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "关闭";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // About
            // 
            this.AcceptButton = this.CloseBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(376, 386);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Createrlb);
            this.Controls.Add(this.Mlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.Text = "关于";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mlb;
        private System.Windows.Forms.LinkLabel Createrlb;
        private System.Windows.Forms.Button CloseBtn;
    }
}