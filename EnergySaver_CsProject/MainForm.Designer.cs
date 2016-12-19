namespace EnergySaver_CsProject
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelAutoRun = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarAutoRun = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelAutoRun,
            this.toolStripProgressBarAutoRun});
            this.statusStrip1.Location = new System.Drawing.Point(0, 226);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(447, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelAutoRun
            // 
            this.toolStripStatusLabelAutoRun.Name = "toolStripStatusLabelAutoRun";
            this.toolStripStatusLabelAutoRun.Size = new System.Drawing.Size(74, 20);
            this.toolStripStatusLabelAutoRun.Text = "자동 실행";
            // 
            // toolStripProgressBarAutoRun
            // 
            this.toolStripProgressBarAutoRun.Name = "toolStripProgressBarAutoRun";
            this.toolStripProgressBarAutoRun.Size = new System.Drawing.Size(100, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 251);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAutoRun;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarAutoRun;
    }
}