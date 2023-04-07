using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace lab1_pi_VS2019
{
    public partial class WinAsyncMethod : Form
    {
        public WinAsyncMethod()
        {
            InitializeComponent();
        }

        private static async Task<int> Sum(int a, int b)
        {
            await Task.Delay(5000);//немного подождем
            return a + b;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");

                textBox1.Text = textBox2.Text = "";
                return;
            }
            var sum = Sum(a, b);
            int sumResult = await sum;
            string str = String.Format("Сумма введенных чисел равна {0}", sumResult);
            MessageBox.Show(str, "Результат операции");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                helpProvider1.HelpNamespace = @"справочная информация.docx";
                Help.ShowHelp(this, helpProvider1.HelpNamespace);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

