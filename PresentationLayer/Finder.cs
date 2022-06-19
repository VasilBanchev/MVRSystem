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
    public partial class Finder : Form
    {
        public Finder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    CardManager manager = new CardManager(MVRSystemDBManager.GetContext());
                    Card card = manager.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                    if (card != null)
                    {
                        CardChanger newForm = new CardChanger(card);
                        newForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Не съществува лична карта с това ЕГН");
                    }

                }
                else if (radioButton2.Checked == true)
                {
                    PassportManager manager = new PassportManager(MVRSystemDBManager.GetContext());
                    Passport passport = manager.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                    if (passport != null)
                    {
                        PassportChanger newForm = new PassportChanger(passport);
                        newForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Не съществува паспорт с това ЕГН");
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    DrivingLicenseManager manager = new DrivingLicenseManager(MVRSystemDBManager.GetContext());
                    DrivingLicense drivingLicense = manager.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                    if (drivingLicense != null)
                    {
                        DrivingLicenseChanger newForm = new DrivingLicenseChanger(drivingLicense);
                        
                        newForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Не съществува шофьорска книжка с това ЕГН");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
      /*  private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString =
                    "Data Source=<SQL Server>;Initial Catalog=Northwind;" +
                    "Integrated Security=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new MySQLDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }*/
    }
}
