﻿namespace EnergySaver_CsProject
{
    partial class CountDownForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 50);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(87, 83);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(101, 30);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "지금 실행";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(194, 83);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(101, 30);
            this.buttonCancle.TabIndex = 2;
            this.buttonCancle.Text = "취소";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            // 
            // CountDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.progressBar1);
            this.Name = "CountDownForm";
            this.Text = "절전모드 시작확인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Label label1;
    }
}