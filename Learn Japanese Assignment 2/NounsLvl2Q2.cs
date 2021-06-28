﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class NounsLvl2Q2 : Form
    {
        public static NounsLvl2Q2 instance;
        public bool correct = false;
         
        public NounsLvl2Q2()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnNext_Click(object sender, EventArgs e)
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
                NounsLvl2Q3 start = new NounsLvl2Q3();
                start.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void NounsLvl2Q2_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tomorrow" || textBox1.Text == "tomorrow")
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