namespace lab1_pi_VS2019
{
    partial class WinAsyncMethod
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAsyncMethod));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            helpProvider1.SetHelpString(button1, resources.GetString("button1.HelpString"));
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            helpProvider1.SetShowHelp(button1, (bool)resources.GetObject("button1.ShowHelp"));
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            helpProvider1.SetHelpString(button2, resources.GetString("button2.HelpString"));
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            helpProvider1.SetShowHelp(button2, (bool)resources.GetObject("button2.ShowHelp"));
            toolTip1.SetToolTip(button2, resources.GetString("button2.ToolTip"));
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            helpProvider1.SetShowHelp(label1, (bool)resources.GetObject("label1.ShowHelp"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            helpProvider1.SetShowHelp(label2, (bool)resources.GetObject("label2.ShowHelp"));
            // 
            // textBox1
            // 
            helpProvider1.SetHelpString(textBox1, resources.GetString("textBox1.HelpString"));
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            helpProvider1.SetShowHelp(textBox1, (bool)resources.GetObject("textBox1.ShowHelp"));
            toolTip1.SetToolTip(textBox1, resources.GetString("textBox1.ToolTip"));
            // 
            // textBox2
            // 
            helpProvider1.SetHelpString(textBox2, resources.GetString("textBox2.HelpString"));
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            helpProvider1.SetShowHelp(textBox2, (bool)resources.GetObject("textBox2.ShowHelp"));
            toolTip1.SetToolTip(textBox2, resources.GetString("textBox2.ToolTip"));
            // 
            // helpProvider1
            // 
            resources.ApplyResources(helpProvider1, "helpProvider1");
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1 });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            helpProvider1.SetShowHelp(toolStrip1, (bool)resources.GetObject("toolStrip1.ShowHelp"));
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // WinAsyncMethod
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WinAsyncMethod";
            helpProvider1.SetShowHelp(this, (bool)resources.GetObject("$this.ShowHelp"));
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}