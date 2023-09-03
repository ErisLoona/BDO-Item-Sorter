using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;

namespace BDO_Item_Sorter
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
            string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Position Settings.csv");
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary == true)
                    screenDrop.Items.Add("Primary Screen");
                else
                    screenDrop.Items.Add(screen.DeviceName);
            }
            int j = 0;
            while (j < Screen.AllScreens.Length)
            {
                screenDrop.SelectedIndex = 0;
                if (temp[6] == Screen.AllScreens[j].DeviceName)
                {
                    screenDrop.SelectedIndex = j;
                    break;
                }
                j++;
            }
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
                garmothText.Text = temp[1];
                delayCounter.Value = Convert.ToDecimal(temp[2]) / 1000M;
            }
            iconsCheck.Checked = MainMenu.iconsMode;
        }

        private void screenButton_Click(object sender, EventArgs e)
        {
            MainMenu.lineEditor(Screen.AllScreens[screenDrop.SelectedIndex].DeviceName, Directory.GetCurrentDirectory() + "\\Position Settings.csv", 6);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alignmentButton_Click(object sender, EventArgs e)
        {
            screenButton_Click(sender, e);
            AlignmentSetter a = new AlignmentSetter();
            a.ShowDialog();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            screenButton_Click(sender, e);
            setIDButton_Click(sender, e);
            setDelayButton_Click(sender, e);
        }

        private void setIDButton_Click(object sender, EventArgs e)
        {
            string[] temp = new string[5];
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            MainMenu.lineEditor(temp[0] + ',' + garmothText.Text + ',' + temp[2] + ',' + temp[3], Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
        }

        private void setDelayButton_Click(object sender, EventArgs e)
        {
            string[] temp = new string[5];
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            MainMenu.lineEditor(temp[0] + ',' + temp[1] + ',' + Convert.ToString(Convert.ToInt32(delayCounter.Value * 1000M)) + ',' + temp[3], Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
        }

        private void calibrateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This is only needed if you changed your UI Scale.\nDo you wish to proceed?", "Digit Calibration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DigitCalibration dc = new DigitCalibration();
                dc.ShowDialog();
                GC.Collect();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo website = new ProcessStartInfo();
            website.FileName = "https://youtu.be/WmSPHVduDfc";
            Process.Start(website);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://github.com/ErisLoona/support-files/raw/main/BDO%20Sorting%20Mode.zip", Directory.GetCurrentDirectory() + "\\sorting.zip");
                }
                catch
                {
                    MessageBox.Show("The download failed.\nPlease try again later.", "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            using (ZipArchive archive = ZipFile.OpenRead(Directory.GetCurrentDirectory() + "\\sorting.zip"))
            {
                foreach(ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.Name == "Grind Location Scripts.csv")
                    {
                        try
                        {
                            File.Delete(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv");
                            entry.ExtractToFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv");
                        }
                        catch
                        {
                            MessageBox.Show("The update was downloaded, but file extraction failed.\nYou can extract it yourself and replace the old one.", "Extraction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
                }
            }
            File.Delete(Directory.GetCurrentDirectory() + "\\sorting.zip");
            MessageBox.Show("Successfully updated to latest scripts!", "Update complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateButton.Enabled = true;
        }

        private void iconsCheck_Click(object sender, EventArgs e)
        {
            string[] temp = new string[5];
            if (iconsCheck.Checked == true)
                MainMenu.iconsMode = true;
            else
                MainMenu.iconsMode = false;
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            MainMenu.lineEditor(temp[0] + ',' + temp[1] + ',' + temp[2] + ',' + Convert.ToBoolean(iconsCheck.Checked), Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo website = new ProcessStartInfo();
            website.FileName = "https://ko-fi.com/erisloona";
            Process.Start(website);
        }
    }
}