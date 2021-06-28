using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class VerbsLvl2Q5 : Form
    {
        public static VerbsLvl2Q5 instance;
        public bool correct = false;
        public VerbsLvl2Q5()
        {
            InitializeComponent();
            instance = this;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
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
                Category start = new Category();
                start.Show();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int Score()
        {
            int counter = 0;

            if (VerbsLvl2Q1.instance.correct == true)
            {
                counter++;
            }

            if (VerbsLvl2Q2.instance.correct == true)
            {
                counter++;
            }

            if (VerbsLvl2Q3.instance.correct == true)
            {
                counter++;
            }
            if (VerbsLvl2Q4.instance.correct == true)
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
            if (textBox1.Text == "Bite" || textBox1.Text == "bite")
            {
                textBox1.Enabled = false;
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Correct_Sound.wav");
                splayer.Play();
                textBox1.ForeColor = Color.Green;
                MessageBox.Show("Correct!");
                correct = true;

            }
            else
            {
                textBox1.Enabled = false;
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
                splayer.Play();
                textBox1.ForeColor = Color.Red;
                MessageBox.Show("Incorrect!");


            }
        }
    }
}
