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
    public partial class CompareForm : Form
    {
        public CompareForm()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.listK.Count; i++)
            {
                if(Form1.listK[i] is Pracodawca)
                {
                    firstCombo.Items.Add(i);
                    secondCombo.Items.Add(i);
                }
            }

        }

        private void CompareForm_Load(object sender, EventArgs e)
        {

        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            bool result = false;

            int fc = Convert.ToInt32(firstCombo.Items[firstCombo.SelectedIndex].ToString());
            int sc = Convert.ToInt32(secondCombo.Items[secondCombo.SelectedIndex].ToString());

            Pracodawca pd1 = (Pracodawca)Form1.listK[fc];
            Pracodawca pd2 = (Pracodawca)Form1.listK[sc];
            if (operatorCombo.SelectedIndex == 0) result = pd1 == pd2;
            if (operatorCombo.SelectedIndex == 1) result = pd1 != pd2;
            if (operatorCombo.SelectedIndex == 2) result = pd1 > pd2;
            if (operatorCombo.SelectedIndex == 3) result = pd1 < pd2;
            res.Text = result.ToString();
        }
    }
}
