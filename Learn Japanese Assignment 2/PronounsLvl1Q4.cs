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
    public partial class PronounsLvl1Q4 : Form
    {
        public static PronounsLvl1Q4 instance;
        public bool correct = false;

        public PronounsLvl1Q4()
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
            if (PQ1Option1.Enabled == true || PQ1Option2.Enabled == true || PQ1Option3.Enabled == true || PQ1Option4.Enabled == true)
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
                PronounsLvl1Q5 start = new PronounsLvl1Q5();
                start.Show();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Correct Answer
        private void PQ1Option4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Correct_Sound.wav");
            splayer.Play();

            correct = true;

            PQ1Option4.BackColor = Color.Green;

            PQ1Option1.Enabled = false;
            PQ1Option2.Enabled = false;
            PQ1Option3.Enabled = false;
            PQ1Option4.Enabled = false;
        }

        //Wrong Answers
        private void PQ1Option1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
            splayer.Play();

            PQ1Option1.BackColor = Color.Red;

            PQ1Option1.Enabled = false;
            PQ1Option2.Enabled = false;
            PQ1Option3.Enabled = false;
            PQ1Option4.Enabled = false;
        }

        private void PQ1Option2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
            splayer.Play();

            PQ1Option2.BackColor = Color.Red;

            PQ1Option1.Enabled = false;
            PQ1Option2.Enabled = false;
            PQ1Option3.Enabled = false;
            PQ1Option4.Enabled = false;
        }

        private void PQ1Option3_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
            splayer.Play();

            PQ1Option3.BackColor = Color.Red;

            PQ1Option1.Enabled = false;
            PQ1Option2.Enabled = false;
            PQ1Option3.Enabled = false;
            PQ1Option4.Enabled = false;
        }
    }
}
