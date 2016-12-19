namespace EnergySaver_CsProject
{
    partial class SetKeyForm
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
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.checkBoxCtrl1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxAlt1 = new System.Windows.Forms.CheckBox();
            this.checkBoxShift1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxKey.Location = new System.Drawing.Point(105, 6);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(84, 23);
            this.comboBoxKey.TabIndex = 25;
            // 
            // checkBoxCtrl1
            // 
            this.checkBoxCtrl1.AutoSize = true;
            this.checkBoxCtrl1.Location = new System.Drawing.Point(130, 38);
            this.checkBoxCtrl1.Name = "checkBoxCtrl1";
            this.checkBoxCtrl1.Size = new System.Drawing.Size(50, 19);
            this.checkBoxCtrl1.TabIndex = 24;
            this.checkBoxCtrl1.Text = "Ctrl";
            this.checkBoxCtrl1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "단축키 설정";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(114, 63);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "확인";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxAlt1
            // 
            this.checkBoxAlt1.AutoSize = true;
            this.checkBoxAlt1.Location = new System.Drawing.Point(79, 38);
            this.checkBoxAlt1.Name = "checkBoxAlt1";
            this.checkBoxAlt1.Size = new System.Drawing.Size(45, 19);
            this.checkBoxAlt1.TabIndex = 21;
            this.checkBoxAlt1.Text = "Alt";
            this.checkBoxAlt1.UseVisualStyleBackColor = true;
            // 
            // checkBoxShift1
            // 
            this.checkBoxShift1.AutoSize = true;
            this.checkBoxShift1.Location = new System.Drawing.Point(15, 38);
            this.checkBoxShift1.Name = "checkBoxShift1";
            this.checkBoxShift1.Size = new System.Drawing.Size(58, 19);
            this.checkBoxShift1.TabIndex = 20;
            this.checkBoxShift1.Text = "Shift";
            this.checkBoxShift1.UseVisualStyleBackColor = true;
            // 
            // SetKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 94);
            this.Controls.Add(this.comboBoxKey);
            this.Controls.Add(this.checkBoxCtrl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxAlt1);
            this.Controls.Add(this.checkBoxShift1);
            this.Name = "SetKeyForm";
            this.Text = "단축키 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.CheckBox checkBoxCtrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxAlt1;
        private System.Windows.Forms.CheckBox checkBoxShift1;
    }
}