using System.Drawing;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    partial class WinQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1yes = new Button();
            button2no = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1yes
            // 
            button1yes.Location = new Point(42, 79);
            button1yes.Name = "button1yes";
            button1yes.Size = new Size(94, 29);
            button1yes.TabIndex = 0;
            button1yes.Text = "Да";
            button1yes.UseVisualStyleBackColor = true;
            button1yes.Click += button1yes_Click;
            // 
            // button2no
            // 
            button2no.Location = new Point(197, 79);
            button2no.Name = "button2no";
            button2no.Size = new Size(94, 29);
            button2no.TabIndex = 1;
            button2no.Text = "Нет";
            button2no.UseVisualStyleBackColor = true;
            button2no.MouseMove += button2no_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 2;
            label1.Text = " Вы довольны своей зарплатой? ";
            // 
            // WinQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 149);
            Controls.Add(label1);
            Controls.Add(button2no);
            Controls.Add(button1yes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "WinQuestion";
            Text = "Насущный вопрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1yes;
        private Button button2no;
        private Label label1;
    }
}