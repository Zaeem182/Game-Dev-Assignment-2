using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen start = new StartScreen();
            start.Show();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {


        }

        private void btnPerson_Click(object sender, EventArgs e)
        {

        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            btnPeople.BackColor = Color.Green;
        }

        private void btnEarth_Click(object sender, EventArgs e)
        {

        }
    }
}
