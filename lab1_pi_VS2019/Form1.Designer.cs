using System.Drawing;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            beginToolStripMenuItem = new ToolStripMenuItem();
            workToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lab2ToolStripMenuItem = new ToolStripMenuItem();
            mdiMenuToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            lab3ToolStripMenuItem = new ToolStripMenuItem();
            winQuestionToolStripMenuItem = new ToolStripMenuItem();
            testListToolStripMenuItem = new ToolStripMenuItem();
            winContainerToolStripMenuItem = new ToolStripMenuItem();
            winLinkLabelToolStripMenuItem = new ToolStripMenuItem();
            registrationFormToolStripMenuItem = new ToolStripMenuItem();
            lab5ToolStripMenuItem = new ToolStripMenuItem();
            lab7ToolStripMenuItem = new ToolStripMenuItem();
            winBackgroundWorkerToolStripMenuItem = new ToolStripMenuItem();
            winAsyncDelegateToolStripMenuItem = new ToolStripMenuItem();
            winAsyncMethodToolStripMenuItem = new ToolStripMenuItem();
            lab8ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            clickButton1 = new ClickButton();
            userControlTimer1 = new UserControlTimer();
            userControlTimer21 = new UserControlTimer2();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { beginToolStripMenuItem, workToolStripMenuItem, aboutToolStripMenuItem, lab2ToolStripMenuItem, lab3ToolStripMenuItem, lab5ToolStripMenuItem, lab7ToolStripMenuItem, lab8ToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // beginToolStripMenuItem
            // 
            beginToolStripMenuItem.Name = "beginToolStripMenuItem";
            resources.ApplyResources(beginToolStripMenuItem, "beginToolStripMenuItem");
            beginToolStripMenuItem.Click += beginToolStripMenuItem_Click;
            // 
            // workToolStripMenuItem
            // 
            resources.ApplyResources(workToolStripMenuItem, "workToolStripMenuItem");
            workToolStripMenuItem.Name = "workToolStripMenuItem";
            workToolStripMenuItem.Click += workToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lab2ToolStripMenuItem
            // 
            lab2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mdiMenuToolStripMenuItem, windowToolStripMenuItem });
            lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            resources.ApplyResources(lab2ToolStripMenuItem, "lab2ToolStripMenuItem");
            // 
            // mdiMenuToolStripMenuItem
            // 
            mdiMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exitToolStripMenuItem });
            mdiMenuToolStripMenuItem.Name = "mdiMenuToolStripMenuItem";
            resources.ApplyResources(mdiMenuToolStripMenuItem, "mdiMenuToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(newToolStripMenuItem, "newToolStripMenuItem");
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            resources.ApplyResources(cascadeToolStripMenuItem, "cascadeToolStripMenuItem");
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            resources.ApplyResources(tileToolStripMenuItem, "tileToolStripMenuItem");
            tileToolStripMenuItem.Click += tileToolStripMenuItem_Click;
            // 
            // lab3ToolStripMenuItem
            // 
            lab3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { winQuestionToolStripMenuItem, testListToolStripMenuItem, winContainerToolStripMenuItem, winLinkLabelToolStripMenuItem, registrationFormToolStripMenuItem });
            lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            resources.ApplyResources(lab3ToolStripMenuItem, "lab3ToolStripMenuItem");
            // 
            // winQuestionToolStripMenuItem
            // 
            winQuestionToolStripMenuItem.Name = "winQuestionToolStripMenuItem";
            resources.ApplyResources(winQuestionToolStripMenuItem, "winQuestionToolStripMenuItem");
            winQuestionToolStripMenuItem.Click += winQuestionToolStripMenuItem_Click;
            // 
            // testListToolStripMenuItem
            // 
            testListToolStripMenuItem.Name = "testListToolStripMenuItem";
            resources.ApplyResources(testListToolStripMenuItem, "testListToolStripMenuItem");
            testListToolStripMenuItem.Click += testListToolStripMenuItem_Click;
            // 
            // winContainerToolStripMenuItem
            // 
            winContainerToolStripMenuItem.Name = "winContainerToolStripMenuItem";
            resources.ApplyResources(winContainerToolStripMenuItem, "winContainerToolStripMenuItem");
            winContainerToolStripMenuItem.Click += winContainerToolStripMenuItem_Click;
            // 
            // winLinkLabelToolStripMenuItem
            // 
            winLinkLabelToolStripMenuItem.Name = "winLinkLabelToolStripMenuItem";
            resources.ApplyResources(winLinkLabelToolStripMenuItem, "winLinkLabelToolStripMenuItem");
            winLinkLabelToolStripMenuItem.Click += winLinkLabelToolStripMenuItem_Click;
            // 
            // registrationFormToolStripMenuItem
            // 
            registrationFormToolStripMenuItem.Name = "registrationFormToolStripMenuItem";
            resources.ApplyResources(registrationFormToolStripMenuItem, "registrationFormToolStripMenuItem");
            registrationFormToolStripMenuItem.Click += registrationFormToolStripMenuItem_Click;
            // 
            // lab5ToolStripMenuItem
            // 
            lab5ToolStripMenuItem.Name = "lab5ToolStripMenuItem";
            resources.ApplyResources(lab5ToolStripMenuItem, "lab5ToolStripMenuItem");
            lab5ToolStripMenuItem.Click += lab5ToolStripMenuItem_Click;
            // 
            // lab7ToolStripMenuItem
            // 
            lab7ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { winBackgroundWorkerToolStripMenuItem, winAsyncDelegateToolStripMenuItem, winAsyncMethodToolStripMenuItem });
            lab7ToolStripMenuItem.Name = "lab7ToolStripMenuItem";
            resources.ApplyResources(lab7ToolStripMenuItem, "lab7ToolStripMenuItem");
            // 
            // winBackgroundWorkerToolStripMenuItem
            // 
            winBackgroundWorkerToolStripMenuItem.Name = "winBackgroundWorkerToolStripMenuItem";
            resources.ApplyResources(winBackgroundWorkerToolStripMenuItem, "winBackgroundWorkerToolStripMenuItem");
            winBackgroundWorkerToolStripMenuItem.Click += winBackgroundWorkerToolStripMenuItem_Click;
            // 
            // winAsyncDelegateToolStripMenuItem
            // 
            winAsyncDelegateToolStripMenuItem.Name = "winAsyncDelegateToolStripMenuItem";
            resources.ApplyResources(winAsyncDelegateToolStripMenuItem, "winAsyncDelegateToolStripMenuItem");
            winAsyncDelegateToolStripMenuItem.Click += winAsyncDelegateToolStripMenuItem_Click;
            // 
            // winAsyncMethodToolStripMenuItem
            // 
            winAsyncMethodToolStripMenuItem.Name = "winAsyncMethodToolStripMenuItem";
            resources.ApplyResources(winAsyncMethodToolStripMenuItem, "winAsyncMethodToolStripMenuItem");
            winAsyncMethodToolStripMenuItem.Click += winAsyncMethodToolStripMenuItem_Click;
            // 
            // lab8ToolStripMenuItem
            // 
            lab8ToolStripMenuItem.Name = "lab8ToolStripMenuItem";
            resources.ApplyResources(lab8ToolStripMenuItem, "lab8ToolStripMenuItem");
            lab8ToolStripMenuItem.Click += lab8ToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3 });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Tag = "NewDoc";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton2, "toolStripButton2");
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Tag = "Cascade";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton3, "toolStripButton3");
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Tag = "Tile";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // clickButton1
            // 
            resources.ApplyResources(clickButton1, "clickButton1");
            clickButton1.Name = "clickButton1";
            // 
            // userControlTimer1
            // 
            userControlTimer1.BackColor = SystemColors.AppWorkspace;
            resources.ApplyResources(userControlTimer1, "userControlTimer1");
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.TimeEnabled = true;
            // 
            // userControlTimer21
            // 
            resources.ApplyResources(userControlTimer21, "userControlTimer21");
            userControlTimer21.Name = "userControlTimer21";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDialog1
            // 
            printDialog1.AllowSomePages = true;
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(printPreviewDialog1, "printPreviewDialog1");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(openFileDialog1, "openFileDialog1");
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(clickButton1);
            Controls.Add(userControlTimer21);
            Controls.Add(userControlTimer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem beginToolStripMenuItem;
        private ToolStripMenuItem workToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem lab2ToolStripMenuItem;
        private ToolStripMenuItem mdiMenuToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripMenuItem lab3ToolStripMenuItem;
        private ToolStripMenuItem winQuestionToolStripMenuItem;
        private ToolStripMenuItem testListToolStripMenuItem;
        private ToolStripMenuItem winContainerToolStripMenuItem;
        private ToolStripMenuItem winLinkLabelToolStripMenuItem;
        private ToolStripMenuItem registrationFormToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private UserControlTimer userControlTimer1;
        private UserControlTimer2 userControlTimer21;
        private ClickButton clickButton1;
        private ToolStripMenuItem lab5ToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private ToolStripMenuItem lab7ToolStripMenuItem;
        private ToolStripMenuItem winBackgroundWorkerToolStripMenuItem;
        private ToolStripMenuItem winAsyncDelegateToolStripMenuItem;
        private ToolStripMenuItem winAsyncMethodToolStripMenuItem;
        private ToolStripMenuItem lab8ToolStripMenuItem;
    }
}

