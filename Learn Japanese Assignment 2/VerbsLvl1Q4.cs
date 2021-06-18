﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class VerbsLvl1Q4 : Form
    {
        public static VerbsLvl1Q4 instance;
        public bool correct = false;

        public VerbsLvl1Q4()
        {
            InitializeComponent();
            instance = this;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?";
            string title = "Cancel?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Category start = new Category();
                start.Show();
            }
            else
            {
                // Closes the MessegeBox and allows user to continue with the quiz. 
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (VQ1Option1.Enabled == true || VQ1Option2.Enabled == true || VQ1Option3.Enabled == true || VQ1Option4.Enabled == true)
            {
                string message = "Please select an answer.";
                string title = "Did not Answer";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    // Closes Messege Box and allows user to answer the question again.
                }

            }
            else
            {
                this.Hide();
                VerbsLvl1Q5 start = new VerbsLvl1Q5();
                start.Show();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void VQ1Option3_Click(object sender, EventArgs e)
        {
            correct = true;

            VQ1Option3.BackColor = Color.Green;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }

        private void VQ1Option1_Click(object sender, EventArgs e)
        {
            VQ1Option3.BackColor = Color.Red;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }

        private void VQ1Option2_Click(object sender, EventArgs e)
        {
            VQ1Option2.BackColor = Color.Red;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }

        private void VQ1Option4_Click(object sender, EventArgs e)
        {
            VQ1Option4.BackColor = Color.Red;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }
    }
}
