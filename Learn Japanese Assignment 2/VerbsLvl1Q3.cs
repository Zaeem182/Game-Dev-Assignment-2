﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class VerbsLvl1Q3 : Form
    {
        public VerbsLvl1Q3()
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
            VerbsLvl1Q4 start = new VerbsLvl1Q4();
            start.Show();
        }

        private void VerbsLvl1Q3_Load(object sender, EventArgs e)
        {

        }
    }
}
