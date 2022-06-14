using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianHasyak_AgencjaPracy
{
    public partial class DisplayForm : Form
    {
        private int currentPos = 0;

        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if (Form1.listK.ElementAtOrDefault(0) != null)
            {
                Form1.listK[currentPos].Write(listBox1, pictureBox1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPos < Form1.listK.Count() - 1)
            {
                listBox1.Items.Clear();
                currentPos++;
                Form1.listK[currentPos].Write(listBox1, pictureBox1);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPos > 0)
            {
                listBox1.Items.Clear();
                currentPos--;
                Form1.listK[currentPos].Write(listBox1, pictureBox1);
            }
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Plik tekstowy|*.txt";
            sfd.Title = "Podaj nazwę pliku do zapisu danych osób";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Klient k in Form1.listK)
                {
                    k.WriteToFile(sw);
                }
                sw.Close();
            }

        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.Filter = "Plik tekstowy|*.txt";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line == "PD") 
                    {
                        Pracodawca p = new Pracodawca();
                        p.ReadFromFile(sr);
                        Form1.listK.Add(p);
                    }
                    else if (line == "PW")
                    {
                        Pracownik p = new Pracownik();
                        p.ReadFromFile(sr);
                        Form1.listK.Add(p);
                    }
                }
                sr.Close();
                foreach (Klient k in Form1.listK)
                {
                    k.Write(listBox1);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Form1.listK.ElementAtOrDefault(currentPos) != null) Form1.listK.RemoveAt(currentPos);
            //currentPos element changed
            if (Form1.listK.ElementAtOrDefault(currentPos) != null)
            {
                listBox1.Items.Clear();
                Form1.listK[currentPos].Write(listBox1, pictureBox1);
            }
            else if (Form1.listK.ElementAtOrDefault(currentPos - 1) != null)
            {
                listBox1.Items.Clear();
                currentPos--;
                Form1.listK[currentPos].Write(listBox1, pictureBox1);
            }
            else 
            {
                listBox1.Items.Clear();
            }
        }

        private void btnAvgRtng_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(Form1.CalculateAvgRating());
        }
    }
}
