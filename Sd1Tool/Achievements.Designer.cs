
namespace Sd1Tool
{
    partial class Achievements
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
            this.components = new System.ComponentModel.Container();
            this.GetUp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GetUp
            // 
            this.GetUp.Enabled = true;
            this.GetUp.Interval = 10;
            this.GetUp.Tick += new System.EventHandler(this.GetUp_Tick);
            // 
            // Achievements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Name = "Achievements";
            this.Text = "成就系统";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Achievements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GetUp;
    }
}