﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class NounsLvl1Q4 : Form
    {
        public NounsLvl1Q4()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NounsLvl1Q5 start = new NounsLvl1Q5();
            start.Show();
        }
    }
}