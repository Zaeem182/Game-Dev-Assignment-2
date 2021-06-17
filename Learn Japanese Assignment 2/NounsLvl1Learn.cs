using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class NounsLvl1Learn : Form
    {
        public NounsLvl1Learn()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NounsLvl1Q1 start = new NounsLvl1Q1();
            start.Show();
        }
    }
}
