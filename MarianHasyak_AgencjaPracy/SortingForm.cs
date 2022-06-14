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
    public partial class SortingForm : Form
    {
        public SortingForm()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            foreach (Klient k in Form1.listK) k.WriteSlim(listBoxDisplay);
        }

        private void btnSortDisplay_Click(object sender, EventArgs e)
        {
            Form1.listK.Sort();
            listBoxDisplay.Items.Clear();
            foreach (Klient k in Form1.listK) k.WriteSlim(listBoxDisplay);
        }
    }
}
