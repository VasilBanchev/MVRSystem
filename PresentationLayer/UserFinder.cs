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
    public partial class UserFinder : Form
    {
        UserManager manager = new UserManager(MVRSystemDBManager.CreateContext());
        User? selectedUser;
        public UserFinder()
        {
            InitializeComponent();

            dataGridView1.DataSource = manager.ReadAll().ToList();
            TableUpdate();
        }
        private void TableUpdate()
        {
            dataGridView1.DataSource = manager.ReadAll().ToList();
        }

        private void MultyUpdate(string username)
        {
            dataGridView1.DataSource = manager.ReadAll().ToList().Where(x => x.Username.Contains(username)).ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MultyUpdate(textBox1.Text);
        }
    }
}
