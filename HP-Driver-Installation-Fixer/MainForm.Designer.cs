
namespace HP_Driver_Installation_Fixer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HpWizard = new AeroWizard.WizardControl();
            this.PathPage = new AeroWizard.WizardPage();
            this.version = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RootEllipse = new System.Windows.Forms.Button();
            this.RootBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPage = new AeroWizard.WizardPage();
            this.searchingLabel = new System.Windows.Forms.Label();
            this.searchingProgress = new System.Windows.Forms.ProgressBar();
            this.ListPage = new AeroWizard.WizardPage();
            this.label4 = new System.Windows.Forms.Label();
            this.patchListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatchPage = new AeroWizard.WizardPage();
            this.patchCurrent = new System.Windows.Forms.Label();
            this.patchProgressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.FailedPage = new AeroWizard.WizardPage();
            this.tryAgainBtn = new UI.CommandLink();
            this.failedReason = new System.Windows.Forms.Label();
            this.CompletePage = new AeroWizard.WizardPage();
            this.startOverBtn = new UI.CommandLink();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rebootBtn = new UI.CommandLink();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HpWizard)).BeginInit();
            this.PathPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.ListPage.SuspendLayout();
            this.PatchPage.SuspendLayout();
            this.FailedPage.SuspendLayout();
            this.CompletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HpWizard
            // 
            this.HpWizard.Location = new System.Drawing.Point(0, 0);
            this.HpWizard.Name = "HpWizard";
            this.HpWizard.Pages.Add(this.PathPage);
            this.HpWizard.Pages.Add(this.SearchPage);
            this.HpWizard.Pages.Add(this.ListPage);
            this.HpWizard.Pages.Add(this.PatchPage);
            this.HpWizard.Pages.Add(this.FailedPage);
            this.HpWizard.Pages.Add(this.CompletePage);
            this.HpWizard.Size = new System.Drawing.Size(684, 511);
            this.HpWizard.TabIndex = 0;
            this.HpWizard.Title = "HP Driver Installation Fixer";
            this.HpWizard.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("HpWizard.TitleIcon")));
            // 
            // PathPage
            // 
            this.PathPage.AllowBack = false;
            this.PathPage.Controls.Add(this.version);
            this.PathPage.Controls.Add(this.groupBox1);
            this.PathPage.Controls.Add(this.label1);
            this.PathPage.Name = "PathPage";
            this.PathPage.Size = new System.Drawing.Size(637, 357);
            this.PathPage.TabIndex = 0;
            this.PathPage.Text = "Welcome";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(2, 339);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(45, 15);
            this.version.TabIndex = 2;
            this.version.Text = "Version";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RootEllipse);
            this.groupBox1.Controls.Add(this.RootBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // RootEllipse
            // 
            this.RootEllipse.Location = new System.Drawing.Point(563, 14);
            this.RootEllipse.Name = "RootEllipse";
            this.RootEllipse.Size = new System.Drawing.Size(33, 25);
            this.RootEllipse.TabIndex = 1;
            this.RootEllipse.Text = "...";
            this.RootEllipse.UseVisualStyleBackColor = true;
            this.RootEllipse.Click += new System.EventHandler(this.RootEllipse_Click);
            // 
            // RootBox
            // 
            this.RootBox.AllowDrop = true;
            this.RootBox.Location = new System.Drawing.Point(83, 15);
            this.RootBox.Name = "RootBox";
            this.RootBox.Size = new System.Drawing.Size(474, 23);
            this.RootBox.TabIndex = 1;
            this.RootBox.Text = "C:\\SWsetup";
            this.RootBox.TextChanged += new System.EventHandler(this.RootBox_TextChanged);
            this.RootBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.RootBox_DragDrop);
            this.RootBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.RootBox_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Root Folder:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 210);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // SearchPage
            // 
            this.SearchPage.AllowBack = false;
            this.SearchPage.AllowNext = false;
            this.SearchPage.Controls.Add(this.searchingLabel);
            this.SearchPage.Controls.Add(this.searchingProgress);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.ShowNext = false;
            this.SearchPage.Size = new System.Drawing.Size(637, 357);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "Searching...";
            // 
            // searchingLabel
            // 
            this.searchingLabel.AutoSize = true;
            this.searchingLabel.Location = new System.Drawing.Point(2, 2);
            this.searchingLabel.Name = "searchingLabel";
            this.searchingLabel.Size = new System.Drawing.Size(86, 15);
            this.searchingLabel.TabIndex = 1;
            this.searchingLabel.Text = "searchingLabel";
            // 
            // searchingProgress
            // 
            this.searchingProgress.Location = new System.Drawing.Point(2, 20);
            this.searchingProgress.Name = "searchingProgress";
            this.searchingProgress.Size = new System.Drawing.Size(602, 23);
            this.searchingProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchingProgress.TabIndex = 0;
            // 
            // ListPage
            // 
            this.ListPage.Controls.Add(this.label4);
            this.ListPage.Controls.Add(this.patchListBox);
            this.ListPage.Controls.Add(this.label3);
            this.ListPage.Name = "ListPage";
            this.ListPage.Size = new System.Drawing.Size(637, 357);
            this.ListPage.TabIndex = 4;
            this.ListPage.Text = "Search Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Click Next to begin patching. Each driver package will be installed after it is p" +
    "atched.";
            // 
            // patchListBox
            // 
            this.patchListBox.FormattingEnabled = true;
            this.patchListBox.ItemHeight = 15;
            this.patchListBox.Location = new System.Drawing.Point(4, 21);
            this.patchListBox.Name = "patchListBox";
            this.patchListBox.ScrollAlwaysVisible = true;
            this.patchListBox.Size = new System.Drawing.Size(602, 319);
            this.patchListBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "The following packages need to be patched:";
            // 
            // PatchPage
            // 
            this.PatchPage.AllowBack = false;
            this.PatchPage.AllowNext = false;
            this.PatchPage.Controls.Add(this.patchCurrent);
            this.PatchPage.Controls.Add(this.patchProgressBar);
            this.PatchPage.Controls.Add(this.label5);
            this.PatchPage.Name = "PatchPage";
            this.PatchPage.ShowNext = false;
            this.PatchPage.Size = new System.Drawing.Size(637, 357);
            this.PatchPage.TabIndex = 5;
            this.PatchPage.Text = "Patching and Installing...";
            // 
            // patchCurrent
            // 
            this.patchCurrent.AutoSize = true;
            this.patchCurrent.Location = new System.Drawing.Point(2, 46);
            this.patchCurrent.Name = "patchCurrent";
            this.patchCurrent.Size = new System.Drawing.Size(77, 15);
            this.patchCurrent.TabIndex = 2;
            this.patchCurrent.Text = "patchCurrent";
            // 
            // patchProgressBar
            // 
            this.patchProgressBar.Location = new System.Drawing.Point(2, 20);
            this.patchProgressBar.Name = "patchProgressBar";
            this.patchProgressBar.Size = new System.Drawing.Size(602, 23);
            this.patchProgressBar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(542, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Driver packages are being patched and installed. This may take some time dependin" +
    "g on the package.";
            // 
            // FailedPage
            // 
            this.FailedPage.AllowBack = false;
            this.FailedPage.AllowCancel = false;
            this.FailedPage.Controls.Add(this.tryAgainBtn);
            this.FailedPage.Controls.Add(this.failedReason);
            this.FailedPage.IsFinishPage = true;
            this.FailedPage.Name = "FailedPage";
            this.FailedPage.ShowCancel = false;
            this.FailedPage.Size = new System.Drawing.Size(637, 357);
            this.FailedPage.TabIndex = 2;
            this.FailedPage.Text = "Something Happened";
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tryAgainBtn.Location = new System.Drawing.Point(2, 34);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(232, 43);
            this.tryAgainBtn.TabIndex = 2;
            this.tryAgainBtn.Text = "Try Again";
            this.tryAgainBtn.UseVisualStyleBackColor = true;
            this.tryAgainBtn.Click += new System.EventHandler(this.startOverBtn_Click);
            // 
            // failedReason
            // 
            this.failedReason.AutoSize = true;
            this.failedReason.Location = new System.Drawing.Point(2, 2);
            this.failedReason.Name = "failedReason";
            this.failedReason.Size = new System.Drawing.Size(74, 15);
            this.failedReason.TabIndex = 0;
            this.failedReason.Text = "failedReason";
            // 
            // CompletePage
            // 
            this.CompletePage.AllowBack = false;
            this.CompletePage.AllowCancel = false;
            this.CompletePage.Controls.Add(this.startOverBtn);
            this.CompletePage.Controls.Add(this.pictureBox2);
            this.CompletePage.Controls.Add(this.rebootBtn);
            this.CompletePage.Controls.Add(this.label6);
            this.CompletePage.IsFinishPage = true;
            this.CompletePage.Name = "CompletePage";
            this.CompletePage.ShowCancel = false;
            this.CompletePage.Size = new System.Drawing.Size(637, 357);
            this.CompletePage.TabIndex = 3;
            this.CompletePage.Text = "Installation Complete";
            // 
            // startOverBtn
            // 
            this.startOverBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startOverBtn.Location = new System.Drawing.Point(2, 309);
            this.startOverBtn.Name = "startOverBtn";
            this.startOverBtn.Size = new System.Drawing.Size(232, 45);
            this.startOverBtn.TabIndex = 2;
            this.startOverBtn.Text = "Start Over";
            this.startOverBtn.UseVisualStyleBackColor = true;
            this.startOverBtn.Click += new System.EventHandler(this.startOverBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HP_Driver_Installation_Fixer.Properties.Resources.greencheck;
            this.pictureBox2.Location = new System.Drawing.Point(240, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rebootBtn
            // 
            this.rebootBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rebootBtn.Location = new System.Drawing.Point(2, 64);
            this.rebootBtn.Name = "rebootBtn";
            this.rebootBtn.Size = new System.Drawing.Size(232, 43);
            this.rebootBtn.TabIndex = 1;
            this.rebootBtn.Text = "Reboot";
            this.rebootBtn.UseVisualStyleBackColor = true;
            this.rebootBtn.Click += new System.EventHandler(this.rebootBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "Patching and installation is complete!\r\n\r\nA reboot is strongly suggested in order" +
    " to complete driver installation.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.HpWizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HP Driver Installation Fixer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HpWizard)).EndInit();
            this.PathPage.ResumeLayout(false);
            this.PathPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.ListPage.ResumeLayout(false);
            this.ListPage.PerformLayout();
            this.PatchPage.ResumeLayout(false);
            this.PatchPage.PerformLayout();
            this.FailedPage.ResumeLayout(false);
            this.FailedPage.PerformLayout();
            this.CompletePage.ResumeLayout(false);
            this.CompletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl HpWizard;
        private AeroWizard.WizardPage PathPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RootBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RootEllipse;
        private AeroWizard.WizardPage SearchPage;
        private System.Windows.Forms.Label searchingLabel;
        private System.Windows.Forms.ProgressBar searchingProgress;
        private AeroWizard.WizardPage FailedPage;
        private System.Windows.Forms.Label failedReason;
        private AeroWizard.WizardPage CompletePage;
        private AeroWizard.WizardPage ListPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox patchListBox;
        private System.Windows.Forms.Label label4;
        private AeroWizard.WizardPage PatchPage;
        private System.Windows.Forms.ProgressBar patchProgressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private UI.CommandLink rebootBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UI.CommandLink startOverBtn;
        private UI.CommandLink tryAgainBtn;
        private System.Windows.Forms.Label patchCurrent;
        private System.Windows.Forms.Label version;
    }
}

