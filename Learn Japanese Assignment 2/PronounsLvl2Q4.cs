﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class PronounsLvl2Q4 : Form
    {
        public PronounsLvl2Q4()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Who")
            {
                textBox1.ForeColor = Color.Green;
                MessageBox.Show("Correct!");
                this.Hide();
                PronounsLvl2Q5 start = new PronounsLvl2Q5();
                start.Show();
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                MessageBox.Show("Incorrect!");
                this.Hide();
                PronounsLvl2Q5 start = new PronounsLvl2Q5();
                start.Show();

            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}