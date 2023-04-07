using System;
using System.Threading;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    public partial class WinAsyncDelegate : Form
    {
        bool Cancel;

        public WinAsyncDelegate()
        {
            InitializeComponent();
        }

        private delegate void TimeConsumingMethodDelegate(int seconds);
        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++) { 
                Thread.Sleep(1000);
                SetProgress(j * 100 / seconds);
                if (Cancel)
                    break;
            }
            if (Cancel)
            {
                MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                MessageBox.Show("Complete");
            }
        }

        public delegate void SetProgressDelegate(int val);
        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            ThreadPool.QueueUserWorkItem(delegate {del.Invoke(int.Parse(textBox1.Text)); });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
