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
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();

            Thread.Sleep(50000);

            InitializeComponent();
            //enter code here

            t.Abort();
        }
        public void Splash()
        {
            Application.Run(new SplashScreen());
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutorial tut = new Tutorial();
            tut.Show();

        }
    }
}
