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
        int count = 15;
        public CountDownForm()
        {
            InitializeComponent();
        }
        public CountDownForm(Processor _processor) : this()
        {
            processor = _processor;
            timer = new Timer();
            timer.Interval = 1000;  //1000ms 단위로 카운트
            timer.Tick += new EventHandler(countdown);
            timer.Start();
            progressBar1.Maximum = 15;
        }
        void countdown(object sender, EventArgs e)
        {
            label1.Text = (15 - (++progressBar1.Value)) + "초 후에 실행합니다.";
            count--;
            if (count <= 0)
            {
                timer.Stop();
                processor.ExecuteMode();
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            timer.Stop();
            processor.ExecuteMode();
            this.Dispose();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Dispose();
        }
    }
}
