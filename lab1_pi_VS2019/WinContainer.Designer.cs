﻿using System.Drawing;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    partial class WinContainer
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            tabPage3 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            tabPage4 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            button10 = new Button();
            tabPage5 = new TabPage();
            splitContainer1 = new SplitContainer();
            button12 = new Button();
            button11 = new Button();
            button13 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GroupBox";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(215, 329);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(41, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(37, 135);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Panel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 411);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(612, 199);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(439, 199);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(270, 199);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(93, 199);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(flowLayoutPanel1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "FlowLayoutPanel";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(792, 417);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 0;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(103, 3);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 1;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(203, 3);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 2;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(303, 3);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 3;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button10_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "TableLayoutPanel";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button10, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(792, 417);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button10
            // 
            button10.Location = new Point(5, 5);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 1;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(splitContainer1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(792, 417);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "SplitContainer";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button12);
            splitContainer1.Panel1.Controls.Add(button11);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button13);
            splitContainer1.Size = new Size(792, 417);
            splitContainer1.SplitterDistance = 264;
            splitContainer1.TabIndex = 0;
            // 
            // button12
            // 
            button12.Location = new Point(82, 263);
            button12.Name = "button12";
            button12.Size = new Size(94, 55);
            button12.TabIndex = 2;
            button12.Text = "(un)fix Splitter";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(82, 97);
            button11.Name = "button11";
            button11.Size = new Size(94, 55);
            button11.TabIndex = 1;
            button11.Text = "(un)fix Panel1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Location = new Point(213, 192);
            button13.Name = "button13";
            button13.Size = new Size(100, 55);
            button13.TabIndex = 1;
            button13.Text = "(un)collapse Panel1";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // WinContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "WinContainer";
            Text = "WinContainer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button10;
        private SplitContainer splitContainer1;
        private Button button12;
        private Button button11;
        private Button button13;
    }
}