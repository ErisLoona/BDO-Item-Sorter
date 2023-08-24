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
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
                garmothText.Text = temp[1];
                delayCounter.Value = Convert.ToDecimal(temp[2]) / 1000M;
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
            setIDButton_Click(sender, e);
            setDelayButton_Click(sender, e);
        }

        private void setIDButton_Click(object sender, EventArgs e)
        {
            string[] temp = new string[3];
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            MainMenu.lineEditor(temp[0] + ',' + garmothText.Text + ',' + temp[2], Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
        }

        private void setDelayButton_Click(object sender, EventArgs e)
        {
            string[] temp = new string[3];
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            MainMenu.lineEditor(temp[0] + ',' + temp[1] + ',' + Convert.ToString(Convert.ToInt32(delayCounter.Value * 1000M)), Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
        }
    }
}