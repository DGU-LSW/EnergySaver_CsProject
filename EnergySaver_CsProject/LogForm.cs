using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EnergySaver_CsProject
{
    public partial class LogForm : Form
    {
        Processor processor;
        OptionForm of;
        public LogForm()
        {
            InitializeComponent();
        }
        public LogForm(Processor _processor, OptionForm _of) : this()
        {
            processor = _processor;
            of = _of;
            textBoxLog.Text = processor.ServerLog;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "로그 저장";
            saveFileDialog.Filter = "텍스트 파일 (*.txt) |*.txt|모든 파일(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dir = saveFileDialog.FileName;
                FileStream fs = new FileStream(
                    saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBoxLog.Text);

                sw.Flush();
                sw.Close();
                fs.Close();
            }
            this.Close();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            textBoxLog.Text = processor.ServerLog;
        }
    }
}
