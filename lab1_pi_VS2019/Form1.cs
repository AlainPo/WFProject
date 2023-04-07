using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace lab1_pi_VS2019
{
    public partial class Form1 : Form
    {
        public string result;
        private int openDocuments = 0;
        Form2 input = new Form2();

        string s;
        string[] strings;
        int ArrayCounter = 0;

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            InitializeComponent();
            toolStripStatusLabel2.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        /// <summary>
        /// Lab 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик молодец", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = input.result;
            Form3 output = new Form3();
            output.text = result;
            output.MdiParent = this;
            output.Dock = DockStyle.Fill;
            output.Show();
            workToolStripMenuItem.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetWindowRegion();

        }

        public void SetWindowRegion()
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath FormPath = GetRoundedRectPath(rect, this.Height / 4);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            // В левом верхнем углу
            path.AddArc(arcRect, 180, 90);
            // Правый верхний угол
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // Нижний правый угол
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // Нижний левый угол
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure(); // Замкнутая кривая
            return path;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.MdiParent = this;
            input.Dock = DockStyle.Fill;
            input.Show();

            workToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Lab 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            toolStripStatusLabel1.Text = "Windows is cascade";

        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            toolStripStatusLabel1.Text = "Windows is horizontal";

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.Show();
        }

        /// <summary>
        /// LAB 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void winQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinQuestion winQuestion = new WinQuestion();
            winQuestion.Show();
        }

        private void testListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestList testList = new TestList();
            testList.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    toolStripStatusLabel1.Text = "Windows is cascade";
                    break;
                case "Tile":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    toolStripStatusLabel1.Text = "Windows is horizontal";
                    break;
            }
        }

        private void winContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinContainer winContainer = new WinContainer();
            winContainer.Show();
        }

        private void winLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinLinkLabel winLinkLabel = new WinLinkLabel();
            winLinkLabel.Show();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void lab5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            float MyLines = 0;
            float YPosition = 0;
            int Counter = 0;
            string CurrentLine;
            MyLines = e.MarginBounds.Height / Font.GetHeight(e.Graphics);
            while (Counter < MyLines && ArrayCounter <= strings.Length - 1)
            {
                CurrentLine = strings[ArrayCounter];
                YPosition = TopMargin + Counter * Font.GetHeight(e.Graphics);
                e.Graphics.DrawString(CurrentLine, Font, Brushes.Black, LeftMargin, YPosition, new StringFormat());
                Counter++;
                ArrayCounter++;
            }
            if (!(ArrayCounter >= strings.GetLength(0) - 1))
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            ArrayCounter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*printPreviewDialog1.ShowDialog();*/
            Form5 aForm = new Form5();
            DialogResult aResult;
            aForm.printPreviewControl1.Document = printDocument1;
            aResult = aForm.ShowDialog();
            if (aResult == DialogResult.OK)
                printDocument1.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult aResult;
            aResult = openFileDialog1.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                StreamReader aReader = new StreamReader(openFileDialog1.FileName);
                s = aReader.ReadToEnd();
                aReader.Close();
                strings = s.Split('\n');
            }
        }

        private void winBackgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinBackgroundWorker winBackgroundWorker = new WinBackgroundWorker();
            winBackgroundWorker.Show();
        }

        private void winAsyncDelegateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAsyncDelegate winAsyncDelegate = new WinAsyncDelegate();
            winAsyncDelegate.Show();
        }

        private void winAsyncMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAsyncMethod winAsyncMethod = new WinAsyncMethod();
            winAsyncMethod.Show();
        }

        private void lab8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsabilityDemo usabilityDemo = new UsabilityDemo();
            usabilityDemo.Show();
        }
    }
}
