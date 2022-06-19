using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class CardCreator : Form
    {
        CardManager _manager = new CardManager(MVRSystemDBManager.GetContext());
        string unicodeID = "0000000000";
        string imagePath = "";
        public CardCreator()
        {
            InitializeComponent();
            try
            {
                Card card = _manager.ReadAll().Last();
                unicodeID = $"{(Convert.ToInt32(card.Id) + 1):d9}";
            }
            catch (Exception)
            {

                unicodeID = "000000001";
            }
          
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //  FamiliyaLabel.BackColor = pictureBox1.BackColor;
            ExpiryLabel.Text = DateTime.Now.AddYears(10).ToShortDateString();
            DateOfAuthorityLabel.Text = DateTime.Now.ToShortDateString();

            DocNumLabel.Text = unicodeID;

            UniCode1Label.Text = $"IDBGN{unicodeID}<<<<<<<<<<<<<<<";
            UniCode2Label.Text = $"--------{DateTime.Now.AddYears(10).Year.ToString()[2]}{DateTime.Now.AddYears(10).Year.ToString()[3]}{((short)DateTime.Now.Month):d2}{DateTime.Now.Day:d2}-BGR----------<-";
            UniCode3Label.Text = "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";

        }
        private string ConvertText(string text)
        {
            return text;
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                Stream fileStream = null;

                if (openFileDialog.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog.OpenFile()) != null)
                {
                    string fileName = openFileDialog.FileName;
                    string path = "";
                    path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                    pictureBox3.Image = Image.FromFile(path);
                    pictureBox4.Image = Image.FromFile(path);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ImeLabel.Text = NameTB.Text;
                NameLabel.Text = Converter.ConvertToLatin(NameTB.Text);
                string code = Converter.ConvertToLatin(SurnameTB.Text) + "<<" + Converter.ConvertToLatin(NameTB.Text) + "<" + Converter.ConvertToLatin(MidNameTB.Text);

                UniCode3Label.Text = UniCodeNew(UniCode3Label.Text, code, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }



        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        #region tupi_metodi
        private void CardChanger_SizeChanged(object sender, EventArgs e)
        {

        }


        private void CardChanger_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void CardChanger_Resize(object sender, EventArgs e)
        {

        }

        private void CardChanger_SizeChanged_1(object sender, EventArgs e)
        {

        }

        private void CardChanger_DragOver(object sender, DragEventArgs e)
        {

        }

        private void CardChanger_MinimumSizeChanged(object sender, EventArgs e)
        {

        }

        private void CardChanger_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CardChanger_Click(object sender, EventArgs e)
        {

        }

        private void CardChanger_Move(object sender, EventArgs e)
        {

        }

        private void CardChanger_LocationChanged(object sender, EventArgs e)
        {

        }

        private void CardChanger_DragLeave(object sender, EventArgs e)
        {

        }

        private void CardChanger_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void CardChanger_DoubleClick(object sender, EventArgs e)
        {

        }
        #endregion

        private void MidNameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PrezimeLabel.Text = MidNameTB.Text;
                MidNameLabel.Text = Converter.ConvertToLatin(MidNameTB.Text);

                string code = Converter.ConvertToLatin(SurnameTB.Text) + "<<" + Converter.ConvertToLatin(NameTB.Text) + "<" + Converter.ConvertToLatin(MidNameTB.Text);

                UniCode3Label.Text = UniCodeNew(UniCode3Label.Text, code, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FamiliyaLabel.Text = SurnameTB.Text;
                FamiliyaBackLabel.Text = SurnameTB.Text;
                SurnameLabel.Text = Converter.ConvertToLatin(SurnameTB.Text);

                string code = Converter.ConvertToLatin(SurnameTB.Text) + "<<" + Converter.ConvertToLatin(NameTB.Text) + "<" + Converter.ConvertToLatin(MidNameTB.Text);

                UniCode3Label.Text = UniCodeNew(UniCode3Label.Text, code, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void IDnumTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EGNLabel.Text = IDnumTB.Text;
                if (IDnumTB.Text.Length == 6)
                {
                    string finalDate = string.Empty;
                    string egnvalue = IDnumTB.Text;
                    string yearNum = egnvalue[0].ToString();
                    yearNum += egnvalue[1].ToString();
                    string monthNum = egnvalue[2].ToString();
                    monthNum += egnvalue[3].ToString();
                    string dateNum = egnvalue[4].ToString();
                    dateNum += egnvalue[5].ToString();
                    string newUnicode = string.Empty;
                    if (int.Parse(monthNum) < 20)
                    {
                        finalDate = $"{dateNum}.{monthNum}.19{yearNum}";
                        newUnicode = dateNum + $"{(int.Parse(monthNum)):D2}" + yearNum;
                    }
                    else if (int.Parse(monthNum) < 40)
                    {
                        finalDate = $"{dateNum}.{int.Parse(monthNum) - 20}.18{yearNum}";

                        newUnicode = dateNum + $"{(int.Parse(monthNum) - 20):D2}" + yearNum;
                    }
                    else
                    {
                        finalDate = $"{dateNum}.{int.Parse(monthNum) - 40}.20{yearNum}";
                        newUnicode = dateNum + $"{(int.Parse(monthNum) - 40):D2}" + yearNum;
                    }
                    DateOfBirth.Text = finalDate;

                    Random contrNum = new Random();
                    newUnicode += contrNum.Next(0, 10).ToString();
                    UniCode2Label.Text = UniCodeNew(UniCode2Label.Text, newUnicode, 1);


                }
                if (IDnumTB.Text.Length == 9)
                {
                    int genderNum = Convert.ToInt32(IDnumTB.Text[8]);
                    if (genderNum % 2 == 0)
                    {
                        GenderLabel.Text = "М/М";
                        UniCode2Label.Text = UniCodeNew(UniCode2Label.Text, "M", 8);
                    }
                    else
                    {
                        GenderLabel.Text = "Ж/F";
                        UniCode2Label.Text = UniCodeNew(UniCode2Label.Text, "F", 8);

                    }
                    Random contrNum = new Random();
                    UniCode2Label.Text = UniCodeNew(UniCode2Label.Text, contrNum.Next(0, 10).ToString(), 15);
                }

                if (IDnumTB.Text.Length == 10)
                {
                    Random contrNum = new Random();

                    UniCode2Label.Text = UniCodeNew(UniCode2Label.Text, IDnumTB.Text + "<" + contrNum.Next(0, 10).ToString(), 19);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //  DateOfBirth.Text = dateTimePicker1.Text;
        }

        private void RegionTB_TextChanged(object sender, EventArgs e)
        {
            try
            {

                PlaceOfBirth1Label.Text = "обл. " + RegionTB.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TownshipTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlaceOfBirth2Label.Text = "общ. " + TownshipTB.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }
        private void CityTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlaceOfBirth3label.Text = "гр." + CityTB.Text + "/" + Converter.ConvertToLatin(CityTB.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddressTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlaceOfBirth4label.Text = "ул. " + AddressTB.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                HeightLabel.Text = numericUpDown1.Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void EyecolourTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EyesColour.Text = EyecolourTB.Text + "/" + Converter.ConvertToLatin(EyecolourTB.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void PlaceTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PlaceOfBirthLabel.Text = PlaceTB.Text + "/" + Converter.ConvertToLatin(PlaceTB.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CardChanger_Load(object sender, EventArgs e)
        {

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = comboBox1.SelectedIndex;
                comboBox1.SelectedItem.ToString();
                Authority.Text = comboBox1.Items[selectedIndex].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private string UniCodeNew(string unicode, string symbols, int rangeMin)
        {
            try
            {
                string newCode = "";
                for (int i = 0; i < rangeMin - 1; i++)
                {
                    newCode += unicode[i];
                }
                newCode += symbols;
                for (int i = rangeMin + symbols.Length - 1; i < unicode.Length; i++)
                {
                    newCode += unicode[i];
                }
                return newCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           Card idCard = new Card(unicodeID ,IDnumTB.Text, pictureBox3.ImageLocation, NameTB.Text, MidNameTB.Text, SurnameTB.Text,GenderLabel.Text, DateOfBirth.Text,ExpiryLabel.Text, PlaceTB.Text, PlaceOfBirth4label.Text,RegionTB.Text,CityTB.Text, TownshipTB.Text, Convert.ToInt32(numericUpDown1.Value), EyecolourTB.Text, Authority.Text, DateTime.Now.ToString(), UniCode1Label.Text, UniCode2Label.Text, UniCode3Label.Text);
           _manager.Create(idCard);

            ResetFormData();
            
        
        }

        private void ResetFormData()
        {
            try
            {
             /*   CardChanger newForm = new CardChanger();
                this.Hide();
                newForm.ShowDialog();
                this.Close();*/

                AddressTB.Clear();
                CityTB.Clear();
                EyecolourTB.Clear();
                IDnumTB.Clear();
                MidNameTB.Clear();
                NameTB.Clear();
                PlaceTB.Clear();
                RegionTB.Clear();
                SurnameTB.Clear();
                TownshipTB.Clear();
                numericUpDown1.Value = 170;
                comboBox1.ResetText();

                Authority.ResetText();
                DateOfBirth.ResetText();
                ImeLabel.ResetText();
                DateOfAuthorityLabel.ResetText();
                DocNumLabel.ResetText();
                EGNLabel.ResetText();
                ExpiryLabel.ResetText();
                FamiliyaBackLabel.ResetText();
                FamiliyaLabel.ResetText();
                GenderLabel.ResetText();
                HeightLabel.ResetText();
                ImeLabel.ResetText();
                MidNameLabel.ResetText();
                NameLabel.ResetText();
                PlaceOfBirth1Label.ResetText();
                PlaceOfBirth2Label.ResetText();
                PlaceOfBirth3label.ResetText();
                PlaceOfBirth4label.ResetText();
                PlaceOfBirthLabel.ResetText();
                PrezimeLabel.ResetText();
                SurnameLabel.ResetText();

                UniCode1Label.Text = $"IDBGN{unicodeID}<<<<<<<<<<<<<<<";
                UniCode2Label.Text = $"--------{DateTime.Now.AddYears(10).Year.ToString()[2]}{DateTime.Now.AddYears(10).Year.ToString()[3]}{((short)DateTime.Now.Month):d2}{DateTime.Now.Day:d2}-BGR----------<-";
                UniCode3Label.Text = "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void PrezimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
