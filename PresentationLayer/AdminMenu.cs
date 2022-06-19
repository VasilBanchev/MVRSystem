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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseDocument form = new ChooseDocument();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserCreate form = new UserCreate();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finder form = new Finder();
            form.ShowDialog();
        }
    }
}
