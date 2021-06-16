using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class ProunounsLvl2Learn : Form
    {
        public ProunounsLvl2Learn()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            
        }

        private void ProunounsLvl2Learn_Load(object sender, EventArgs e)
        {

        }

        string[] Pronouns = { "Watashi(私)", "Anata(貴方)", "Kare(彼)", "Kanojo(彼女)", "kare-ra(彼等)", "Wareware(我々)", "Min'na(みんな)", "Dare(誰)", "Nani(何)" };
        static int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            lbl1.Text = Pronouns[i];
            i = (i + 1) % 9;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
