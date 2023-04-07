using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab1_pi_VS2019
{
    /// <summary>
    /// Summary description for CultureChooser.
    /// </summary>
    public class CultureChooser : Form
    {
		private GroupBox CulturesGroupBox;
		private Button ChooseCultureButton;
		private RadioButton EnglishChoice;
		private RadioButton FrenchChoice;
		private RadioButton GermanChoice;
		private RadioButton JapaneseChoice;

		private readonly string EnglishCulture;
		private readonly string FrenchCulture;
		private readonly string GermanCulture;
		private readonly string JapaneseCulture;

		private string CultureChoiceString;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CultureChooser()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			EnglishCulture = "en-US";
			FrenchCulture = "fr-FR";
			GermanCulture = "de-DE";
			JapaneseCulture = "ja-JP";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CultureChooser));
			this.CulturesGroupBox = new GroupBox();
			this.JapaneseChoice = new RadioButton();
			this.GermanChoice = new RadioButton();
			this.FrenchChoice = new RadioButton();
			this.EnglishChoice = new RadioButton();
			this.ChooseCultureButton = new Button();
			this.CulturesGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// CulturesGroupBox
			// 
			this.CulturesGroupBox.AccessibleDescription = ((string)(resources.GetObject("CulturesGroupBox.AccessibleDescription")));
			this.CulturesGroupBox.AccessibleName = ((string)(resources.GetObject("CulturesGroupBox.AccessibleName")));
			this.CulturesGroupBox.Anchor = ((AnchorStyles)(resources.GetObject("CulturesGroupBox.Anchor")));
			this.CulturesGroupBox.BackgroundImage = ((Image)(resources.GetObject("CulturesGroupBox.BackgroundImage")));
			this.CulturesGroupBox.Controls.AddRange(new Control[] {
																						   this.JapaneseChoice,
																						   this.GermanChoice,
																						   this.FrenchChoice,
																						   this.EnglishChoice});
			this.CulturesGroupBox.Dock = ((DockStyle)(resources.GetObject("CulturesGroupBox.Dock")));
			this.CulturesGroupBox.Enabled = ((bool)(resources.GetObject("CulturesGroupBox.Enabled")));
			this.CulturesGroupBox.Font = ((Font)(resources.GetObject("CulturesGroupBox.Font")));
			this.CulturesGroupBox.ImeMode = ((ImeMode)(resources.GetObject("CulturesGroupBox.ImeMode")));
			this.CulturesGroupBox.Location = ((Point)(resources.GetObject("CulturesGroupBox.Location")));
			this.CulturesGroupBox.Name = "CulturesGroupBox";
			this.CulturesGroupBox.RightToLeft = ((RightToLeft)(resources.GetObject("CulturesGroupBox.RightToLeft")));
			this.CulturesGroupBox.Size = ((Size)(resources.GetObject("CulturesGroupBox.Size")));
			this.CulturesGroupBox.TabIndex = ((int)(resources.GetObject("CulturesGroupBox.TabIndex")));
			this.CulturesGroupBox.TabStop = false;
			this.CulturesGroupBox.Text = resources.GetString("CulturesGroupBox.Text");
			this.CulturesGroupBox.Visible = ((bool)(resources.GetObject("CulturesGroupBox.Visible")));
			// 
			// JapaneseChoice
			// 
			this.JapaneseChoice.AccessibleDescription = ((string)(resources.GetObject("JapaneseChoice.AccessibleDescription")));
			this.JapaneseChoice.AccessibleName = ((string)(resources.GetObject("JapaneseChoice.AccessibleName")));
			this.JapaneseChoice.Anchor = ((AnchorStyles)(resources.GetObject("JapaneseChoice.Anchor")));
			this.JapaneseChoice.Appearance = ((Appearance)(resources.GetObject("JapaneseChoice.Appearance")));
			this.JapaneseChoice.BackgroundImage = ((Image)(resources.GetObject("JapaneseChoice.BackgroundImage")));
			this.JapaneseChoice.CheckAlign = ((ContentAlignment)(resources.GetObject("JapaneseChoice.CheckAlign")));
			this.JapaneseChoice.Dock = ((DockStyle)(resources.GetObject("JapaneseChoice.Dock")));
			this.JapaneseChoice.Enabled = ((bool)(resources.GetObject("JapaneseChoice.Enabled")));
			this.JapaneseChoice.FlatStyle = ((FlatStyle)(resources.GetObject("JapaneseChoice.FlatStyle")));
			this.JapaneseChoice.Font = ((Font)(resources.GetObject("JapaneseChoice.Font")));
			this.JapaneseChoice.Image = ((Image)(resources.GetObject("JapaneseChoice.Image")));
			this.JapaneseChoice.ImageAlign = ((ContentAlignment)(resources.GetObject("JapaneseChoice.ImageAlign")));
			this.JapaneseChoice.ImageIndex = ((int)(resources.GetObject("JapaneseChoice.ImageIndex")));
			this.JapaneseChoice.ImeMode = ((ImeMode)(resources.GetObject("JapaneseChoice.ImeMode")));
			this.JapaneseChoice.Location = ((Point)(resources.GetObject("JapaneseChoice.Location")));
			this.JapaneseChoice.Name = "JapaneseChoice";
			this.JapaneseChoice.RightToLeft = ((RightToLeft)(resources.GetObject("JapaneseChoice.RightToLeft")));
			this.JapaneseChoice.Size = ((Size)(resources.GetObject("JapaneseChoice.Size")));
			this.JapaneseChoice.TabIndex = ((int)(resources.GetObject("JapaneseChoice.TabIndex")));
			this.JapaneseChoice.Text = resources.GetString("JapaneseChoice.Text");
			this.JapaneseChoice.TextAlign = ((ContentAlignment)(resources.GetObject("JapaneseChoice.TextAlign")));
			this.JapaneseChoice.Visible = ((bool)(resources.GetObject("JapaneseChoice.Visible")));
			this.JapaneseChoice.CheckedChanged += new EventHandler(this.JapaneseChoice_CheckedChanged);
			// 
			// GermanChoice
			// 
			this.GermanChoice.AccessibleDescription = ((string)(resources.GetObject("GermanChoice.AccessibleDescription")));
			this.GermanChoice.AccessibleName = ((string)(resources.GetObject("GermanChoice.AccessibleName")));
			this.GermanChoice.Anchor = ((AnchorStyles)(resources.GetObject("GermanChoice.Anchor")));
			this.GermanChoice.Appearance = ((Appearance)(resources.GetObject("GermanChoice.Appearance")));
			this.GermanChoice.BackgroundImage = ((Image)(resources.GetObject("GermanChoice.BackgroundImage")));
			this.GermanChoice.CheckAlign = ((ContentAlignment)(resources.GetObject("GermanChoice.CheckAlign")));
			this.GermanChoice.Dock = ((DockStyle)(resources.GetObject("GermanChoice.Dock")));
			this.GermanChoice.Enabled = ((bool)(resources.GetObject("GermanChoice.Enabled")));
			this.GermanChoice.FlatStyle = ((FlatStyle)(resources.GetObject("GermanChoice.FlatStyle")));
			this.GermanChoice.Font = ((Font)(resources.GetObject("GermanChoice.Font")));
			this.GermanChoice.Image = ((Image)(resources.GetObject("GermanChoice.Image")));
			this.GermanChoice.ImageAlign = ((ContentAlignment)(resources.GetObject("GermanChoice.ImageAlign")));
			this.GermanChoice.ImageIndex = ((int)(resources.GetObject("GermanChoice.ImageIndex")));
			this.GermanChoice.ImeMode = ((ImeMode)(resources.GetObject("GermanChoice.ImeMode")));
			this.GermanChoice.Location = ((Point)(resources.GetObject("GermanChoice.Location")));
			this.GermanChoice.Name = "GermanChoice";
			this.GermanChoice.RightToLeft = ((RightToLeft)(resources.GetObject("GermanChoice.RightToLeft")));
			this.GermanChoice.Size = ((Size)(resources.GetObject("GermanChoice.Size")));
			this.GermanChoice.TabIndex = ((int)(resources.GetObject("GermanChoice.TabIndex")));
			this.GermanChoice.Text = resources.GetString("GermanChoice.Text");
			this.GermanChoice.TextAlign = ((ContentAlignment)(resources.GetObject("GermanChoice.TextAlign")));
			this.GermanChoice.Visible = ((bool)(resources.GetObject("GermanChoice.Visible")));
			this.GermanChoice.CheckedChanged += new EventHandler(this.GermanChoice_CheckedChanged);
			// 
			// FrenchChoice
			// 
			this.FrenchChoice.AccessibleDescription = ((string)(resources.GetObject("FrenchChoice.AccessibleDescription")));
			this.FrenchChoice.AccessibleName = ((string)(resources.GetObject("FrenchChoice.AccessibleName")));
			this.FrenchChoice.Anchor = ((AnchorStyles)(resources.GetObject("FrenchChoice.Anchor")));
			this.FrenchChoice.Appearance = ((Appearance)(resources.GetObject("FrenchChoice.Appearance")));
			this.FrenchChoice.BackgroundImage = ((Image)(resources.GetObject("FrenchChoice.BackgroundImage")));
			this.FrenchChoice.CheckAlign = ((ContentAlignment)(resources.GetObject("FrenchChoice.CheckAlign")));
			this.FrenchChoice.Dock = ((DockStyle)(resources.GetObject("FrenchChoice.Dock")));
			this.FrenchChoice.Enabled = ((bool)(resources.GetObject("FrenchChoice.Enabled")));
			this.FrenchChoice.FlatStyle = ((FlatStyle)(resources.GetObject("FrenchChoice.FlatStyle")));
			this.FrenchChoice.Font = ((Font)(resources.GetObject("FrenchChoice.Font")));
			this.FrenchChoice.Image = ((Image)(resources.GetObject("FrenchChoice.Image")));
			this.FrenchChoice.ImageAlign = ((ContentAlignment)(resources.GetObject("FrenchChoice.ImageAlign")));
			this.FrenchChoice.ImageIndex = ((int)(resources.GetObject("FrenchChoice.ImageIndex")));
			this.FrenchChoice.ImeMode = ((ImeMode)(resources.GetObject("FrenchChoice.ImeMode")));
			this.FrenchChoice.Location = ((Point)(resources.GetObject("FrenchChoice.Location")));
			this.FrenchChoice.Name = "FrenchChoice";
			this.FrenchChoice.RightToLeft = ((RightToLeft)(resources.GetObject("FrenchChoice.RightToLeft")));
			this.FrenchChoice.Size = ((Size)(resources.GetObject("FrenchChoice.Size")));
			this.FrenchChoice.TabIndex = ((int)(resources.GetObject("FrenchChoice.TabIndex")));
			this.FrenchChoice.Text = resources.GetString("FrenchChoice.Text");
			this.FrenchChoice.TextAlign = ((ContentAlignment)(resources.GetObject("FrenchChoice.TextAlign")));
			this.FrenchChoice.Visible = ((bool)(resources.GetObject("FrenchChoice.Visible")));
			this.FrenchChoice.CheckedChanged += new EventHandler(this.FrenchChoice_CheckedChanged);
			// 
			// EnglishChoice
			// 
			this.EnglishChoice.AccessibleDescription = ((string)(resources.GetObject("EnglishChoice.AccessibleDescription")));
			this.EnglishChoice.AccessibleName = ((string)(resources.GetObject("EnglishChoice.AccessibleName")));
			this.EnglishChoice.Anchor = ((AnchorStyles)(resources.GetObject("EnglishChoice.Anchor")));
			this.EnglishChoice.Appearance = ((Appearance)(resources.GetObject("EnglishChoice.Appearance")));
			this.EnglishChoice.BackgroundImage = ((Image)(resources.GetObject("EnglishChoice.BackgroundImage")));
			this.EnglishChoice.CheckAlign = ((ContentAlignment)(resources.GetObject("EnglishChoice.CheckAlign")));
			this.EnglishChoice.Dock = ((DockStyle)(resources.GetObject("EnglishChoice.Dock")));
			this.EnglishChoice.Enabled = ((bool)(resources.GetObject("EnglishChoice.Enabled")));
			this.EnglishChoice.FlatStyle = ((FlatStyle)(resources.GetObject("EnglishChoice.FlatStyle")));
			this.EnglishChoice.Font = ((Font)(resources.GetObject("EnglishChoice.Font")));
			this.EnglishChoice.Image = ((Image)(resources.GetObject("EnglishChoice.Image")));
			this.EnglishChoice.ImageAlign = ((ContentAlignment)(resources.GetObject("EnglishChoice.ImageAlign")));
			this.EnglishChoice.ImageIndex = ((int)(resources.GetObject("EnglishChoice.ImageIndex")));
			this.EnglishChoice.ImeMode = ((ImeMode)(resources.GetObject("EnglishChoice.ImeMode")));
			this.EnglishChoice.Location = ((Point)(resources.GetObject("EnglishChoice.Location")));
			this.EnglishChoice.Name = "EnglishChoice";
			this.EnglishChoice.RightToLeft = ((RightToLeft)(resources.GetObject("EnglishChoice.RightToLeft")));
			this.EnglishChoice.Size = ((Size)(resources.GetObject("EnglishChoice.Size")));
			this.EnglishChoice.TabIndex = ((int)(resources.GetObject("EnglishChoice.TabIndex")));
			this.EnglishChoice.Text = resources.GetString("EnglishChoice.Text");
			this.EnglishChoice.TextAlign = ((ContentAlignment)(resources.GetObject("EnglishChoice.TextAlign")));
			this.EnglishChoice.Visible = ((bool)(resources.GetObject("EnglishChoice.Visible")));
			this.EnglishChoice.CheckedChanged += new EventHandler(this.EnglishChoice_CheckedChanged);
			// 
			// ChooseCultureButton
			// 
			this.ChooseCultureButton.AccessibleDescription = ((string)(resources.GetObject("ChooseCultureButton.AccessibleDescription")));
			this.ChooseCultureButton.AccessibleName = ((string)(resources.GetObject("ChooseCultureButton.AccessibleName")));
			this.ChooseCultureButton.Anchor = ((AnchorStyles)(resources.GetObject("ChooseCultureButton.Anchor")));
			this.ChooseCultureButton.BackgroundImage = ((Image)(resources.GetObject("ChooseCultureButton.BackgroundImage")));
			this.ChooseCultureButton.Dock = ((DockStyle)(resources.GetObject("ChooseCultureButton.Dock")));
			this.ChooseCultureButton.Enabled = ((bool)(resources.GetObject("ChooseCultureButton.Enabled")));
			this.ChooseCultureButton.FlatStyle = ((FlatStyle)(resources.GetObject("ChooseCultureButton.FlatStyle")));
			this.ChooseCultureButton.Font = ((Font)(resources.GetObject("ChooseCultureButton.Font")));
			this.ChooseCultureButton.Image = ((Image)(resources.GetObject("ChooseCultureButton.Image")));
			this.ChooseCultureButton.ImageAlign = ((ContentAlignment)(resources.GetObject("ChooseCultureButton.ImageAlign")));
			this.ChooseCultureButton.ImageIndex = ((int)(resources.GetObject("ChooseCultureButton.ImageIndex")));
			this.ChooseCultureButton.ImeMode = ((ImeMode)(resources.GetObject("ChooseCultureButton.ImeMode")));
			this.ChooseCultureButton.Location = ((Point)(resources.GetObject("ChooseCultureButton.Location")));
			this.ChooseCultureButton.Name = "ChooseCultureButton";
			this.ChooseCultureButton.RightToLeft = ((RightToLeft)(resources.GetObject("ChooseCultureButton.RightToLeft")));
			this.ChooseCultureButton.Size = ((Size)(resources.GetObject("ChooseCultureButton.Size")));
			this.ChooseCultureButton.TabIndex = ((int)(resources.GetObject("ChooseCultureButton.TabIndex")));
			this.ChooseCultureButton.Text = resources.GetString("ChooseCultureButton.Text");
			this.ChooseCultureButton.TextAlign = ((ContentAlignment)(resources.GetObject("ChooseCultureButton.TextAlign")));
			this.ChooseCultureButton.Visible = ((bool)(resources.GetObject("ChooseCultureButton.Visible")));
			this.ChooseCultureButton.Click += new EventHandler(this.ChooseCultureButton_Click);
			// 
			// CultureChooser
			// 
			this.AccessibleDescription = ((string)(resources.GetObject("$this.AccessibleDescription")));
			this.AccessibleName = ((string)(resources.GetObject("$this.AccessibleName")));
			this.Anchor = ((AnchorStyles)(resources.GetObject("$this.Anchor")));
			this.AutoScaleBaseSize = ((Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((Size)(resources.GetObject("$this.ClientSize")));
			this.ControlBox = false;
			this.Controls.AddRange(new Control[] {
																		  this.ChooseCultureButton,
																		  this.CulturesGroupBox});
			this.Dock = ((DockStyle)(resources.GetObject("$this.Dock")));
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "CultureChooser";
			this.RightToLeft = ((RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Visible = ((bool)(resources.GetObject("$this.Visible")));
			this.CulturesGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void EnglishChoice_CheckedChanged(object sender, EventArgs e)
		{
			CultureChoiceString = EnglishCulture;
		}

		private void FrenchChoice_CheckedChanged(object sender, EventArgs e)
		{
			CultureChoiceString = FrenchCulture;
		}

		private void GermanChoice_CheckedChanged(object sender, EventArgs e)
		{
			CultureChoiceString = GermanCulture;
		}

		private void JapaneseChoice_CheckedChanged(object sender, EventArgs e)
		{
			CultureChoiceString = JapaneseCulture;
		}

		private void ChooseCultureButton_Click(object sender, EventArgs e)
		{
			if (CultureChoiceString == null)
				CultureChoiceString = EnglishCulture;

			this.Close();
		}

		public string UsersChoice
		{
			get
			{
				return CultureChoiceString;
			}
		}
	}
}
