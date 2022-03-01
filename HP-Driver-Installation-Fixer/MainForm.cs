using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

// Copyright (c) 2022 Josh Davidson

namespace HP_Driver_Installation_Fixer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HpWizard.Cancelling += WizardCancelled;
            HpWizard.Finished += WizardFinished;
            PathPage.Commit += PathNext;
            SearchPage.Initialize += SearchInit;
            ListPage.Rollback += ListRollback;
            PatchPage.Initialize += PatchInit;
            FailedPage.Initialize += FailedInit;
            CompletePage.Initialize += CompleteInit;
        }

        public static MainForm mainForm;
        public string rootPath;
        private bool rootValid = false;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainForm = this;
            version.Text = "Version: " + Version.VerMain;
        }

        private void WizardCancelled(object sender, EventArgs e)
        {
            if (HpWizard.SelectedPage == SearchPage || HpWizard.SelectedPage == PatchPage)
            {
                if (DialogResult.Yes == MessageBox.Show("The application is busy doing something\n\nDo you want to force it to close?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void WizardFinished(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string FilePickerInitialPath(string input)
        {
            if (input.Length > 0)
            {
                try
                {
                    FileAttributes pathattr = File.GetAttributes(Path.GetFullPath(input));
                    if (pathattr.HasFlag(FileAttributes.Directory))
                    {
                        return Path.GetFullPath(input);
                    }
                    else return Path.GetDirectoryName(input);
                }
                catch
                {
                    return "";
                }
            }
            else return "";
        }

        #region Path Page

        private void PathNext(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            checkRootPath();
            if (!rootValid)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                searchingLabel.Text = "Searching " + Path.GetFileName(rootPath) + " for packages...";
            }
        }

        private void PathCheckNext()
        {
           PathPage.AllowNext = RootBox.TextLength > 0;
        }

        private void RootBox_TextChanged(object sender, EventArgs e)
        {
            PathCheckNext();
        }

        private void RootBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            RootBox.Text = s[0];
        }
        private void RootBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void RootEllipse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openDialog = new CommonOpenFileDialog();
            openDialog.InitialDirectory = FilePickerInitialPath(RootBox.Text);
            openDialog.RestoreDirectory = false;
            openDialog.IsFolderPicker = true;
            if (openDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                RootBox.Text = openDialog.FileName;
            }
        }

        private void checkRootPath()
        {
            try
            {
                rootPath = Path.GetFullPath(RootBox.Text);
            }
            catch
            {
                rootValid = false;
                MessageBox.Show("Illegal path to folder\n\nYou need to supply a valid folder", "Can't", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(rootPath))
            {
                rootValid = false;
                MessageBox.Show("Folder does not exist or is not a folder\n\nYou need to supply a valid folder", "Can't", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rootValid = true;
            }
        }

        #endregion

        #region Search, List and Patch Pages

        public void Failed(string error)
        {
            failedReason.Text = error;
            HpWizard.NextPage(FailedPage);
        }

        private void SearchInit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            DriverFix.search();
        }

        public void SearchProceed()
        {
            patchListBox.DataSource = DriverFix.patchList;
            HpWizard.NextPage();
        }

        private void ListRollback(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            e.Cancel = true;
            HpWizard.NextPage(PathPage);
        }

        private void PatchInit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            DriverFix.patch();
        }

        public void PatchProceed()
        {
            HpWizard.NextPage(CompletePage);
        }

        public void patchProgress(int current, int total, int step, string path)
        {
            int progress;
            if (current == -1)
            {
                progress = 100;
            }
            else
            {
                progress = Convert.ToInt32((100 / ((float)(total * 2) + 1)) * (((current - 1) * 2) + step)); // Increment bar for each item, and each step, leaving one empty slot at end
            }
            patchProgressBar.Value = progress;

            if (path == null)
            {
                patchCurrent.Text = progress + "% - Please wait...";
            }
            else if (step == 2)
            {
                patchCurrent.Text = progress + "% - Installing " + path + " (" + current + "/" + total + ")...";
            }
            else
            {
                patchCurrent.Text = progress + "% - Patching " + path + " (" + current + "/" + total + ")...";
            }
        }


        #endregion

        #region Failed/Complete Page

        private void FailedInit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            AcceptButton = tryAgainBtn;
        }

        private void CompleteInit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            AcceptButton = rebootBtn;
        }

        private void startOverBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rebootBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 0");
        }

        #endregion
    }
}
