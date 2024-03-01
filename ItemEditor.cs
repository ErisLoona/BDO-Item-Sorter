using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BDO_Item_Sorter
{
    public partial class ItemEditor : Form
    {
        int itemID = 0;

        public ItemEditor()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void ItemEditor_Load(object sender, EventArgs e)
        {
            nameText.Text = null;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (MainMenu.itemClicked[row, col] == true)
                    {
                        itemID = MainMenu.itemID[MainMenu.gridItemID[row, col]];
                        nameText.Text = MainMenu.itemName[itemID];
                        if (MainMenu.itemIgnored[itemID] == true)
                            ignoredBox.Checked = true;
                        if (MainMenu.itemProblematic[itemID] == true)
                            problematicBox.Checked = true;
                        if (MainMenu.itemLocked[itemID] == true)
                        {
                            nameText.Enabled = false;
                            problematicBox.Enabled = false;
                        }
                        return;
                    }
                }
            }
        }

        private void ItemEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MainMenu.itemLocked[itemID] == true)
                MainMenu.lineEditor(Convert.ToString(itemID) + ',' + nameText.Text + ',' + "True" + ',' + Convert.ToString(ignoredBox.Checked) + ',' + Convert.ToString(problematicBox.Checked), Directory.GetCurrentDirectory() + "\\Item Attributions.csv", itemID);
            else
                MainMenu.lineEditor(Convert.ToString(itemID) + ',' + nameText.Text + ',' + "False" + ',' + Convert.ToString(ignoredBox.Checked) + ',' + Convert.ToString(problematicBox.Checked), Directory.GetCurrentDirectory() + "\\Item Attributions.csv", itemID);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nameText.Text.Contains(',') == true)
            {
                MessageBox.Show("The name cannot contain commas (\",\")!", "Illegal character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
        }

        private void ItemEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}