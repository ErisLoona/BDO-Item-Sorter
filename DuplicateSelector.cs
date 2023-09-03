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
    public partial class DuplicateSelector : Form
    {
        int[] itemIDs = new int[10000];
        int index = -1, rowID, colID;

        public DuplicateSelector()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void DuplicateSelector_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
            nameBox.Items.Clear();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (MainMenu.itemClicked[row, col] == true)
                    {
                        rowID = row;
                        colID = col;
                        break;
                    }
                }
            }
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Problematic Items.txt"))
            {
                while (reader.EndOfStream == false)
                {
                    string[] temp;
                    temp = reader.ReadLine().Split(',');
                    if (Convert.ToInt32(temp[0]) == MainMenu.gridItemID[rowID, colID])
                    {
                        index++;
                        nameBox.Items.Add(MainMenu.itemName[Convert.ToInt32(temp[1])]);
                        itemIDs[index] = Convert.ToInt32(temp[1]);
                    }
                }
                reader.Dispose();
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DuplicateSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nameBox.Text.Contains(',') == true)
            {
                MessageBox.Show("The name cannot contain commas (\",\")!", "Illegal character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
            if (nameBox.SelectedIndex == -1 && nameBox.Text != string.Empty)
            {
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(MainMenu.itemDatabaseIndex) + ',' + nameBox.Text + ",(none),False,True");
                    writer.Dispose();
                }
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Problematic Items.txt", true))
                {
                    writer.WriteLine(Convert.ToString(MainMenu.gridItemID[rowID, colID]) + ',' + Convert.ToString(MainMenu.itemDatabaseIndex));
                    writer.Dispose();
                }
                MainMenu.lineEditor(Convert.ToString(MainMenu.gridItemID[rowID, colID]) + ',' + Convert.ToString(MainMenu.itemName[MainMenu.gridItemID[rowID, colID]]) + ',' + Convert.ToString(MainMenu.itemCategory[MainMenu.gridItemID[rowID, colID]]) + ',' + Convert.ToString(MainMenu.itemIgnored[MainMenu.gridItemID[rowID, colID]]) + ',' + "True", Directory.GetCurrentDirectory() + "\\Item Attributions.csv", MainMenu.gridItemID[rowID, colID]);
                File.Copy(Directory.GetCurrentDirectory() + '\\' + Convert.ToString(MainMenu.gridItemID[rowID, colID]) + ".bmp", Directory.GetCurrentDirectory() + '\\' + Convert.ToString(MainMenu.itemDatabaseIndex) + ".bmp");
                MainMenu.gridItemID[rowID, colID] = MainMenu.itemDatabaseIndex;
            }
            else
            {
                if (nameBox.SelectedIndex != -1)
                    MainMenu.gridItemID[rowID, colID] = itemIDs[nameBox.SelectedIndex];
            }
            MainMenu.canAdd[rowID, colID] = false;
        }
    }
}