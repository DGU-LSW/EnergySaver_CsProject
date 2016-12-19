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
    public partial class SetIPForm : Form
    {
        Processor processor;
        OptionForm of;
        public SetIPForm()
        {
            InitializeComponent();
        }
        public SetIPForm(Processor _processor, OptionForm _of) : this()
        {
            processor = _processor;
            of = _of;
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            processor.IP = textBoxIP.Text;
            processor.PortNUM = textBoxPortNum.Text;
            of.redrawIP();
            this.Close();
        }
    }
}
