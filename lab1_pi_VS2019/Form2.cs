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
    public partial class Form2 : Form
    {
        public string result = "";
        public string dividers = "(\'\"\n ";

        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked || richTextBox1.Text.Length == 0)
                MessageBox.Show("Повторите ввод!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            else
            {
                if (radioButton1.Checked)
                {
                    string text = richTextBox1.Text.ToString();
                    List<string> list = text.Split(' ').ToList();
                    List<string> res = new List<string>();


                    foreach (var x in list)
                    {
                        if (!dividers.Contains(x[0]))
                            res.Add(x.Substring(0, 1).ToUpper() + x.Substring(1));
                        else
                        {
                            int i = 0;
                            while (dividers.Contains(x[i]))
                                i++;

                            res.Add(x.Substring(0, i) + x.Substring(i, 1).ToUpper() + x.Substring(i + 1));
                        }
                    }

                    result = string.Join(" ", res);

                }

                else if (radioButton2.Checked)
                {
                    result = richTextBox1.Text.ToString().ToUpper();

                }

                richTextBox1.Clear();

                Hide();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }

        }
    }
}
