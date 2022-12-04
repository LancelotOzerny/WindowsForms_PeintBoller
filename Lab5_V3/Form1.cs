using System.Windows.Forms;

namespace Lab5_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peintboller1_MouseClick(object sender, MouseEventArgs e)
        {
            peintboller1.SetRandomDirection();
        }
    }
}
