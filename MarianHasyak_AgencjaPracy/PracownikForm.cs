using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianHasyak_AgencjaPracy
{
    public partial class PracownikForm : Form
    {
        public PracownikForm()
        {
            InitializeComponent();
            //Default image on load
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\empty.png");
            Bitmap bitmapPh = new Bitmap(path);
            pictureBox1.Image = bitmapPh;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pracownik pc = new Pracownik(peselMasked.Text, Convert.ToInt32(Math.Round(yearNumeric.Value, 0)), nameTextBox.Text, surnameTextBox.Text, countryTextBox.Text, cityTextBox.Text, emailTextBox.Text, Convert.ToSingle(ratingNumeric.Value), birthdayDateTime.Value, new Bitmap(pictureBox1.Image), hasEducationCheck.Checked, jobTextBox.Text, Convert.ToInt32(Math.Round(yearStartedNumeric.Value, 0)), expTextBox.Text, skillsTextBox.Text.Split(',').ToList());
            pc.Write(listBox1);
            //
            Form1.listK.Add(pc);
        }
        
        private void photoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                Bitmap bitmapPh;

                try
                {
                    bitmapPh = new Bitmap(fileName);
                    pictureBox1.Image = bitmapPh;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            peselMasked.Text = "01938538299";
            yearNumeric.Value = 2002;
            nameTextBox.Text = "Eryk";
            surnameTextBox.Text = "Botkowski";
            countryTextBox.Text = "Poland";
            cityTextBox.Text = "Opole";
            emailTextBox.Text = "erykbytkowski@mail.com";
            ratingNumeric.Value = (decimal)8f; 
            birthdayDateTime.Value = new DateTime(2002, 12, 31);
            hasEducationCheck.Checked = false;
            jobTextBox.Text = "programmer";
            yearStartedNumeric.Value = 2019;
            expTextBox.Text = "Frontend developer";
            skillsTextBox.Text = "creative, team player";
        }

        private void peselMasked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Too long for PESEL!");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string randomPesel = "";

            for (int i = 0; i < 11; i++)
            {
                randomPesel += random.Next(0, 10);
            }
            peselMasked.Text = randomPesel;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            if (name != null && surname != null)
            {
                emailTextBox.Text = name.ToLower() + surname.ToLower() + "@mail.com";
            }
        }
    }
}
