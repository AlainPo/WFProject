﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    public partial class WinLinkLabel : Form
    {
        public WinLinkLabel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            WinLinkLabel2 aForm = new WinLinkLabel2();
            aResult = aForm.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                MessageBox.Show("Your name is " + aForm.textBox1.Text + " " + aForm.textBox2.Text);
                MessageBox.Show("Your address is " + aForm.textBox3.Text);
                MessageBox.Show("Your phone number is " + aForm.maskedTextBox1.Text);
            }
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://www.apple.com";
            process.Start();
            linkLabel2.LinkVisited = true;
        }
    }
}