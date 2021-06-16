using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class PronounsLvl1Q1 : Form
    {
        public PronounsLvl1Q1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PQ1Option3_Click(object sender, EventArgs e)
        {
            PQ1Option3.BackColor = Color.Green;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PronounsLvl1Q2 start = new PronounsLvl1Q2();
            start.Show();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }
    }
}
