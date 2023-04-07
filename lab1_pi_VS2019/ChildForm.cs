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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void togglerForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (togglerForegroundToolStripMenuItem.Checked)
            {
                togglerForegroundToolStripMenuItem.Checked = false;
                richTextBox1.ForeColor = Color.Black;
            }
            else
            {
                togglerForegroundToolStripMenuItem.Checked = true;
                richTextBox1.ForeColor = Color.Blue;
            }
        }
    }
}
