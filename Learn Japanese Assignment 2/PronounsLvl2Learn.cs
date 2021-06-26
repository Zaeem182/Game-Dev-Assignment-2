using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class PronounsLvl2Learn : Form
    {
        public PronounsLvl2Learn()
        {
            InitializeComponent();
        }

        private void PLvl1Lbl_Click(object sender, EventArgs e)
        {

        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            string message = "Are you ready to start the quiz?";
            string title = "Start?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                PronounsLvl2Q1 start = new PronounsLvl2Q1();
                start.Show();
            }
        }

        private void PronounsLvl2Learn_Load(object sender, EventArgs e)
        {

        }
    }
}
