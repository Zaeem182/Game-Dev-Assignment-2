using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class PronounsLvl1Q3 : Form
    {
        public static PronounsLvl1Q3 instance;
        public bool correct = false;

        public PronounsLvl1Q3()
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
            this.Hide();
            PronounsLvl1Q4 start = new PronounsLvl1Q4();
            start.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PQ1Option3_Click(object sender, EventArgs e)
        {
            correct = true;

            PQ1Option3.BackColor = Color.Green;

            PQ1Option1.Enabled = false;
            PQ1Option2.Enabled = false;
            PQ1Option3.Enabled = false;
            PQ1Option4.Enabled = false;
        }
    }
}
