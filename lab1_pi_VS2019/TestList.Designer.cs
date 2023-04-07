using System.Drawing;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    partial class TestList
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
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            button1Add = new Button();
            button2Delete = new Button();
            button3Sort = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Location = new Point(73, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список участников";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(49, 25);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "фио1", "фио2", "фио3", "фио4", "фио5" });
            comboBox1.Location = new Point(122, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1Add
            // 
            button1Add.Location = new Point(12, 218);
            button1Add.Name = "button1Add";
            button1Add.Size = new Size(107, 29);
            button1Add.TabIndex = 2;
            button1Add.Text = "Добавить";
            button1Add.UseVisualStyleBackColor = true;
            button1Add.Click += button1Add_Click;
            // 
            // button2Delete
            // 
            button2Delete.Location = new Point(145, 218);
            button2Delete.Name = "button2Delete";
            button2Delete.Size = new Size(107, 29);
            button2Delete.TabIndex = 3;
            button2Delete.Text = "Удалить";
            button2Delete.UseVisualStyleBackColor = true;
            button2Delete.Click += button2Delete_Click;
            // 
            // button3Sort
            // 
            button3Sort.Location = new Point(278, 218);
            button3Sort.Name = "button3Sort";
            button3Sort.Size = new Size(107, 29);
            button3Sort.TabIndex = 4;
            button3Sort.Text = "Сортировать";
            button3Sort.UseVisualStyleBackColor = true;
            button3Sort.Click += button3Sort_Click;
            // 
            // TestList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 259);
            Controls.Add(button3Sort);
            Controls.Add(button2Delete);
            Controls.Add(button1Add);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TestList";
            Text = "Работа со списками";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Button button1Add;
        private Button button2Delete;
        private Button button3Sort;
    }
}