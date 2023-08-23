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
            if (MainMenu.sessionActive == true)
                catDrop.Enabled = false;
            for (int i = 0; i < MainMenu.menuCategoriesIndex; i++)
                catDrop.Items.Add(MainMenu.menuCategories[i]);
            catDrop.SelectedIndex = MainMenu.menuCategoriesIndex - 1;
            nameText.Text = null;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (MainMenu.itemClicked[row, col] == true)
                    {
                        itemID = MainMenu.itemID[MainMenu.gridItemID[row, col]];
                        nameText.Text = MainMenu.itemName[itemID];
                        for (int i = 0; i < MainMenu.menuCategoriesIndex; i++)
                        {
                            if (MainMenu.menuCategories[i] == MainMenu.itemCategory[itemID])
                            {
                                catDrop.SelectedIndex = i;
                                break;
                            }
                        }
                        if (MainMenu.itemIgnored[itemID] == true)
                            ignoredBox.Checked = true;
                        if (MainMenu.itemProblematic[itemID] == true)
                            problematicBox.Checked = true;
                        break;
                    }
                }
            }
        }

        private void ItemEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.lineEditor(Convert.ToString(itemID) + ',' + nameText.Text + ',' + catDrop.Text + ',' + Convert.ToString(ignoredBox.Checked) + ',' + Convert.ToString(problematicBox.Checked), Directory.GetCurrentDirectory() + "\\Item Attributions.csv", itemID);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}