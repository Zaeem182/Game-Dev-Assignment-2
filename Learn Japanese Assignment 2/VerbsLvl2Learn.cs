using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class VerbsLvl2Learn : Form
    {
        public VerbsLvl2Learn()
        {
            InitializeComponent();
        }

        string[] Verbs = { "Iku(行く)", "Desu(です)", "Naru(なる)", "hajimaru(はじまる)", "shinjiru(しんじる)", "kawaru(変える)", "kiru(きる)", "taberu(たべる)", "okiru(おきる)", "kamu(かむ)" };
        static int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            lbl1.Text = Verbs[i];
            i = (i + 1) % 10;
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
    }
}
