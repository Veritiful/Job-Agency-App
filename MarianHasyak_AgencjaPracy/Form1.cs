using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianHasyak_AgencjaPracy
{
    public partial class Form1 : Form
    {
        public static List<Klient> listK = new List<Klient>();

        public static string CalculateAvgRating()
        {
            float res = 0f;
            foreach (Klient k in listK)
            {
                res += k.Rating();
            }
            res /= listK.Count;
            return "Average rating is: " + res;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPracodawca_Click(object sender, EventArgs e)
        {
            PracodwcaForm pracodwcaForm = new PracodwcaForm();
            pracodwcaForm.ShowDialog();
        }

        private void btnPracownik_Click(object sender, EventArgs e)
        {
            PracownikForm pracownikForm = new PracownikForm();
            pracownikForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.ShowDialog();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            CompareForm compareForm = new CompareForm();
            compareForm.ShowDialog();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortingForm sortingForm = new SortingForm();
            sortingForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFrom searchFrom = new SearchFrom();
            searchFrom.ShowDialog();
        }
    }
}
