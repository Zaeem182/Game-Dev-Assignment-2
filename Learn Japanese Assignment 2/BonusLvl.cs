using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

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
                    SoundPlayer splayer = new SoundPlayer(@".\Sounds\8_bit_incorrect_bonus.wav");
                    splayer.Play();

                    life1.ForeColor = Color.Red;
                    life1.Text = "</3";
                }
                if (lives == 2)
                {
                    SoundPlayer splayer = new SoundPlayer(@".\Sounds\8_bit_incorrect_bonus.wav");
                    splayer.Play();

                    life2.ForeColor = Color.Red;
                    life2.Text = "</3";
                }
                if (lives == 3)
                {
                    SoundPlayer splayer = new SoundPlayer(@".\Sounds\8_bit_incorrect_bonus.wav");
                    splayer.Play();

                    life3.ForeColor = Color.Red;
                    life3.Text = "</3";
                }
                if (lives == 4)
                {
                    SoundPlayer splayer = new SoundPlayer(@".\Sounds\8_bit_incorrect_bonus.wav");
                    splayer.Play();

                    life4.ForeColor = Color.Red;
                    life4.Text = "</3";
                }
                if (lives == 5)
                {
                    SoundPlayer splayer = new SoundPlayer(@".\Sounds\8_bit_incorrect_bonus.wav");
                    splayer.Play();

                    life5.ForeColor = Color.Red;
                    life5.Text = "</3";
                }
            }
            if (lives == 5) 
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_sound.wav");
                splayer.Play();

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
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Ding_Sound_Bonus.wav");
                splayer.Play();

                Placeholder1.Visible = false;
                Word1.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "A" || GuessTxt.Text == "a")
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Ding_Sound_Bonus.wav");
                splayer.Play();

                Placeholder2.Visible = false;
                Word2.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "P" || GuessTxt.Text == "p")
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Ding_Sound_Bonus.wav");
                splayer.Play();

                Placeholder3.Visible = false;
                Placeholder4.Visible = false;

                Word3.Visible = true;
                Word4.Visible = true;
                GuessTxt.Text = "";
            }
            if (GuessTxt.Text == "Y" || GuessTxt.Text == "y")
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Ding_Sound_Bonus.wav");
                splayer.Play();

                Placeholder5.Visible = false;
                Word5.Visible = true;
                GuessTxt.Text = "";
            }
        }

        public void Correct() 
        {
            if (Word1.Visible == true && Word2.Visible == true && Word3.Visible == true && Word4.Visible == true && Word5.Visible == true)
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Correct_Sound.wav");
                splayer.Play();

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

