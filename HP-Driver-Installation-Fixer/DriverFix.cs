using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

// Copyright (c) 2022-2023 Josh Davidson

namespace HP_Driver_Installation_Fixer
{
    public static class DriverFix
    {
        private static StreamReader streamReader;
        private static string[] subDirs;
        public static List<string> patchList = new List<string>();

        public static void search()
        {
            Thread searchThread = new Thread(() =>
            {
                try
                {
                    patchList.Clear();

                    subDirs = Directory.GetDirectories(MainForm.mainForm.rootPath, "*", SearchOption.TopDirectoryOnly);
                    if (subDirs.Length > 0)
                    {
                        foreach (string subDir in subDirs)
                        {
                            string detectionCmd = Path.Combine(subDir, "detection.cmd");
                            string drvInstallCmd = Path.Combine(subDir, "drvinstall.cmd");
                            string installBat = Path.Combine(subDir, "install.bat");
                            string installCmd = Path.Combine(subDir, "install.cmd");

                            if (File.Exists(detectionCmd))
                            {
                                streamReader = new StreamReader(detectionCmd);
                                string streamContents = streamReader.ReadToEnd();

                                if (streamContents.Contains("goto unsupport_OS"))
                                {
                                    patchList.Add(subDir);
                                }

                                streamReader.Close();
                                Thread.Sleep(50);
                            }
                            else if (File.Exists(drvInstallCmd))
                            {
                                streamReader = new StreamReader(drvInstallCmd);
                                string streamContents = streamReader.ReadToEnd();

                                if (streamContents.Contains("goto unsupport_OS"))
                                {
                                    patchList.Add(subDir);
                                }

                                streamReader.Close();
                                Thread.Sleep(50);
                            }
                            else if (File.Exists(installBat))
                            {
                                streamReader = new StreamReader(installBat);
                                string streamContents = streamReader.ReadToEnd();

                                if (streamContents.Contains("goto unsupport_OS"))
                                {
                                    patchList.Add(subDir);
                                }

                                streamReader.Close();
                                Thread.Sleep(50);
                            }
                            else if (File.Exists(installCmd))
                            {
                                streamReader = new StreamReader(installCmd);
                                string streamContents = streamReader.ReadToEnd();

                                if (streamContents.Contains("goto unsupport_OS"))
                                {
                                    patchList.Add(subDir);
                                }

                                streamReader.Close();
                                Thread.Sleep(50);
                            }
                        }

                        if (patchList.Count > 0)
                        {
                            MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.SearchProceed()));
                        }
                        else
                        {
                            MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.Failed("No supported packages were found in " + MainForm.mainForm.rootPath + ".")));
                        }
                    }
                    else
                    {
                        MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.Failed("No supported packages were found in " + MainForm.mainForm.rootPath + ".")));
                    }
                }
                catch
                {
                    MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.Failed("An unknown error occured searching for packages.")));
                }
            });
            searchThread.Start();
        }

        public static void patch()
        {
            Thread patchThread = new Thread(() =>
            {
                try
                {
                    if (patchList.Count <= 0) // Should never get here
                    {
                        MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.Failed("No packages are selected to patch.")));
                        return;
                    }

                    foreach (string patchDir in patchList)
                    {
                        string detectionCmd = Path.Combine(patchDir, "detection.cmd");
                        string drvInstallCmd = Path.Combine(patchDir, "drvinstall.cmd");
                        string installBat = Path.Combine(patchDir, "install.bat");
                        string installCmd = Path.Combine(patchDir, "install.cmd");

                        bool detectionCmdExists = File.Exists(detectionCmd);
                        bool drvInstallCmdExists = File.Exists(drvInstallCmd);
                        bool installBatExists = File.Exists(installBat);
                        bool installCmdExists = File.Exists(installCmd);

                        if (detectionCmdExists || drvInstallCmdExists || installBatExists || installCmdExists)
                        {
                            MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.patchProgress(patchList.IndexOf(patchDir) + 1, patchList.Count, 1, patchDir)));

                            if (detectionCmdExists)
                            {
                                streamReader = new StreamReader(detectionCmd);
                                string streamContents = streamReader.ReadToEnd();
                                streamReader.Close();
                                Thread.Sleep(50);

                                File.WriteAllText(detectionCmd, streamContents.Replace("goto unsupport_OS", "echo [%date%][%time%][%~dpnx0] Patched by HP Driver Installation Fixer, continuing installation >> %Logpath%"));
                                Thread.Sleep(500);
                            }

                            if (drvInstallCmdExists)
                            {
                                streamReader = new StreamReader(drvInstallCmd);
                                string streamContents = streamReader.ReadToEnd();
                                streamReader.Close();
                                Thread.Sleep(50);

                                File.WriteAllText(drvInstallCmd, streamContents.Replace("goto unsupport_OS", "echo [%date%][%time%][%~dpnx0] Patched by HP Driver Installation Fixer, continuing installation >> %Logpath%"));
                                Thread.Sleep(500);
                            }

                            if (installBatExists)
                            {
                                streamReader = new StreamReader(installBat);
                                string streamContents = streamReader.ReadToEnd();
                                streamReader.Close();
                                Thread.Sleep(50);

                                File.WriteAllText(installBat, streamContents.Replace("goto unsupport_OS", "echo [%date%][%time%][%~dpnx0] Patched by HP Driver Installation Fixer, continuing installation >> %Logpath%"));
                                Thread.Sleep(500);
                            }

                            if (installCmdExists)
                            {
                                streamReader = new StreamReader(installCmd);
                                string streamContents = streamReader.ReadToEnd();
                                streamReader.Close();
                                Thread.Sleep(50);

                                File.WriteAllText(installCmd, streamContents.Replace("goto unsupport_OS", "echo [%date%][%time%][%~dpnx0] Patched by HP Driver Installation Fixer, continuing installation >> %Logpath%"));
                                Thread.Sleep(500);
                            }

                            MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.patchProgress(patchList.IndexOf(patchDir) + 1, patchList.Count, 2, patchDir)));

                            string hpSetup = Path.Combine(patchDir, "HPSetup.exe");
                            string hpUp = Path.Combine(patchDir, "HPUP.exe");
                            string installExe = Path.Combine(patchDir, "install.exe");

                            if (File.Exists(hpSetup))
                            {
                                Process process = new Process();
                                process.StartInfo.FileName = hpSetup;
                                process.StartInfo.UseShellExecute = false;
                                process.StartInfo.WorkingDirectory = patchDir;
                                process.Start();
                                process.WaitForExit();
                                Thread.Sleep(50);
                            }
                            else if (File.Exists(hpUp))
                            {
                                Process process = new Process();
                                process.StartInfo.FileName = hpUp;
                                process.StartInfo.UseShellExecute = false;
                                process.StartInfo.WorkingDirectory = patchDir;
                                process.Start();
                                process.WaitForExit();
                                Thread.Sleep(50);
                            }
                            else if (File.Exists(installExe))
                            {
                                Process process = new Process();
                                process.StartInfo.FileName = installExe;
                                process.StartInfo.UseShellExecute = false;
                                process.StartInfo.WorkingDirectory = patchDir;
                                process.Start();
                                process.WaitForExit();
                                Thread.Sleep(50);
                            }
                            else
                            {
                                MessageBox.Show("Successfully patched " + patchDir + " but could not install it because HPSetup.exe, HPUP.exe, or Install.exe was not found\n\nClick OK to continue patching other packages", "Can't", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else // This will only happen if the user/system deleted something before we got here, but after we searched
                        {
                            MessageBox.Show("Could not patch " + patchDir + " because detection.cmd, drvinstall.cmd, install.bat, or install.cmd was found\n\nClick OK to continue patching other packages", "Can't", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.patchProgress(-1, patchList.Count, 2, null))); // 100%
                    Thread.Sleep(450);
                    MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.PatchProceed()));
                }
                catch
                {
                    MainForm.mainForm.BeginInvoke((Action)(() => MainForm.mainForm.Failed("An unknown error occured patching and installing packages.")));
                }
            });
            patchThread.Start();
        }
    }
}
