using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ChooseDocument : Form
    {
        public ChooseDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardCreator form = new CardCreator();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassportCreator form = new PassportCreator();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrivingLicenseCreator form = new DrivingLicenseCreator();
            form.ShowDialog();
        }
    }
}
