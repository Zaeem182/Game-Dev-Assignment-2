using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class BonusLvl : Form
    {
        public static BonusLvl instance;
        public bool correct = false;

        public BonusLvl()
        {
            InitializeComponent();
            instance = this;
        }
        int lives = 0;

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
        
        private void Lives()
        {


            if (GuessTxt.Text != "H" && GuessTxt.Text != "h" & GuessTxt.Text != "A" && GuessTxt.Text != "a" && GuessTxt.Text != "P"
                && GuessTxt.Text != "p" && GuessTxt.Text != "Y" && GuessTxt.Text != "y")
            {
                lives++;

                if (lives == 1)
                {
                    life1.Text = "</3";
                }
                if (lives == 2)
                {
                    life2.Text = "</3";
                }
                if (lives == 3)
                {
                    life3.Text = "</3";
                }
                if (lives == 4)
                {
                    life4.Text = "</3";
                }
                if (lives == 5)
                {
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
            if (GuessTxt.Text == "H"|| GuessTxt.Text == "h")
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
            if (GuessTxt.Text == "P" || GuessTxt.Text == "p")
            {
                Placeholder3.Visible = false;
                Placeholder4.Visible = false;

                Word3.Visible = true;
                Word4.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "Y" || GuessTxt.Text == "y")
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
                MessageBox.Show("URESHII '嬉しい' = 'HAPPY'", title);
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
                BonusQ2 start = new BonusQ2();
                start.Show();
            }
        }
    }
}

