using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

using MouseKeyboardLibrary;

namespace EnergySaver_CsProject
{
    public partial class OptionForm : Form
    {
        Processor processor;
        string[] tmpKey;    //단축키 임시 저장

        MouseHook mouseHook = new MouseHook();
        KeyboardHook keyboardHook = new KeyboardHook();
        
        public OptionForm()
        {
            InitializeComponent();
            processor = new Processor(this);
            tmpKey = new string[4];
            #region processor 설정 불러오기
            tmpKey[0] = processor.HotKey[0];
            tmpKey[1] = processor.HotKey[1];
            tmpKey[2] = processor.HotKey[2];
            tmpKey[3] = processor.HotKey[3];
            redrawFromProcessor();  //콤포넌트 값을 processor과 맞춤
            #endregion
        }
        public string[] TmpKey
        {
            get
            {
                return tmpKey;
            }
            set
            {
                tmpKey = value;
            }
        }
        public ToolStripStatusLabel ToolLabelAutoRun
        {
            get
            {
                return toolStripStatusLabelAutoRun;
            }
        }
        public ToolStripProgressBar ToolProgressBar
        {
            get
            {
                return toolStripProgressBar1;
            }
        }
        public ToolStripStatusLabel ToolLabelDaily
        {
            get
            {
                return toolStripStatusLabelDaily;
            }
        }
        public void redrawFromProcessor()
        {
            comboBoxAutoRun.SelectedIndex = processor.AutoRunTimeIndex;
            comboBoxDailyHour.SelectedIndex = processor.DailyTimeHour;
            comboBoxDailyMin.SelectedIndex = processor.DailyTimeMin;
            switch (processor.Mode) //모드 값에 따라서 radio버튼 선택
            {
                case MODE.MonitorOff:
                    radioButtonMonitor.Select();
                    break;
                case MODE.Stanby:
                    radioButtonStandby.Select();
                    break;
                case MODE.MaxSave:
                    radioButtonMaxSave.Select();
                    break;
            }
            redrawID();
            redrawIP();
        }
        public void redrawID()
        {
            textBoxID.Text = processor.ID;
        }
        public void redrawIP()
        {
            textBoxServer.Text = processor.IP + " : " + processor.PortNUM;
        }

        private void buttonID_Click(object sender, EventArgs e)
        {
            SetIDForm setIDForm = new SetIDForm(processor, this);
            setIDForm.ShowDialog(this);
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            SetIPForm setIPForm = new SetIPForm(processor, this);
            setIPForm.ShowDialog(this);
        }
        
        private void buttonLog_Click(object sender, EventArgs e)
        {
            LogForm lf = new LogForm(processor, this);
            lf.ShowDialog(this);
        }
        //processor와 설정저장파일에 값을 저장
        private void buttonSaveSeting_Click(object sender, EventArgs e)
        {
            processor.AutoRunTimeIndex = comboBoxAutoRun.SelectedIndex;
            if (radioButtonMonitor.Checked)
            {
                processor.Mode = MODE.MonitorOff;
            }
            else if (radioButtonStandby.Checked)
            {
                processor.Mode = MODE.Stanby;
            }
            else if (radioButtonMaxSave.Checked)
            {
                processor.Mode = MODE.MaxSave;
            }
            processor.DailyTimeHour = comboBoxDailyHour.SelectedIndex;
            processor.DailyTimeMin = comboBoxDailyMin.SelectedIndex;
            processor.ID = textBoxID.Text;
            string[] tmp = textBoxServer.Text.Split(' ');
            processor.IP = tmp[0];
            processor.PortNUM = tmp[2];
            processor.HotKey = tmpKey;
            processor.TimerSetting();
            processor.reConnectServer();
            processor.reRegisterID();
            #region 설정 텍스트 파일로 저장
            string[] str = processor.SetingToStringArr();
            string path = str[4];
            System.IO.File.WriteAllLines(path, str);
            MessageBox.Show("설정 저장 완료");
            #endregion
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            SetKeyForm setKeyForm = new SetKeyForm(processor, this);
            setKeyForm.ShowDialog(this);
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //기본 설정 값으로 processor값 변경
        private void buttonDefaultSetting_Click(object sender, EventArgs e)
        {
            if (File.Exists(processor.pathDefaultSetting))
            {
                string[] tmp = File.ReadAllLines(processor.pathDefaultSetting);
                processor.SetingFromStringArr(tmp);
                redrawFromProcessor();
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);
            mouseHook.MouseWheel += new MouseEventHandler(mouseHook_MouseWheel);

            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
            keyboardHook.KeyPress += new KeyPressEventHandler(keyboardHook_KeyPress);

            mouseHook.Start();
            keyboardHook.Start();

            #region 실행시 visible 설정
            this.notifyIcon1.Visible = false;
            string tmp = processor.SetingToStringArr()[0];
            if (tmp.Equals("True"))     //2회째 실행일 경우
            {

                this.ShowInTaskbar = false;
                this.Visible = false;
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
            //최초 실행일 경우
            else
            {
                processor.ReRun = true;
                string[] str = processor.SetingToStringArr();
                string path = str[4];
                System.IO.File.WriteAllLines(path, str);
                this.notifyIcon1.Visible = false;
            }
            #endregion

            //firstAction();
            //loadKey();
        }
        #region 키보드, 마우스 후킹


        void keyboardHook_KeyPress(object sender, KeyPressEventArgs e)
        {
            processor.monitorOn();
            processor.autoRunCountRestart();    //자동 실행 다시 시작
        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            //저장된 설정과 비교
            if (e.KeyCode.ToString().Equals(processor.HotKey[0]) &&
                e.Shift.ToString().Equals(processor.HotKey[1]) &&
                e.Control.ToString().Equals(processor.HotKey[2]) &&
                e.Alt.ToString().Equals(processor.HotKey[3]))
            {
                MessageBox.Show("단축키 기능 실행");
                CountDownForm cdf = new CountDownForm(processor);
                cdf.ShowDialog(this);
            }
        }

        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
        }

        void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {
        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {
        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
        }
        //마우스 움직일 경우
        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            processor.monitorOn();
            processor.autoRunCountRestart();    //자동 실행 카운트 초기화
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Not necessary anymore, will stop when application exits

            //mouseHook.Stop();
            //keyboardHook.Stop();
        }
        #endregion
        //컨텍스트 메뉴 환경설정
        private void toolStripMenuItemOption_Click(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.notifyIcon1.Visible = false;
        }
        //컨텍스트 메뉴 단축키 설정
        private void toolStripMenuItemHotkey_Click(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.notifyIcon1.Visible = false;
            SetKeyForm setKeyForm = new SetKeyForm(processor, this);
            setKeyForm.ShowDialog(this);
        }
        //설정 모드 바로 실행
        private void toolStripMenuItemExecute_Click(object sender, EventArgs e)
        {
            CountDownForm cdf = new CountDownForm(processor);
            cdf.ShowDialog(this);
        }
        //프로그램 종료
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //X버튼 클릭시 폼 hide
        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;//이벤트 캔슬
            this.Hide();    //폼 숨김
            this.notifyIcon1.Visible = true;    //트레이 아이콘 표시
        }
    }
}
