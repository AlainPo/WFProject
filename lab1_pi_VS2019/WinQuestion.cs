using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    public partial class WinQuestion : Form
    {
        public WinQuestion()
        {
            InitializeComponent();
        }

        private void button1yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что вы так думаете!");
        }

        private void button2no_MouseMove(object sender, MouseEventArgs e)
        {
            button2no.Top -= e.Y;
            button2no.Left += e.X;
            if (button2no.Top < -10 || button2no.Top > 100)
            {
                button2no.Top = 60;
            }
            if (button2no.Left < -80 || button2no.Left > 250)
            {
                button2no.Left = 120;
            }
        }
    }
}
