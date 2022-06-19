using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class LogIn : Form
    {
        UserManager _manager = new UserManager();
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_manager.CorrectLogin(textBox1.Text.ToString(), textBox2.Text.ToString()))
                {
                    MessageBox.Show("Успешно влизане");
                    User user = _manager.ReadAll().ToList().Find(x => x.Username == textBox1.Text && x.Password == textBox2.Text);

                    if (user.IsAdmin == true)
                    {
                        AdminMenu newForm = new AdminMenu();
                        newForm.Parent = this;
                        newForm.ShowDialog();
                    }
                    else
                    {
                        NonAdminMenu newForm = new NonAdminMenu();
                        newForm.Parent = this;
                        newForm.ShowDialog();
                    }
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Грешно потребителско име или парола");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CorrectLogin(string username, string password)
        {
            List<User> users = _manager.ReadAll().ToList();
            try
            {
                User user = users.Find(x => x.Username == username && x.Password == password);

                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {

                throw;
                return false;
            }


        }

    }
}