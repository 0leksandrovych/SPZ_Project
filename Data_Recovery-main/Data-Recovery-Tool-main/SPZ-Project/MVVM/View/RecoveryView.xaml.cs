using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using WinForms = System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SPZ_Project.MVVM.View
{
    /// <summary>
    /// Interaction logic for RecoveryView.xaml
    /// </summary>
    public partial class RecoveryView : System.Windows.Controls.UserControl
    {
        string SourceDirectory { get; set; }
        string DestinationDirectory { get; set; }
        string SourceDirectoryDisk, DestinationDirectoryDisk;
        string RecoveryMode = "/extensive /x";
        string Request;

        public RecoveryView()
        {
            InitializeComponent();
            PopulateDiskComboBox();
        }

        private void ChooseDestinationButton_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();

            WinForms.DialogResult result = dialog.ShowDialog();

            if (result == WinForms.DialogResult.OK)
            {
                DestinationDirectory = dialog.SelectedPath;
            }

            Destinationlabel.Content = DestinationDirectory;
        }

        bool IsSourceAndDestinationSameDisk(string source, string destination)   
        {
            if (source != "Source :" && destination != "Destination" && source != null && destination != null)
            {
                string SourceDisk = source[0].ToString(), DestinationDisk = destination[0].ToString();

                if (SourceDisk == DestinationDisk)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }

        private void RestoreDataButton_Click(object sender, RoutedEventArgs e)
        {
            string request = FormRequest(SourceDirectory, DestinationDirectory, RecoveryMode, ref Request);
            if (!IsWindowsFileRecoveryInstalled())
            {
                System.Windows.MessageBox.Show("Перевірте чи WFR встановлений!", "Warning", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Warning);
            }

            if (FormRequest(SourceDirectory, DestinationDirectory, RecoveryMode, ref Request) != "Incorrect Disk selection!(they cannot be the same)")
            {
                EditScript(Request);
                RunScript();
            }
            else
            {
                System.Windows.MessageBox.Show("Неправильно обраний диск!(Диски не можуть бути однаковими)", "Warning", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Warning);
            }
        }

        private string GetRequiredDataTypes()
        {
            string RequiredDataTypes = " /y:";
            if(CBdoc.IsChecked == true) { RequiredDataTypes += "doc,"; }
            if(CBdocx.IsChecked == true) { RequiredDataTypes += "docx,"; }
            if (CBjpe.IsChecked == true) { RequiredDataTypes += "jpe,"; }
            if (CBjpeg.IsChecked == true) { RequiredDataTypes += "jpeg,"; }
            if (CBjpg.IsChecked == true) { RequiredDataTypes += "jpg,"; }
            if (CBm4a.IsChecked == true) { RequiredDataTypes += "m4a,"; }
            if (CBmov.IsChecked == true) { RequiredDataTypes += "mov,"; }
            if (CBmp3.IsChecked == true) { RequiredDataTypes += "mp3,"; }
            if (CBmp4.IsChecked == true) { RequiredDataTypes += "mp4,"; }
            if (CBmpeg.IsChecked == true) { RequiredDataTypes += "mpeg,"; }
            if (CBmpg.IsChecked == true) { RequiredDataTypes += "mpg,"; }
            if (CBodf.IsChecked == true) { RequiredDataTypes += "odf,"; }
            if (CBpdf.IsChecked == true) { RequiredDataTypes += "pdf,"; }
            if (CBpng.IsChecked == true) { RequiredDataTypes += "png,"; }
            if (CBwma.IsChecked == true) { RequiredDataTypes += "wma,"; }
            if (CBwmv.IsChecked == true) { RequiredDataTypes += "wmv,"; }
            if (CBzip.IsChecked == true) { RequiredDataTypes += "zip,"; }

            if (RequiredDataTypes == " /y:")
                return " ";
            else
                return RequiredDataTypes.Substring(0, RequiredDataTypes.Length - 1);
        }

        private string FormRequest(string SourceDirectory, string DestinationDirectory, string RecoveryMode, ref string Request)
        {
            Request = "winfr";

            if (!IsSourceAndDestinationSameDisk(SourceDirectory, DestinationDirectory))
            {
                string trmSourceDirectory = SourceDirectory, trmDestinationDirectory = DestinationDirectory;

                if (SourceDirectory.Length == 3)
                    trmSourceDirectory = SourceDirectory[0].ToString() + SourceDirectory[1].ToString();
                else if (DestinationDirectory.Length == 3)
                    trmDestinationDirectory = DestinationDirectory[0].ToString() + DestinationDirectory[1].ToString();

                Request += " " + trmSourceDirectory + " " + trmDestinationDirectory + " " + RecoveryMode + GetRequiredDataTypes();
                return Request;
            }
            else
            {
                return "Incorrect Disk selection!(they cannot be the same)";
            }
        }

        private void RunScript()
        {
            Process process = new Process();

            try
            {
                // Set the process start information
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "Resource\\RunWFR.bat";      // The path to your .bat file
                startInfo.CreateNoWindow = true;              // Do not create a window
                startInfo.UseShellExecute = false;            // Do not use the shell to execute
                startInfo.RedirectStandardOutput = true;      // Redirect the output stream
                startInfo.RedirectStandardError = true;       // Redirect the error stream

                // Assign the start information to the process
                process.StartInfo = startInfo;

                // Start the process
                process.Start();

                // Read the output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                // Display the output and error messages
                Console.WriteLine("Output: " + output);
                Console.WriteLine("Error: " + error);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the process to release resources
                process.Close();
                process.Dispose();
            }
        }

        private void EditScript(string request) 
        {
            try
            {
                string filePath = "Resource\\RunWFR.bat"; // The path to your .bat file

                string fileContent;

                // Modify the .bat file content as needed
                fileContent = "@echo off\r\necho Set objShell = CreateObject(\"Shell.Application\") > runAsAdmin.vbs\r\necho objShell.ShellExecute \"cmd.exe\", \"/k " + request + "\", \"\", \"runas\", 1 >> runAsAdmin.vbs\r\ncscript runAsAdmin.vbs\r\ndel runAsAdmin.vbs";

                // Write the modified content back to the .bat file
                File.WriteAllText(filePath, fileContent);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void PopulateDiskComboBox()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    diskComboBox.Items.Add(drive.Name);
                }
            }
        }

        private void DiskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Perform actions based on the selected disk drive
            string selectedDrive = diskComboBox.SelectedItem as string;
            SourceDirectory = selectedDrive;
            // ...
        }

        public static bool IsWindowsFileRecoveryInstalled()
        {
            string[] systemDirectories = Environment.GetEnvironmentVariable("PATH")
                .Split(System.IO.Path.PathSeparator);

            foreach (string directory in systemDirectories)
            {
                string filePath = System.IO.Path.Combine(directory, "winfr.exe");
                if (File.Exists(filePath))
                {
                    return true; // Windows File Recovery is installed
                }
            }

            return false; // Windows File Recovery is not installed
        }
    }
}
