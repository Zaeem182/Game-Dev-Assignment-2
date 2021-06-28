using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }
    }
}
