using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;

namespace BDO_Item_Sorter
{
    public partial class Settings : Form
    {
        public static Screen activeScreen = Screen.PrimaryScreen;
        private DevModeTrigger sequence = new DevModeTrigger();

        public Settings()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Garmoth Autofiller Data");
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                string[] temp;
                temp = reader.ReadLine().Split(',');
                garmothText.Text = temp[1];
            }
            string[] temps = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Position Settings.csv");
            int count = 0;
            while (count < Screen.AllScreens.Length)
            {
                if (temps[7] == Screen.AllScreens[count].DeviceName)
                {
                    activeScreen = Screen.AllScreens[count];
                    break;
                }
                count++;
            }
            alignmentCheck.Checked = MainMenu.needsAlignment;
            if (Convert.ToBoolean(temps[5].Split(',')[1]) == false)
                alignmentCheck.Enabled = false;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateButton.Enabled == false)
                e.Cancel = true;
            string[] temp = new string[5];
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            MainMenu.lineEditor(temp[0] + ',' + garmothText.Text + ',' + temp[2] + ',' + temp[3], Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            updatingLabel.Visible = true;
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://github.com/ErisLoona/support-files/releases/download/1/BDO.Garmoth.Autofiller.zip", Directory.GetCurrentDirectory() + "\\sorting.zip");
                }
                catch
                {
                    updateButton.Enabled = true;
                    updatingLabel.Visible = false;
                    MessageBox.Show("The download failed.\nPlease try again later.", "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                for (int i = 0; i < 10; i++)
                    MainMenu.digits[i].Dispose();
                for (int i = 0; i < MainMenu.itemIcons.Count; i++)
                    MainMenu.itemIcons[i].Dispose();
                MainMenu.itemIcons.Clear();
                MainMenu.timerButtonPlayIcon.Dispose();
                MainMenu.timerButtonPauseIcon.Dispose();
                MainMenu.unknownItemOverlay.Dispose();
                MainMenu.problematicItemOverlay.Dispose();
                MainMenu.ignoredItemOverlay.Dispose();
                Directory.Delete(Directory.GetCurrentDirectory() + "\\Icons", true);
                Directory.Delete(Directory.GetCurrentDirectory() + "\\Sorting Mode", true);
                Directory.Delete(Directory.GetCurrentDirectory() + "\\Python", true);
                File.Delete(Directory.GetCurrentDirectory() + "\\Item Attributions.csv");
                File.Delete(Directory.GetCurrentDirectory() + "\\Problematic Items.txt");
                ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "\\sorting.zip", Directory.GetCurrentDirectory());
                File.Delete(Directory.GetCurrentDirectory() + "\\sorting.zip");
            }
            catch
            {
                MessageBox.Show("The update was downloaded but file extraction failed!\nYou can extract it yourself, then delete the archive.", "Extraction IO error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateButton.Enabled = true;
                updatingLabel.Visible = false;
                return;
            }
            string[] gameOptionsFile = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\GameOption.txt");
            if (Convert.ToInt32(gameOptionsFile[101].Substring(gameOptionsFile[101].Length - 1, 1)) == 0)
                for (int i = 0; i < 10; i++)
                    MainMenu.digits[i] = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\DejaVu Sans\\" + Convert.ToString(MainMenu.currentUIScale) + "\\" + Convert.ToString(i) + ".bmp");
            else if (Convert.ToInt32(gameOptionsFile[101].Substring(gameOptionsFile[101].Length - 1, 1)) == 2)
                for (int i = 0; i < 10; i++)
                    MainMenu.digits[i] = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\Strong Sword\\" + Convert.ToString(MainMenu.currentUIScale) + "\\" + Convert.ToString(i) + ".bmp");
            MainMenu.timerButtonPlayIcon = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\play.png");
            MainMenu.timerButtonPauseIcon = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\pause.png");
            MainMenu.unknownItemOverlay = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\unknownitem.png");
            MainMenu.problematicItemOverlay = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\problematicitem.png");
            MainMenu.ignoredItemOverlay = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\ignoreditem.png");
            updatingLabel.Visible = false;
            MessageBox.Show("Successfully updated!", "Update complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateButton.Enabled = true;
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo website = new ProcessStartInfo();
            website.FileName = "https://ko-fi.com/erisloona";
            Process.Start(website);
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void alignmentCheck_Click(object sender, EventArgs e)
        {
            MainMenu.needsAlignment = !MainMenu.needsAlignment;
        }

        private void Settings_KeyUp(object sender, KeyEventArgs e)
        {
            if (sequence.IsCompletedBy(e.KeyCode))
            {
                DevMode dm = new DevMode();
                dm.Show();
            }
        }
    }

    public class DevModeTrigger
    {
        List<Keys> Keys = new List<Keys>{System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A};
        private int mPosition = -1;

        public int Position
        {
            get { return mPosition; }
            private set { mPosition = value; }
        }

        public bool IsCompletedBy(Keys key)
        {
            if (Keys[Position + 1] == key)
                Position++;
            else if (Keys[0] == key)
                Position = 0;
            else
                Position = -1;
            if (Position == Keys.Count - 1)
            {
                Position = -1;
                return true;
            }
            return false;
        }
    }
}