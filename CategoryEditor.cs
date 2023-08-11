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
    public partial class CategoryEditor : Form
    {
        public static string[] itemName = new string[10000], itemCategory = new string[10000], menuCategories = new string[100], menuCities = new string[100], menuCategoryAttribution = new string[100], menuCityAttribution = new string[100];
        public static int menuCategoriesIndex = 0, menuCitiesIndex = 0, itemDatabaseIndex = 0, categoryAttributionIndex = 0;
        public static int[] itemID = new int[10000], cityCapacity = new int[100];
        public static bool[] itemIgnored = new bool[10000], itemProblematic = new bool[10000];

        public CategoryEditor()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void CategoryEditor_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
            update();
        }

        public void update()
        {
            menuCategoriesIndex = 0;
            menuCitiesIndex = 0;
            itemDatabaseIndex = 0;
            categoryAttributionIndex = 0;
            categoryDisplay.Items.Clear();
            categoryDrop.Items.Clear();
            cityDrop.Items.Clear();
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Categories.txt"))
            {
                while (reader.EndOfStream == false)
                {
                    menuCategories[menuCategoriesIndex] = reader.ReadLine();
                    menuCategoriesIndex++;
                }
                reader.Dispose();
            }
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Cities.txt"))
            {
                while (reader.EndOfStream == false)
                {
                    menuCities[menuCitiesIndex] = reader.ReadLine();
                    menuCitiesIndex++;
                }
                reader.Dispose();
            }
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Item Attributions.csv"))
            {
                while (reader.EndOfStream == false)
                {
                    string[] tempAttributes = new string[5];
                    tempAttributes = reader.ReadLine().Split(',');
                    itemID[itemDatabaseIndex] = Convert.ToInt32(tempAttributes[0]);
                    itemName[itemDatabaseIndex] = tempAttributes[1];
                    itemCategory[itemDatabaseIndex] = tempAttributes[2];
                    itemIgnored[itemDatabaseIndex] = Convert.ToBoolean(tempAttributes[3]);
                    itemProblematic[itemDatabaseIndex] = Convert.ToBoolean(tempAttributes[4]);
                    itemDatabaseIndex++;
                }
                reader.Dispose();
            }
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Category Attributions.csv"))
            {
                while (reader.EndOfStream == false)
                {
                    string[] tempAttributes = new string[2];
                    tempAttributes = reader.ReadLine().Split(',');
                    menuCategoryAttribution[categoryAttributionIndex] = tempAttributes[0];
                    menuCityAttribution[categoryAttributionIndex] = tempAttributes[1];
                    categoryAttributionIndex++;
                }
                reader.Dispose();
            }
            for (int i = 0; i < menuCategoriesIndex; i++)
            {
                categoryDisplay.Items.Add(menuCategories[i]);
                categoryDrop.Items.Add(menuCategories[i]);
            }
            for(int i = 0; i < menuCitiesIndex; i++)
            {
                cityDrop.Items.Add(menuCities[i]);
            }
            categoryDrop.SelectedIndex = menuCategoriesIndex - 1;
            cityDrop.SelectedIndex = menuCitiesIndex - 1;
        }

        private void attributeButton_Click(object sender, EventArgs e)
        {
            if (categoryDrop.SelectedIndex != MainMenu.menuCategoriesIndex - 1)
            {
                MainMenu.lineEditor(categoryDrop.Text + ',' + cityDrop.Text, Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryDrop.SelectedIndex);
            }
        }

        private void categoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < MainMenu.menuCitiesIndex; i++)
            {
                if (MainMenu.menuCityAttribution[categoryDrop.SelectedIndex] == MainMenu.menuCities[i])
                {
                    cityDrop.SelectedIndex = i;
                    break;
                }
            }
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoryDisplay.SelectedIndex != menuCategoriesIndex - 1 && categoryDisplay.SelectedIndex != 0)
            {
                string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Categories.txt");
                string b;
                b = temp[categoryDisplay.SelectedIndex];
                MainMenu.lineEditor(temp[categoryDisplay.SelectedIndex - 1], Directory.GetCurrentDirectory() + "\\Categories.txt", categoryDisplay.SelectedIndex);
                MainMenu.lineEditor(b, Directory.GetCurrentDirectory() + "\\Categories.txt", categoryDisplay.SelectedIndex - 1);
                string[] temp2 = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Category Attributions.csv");
                string b2;
                b2 = temp2[categoryDisplay.SelectedIndex];
                MainMenu.lineEditor(temp2[categoryDisplay.SelectedIndex - 1], Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryDisplay.SelectedIndex);
                MainMenu.lineEditor(b2, Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryDisplay.SelectedIndex - 1);
            }
            else
                MessageBox.Show("Cannot change the order of (none) or the first item.", "Wait, that's illegal!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            update();
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoryDisplay.SelectedIndex != menuCategoriesIndex - 1 && categoryDisplay.SelectedIndex != menuCategoriesIndex - 2)
            {
                string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Categories.txt");
                string b;
                b = temp[categoryDisplay.SelectedIndex];
                MainMenu.lineEditor(temp[categoryDisplay.SelectedIndex + 1], Directory.GetCurrentDirectory() + "\\Categories.txt", categoryDisplay.SelectedIndex);
                MainMenu.lineEditor(b, Directory.GetCurrentDirectory() + "\\Categories.txt", categoryDisplay.SelectedIndex + 1);
                string[] temp2 = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Category Attributions.csv");
                string b2;
                b2 = temp2[categoryDisplay.SelectedIndex];
                MainMenu.lineEditor(temp2[categoryDisplay.SelectedIndex + 1], Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryDisplay.SelectedIndex);
                MainMenu.lineEditor(b2, Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryDisplay.SelectedIndex + 1);
            }
            else
                MessageBox.Show("Cannot change the order of (none).", "Wait, that's illegal!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            update();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoryDisplay.SelectedIndex != menuCategoriesIndex - 1)
            {
                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Categories.txt"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != menuCategories[categoryDisplay.SelectedIndex])
                            sw.WriteLine(line);
                    }
                }
                File.Delete(Directory.GetCurrentDirectory() + "\\Categories.txt");
                File.Move(tempFile, Directory.GetCurrentDirectory() + "\\Categories.txt");
                using (var sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Category Attributions.csv"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != (menuCategoryAttribution[categoryDisplay.SelectedIndex] + ',' + menuCityAttribution[categoryDisplay.SelectedIndex]))
                            sw.WriteLine(line);
                    }
                }
                File.Delete(Directory.GetCurrentDirectory() + "\\Category Attributions.csv");
                File.Move(tempFile, Directory.GetCurrentDirectory() + "\\Category Attributions.csv");
                for (int i = 0; i < itemDatabaseIndex; i++)
                {
                    if (itemCategory[i] == menuCategories[categoryDisplay.SelectedIndex])
                    {
                        MainMenu.lineEditor(Convert.ToString(itemID[i]) + ',' + itemName[i] + ',' + "(none)" + ',' + Convert.ToString(itemIgnored[i]) + ',' + itemProblematic[i], Directory.GetCurrentDirectory() + "\\Item Attributions.csv", i);
                    }
                }
                update();
            }
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            if (newCategoryText.Text != null)
            {
                MainMenu.lineEditor(newCategoryText.Text, Directory.GetCurrentDirectory() + "\\Categories.txt", menuCategoriesIndex - 1);
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Categories.txt", true))
                {
                    writer.WriteLine("(none)");
                    writer.Dispose();
                }
                MainMenu.lineEditor(newCategoryText.Text + ",(none)", Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryAttributionIndex - 1);
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Category Attributions.csv", true))
                {
                    writer.WriteLine("(none),(none)");
                    writer.Dispose();
                }
                newCategoryText.Text = null;
            }
            update();
        }

        private void addLocation_Click(object sender, EventArgs e)
        {
            if (newLocationText.Text != null)
            {
                MainMenu.lineEditor(newLocationText.Text, Directory.GetCurrentDirectory() + "\\Cities.txt", menuCitiesIndex - 1);
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cities.txt", true))
                {
                    writer.WriteLine("(none)");
                    writer.Dispose();
                }
                newLocationText.Text = null;
            }
            update();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (categoryDrop.SelectedIndex != MainMenu.menuCategoriesIndex - 1)
            {
                MainMenu.lineEditor(categoryDrop.Text + ',' + cityDrop.Text, Directory.GetCurrentDirectory() + "\\Category Attributions.csv", categoryDrop.SelectedIndex);
            }
        }

        private void categoryDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            categoryDisplay.SelectedIndex = categoryDisplay.IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                if (categoryDisplay.SelectedIndex != -1 && categoryDisplay.SelectedItem.ToString() != "(none)")
                    moveContext.Show(Cursor.Position);
            }
        }
    }
}