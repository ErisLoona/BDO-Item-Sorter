using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}