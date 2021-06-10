using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btb1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Tutorial tut = new Tutorial();
            tut.Show();
        }
    }
}
