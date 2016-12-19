using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EnergySaver_CsProject
{
    public partial class SetKeyForm : Form
    {
        Processor processor;
        OptionForm of;
        public SetKeyForm()
        {
            InitializeComponent();
        }
        public SetKeyForm(Processor _processor, OptionForm _of) : this()
        {
            processor = _processor;
            of = _of;
            comboBoxKey.Text = of.TmpKey[0].ToString();
            if (of.TmpKey[1].Equals("True"))
            {
                checkBoxShift1.Checked = true;
            }
            else
            {
                checkBoxShift1.Checked = false;
            }
            if (of.TmpKey[2].Equals("True"))
            {
                checkBoxCtrl1.Checked = true;
            }
            else
            {
                checkBoxCtrl1.Checked = false;
            }
            if (of.TmpKey[3].Equals("True"))
            {
                checkBoxAlt1.Checked = true;
            }
            else
            {
                checkBoxAlt1.Checked = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            of.TmpKey[0] = comboBoxKey.Text;
            of.TmpKey[1] = checkBoxShift1.Checked.ToString();   //shift
            of.TmpKey[2] = checkBoxCtrl1.Checked.ToString();    //ctrl
            of.TmpKey[3] = checkBoxAlt1.Checked.ToString();     //alt
            this.Close();
        }
    }
}
