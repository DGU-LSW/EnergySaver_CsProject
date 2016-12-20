namespace EnergySaver_CsProject
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.labelServer = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSaveSeting = new System.Windows.Forms.Button();
            this.buttonID = new System.Windows.Forms.Button();
            this.buttonServer = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelAutoTimer = new System.Windows.Forms.Label();
            this.comboBoxAutoRun = new System.Windows.Forms.ComboBox();
            this.radioButtonMonitor = new System.Windows.Forms.RadioButton();
            this.radioButtonStandby = new System.Windows.Forms.RadioButton();
            this.radioButtonMaxSave = new System.Windows.Forms.RadioButton();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelDaily = new System.Windows.Forms.Label();
            this.comboBoxDailyHour = new System.Windows.Forms.ComboBox();
            this.comboBoxDailyMin = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelAutoRun = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelDaily = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonKey = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHotkey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDefaultSetting = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(8, 191);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(72, 15);
            this.labelServer.TabIndex = 1;
            this.labelServer.Text = "서버 설정";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(8, 145);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(87, 15);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "아이디 설정";
            // 
            // buttonSaveSeting
            // 
            this.buttonSaveSeting.Location = new System.Drawing.Point(230, 310);
            this.buttonSaveSeting.Name = "buttonSaveSeting";
            this.buttonSaveSeting.Size = new System.Drawing.Size(104, 28);
            this.buttonSaveSeting.TabIndex = 3;
            this.buttonSaveSeting.Text = "적용";
            this.buttonSaveSeting.UseVisualStyleBackColor = true;
            this.buttonSaveSeting.Click += new System.EventHandler(this.buttonSaveSeting_Click);
            // 
            // buttonID
            // 
            this.buttonID.Location = new System.Drawing.Point(340, 137);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(104, 30);
            this.buttonID.TabIndex = 4;
            this.buttonID.Text = "아이디 설정";
            this.buttonID.UseVisualStyleBackColor = true;
            this.buttonID.Click += new System.EventHandler(this.buttonID_Click);
            // 
            // buttonServer
            // 
            this.buttonServer.Location = new System.Drawing.Point(340, 183);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(104, 30);
            this.buttonServer.TabIndex = 5;
            this.buttonServer.Text = "서버 설정";
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(115, 142);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(186, 25);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(115, 188);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.ReadOnly = true;
            this.textBoxServer.Size = new System.Drawing.Size(186, 25);
            this.textBoxServer.TabIndex = 7;
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(11, 252);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(117, 28);
            this.buttonLog.TabIndex = 8;
            this.buttonLog.Text = "절전 로그 저장";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelAutoTimer
            // 
            this.labelAutoTimer.AutoSize = true;
            this.labelAutoTimer.Location = new System.Drawing.Point(12, 9);
            this.labelAutoTimer.Name = "labelAutoTimer";
            this.labelAutoTimer.Size = new System.Drawing.Size(107, 15);
            this.labelAutoTimer.TabIndex = 9;
            this.labelAutoTimer.Text = "자동 실행 시간";
            // 
            // comboBoxAutoRun
            // 
            this.comboBoxAutoRun.FormattingEnabled = true;
            this.comboBoxAutoRun.Items.AddRange(new object[] {
            "사용안함",
            "5분",
            "10분",
            "15분",
            "20분",
            "25분",
            "30분",
            "35분",
            "40분",
            "45분",
            "50분",
            "55분",
            "60분"});
            this.comboBoxAutoRun.Location = new System.Drawing.Point(126, 6);
            this.comboBoxAutoRun.Name = "comboBoxAutoRun";
            this.comboBoxAutoRun.Size = new System.Drawing.Size(113, 23);
            this.comboBoxAutoRun.TabIndex = 10;
            // 
            // radioButtonMonitor
            // 
            this.radioButtonMonitor.AutoSize = true;
            this.radioButtonMonitor.Location = new System.Drawing.Point(90, 42);
            this.radioButtonMonitor.Name = "radioButtonMonitor";
            this.radioButtonMonitor.Size = new System.Drawing.Size(108, 19);
            this.radioButtonMonitor.TabIndex = 11;
            this.radioButtonMonitor.TabStop = true;
            this.radioButtonMonitor.Text = "모니터 끄기";
            this.radioButtonMonitor.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandby
            // 
            this.radioButtonStandby.AutoSize = true;
            this.radioButtonStandby.Location = new System.Drawing.Point(204, 42);
            this.radioButtonStandby.Name = "radioButtonStandby";
            this.radioButtonStandby.Size = new System.Drawing.Size(88, 19);
            this.radioButtonStandby.TabIndex = 12;
            this.radioButtonStandby.TabStop = true;
            this.radioButtonStandby.Text = "절전모드";
            this.radioButtonStandby.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaxSave
            // 
            this.radioButtonMaxSave.AutoSize = true;
            this.radioButtonMaxSave.Location = new System.Drawing.Point(298, 42);
            this.radioButtonMaxSave.Name = "radioButtonMaxSave";
            this.radioButtonMaxSave.Size = new System.Drawing.Size(93, 19);
            this.radioButtonMaxSave.TabIndex = 13;
            this.radioButtonMaxSave.TabStop = true;
            this.radioButtonMaxSave.Text = "최대 절전";
            this.radioButtonMaxSave.UseVisualStyleBackColor = true;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(12, 44);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(72, 15);
            this.labelMode.TabIndex = 14;
            this.labelMode.Text = "모드 설정";
            // 
            // labelDaily
            // 
            this.labelDaily.AutoSize = true;
            this.labelDaily.Location = new System.Drawing.Point(15, 87);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(37, 15);
            this.labelDaily.TabIndex = 15;
            this.labelDaily.Text = "매일";
            // 
            // comboBoxDailyHour
            // 
            this.comboBoxDailyHour.FormattingEnabled = true;
            this.comboBoxDailyHour.Items.AddRange(new object[] {
            "00시",
            "01시",
            "02시",
            "03시",
            "04시",
            "05시",
            "06시",
            "07시",
            "08시",
            "09시",
            "10시",
            "11시",
            "12시",
            "13시",
            "14시",
            "15시",
            "16시",
            "17시",
            "18시",
            "19시",
            "20시",
            "21시",
            "22시",
            "23시"});
            this.comboBoxDailyHour.Location = new System.Drawing.Point(58, 84);
            this.comboBoxDailyHour.Name = "comboBoxDailyHour";
            this.comboBoxDailyHour.Size = new System.Drawing.Size(97, 23);
            this.comboBoxDailyHour.TabIndex = 16;
            // 
            // comboBoxDailyMin
            // 
            this.comboBoxDailyMin.FormattingEnabled = true;
            this.comboBoxDailyMin.Items.AddRange(new object[] {
            "00분",
            "10분",
            "20분",
            "30분",
            "40분",
            "50분"});
            this.comboBoxDailyMin.Location = new System.Drawing.Point(161, 84);
            this.comboBoxDailyMin.Name = "comboBoxDailyMin";
            this.comboBoxDailyMin.Size = new System.Drawing.Size(110, 23);
            this.comboBoxDailyMin.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelAutoRun,
            this.toolStripProgressBar1,
            this.toolStripStatusLabelDaily});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 25);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelAutoRun
            // 
            this.toolStripStatusLabelAutoRun.Name = "toolStripStatusLabelAutoRun";
            this.toolStripStatusLabelAutoRun.Size = new System.Drawing.Size(74, 20);
            this.toolStripStatusLabelAutoRun.Text = "자동 실행";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabelDaily
            // 
            this.toolStripStatusLabelDaily.Name = "toolStripStatusLabelDaily";
            this.toolStripStatusLabelDaily.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabelDaily.Text = "매일 종료 : ";
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(161, 252);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(110, 28);
            this.buttonKey.TabIndex = 19;
            this.buttonKey.Text = "단축키 설정";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(340, 310);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(104, 28);
            this.buttonCancle.TabIndex = 20;
            this.buttonCancle.Text = "취소";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCheck,
            this.toolStripMenuItemOption,
            this.toolStripMenuItemHotkey,
            this.toolStripMenuItemExecute,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 134);
            // 
            // toolStripMenuItemCheck
            // 
            this.toolStripMenuItemCheck.Name = "toolStripMenuItemCheck";
            this.toolStripMenuItemCheck.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemCheck.Text = "절감전력 확인";
            // 
            // toolStripMenuItemOption
            // 
            this.toolStripMenuItemOption.Name = "toolStripMenuItemOption";
            this.toolStripMenuItemOption.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemOption.Text = "환경설정";
            this.toolStripMenuItemOption.Click += new System.EventHandler(this.toolStripMenuItemOption_Click);
            // 
            // toolStripMenuItemHotkey
            // 
            this.toolStripMenuItemHotkey.Name = "toolStripMenuItemHotkey";
            this.toolStripMenuItemHotkey.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemHotkey.Text = "화면단축키 변경";
            this.toolStripMenuItemHotkey.Click += new System.EventHandler(this.toolStripMenuItemHotkey_Click);
            // 
            // toolStripMenuItemExecute
            // 
            this.toolStripMenuItemExecute.Name = "toolStripMenuItemExecute";
            this.toolStripMenuItemExecute.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemExecute.Text = "절전 바로실행";
            this.toolStripMenuItemExecute.Click += new System.EventHandler(this.toolStripMenuItemExecute_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemExit.Text = "종료";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // buttonDefaultSetting
            // 
            this.buttonDefaultSetting.Location = new System.Drawing.Point(11, 310);
            this.buttonDefaultSetting.Name = "buttonDefaultSetting";
            this.buttonDefaultSetting.Size = new System.Drawing.Size(104, 28);
            this.buttonDefaultSetting.TabIndex = 21;
            this.buttonDefaultSetting.Text = "설정 초기화";
            this.buttonDefaultSetting.UseVisualStyleBackColor = true;
            this.buttonDefaultSetting.Click += new System.EventHandler(this.buttonDefaultSetting_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 366);
            this.Controls.Add(this.buttonDefaultSetting);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonKey);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBoxDailyMin);
            this.Controls.Add(this.comboBoxDailyHour);
            this.Controls.Add(this.labelDaily);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.radioButtonMaxSave);
            this.Controls.Add(this.radioButtonStandby);
            this.Controls.Add(this.radioButtonMonitor);
            this.Controls.Add(this.comboBoxAutoRun);
            this.Controls.Add(this.labelAutoTimer);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonServer);
            this.Controls.Add(this.buttonID);
            this.Controls.Add(this.buttonSaveSeting);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelServer);
            this.Name = "OptionForm";
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSaveSeting;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelAutoTimer;
        private System.Windows.Forms.ComboBox comboBoxAutoRun;
        private System.Windows.Forms.RadioButton radioButtonMonitor;
        private System.Windows.Forms.RadioButton radioButtonStandby;
        private System.Windows.Forms.RadioButton radioButtonMaxSave;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelDaily;
        private System.Windows.Forms.ComboBox comboBoxDailyHour;
        private System.Windows.Forms.ComboBox comboBoxDailyMin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAutoRun;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDaily;
        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonDefaultSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCheck;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHotkey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExecute;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

