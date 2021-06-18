using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            
        }

        private void NounCategoryBtn_Click(object sender, EventArgs e)
        {
            //Enables Noun Level 1 and 2 Buttons
            NLvl1Btn.Visible = Enabled;
            NLvl2Btn1.Visible = Enabled;

            //Disables other Level 1 and 2 Buttons
            VLvl1Btn.Visible = false;
            VLvl2Btn1.Visible = false;

            PLvl1Btn.Visible = false;
            PLvl2Btn1.Visible = false;
        }

        private void VerbCategoryBtn_Click(object sender, EventArgs e)
        {
            //Enables Verb Level 1 and 2 Buttons
            VLvl1Btn.Visible = Enabled;
            VLvl2Btn1.Visible = Enabled;

            //Disables other Level 1 and 2 Buttons
            NLvl1Btn.Visible = false;
            NLvl2Btn1.Visible = false;

            PLvl1Btn.Visible = false;
            PLvl2Btn1.Visible = false;
        }

        private void PronounCategoryBtn_Click(object sender, EventArgs e)
        {
            //Enables Pronoun Level 1 and 2 Buttons
            PLvl1Btn.Visible = Enabled;
            PLvl2Btn1.Visible = Enabled;

            //Disables other Level 1 and 2 Buttons
            NLvl1Btn.Visible = false;
            NLvl2Btn1.Visible = false;

            VLvl1Btn.Visible = false;
            VLvl2Btn1.Visible = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen start = new StartScreen();
            start.Show();
        }

        private void PLvl1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PronounsLvl1Learn start = new PronounsLvl1Learn();
            start.Show();
        }

        private void NLvl1Btn_Click(object sender, EventArgs e)
        {
                this.Hide();
                NounsLvl1Learn start = new NounsLvl1Learn();
                start.Show();
        }

        private void VLvl1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerbsLvl1Learn start = new VerbsLvl1Learn();
            start.Show();
        }

        private void NLvl2Btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
           NounsLvl2Q1 start = new NounsLvl2Q1();
            start.Show();
        }

        private void VLvl2Btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
             VerbsLvl2Q1 start = new VerbsLvl2Q1();
            start.Show();
        }

        private void PLvl2Btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProunounsLvl2Q1 start = new ProunounsLvl2Q1();
            start.Show();
        }
    }
}
