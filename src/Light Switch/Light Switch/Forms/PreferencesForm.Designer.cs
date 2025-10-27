namespace Light_Switch.Forms
{
	partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            rbnWallpaperIsEnabled = new RadioButton();
            rdbWallpaperIsDisabled = new RadioButton();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btnDarkColor = new Button();
            btnLightColor = new Button();
            label2 = new Label();
            btnBrowseDark = new Button();
            pbxDark = new PictureBox();
            pbxLight = new PictureBox();
            btnBrowseLight = new Button();
            label1 = new Label();
            dlgLight = new OpenFileDialog();
            btnSave = new Button();
            btnCancel = new Button();
            dlgDark = new OpenFileDialog();
            dlgColor = new ColorDialog();
            groupBox2 = new GroupBox();
            rbnSystemDisabled = new RadioButton();
            rbnSystemEnabled = new RadioButton();
            groupBox3 = new GroupBox();
            rbnAppDisabled = new RadioButton();
            rbnAppEnabled = new RadioButton();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            lblVersion = new Label();
            llbGitHub = new LinkLabel();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxDark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLight).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rbnWallpaperIsEnabled
            // 
            rbnWallpaperIsEnabled.AutoSize = true;
            rbnWallpaperIsEnabled.Location = new Point(6, 25);
            rbnWallpaperIsEnabled.Name = "rbnWallpaperIsEnabled";
            rbnWallpaperIsEnabled.Size = new Size(73, 21);
            rbnWallpaperIsEnabled.TabIndex = 0;
            rbnWallpaperIsEnabled.Text = "Enabled";
            rbnWallpaperIsEnabled.UseVisualStyleBackColor = true;
            rbnWallpaperIsEnabled.CheckedChanged += rbnWallpaperIsEnabled_CheckedChanged;
            // 
            // rdbWallpaperIsDisabled
            // 
            rdbWallpaperIsDisabled.AutoSize = true;
            rdbWallpaperIsDisabled.Checked = true;
            rdbWallpaperIsDisabled.Location = new Point(79, 25);
            rdbWallpaperIsDisabled.Name = "rdbWallpaperIsDisabled";
            rdbWallpaperIsDisabled.Size = new Size(77, 21);
            rdbWallpaperIsDisabled.TabIndex = 1;
            rdbWallpaperIsDisabled.TabStop = true;
            rdbWallpaperIsDisabled.Text = "Disabled";
            rdbWallpaperIsDisabled.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnDarkColor);
            groupBox1.Controls.Add(btnLightColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnBrowseDark);
            groupBox1.Controls.Add(pbxDark);
            groupBox1.Controls.Add(pbxLight);
            groupBox1.Controls.Add(btnBrowseLight);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbWallpaperIsDisabled);
            groupBox1.Controls.Add(rbnWallpaperIsEnabled);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 160);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change wallpaper";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 115);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 9;
            label4.Text = "- or -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 59);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 9;
            label3.Text = "- or -";
            // 
            // btnDarkColor
            // 
            btnDarkColor.Location = new Point(262, 108);
            btnDarkColor.Name = "btnDarkColor";
            btnDarkColor.Size = new Size(116, 30);
            btnDarkColor.TabIndex = 8;
            btnDarkColor.Text = "Pick a color...";
            btnDarkColor.UseVisualStyleBackColor = true;
            btnDarkColor.Click += btnDarkColor_Click;
            // 
            // btnLightColor
            // 
            btnLightColor.Location = new Point(262, 52);
            btnLightColor.Name = "btnLightColor";
            btnLightColor.Size = new Size(116, 30);
            btnLightColor.TabIndex = 7;
            btnLightColor.Text = "Pick a color...";
            btnLightColor.UseVisualStyleBackColor = true;
            btnLightColor.Click += btnLightColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 3;
            label2.Text = "Dark";
            // 
            // btnBrowseDark
            // 
            btnBrowseDark.Location = new Point(48, 108);
            btnBrowseDark.Name = "btnBrowseDark";
            btnBrowseDark.Size = new Size(163, 30);
            btnBrowseDark.TabIndex = 5;
            btnBrowseDark.Text = "Browse for an image...";
            btnBrowseDark.UseVisualStyleBackColor = true;
            btnBrowseDark.Click += btnBrowseDark_Click;
            // 
            // pbxDark
            // 
            pbxDark.Location = new Point(384, 97);
            pbxDark.Name = "pbxDark";
            pbxDark.Size = new Size(100, 50);
            pbxDark.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDark.TabIndex = 6;
            pbxDark.TabStop = false;
            // 
            // pbxLight
            // 
            pbxLight.Location = new Point(384, 41);
            pbxLight.Name = "pbxLight";
            pbxLight.Size = new Size(100, 50);
            pbxLight.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLight.TabIndex = 6;
            pbxLight.TabStop = false;
            // 
            // btnBrowseLight
            // 
            btnBrowseLight.Location = new Point(48, 52);
            btnBrowseLight.Name = "btnBrowseLight";
            btnBrowseLight.Size = new Size(163, 30);
            btnBrowseLight.TabIndex = 5;
            btnBrowseLight.Text = "Browse for an image...";
            btnBrowseLight.UseVisualStyleBackColor = true;
            btnBrowseLight.Click += btnBrowseLight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 3;
            label1.Text = "Light";
            // 
            // dlgLight
            // 
            dlgLight.Filter = "Image files|*.png;*.jpg;*.jpeg;*.gif";
            dlgLight.Title = "Browse for light mode wallpaper...";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(359, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "✔ Save changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "❌ Discard changes";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dlgDark
            // 
            dlgDark.Filter = "Image files|*.png;*.jpg;*.jpeg;*.gif";
            dlgDark.Title = "Browse for dark mode wallpaper...";
            // 
            // dlgColor
            // 
            dlgColor.FullOpen = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnSystemDisabled);
            groupBox2.Controls.Add(rbnSystemEnabled);
            groupBox2.Location = new Point(12, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 54);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Change system theme";
            // 
            // rbnSystemDisabled
            // 
            rbnSystemDisabled.AutoSize = true;
            rbnSystemDisabled.Location = new Point(79, 24);
            rbnSystemDisabled.Name = "rbnSystemDisabled";
            rbnSystemDisabled.Size = new Size(77, 21);
            rbnSystemDisabled.TabIndex = 1;
            rbnSystemDisabled.TabStop = true;
            rbnSystemDisabled.Text = "Disabled";
            rbnSystemDisabled.UseVisualStyleBackColor = true;
            // 
            // rbnSystemEnabled
            // 
            rbnSystemEnabled.AutoSize = true;
            rbnSystemEnabled.Checked = true;
            rbnSystemEnabled.Location = new Point(6, 24);
            rbnSystemEnabled.Name = "rbnSystemEnabled";
            rbnSystemEnabled.Size = new Size(73, 21);
            rbnSystemEnabled.TabIndex = 0;
            rbnSystemEnabled.TabStop = true;
            rbnSystemEnabled.Text = "Enabled";
            rbnSystemEnabled.UseVisualStyleBackColor = true;
            rbnSystemEnabled.CheckedChanged += rbnSystemEnabled_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbnAppDisabled);
            groupBox3.Controls.Add(rbnAppEnabled);
            groupBox3.Location = new Point(12, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(171, 57);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Change app theme";
            // 
            // rbnAppDisabled
            // 
            rbnAppDisabled.AutoSize = true;
            rbnAppDisabled.Location = new Point(79, 25);
            rbnAppDisabled.Name = "rbnAppDisabled";
            rbnAppDisabled.Size = new Size(77, 21);
            rbnAppDisabled.TabIndex = 1;
            rbnAppDisabled.TabStop = true;
            rbnAppDisabled.Text = "Disabled";
            rbnAppDisabled.UseVisualStyleBackColor = true;
            // 
            // rbnAppEnabled
            // 
            rbnAppEnabled.AutoSize = true;
            rbnAppEnabled.Checked = true;
            rbnAppEnabled.Location = new Point(6, 25);
            rbnAppEnabled.Name = "rbnAppEnabled";
            rbnAppEnabled.Size = new Size(73, 21);
            rbnAppEnabled.TabIndex = 0;
            rbnAppEnabled.TabStop = true;
            rbnAppEnabled.Text = "Enabled";
            rbnAppEnabled.UseVisualStyleBackColor = true;
            rbnAppEnabled.CheckedChanged += rbnAppEnabled_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(274, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 12);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 9;
            label5.Text = "Light Switch";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(330, 30);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(27, 17);
            lblVersion.TabIndex = 10;
            lblVersion.Text = "#.#";
            // 
            // llbGitHub
            // 
            llbGitHub.AutoSize = true;
            llbGitHub.Location = new Point(330, 47);
            llbGitHub.Name = "llbGitHub";
            llbGitHub.Size = new Size(48, 17);
            llbGitHub.TabIndex = 11;
            llbGitHub.TabStop = true;
            llbGitHub.Text = "GitHub";
            llbGitHub.LinkClicked += llbGitHub_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 75);
            label6.Name = "label6";
            label6.Size = new Size(171, 17);
            label6.TabIndex = 12;
            label6.Text = "(C) 2023 Joakim Magnussen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 100);
            label7.Name = "label7";
            label7.Size = new Size(154, 17);
            label7.TabIndex = 13;
            label7.Text = "(C) 2025 Ramón Ordiales";
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 344);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(llbGitHub);
            Controls.Add(lblVersion);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreferencesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preferences";
            Load += PreferencesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxDark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLight).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnWallpaperIsEnabled;
		private System.Windows.Forms.RadioButton rdbWallpaperIsDisabled;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBrowseLight;
		private System.Windows.Forms.OpenFileDialog dlgLight;
		private System.Windows.Forms.PictureBox pbxLight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseDark;
		private System.Windows.Forms.PictureBox pbxDark;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.OpenFileDialog dlgDark;
		private System.Windows.Forms.Button btnDarkColor;
		private System.Windows.Forms.Button btnLightColor;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbnSystemDisabled;
		private System.Windows.Forms.RadioButton rbnSystemEnabled;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbnAppEnabled;
		private System.Windows.Forms.RadioButton rbnAppDisabled;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.LinkLabel llbGitHub;
        private Label label6;
        private Label label7;
    }
}