using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class NounsLvl2Learn : Form
    {
        public NounsLvl2Learn()
        {
            InitializeComponent();
        }
        string[] Nouns = { "Namae (名前)", "Gakkou (学校)", "Mizu (水)", "Kazoku (家族)", "Hito (人)", "Nihon (日本)", "Ashita (明日)", "Shuu (週)", "Toire (トイレ)", "Pan (パン)", "Sensei (先生)" };
        static int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            lbl1.Text = Nouns[i];
            i = (i + 1) % 11;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
