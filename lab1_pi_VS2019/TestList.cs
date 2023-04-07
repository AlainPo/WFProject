using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1_pi_VS2019
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length != 0)
            {
                checkedListBox1.Items.Add(comboBox1.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void button2Delete_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
        }

        private void button3Sort_Click(object sender, EventArgs e)
        {
            checkedListBox1.Sorted = true;
        }
    }
}
