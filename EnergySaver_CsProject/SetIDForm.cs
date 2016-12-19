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
    public partial class SetIDForm : Form
    {
        Processor processor;
        OptionForm of;
        public SetIDForm()
        {
            InitializeComponent();
        }
        public SetIDForm(Processor _processor, OptionForm _of) : this()
        {
            processor = _processor;
            of = _of;
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            processor.ID = textBoxID.Text;
            of.redrawID();
            this.Close();
        }
    }
}
