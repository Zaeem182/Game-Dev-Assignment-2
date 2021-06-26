using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class BonusQ3 : Form
    {
        public static BonusQ3 instance;
        public bool correct = false;

        public BonusQ3()
        {
            InitializeComponent();
            instance = this;
        }
        int lives = 0;

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void Lives()
        {


            if (GuessTxt.Text != "W" && GuessTxt.Text != "w" & GuessTxt.Text != "A" && GuessTxt.Text != "a" && GuessTxt.Text != "T"
                && GuessTxt.Text != "t" && GuessTxt.Text != "E" && GuessTxt.Text != "e" && GuessTxt.Text != "R" && GuessTxt.Text != "r")
            {
                lives++;

                if (lives == 1)
                {
                    life1.ForeColor = Color.Red;
                    life1.Text = "</3";
                }
                if (lives == 2)
                {
                    life2.ForeColor = Color.Red;
                    life2.Text = "</3";
                }
                if (lives == 3)
                {
                    life3.ForeColor = Color.Red;
                    life3.Text = "</3";
                }
                if (lives == 4)
                {
                    life4.ForeColor = Color.Red;
                    life4.Text = "</3";
                }
                if (lives == 5)
                {
                    life5.ForeColor = Color.Red;
                    life5.Text = "</3";
                }
            }
            if (lives == 5)
            {
                SubmitBtn.Enabled = false;
                GuessTxt.Enabled = false;
                String title = "ALL LIVES LOST :(";
                MessageBox.Show("You have used up all your lives", title);
            }
        }


        private void CheckWords()
        {
            if (GuessTxt.Text == "W" || GuessTxt.Text == "w")
            {
                Placeholder1.Visible = false;
                Word1.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "A" || GuessTxt.Text == "a")
            {
                Placeholder2.Visible = false;
                Word2.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "T" || GuessTxt.Text == "t")
            {
                Placeholder3.Visible = false;

                Word3.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "E" || GuessTxt.Text == "e")
            {
                Placeholder4.Visible = false;
                Word4.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "R" || GuessTxt.Text == "r")
            {
                Placeholder5.Visible = false;
                Word5.Visible = true;
                GuessTxt.Text = "";
            }
        }

        public void Correct()
        {
            if (Word1.Visible == true && Word2.Visible == true && Word3.Visible == true && Word4.Visible == true && Word5.Visible == true)
            {
                correct = true;

                SubmitBtn.Enabled = false;
                GuessTxt.Enabled = false;
                String title = "Congratulations!";
                MessageBox.Show("MIZU '水' = 'WATER'", title);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Lives();
            CheckWords();
            Correct();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (SubmitBtn.Enabled == true)
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
                Bonus4 start = new Bonus4();
                start.Show();
            }
        }
    }
}
