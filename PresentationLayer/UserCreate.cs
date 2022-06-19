using BusinessLayer;
using ServiceLayer;
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
    public partial class UserCreate : Form
    {
        UserManager manager = new UserManager(MVRSystemDBManager.GetContext());

        public UserCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool admin = false;
                if (radioButton1.Checked)
                {
                    admin = true;
                }
                User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, admin);

                manager.Create(user);

                MessageBox.Show("Успешно създаден потребител");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
