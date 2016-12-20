using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnergySaver_CsProject
{
    public partial class CountDownForm : Form
    {
        Processor processor;
        Timer timer;
        bool modeExe = false;   //mode값에 따라 수행 여부
        MODE mode;
        int count = 15;
        public CountDownForm()
        {
            InitializeComponent();
        }
        public CountDownForm(Processor _processor) : this()
        {
            processor = _processor;
            modeExe = false;
            timer = new Timer();
            timer.Interval = 1000;  //1000ms 단위로 카운트
            timer.Tick += new EventHandler(countdown);
            timer.Start();
            progressBar1.Maximum = 15;
        }
        public CountDownForm(Processor _processor, MODE _mode) : this()
        {
            mode = _mode;
            modeExe = true;
            processor = _processor;
            timer = new Timer();
            timer.Interval = 1000;  //1000ms 단위로 카운트
            timer.Tick += new EventHandler(countdown);
            timer.Start();
            progressBar1.Maximum = 15;
        }
        void countdown(object sender, EventArgs e)
        {
            count--;
            if (count <= 0)
            {
                if (modeExe)    //매개변수 mode 에 따라 실행
                {
                    switch (mode)
                    {
                        case MODE.MonitorOff:
                            timer.Stop();
                            processor.monitorOff();
                            break;
                        case MODE.Stanby:
                            timer.Stop();
                            processor.standby();
                            break;
                        case MODE.MaxSave:
                            timer.Stop();
                            processor.savePower();
                            break;
                        case MODE.Turnoff:
                            timer.Stop();
                            processor.turnOff();
                            break;
                    }
                    this.Dispose();
                }
                else
                {   //processor의 mode에 따라 실행
                    timer.Stop();
                    processor.ExecuteMode();
                    this.Dispose();
                }
            }
            label1.Text = (15 - (++progressBar1.Value)) + "초 후에 실행합니다.";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (modeExe)
            {
                switch (mode)
                {
                    case MODE.MonitorOff:
                        timer.Stop();
                        processor.monitorOff();
                        break;
                    case MODE.Stanby:
                        timer.Stop();
                        processor.standby();
                        break;
                    case MODE.MaxSave:
                        timer.Stop();
                        processor.savePower();
                        break;
                    case MODE.Turnoff:
                        timer.Stop();
                        processor.turnOff();
                        break;
                }
                this.Dispose();
            }
            else
            {
                timer.Stop();
                processor.ExecuteMode();
            }
            this.Dispose();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Dispose();
        }
    }
}
