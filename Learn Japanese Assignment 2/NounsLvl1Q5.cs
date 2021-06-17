using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class NounsLvl1Q5 : Form
    {
        public static NounsLvl1Q5 instance;
        public bool correct = false;

        public NounsLvl1Q5()
        {
            InitializeComponent();
            instance = this;
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

        private int Score()
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                if (NounsLvl1Q1.instance.correct == true)
                {
                    i++;
                }

                if (NounsLvl1Q2.instance.correct == true)
                {
                    i++;
                }

                if (NounsLvl1Q3.instance.correct == true)
                {
                    i++;
                }
                if (NounsLvl1Q4.instance.correct == true)
                {
                    i++;
                }
                if (correct == true)
                {
                    i++;
                    break;
                }
            }
            return i;

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            String title = "You Scored";
            MessageBox.Show("" + Score() + " Out of 5", title);
        }

        private void VQ1Option2_Click(object sender, EventArgs e)
        {
            correct = true;

            VQ1Option2.BackColor = Color.Green;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }
    }
}
