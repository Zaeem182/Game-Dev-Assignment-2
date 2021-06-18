using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class ProunounsLvl2Q2 : Form
    {
        public ProunounsLvl2Q2()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "We")
            {
                textBox1.ForeColor = Color.Green;
                MessageBox.Show("Correct!");
                this.Hide();
                ProunounsLvl2Q3 start = new ProunounsLvl2Q3();
                start.Show();
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                MessageBox.Show("Incorrect!");
                this.Hide();
                ProunounsLvl2Q3 start = new ProunounsLvl2Q3();
                start.Show();

            }

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
