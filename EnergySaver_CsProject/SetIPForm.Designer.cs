namespace EnergySaver_CsProject
{
    partial class SetIPForm
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
            this.buttonSet = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPortNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(325, 6);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 25);
            this.buttonSet.TabIndex = 0;
            this.buttonSet.Text = "설정";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 9);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(55, 15);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "서버 IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(90, 6);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(189, 25);
            this.textBoxIP.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 43);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(72, 15);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "포트 번호";
            // 
            // textBoxPortNum
            // 
            this.textBoxPortNum.Location = new System.Drawing.Point(90, 37);
            this.textBoxPortNum.Name = "textBoxPortNum";
            this.textBoxPortNum.Size = new System.Drawing.Size(189, 25);
            this.textBoxPortNum.TabIndex = 4;
            // 
            // SetIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 78);
            this.Controls.Add(this.textBoxPortNum);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.buttonSet);
            this.Name = "SetIPForm";
            this.Text = "서버 IP 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPortNum;
    }
}