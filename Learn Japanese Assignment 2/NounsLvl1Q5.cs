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

        private int Score()
        {
            int counter = 0;

                if (NounsLvl1Q1.instance.correct == true)
                {
                    counter++;
                }

                if (NounsLvl1Q2.instance.correct == true)
                {
                    counter++;
                }

                if (NounsLvl1Q3.instance.correct == true)
                {
                    counter++;
                }
                if (NounsLvl1Q4.instance.correct == true)
                {
                    counter++;
                }
                if (correct == true)
                {
                    counter++;
                }
            return counter;
        }



       
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (NQ1Option1.Enabled == true || NQ1Option2.Enabled == true || NQ1Option3.Enabled == true || NQ1Option4.Enabled == true)
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

        //Correct Answer
        private void NQ1Option2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Correct_Sound.wav");
            splayer.Play();

            correct = true;

            NQ1Option2.BackColor = Color.Green;

            NQ1Option1.Enabled = false;
            NQ1Option2.Enabled = false;
            NQ1Option3.Enabled = false;
            NQ1Option4.Enabled = false;
        }

        //Wrong Answers
        private void NQ1Option1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
            splayer.Play();

            NQ1Option1.BackColor = Color.Red;

            NQ1Option1.Enabled = false;
            NQ1Option2.Enabled = false;
            NQ1Option3.Enabled = false;
            NQ1Option4.Enabled = false;
        }

        private void NQ1Option3_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
            splayer.Play();

            NQ1Option3.BackColor = Color.Red;

            NQ1Option1.Enabled = false;
            NQ1Option2.Enabled = false;
            NQ1Option3.Enabled = false;
            NQ1Option4.Enabled = false;
        }

        private void NQ1Option4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
            splayer.Play();

            NQ1Option4.BackColor = Color.Red;

            NQ1Option1.Enabled = false;
            NQ1Option2.Enabled = false;
            NQ1Option3.Enabled = false;
            NQ1Option4.Enabled = false;
        }
    }
}
