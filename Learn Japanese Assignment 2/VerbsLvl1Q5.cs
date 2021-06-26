using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class VerbsLvl1Q5 : Form
    {
        public static VerbsLvl1Q5 instance;
        public bool correct = false;

        public VerbsLvl1Q5()
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VQ1Option4_Click(object sender, EventArgs e)
        {
            correct = true;

            VQ1Option4.BackColor = Color.Green;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }

        private int Score()
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                if (VerbsLvl1Q1.instance.correct == true)
                {
                    i++;
                }

                if (VerbsLvl1Q2.instance.correct == true)
                {
                    i++;
                }

                if (VerbsLvl1Q3.instance.correct == true)
                {
                    i++;
                }
                if (VerbsLvl1Q4.instance.correct == true)
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

        private void SubmitBtn_Click(object sender, EventArgs e)
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
                String title = "You Scored";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("" + Score() + " Out of 5", title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Category start = new Category();
                    start.Show();
                }
            }
        }

        private void VQ1Option1_Click(object sender, EventArgs e)
        {
            VQ1Option1.BackColor = Color.Red;

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

        private void VQ1Option3_Click(object sender, EventArgs e)
        {
            VQ1Option3.BackColor = Color.Red;

            VQ1Option1.Enabled = false;
            VQ1Option2.Enabled = false;
            VQ1Option3.Enabled = false;
            VQ1Option4.Enabled = false;
        }
    }
}
