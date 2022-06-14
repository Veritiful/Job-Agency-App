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
    public partial class SearchFrom : Form
    {
        public SearchFrom()
        {
            InitializeComponent();
            listView1.Items.Clear();
            foreach (Klient kl in Form1.listK)
            kl.WriteLV(listView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked)
            {
                List<Klient> searchR = Form1.listK
                .Where(a => a.WhereName(textBox2.Text))
                .Where(a => a.WhereAge(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)))
                .ToList();

                listView1.Items.Clear();
                foreach (Klient kl in searchR)
                kl.WriteLV(listView1);
            }
            else if(checkBox1.Checked)
            {
                List<Klient> searchR = Form1.listK
                .Where(a => a.WhereName(textBox2.Text))
                .ToList();

                listView1.Items.Clear();
                foreach (Klient kl in searchR)
                kl.WriteLV(listView1);
            }
            else if(checkBox2.Checked)
            {
                List<Klient> searchR = Form1.listK
                .Where(a => a.WhereAge(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)))
                .ToList();

                listView1.Items.Clear();
                foreach (Klient kl in searchR)
                kl.WriteLV(listView1);
            }
            else
            {
                listView1.Items.Clear();
                foreach (Klient kl in Form1.listK)
                kl.WriteLV(listView1);
            }

        }
    }
}
