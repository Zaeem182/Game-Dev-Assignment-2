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
    public partial class NounsLvl2Q4 : Form
    {
        public NounsLvl2Q4()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Bread")
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Correct_Sound.wav");
                splayer.Play();
                textBox1.ForeColor = Color.Green;
                MessageBox.Show("Correct!");
                this.Hide();
                NounsLvl2Q5 start = new NounsLvl2Q5();
                start.Show();
            }
            else
            {
                SoundPlayer splayer = new SoundPlayer(@".\Sounds\Incorrect_Sound.wav");
                splayer.Play();
                textBox1.ForeColor = Color.Red;
                MessageBox.Show("Incorrect!");
                this.Hide();
                NounsLvl2Q5 start = new NounsLvl2Q5();
                start.Show();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}