using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class PronounsLvl1Q2 : Form
    {
        public PronounsLvl1Q2()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PronounsLvl1Q3 start = new PronounsLvl1Q3();
            start.Show();
        }
    }
}
