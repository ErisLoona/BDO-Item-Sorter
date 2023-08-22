using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BDO_Item_Sorter
{
    public partial class MainMenu : Form
    {
        public static int[] itemID = new int[10000];
        public static int[,] gridItemID = new int[8, 8], gridOverviewIndex = new int[8, 8], gridStackNumber = new int[8, 8];
        public static string[] itemName = new string[10000], itemCategory = new string[10000], menuCategories = new string[100], menuCities = new string[100], menuCategoryAttribution = new string[100], menuCityAttribution = new string[100];
        public static bool[] itemIgnored = new bool[10000], itemProblematic = new bool[10000];
        public static bool[,] knownItemCheck = new bool[8, 8], itemClicked = new bool[8, 8], canAdd = new bool[8, 8];
        public static int cW = 0, cH = 0, s = 0, picW = 0, picH = 0;
        public static bool firstSetup = false, fmode;

        Screen activeScreen = Screen.PrimaryScreen;
        public static Button[,] itemButtons;
        public static Rectangle[,] itemCoords = new Rectangle[8, 8], stack = new Rectangle[8, 8];
        Bitmap prtscr, currentItem;
        public static Bitmap[] digits = new Bitmap[10];
        Graphics g;

        public static int menuCategoriesIndex = 0, menuCitiesIndex = 0, itemDatabaseIndex = 0, categoryAttributionIndex = 0;

        //Sorting Mode extras
        public static string[] script = new string[100], itemRemember = new string[128];
        public static int itemListControls = 0, hh = 0, mm = 0, ss = 0, rememberIndex = 0, scriptIndex = 0;
        public static bool sessionActive = false, sessionPaused = false;
        NumericUpDown[] stackCounter = new NumericUpDown[50];
        Label[] stackLabel = new Label[50];

        public MainMenu()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try //attempt to set current directory, if it doesn't exist then perform initial setup
            {
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
            }
            catch
            {
                MessageBox.Show("Support files not found, doing first time setup.\nPlease make sure BDO is running!", "Support files not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
                    Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
                    using (File.Create(Directory.GetCurrentDirectory() + "\\Problematic Items.txt")) { }
                    using (File.Create(Directory.GetCurrentDirectory() + "\\Item Attributions.csv")) { }
                    using (File.Create(Directory.GetCurrentDirectory() + "\\Categories.txt")) { }
                    using (File.Create(Directory.GetCurrentDirectory() + "\\Category Attributions.csv")) { }
                    using (File.Create(Directory.GetCurrentDirectory() + "\\Position Settings.csv")) { }
                    using (File.Create(Directory.GetCurrentDirectory() + "\\Cities.txt")) { }
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Categories.txt"))
                    {
                        writer.WriteLine("(none)");
                    }
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Category Attributions.csv"))
                    {
                        writer.WriteLine("(none),(none)");
                    }
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Position Settings.csv"))
                    {
                        writer.WriteLine("Top left corner width (horizontal),1467");
                        writer.WriteLine("Top left corner height (vertical),321");
                        writer.WriteLine("Step to next slots,54");
                        writer.WriteLine("Width of slot,42");
                        writer.WriteLine("Height of slot,24");
                        writer.WriteLine("Classic");
                        writer.WriteLine("temp");
                    }
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cities.txt"))
                    {
                        writer.WriteLine("Family Storage");
                        writer.WriteLine("Velia");
                        writer.WriteLine("Heidel");
                        writer.WriteLine("Glish");
                        writer.WriteLine("Calpheon City");
                        writer.WriteLine("Keplan");
                        writer.WriteLine("Trent");
                        writer.WriteLine("Altinova");
                        writer.WriteLine("Tarif");
                        writer.WriteLine("(none)");
                    }
                    firstSetup = true;
                }
                catch
                {
                    MessageBox.Show("Error creating support files!", "IO error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(0);
                }
            }
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                string[] tempAttributes = new string[5];
                tempAttributes = reader.ReadLine().Split(',');
                fmode = Convert.ToBoolean(tempAttributes[0]);
                modeCheck.Checked = fmode;
            }
            if (modeCheck.Checked == true)
            {
                loadingBar.Maximum = 2000000;
                normalModePanel.Visible = false;
                normalModePanel.Enabled = false;
                farmingModePanel.Visible = true;
                farmingModePanel.Enabled = true;
                locationBox.Items.Add("Select farming location");
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
                {
                    reader.ReadLine();
                    while (reader.EndOfStream == false)
                    {
                        string[] tempAttributes = new string[100];
                        tempAttributes = reader.ReadLine().Split(',');
                        locationBox.Items.Add(tempAttributes[0]);
                    }
                }
                locationBox.SelectedIndex = 0;
            }
            else
            {
                loadingBar.Maximum = 1000000;
                normalModePanel.Visible = true;
                normalModePanel.Enabled = true;
                farmingModePanel.Visible = false;
                farmingModePanel.Enabled = false;
            }
            databaseLoad();
            for (int i = 0; i < 10; i++)
                digits[i] = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\" + Convert.ToString(i) + ".bmp");
            itemButtons = new Button[,]
            {
                {itemButton00,itemButton01,itemButton02,itemButton03,itemButton04,itemButton05,itemButton06,itemButton07},
                {itemButton10,itemButton11,itemButton12,itemButton13,itemButton14,itemButton15,itemButton16,itemButton17},
                {itemButton20,itemButton21,itemButton22,itemButton23,itemButton24,itemButton25,itemButton26,itemButton27},
                {itemButton30,itemButton31,itemButton32,itemButton33,itemButton34,itemButton35,itemButton36,itemButton37},
                {itemButton40,itemButton41,itemButton42,itemButton43,itemButton44,itemButton45,itemButton46,itemButton47},
                {itemButton50,itemButton51,itemButton52,itemButton53,itemButton54,itemButton55,itemButton56,itemButton57},
                {itemButton60,itemButton61,itemButton62,itemButton63,itemButton64,itemButton65,itemButton66,itemButton67},
                {itemButton70,itemButton71,itemButton72,itemButton73,itemButton74,itemButton75,itemButton76,itemButton77}
            };
            gridItemID = ClearIntMatrix(gridItemID);
            prtscr = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            g = Graphics.FromImage(prtscr);
            if (firstSetup == true)
            {
                firstSetup = false;
                settingsButton_Click(sender, e);
            }
        }

        public void databaseLoad()
        {
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                string[] tempAttributes = new string[2];
                tempAttributes = reader.ReadLine().Split(',');
                fmode = Convert.ToBoolean(tempAttributes[0]);
                modeCheck.Checked = fmode;
            }
            if (fmode == false)
            {
                menuCategoriesIndex = 0;
                menuCitiesIndex = 0;
                itemDatabaseIndex = 0;
                categoryAttributionIndex = 0;
                itemLookup.Items.Clear();
                itemLookupLabel.Text = string.Empty;
                string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Position Settings.csv");
                int count = 0;
                while (count < Screen.AllScreens.Length)
                {
                    if (temp[6] == Screen.AllScreens[count].DeviceName)
                    {
                        activeScreen = Screen.AllScreens[count];
                        break;
                    }
                    count++;
                }
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Categories.txt"))
                {
                    while (reader.EndOfStream == false)
                    {
                        menuCategories[menuCategoriesIndex] = reader.ReadLine();
                        menuCategoriesIndex++;
                    }
                }
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Cities.txt"))
                {
                    while (reader.EndOfStream == false)
                    {
                        menuCities[menuCitiesIndex] = reader.ReadLine();
                        menuCitiesIndex++;
                    }
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
                }
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Position Settings.csv"))
                {
                    string[] tempAttribute = new string[2];
                    tempAttribute = reader.ReadLine().Split(',');
                    cW = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    cH = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    s = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    picW = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    picH = Convert.ToInt32(tempAttribute[1]);
                }
                categoryOverviewReset();
                for (int i = 0; i < itemDatabaseIndex; i++)
                    itemLookup.Items.Add(itemName[i]);
                itemLookup.SelectedIndex = -1;
                int tempI = 0, tempJ = 0;
                for (int row = cH; row <= cH + 7 * s; row += s)
                {
                    for (int col = cW; col <= cW + 7 * s; col += s)
                    {
                        itemCoords[tempI, tempJ] = new Rectangle(col, row, picW, picH);
                        tempJ++;
                    }
                    tempJ = 0;
                    tempI++;
                }
            }
            else
            {
                itemDatabaseIndex = 0;
                string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Position Settings.csv");
                int count = 0;
                while (count < Screen.AllScreens.Length)
                {
                    if (temp[6] == Screen.AllScreens[count].DeviceName)
                    {
                        activeScreen = Screen.AllScreens[count];
                        break;
                    }
                    count++;
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
                }
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Position Settings.csv"))
                {
                    string[] tempAttribute = new string[2];
                    tempAttribute = reader.ReadLine().Split(',');
                    cW = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    cH = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    s = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    picW = Convert.ToInt32(tempAttribute[1]);
                    tempAttribute = reader.ReadLine().Split(',');
                    picH = Convert.ToInt32(tempAttribute[1]);
                }
                int tempI = 0, tempJ = 0;
                for (int row = cH; row <= cH + 7 * s; row += s)
                {
                    for (int col = cW; col <= cW + 7 * s; col += s)
                    {
                        itemCoords[tempI, tempJ] = new Rectangle(col, row, picW, picH);
                        tempJ++;
                    }
                    tempJ = 0;
                    tempI++;
                }
                tempI = 0;
                tempJ = 0;
                for (int row = cH + picH; row <= cH + picH + 7 * s; row += s)
                {
                    for (int col = cW; col <= cW + 7 * s; col += s)
                    {
                        stack[tempI, tempJ] = new Rectangle(col, row, picW, picW - picH);
                        tempJ++;
                    }
                    tempJ = 0;
                    tempI++;
                }
            }
        }

        public static void lineEditor(string newText, string file, int lineNumber) //edits provided line of provided file with provided text
        {
            string[] temp = File.ReadAllLines(file);
            temp[lineNumber] = newText;
            File.WriteAllLines(file, temp);
        }

        public int ItemDetector(Bitmap testItem) //returns the index of the given item or -1 if it's a new item
        {
            int i = -1;
            do
            {
                i++;
                if (File.Exists(Directory.GetCurrentDirectory() + "\\" + Convert.ToString(i) + ".bmp") == true)
                {
                    if (CompareBitmaps(testItem, (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\" + Convert.ToString(i) + ".bmp")) == true)
                        return i;
                }
                else
                    i = -1;
            } while (i != -1);
            return -1;
        }

        public bool CompareBitmaps(Bitmap bmp1, Bitmap bmp2) //returns true if the given pics are the same || false if not
        {
            int bytes = bmp1.Width * bmp1.Height * (Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);
            bool result = true;
            byte[] b1bytes = new byte[bytes];
            byte[] b2bytes = new byte[bytes];
            BitmapData bitmapData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, bmp1.PixelFormat);
            BitmapData bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, bmp2.PixelFormat);
            Marshal.Copy(bitmapData1.Scan0, b1bytes, 0, bytes);
            Marshal.Copy(bitmapData2.Scan0, b2bytes, 0, bytes);
            for (int n = 0; n <= bytes - 1; n++)
            {
                if (b1bytes[n] != b2bytes[n])
                {
                    result = false;
                    break;
                }
            }
            bmp1.UnlockBits(bitmapData1);
            bmp2.UnlockBits(bitmapData2);
            return result;
        }

        public static bool[,] ClearBoolMatrix(bool[,] array) //sets all elements in 8 by 8 bool matrices to true
        {
            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                    array[row, col] = true;
            return array;
        }

        public static int[,] ClearIntMatrix(int[,] array) //sets all elements in 8 by 8 int matrices to -1
        {
            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                    array[row, col] = -1;
            return array;
        }

        public Bitmap ItemGrabber(int r, int c) //takes ss of the item slot at the given coords and saves the file of it
        {
            currentItem = prtscr.Clone(itemCoords[r, c], prtscr.PixelFormat);
            currentItem.Save(Convert.ToString(itemDatabaseIndex) + ".bmp");
            databaseLoad();
            return currentItem;
        }

        private void SortingHat()
        {
            if (loadingBar.Value >= loadingBar.Maximum)
            {
                GC.Collect();
                if (modeCheck.Checked == false)
                {
                    int overviewIndexCounter = 0;
                    gridOverviewIndex = ClearIntMatrix(gridOverviewIndex);
                    buttonReset();
                    analyzeButton.Enabled = true;
                    for (int row = 0; row < 8; row++)
                        for (int col = 0; col < 8; col++)
                        {
                            if (gridItemID[row, col] == -1)
                            {
                                itemButtons[row, col].BackColor = Color.Red;
                                itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkRed;
                                itemButtons[row, col].Visible = true;
                                itemButtons[row, col].Enabled = true;
                            }
                            else
                            {
                                if (itemIgnored[gridItemID[row, col]] == true && gridItemID[row, col] != 0 && gridItemID[row, col] != 1 && gridItemID[row, col] != 2)
                                {
                                    if (itemProblematic[gridItemID[row, col]] == false)
                                    {
                                        itemButtons[row, col].BackColor = Color.White;
                                        itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Silver;
                                        itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.Gray;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        itemButtons[row, col].BackColor = Color.Orange;
                                        itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                        itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                }
                                if (itemIgnored[gridItemID[row, col]] == false && gridItemID[row, col] != 0 && gridItemID[row, col] != 1 && gridItemID[row, col] != 2)
                                {
                                    if (itemProblematic[gridItemID[row, col]] == false)
                                    {
                                        gridOverviewIndex[row, col] = overviewIndexCounter;
                                        overviewIndexCounter++;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        gridOverviewIndex[row, col] = overviewIndexCounter;
                                        overviewIndexCounter++;
                                        itemButtons[row, col].BackColor = Color.Orange;
                                        itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                        itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    for (int i = 0; i < categoryAttributionIndex; i++)
                                    {
                                        if (itemCategory[gridItemID[row, col]] == menuCategoryAttribution[i])
                                        {
                                            itemOrganization.Items.Add(itemName[gridItemID[row, col]] + " -> " + menuCityAttribution[i]);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                }
                else
                {
                    buttonReset();
                    analyzeButton.Enabled = true;
                    for (int row = 0; row < 8; row++)
                        for (int col = 0; col < 8; col++)
                        {
                            if (gridItemID[row, col] == -1)
                            {
                                itemButtons[row, col].BackColor = Color.Red;
                                itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkRed;
                                itemButtons[row, col].Visible = true;
                                itemButtons[row, col].Enabled = true;
                            }
                            else
                            {
                                if (itemIgnored[gridItemID[row, col]] == true && gridItemID[row, col] != 0 && gridItemID[row, col] != 1 && gridItemID[row, col] != 2)
                                {
                                    if (itemProblematic[gridItemID[row, col]] == false)
                                    {
                                        itemButtons[row, col].BackColor = Color.White;
                                        itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Silver;
                                        itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.Gray;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        itemButtons[row, col].BackColor = Color.Orange;
                                        itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                        itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    if (sessionActive == false)
                                    {
                                        for (int i = 0; i < itemListControls; i++)
                                        {
                                            if (itemName[gridItemID[row, col]] == stackLabel[i].Text)
                                            {
                                                itemRemember[rememberIndex] = Convert.ToString(gridStackNumber[row, col]);
                                                itemRemember[rememberIndex + 1] = itemName[gridItemID[row, col]];
                                                rememberIndex += 2;
                                            }
                                        }
                                    }
                                }
                                if (itemIgnored[gridItemID[row, col]] == false && gridItemID[row, col] != 0 && gridItemID[row, col] != 1 && gridItemID[row, col] != 2)
                                {
                                    if (itemProblematic[gridItemID[row, col]] == false)
                                    {
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        itemButtons[row, col].BackColor = Color.Orange;
                                        itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                        itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    if (sessionActive == false)
                                    {
                                        for (int i = 0; i < itemListControls; i++)
                                        {
                                            if (itemName[gridItemID[row, col]] == stackLabel[i].Text)
                                            {
                                                itemRemember[rememberIndex] = Convert.ToString(gridStackNumber[row, col]);
                                                itemRemember[rememberIndex + 1] = itemName[gridItemID[row, col]];
                                                rememberIndex += 2;
                                            }
                                        }
                                    }
                                    for (int i = 0; i < itemListControls; i++)
                                    {
                                        if (stackLabel[i].Text == itemName[gridItemID[row, col]])
                                        {
                                            int forgor = 0;
                                            for (int j = 1; j < rememberIndex; j += 2)
                                            {
                                                if (itemRemember[j] == stackLabel[i].Text)
                                                {
                                                    forgor = Convert.ToInt32(itemRemember[j - 1]);
                                                    break;
                                                }
                                            }
                                            stackCounter[i].Value = gridStackNumber[row, col] - forgor;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    startSession();
                }
                loadingBar.Visible = false;
                loadingBar.Enabled = false;
            }
        }

        public static int StackNumber(Bitmap region) //returns how many items are in the stack (duh, but if it's not a green comment I don't see it lol)
        {
            int[] foundCoords = new int[10], foundDigits = new int[10], constructor = new int[10];
            int final = 0, totalDigits = 0;
            bool anyDigit = false;
            for (int i = 0; i < 10; i++)
            {
                Point[] temp;
                temp = FindBitmapPositions(region, digits[i]);
                if (temp.Length != 0)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        foundCoords[totalDigits] = temp[j].X;
                        foundDigits[totalDigits] = i;
                        totalDigits++;
                        anyDigit = true;
                    }
                }
            }
            if (anyDigit == false)
                return 1;
            else
            {
                for (int j = 0; j <= totalDigits - 2; j++)
                {
                    for (int i = 0; i <= totalDigits - 2; i++)
                    {
                        if (foundCoords[i] > foundCoords[i + 1])
                        {
                            int temp;
                            temp = foundCoords[i + 1];
                            foundCoords[i + 1] = foundCoords[i];
                            foundCoords[i] = temp;
                            temp = foundDigits[i + 1];
                            foundDigits[i + 1] = foundDigits[i];
                            foundDigits[i] = temp;
                        }
                    }
                }
                int counter = 0;
                for (int i = totalDigits - 1; i >= 0; i--)
                {
                    final += Convert.ToInt32(Math.Pow(10, i)) * foundDigits[counter];
                    counter++;
                }
                return final;
            }
        }

        static Point[] FindBitmapPositions(Bitmap largeBitmap, Bitmap smallBitmap)
        {
            List<Point> positions = new List<Point>();
            for (int x = 0; x <= largeBitmap.Width - smallBitmap.Width; x++)
            {
                for (int y = 0; y <= largeBitmap.Height - smallBitmap.Height; y++)
                {
                    if (CheckBitmapMatch(largeBitmap, smallBitmap, x, y))
                    {
                        positions.Add(new Point(x, y));
                    }
                }
            }
            return positions.ToArray();
        }

        static bool CheckBitmapMatch(Bitmap largeBitmap, Bitmap smallBitmap, int offsetX, int offsetY)
        {
            for (int x = 0; x < smallBitmap.Width; x++)
            {
                for (int y = 0; y < smallBitmap.Height; y++)
                {
                    Color smallPixel = smallBitmap.GetPixel(x, y);
                    if (smallPixel.A != 0) //ignore the transparent pixels
                    {
                        Color largePixel = largeBitmap.GetPixel(offsetX + x, offsetY + y);

                        if (smallPixel != largePixel)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void buttonReset()
        {
            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                {
                    itemButtons[row, col].BackColor = Color.Lime;
                    itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Green;
                    itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGreen;
                    itemButtons[row, col].Visible = false;
                    itemButtons[row, col].Enabled = false;
                }
        }

        public void categoryOverviewReset()
        {
            categoryOverviewList.Items.Clear();
            for (int city = 0; city < menuCitiesIndex; city++)
                for (int category = 0; category < categoryAttributionIndex; category++)
                    if (menuCityAttribution[category] == menuCities[city])
                        categoryOverviewList.Items.Add(menuCategoryAttribution[category] + " -> " + menuCities[city]);
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            if (modeCheck.Checked == true && (locationBox.SelectedIndex == 0 || locationBox.SelectedIndex == -1))
            {
                MessageBox.Show("Please select your farming location first!", "No location set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (sessionActive == true && sessionPaused == false)
                pauseSession();
            analyzeButton.Enabled = false;
            loadingBar.Visible = true;
            loadingBar.Enabled = true;
            loadingBar.Value = 0;
            canAdd = ClearBoolMatrix(canAdd);
            prtscr = null;
            g.Flush();
            prtscr = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            g = Graphics.FromImage(prtscr);
            g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
            itemOrganization.Items.Clear();
            categoryOverviewReset();
            thread1.RunWorkerAsync();
            thread2.RunWorkerAsync();
            thread3.RunWorkerAsync();
            thread4.RunWorkerAsync();
            if (modeCheck.Checked == true)
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        gridStackNumber[row, col] = StackNumber(prtscr.Clone(stack[row, col], prtscr.PixelFormat));
                        loadingBar.Value += 15625;
                    }
                }
                prtscr.Dispose();
                SortingHat();
            }
        }

        public void startSession()
        {
            if (sessionActive == false)
            {
                timerReset();
                modeCheck.Enabled = false;
                locationBox.Enabled = false;
                sessionActive = true;
                clearSessionButton.Enabled = true;
                playPauseButton.Enabled = true;
                playPauseButton.Visible = true;
                timer.Start();
            }
        }

        public void pauseSession()
        {
            if (sessionPaused == false)
            {
                timer.Enabled = false;
                sessionPaused = true;
                endSessionButton.Enabled = true;
                swapPauseButtonIcon(true);
            }
            else
            {
                timer.Enabled = true;
                sessionPaused = false;
                endSessionButton.Enabled = false;
                swapPauseButtonIcon(false);
            }
        }

        private void clearSessionButton_Click(object sender, EventArgs e)
        {
            bool temp = sessionPaused;
            if (temp == false)
                pauseSession();
            if (MessageBox.Show("You are about to reset your current session.\nAre you sure you want to reset it?", "Reset session", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                timerReset();
                buttonReset();
                playPauseButton.Enabled = false;
                playPauseButton.Visible = false;
                modeCheck.Enabled = true;
                locationBox.Enabled = true;
                locationBox.SelectedIndex = 0;
                clearSessionButton.Enabled = false;
                endSessionButton.Enabled = false;
                sessionActive = false;
                sessionPaused = false;
                swapPauseButtonIcon(false);
                rememberIndex = 0;
            }
            else
            {
                if (temp == false)
                    pauseSession();
            }
        }

        private void endSessionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to end your current session and push it to garmoth.\nAre you sure you want to end the session?", "End session", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                clearSessionButton.Enabled = false;
                endSessionButton.Enabled = false;
                playPauseButton.Enabled = false;
                playPauseButton.Visible = false;
                modeCheck.Enabled = true;
                locationBox.Enabled = true;
                sessionActive = false;
                sessionPaused = false;
                swapPauseButtonIcon(false);
                /*
                 * push to garmoth
                 */
            }
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            pauseSession();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ss++;
            if (ss == 60)
            {
                mm++;
                ss = 0;
                if (mm == 60)
                {
                    hh++;
                    mm = 0;
                }
            }
            if (ss < 10)
            {
                if (mm < 10)
                    timerLabel.Text = Convert.ToString(hh) + ':' + '0' + Convert.ToString(mm) + ':' + '0' + Convert.ToString(ss);
                else
                    timerLabel.Text = Convert.ToString(hh) + ':' + Convert.ToString(mm) + ':' + '0' + Convert.ToString(ss);
            }
            else
            {
                if (mm < 10)
                    timerLabel.Text = Convert.ToString(hh) + ':' + '0' + Convert.ToString(mm) + ':' + Convert.ToString(ss);
                else
                    timerLabel.Text = Convert.ToString(hh) + ':' + Convert.ToString(mm) + ':' + '0' + Convert.ToString(ss);
            }
        }

        public void timerReset()
        {
            timer.Stop();
            ss = 0;
            mm = 0;
            hh = 0;
            timerLabel.Text = "0:00:00";
        }

        private void locationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scriptIndex = 0;
            for (int i = 0; i < itemListControls; i++)
            {
                stackCounter[i].Dispose();
                stackLabel[i].Dispose();
            }
            foreach (Control control in itemPanel.Controls)
            {
                control.Dispose();
            }
            itemListControls = 0;
            if (locationBox.SelectedIndex != 0)
            {
                string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv");
                script = temp[locationBox.SelectedIndex].Split(',');
                scriptIndex = temp[locationBox.SelectedIndex].Split(',').Length;
                for (int i = 0; i < scriptIndex; i++)
                {
                    if (script[i] == "item")
                    {
                        i++;
                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.BorderStyle = BorderStyle.None;
                        numericUpDown.AutoSize = true;
                        numericUpDown.Maximum = 10000;
                        numericUpDown.TextAlign = HorizontalAlignment.Center;
                        numericUpDown.ThousandsSeparator = true;
                        Label label = new Label();
                        label.AutoSize = true;
                        label.BackColor = Color.FromArgb(36, 36, 39);
                        label.Font = new Font("Calibri", 11);
                        label.ForeColor = Color.White;
                        label.Text = script[i];
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.BackColor = Color.FromArgb(36, 36, 39);
                        panel.AutoSize = true;
                        panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        panel.WrapContents = false;
                        panel.Dock = DockStyle.Top;
                        stackCounter[itemListControls] = numericUpDown;
                        stackLabel[itemListControls] = label;
                        panel.Controls.Add(stackCounter[itemListControls]);
                        panel.Controls.Add(stackLabel[itemListControls]);
                        itemPanel.Controls.Add(panel);
                        itemPanel.SetFlowBreak(panel, true);
                        itemListControls++;
                    }
                }
            }
        }

        private void modeCheck_Click(object sender, EventArgs e)
        {
            buttonReset();
            lineEditor(Convert.ToString(modeCheck.Checked) + ',' + "reserved", Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
            if (modeCheck.Checked == true)
            {
                loadingBar.Maximum = 2000000;
                normalModePanel.Visible = false;
                normalModePanel.Enabled = false;
                farmingModePanel.Visible = true;
                farmingModePanel.Enabled = true;
                locationBox.Items.Add("Select farming location");
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
                {
                    reader.ReadLine();
                    while (reader.EndOfStream == false)
                    {
                        string[] tempAttributes = new string[100];
                        tempAttributes = reader.ReadLine().Split(',');
                        locationBox.Items.Add(tempAttributes[0]);
                    }
                }
                locationBox.SelectedIndex = 0;
                timerReset();
            }
            else
            {
                loadingBar.Maximum = 1000000;
                locationBox.SelectedIndex = 0;
                locationBox.Items.Clear();
                normalModePanel.Visible = true;
                normalModePanel.Enabled = true;
                farmingModePanel.Visible = false;
                farmingModePanel.Enabled = false;
            }
            databaseLoad();
        }

        public void swapPauseButtonIcon(bool playIcon)
        {
            if (playIcon == true)
                playPauseButton.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\play.png");
            else
                playPauseButton.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\pause.png");
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
            GC.Collect();
            databaseLoad();
        }

        private void itemLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemLookup.SelectedIndex == -1)
                itemLookupLabel.Text = string.Empty;
            else
            {
                int i;
                for (i = 0; i < categoryAttributionIndex; i++)
                    if (itemCategory[itemLookup.SelectedIndex] == menuCategoryAttribution[i])
                        break;
                itemLookupLabel.Text = "is categorized as " + Convert.ToString(itemCategory[itemLookup.SelectedIndex]) + " and goes to " + Convert.ToString(menuCityAttribution[i]) + ".";
            }
        }

        private void thread1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Rectangle[,] temp = new Rectangle[8, 8];
            int tempI = 0, tempJ = 0;
            for (int row = cH; row <= cH + 7 * s; row += s)
            {
                for (int col = cW; col <= cW + 7 * s; col += s)
                {
                    temp[tempI, tempJ] = new Rectangle(col, row, picW, picH);
                    tempJ++;
                }
                tempJ = 0;
                tempI++;
            }
            int[,] gridID = new int[8, 8];
            Bitmap prts;
            prts = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prts))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        gridID[row, col] = ItemDetector(prts.Clone(temp[row, col], prts.PixelFormat));
                        worker.ReportProgress(15625);
                    }
                }
                prts.Dispose();
                e.Result = gridID;
            }
        }

        private void thread1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingBar.Value += e.ProgressPercentage;
        }

        private void thread1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int[,] temp = (int[,])e.Result;
            for (int row = 0; row < 4; row++)
                for (int col = 0; col < 4; col++)
                    gridItemID[row, col] = temp[row, col];
            SortingHat();
        }

        private void thread2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Rectangle[,] temp = new Rectangle[8, 8];
            int tempI = 0, tempJ = 0;
            for (int row = cH; row <= cH + 7 * s; row += s)
            {
                for (int col = cW; col <= cW + 7 * s; col += s)
                {
                    temp[tempI, tempJ] = new Rectangle(col, row, picW, picH);
                    tempJ++;
                }
                tempJ = 0;
                tempI++;
            }
            int[,] gridID = new int[8, 8];
            Bitmap prts;
            prts = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prts))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 4; col < 8; col++)
                    {
                        gridID[row, col] = ItemDetector(prts.Clone(temp[row, col], prts.PixelFormat));
                        worker.ReportProgress(15625);
                    }
                }
                prts.Dispose();
                e.Result = gridID;
            }
        }

        private void thread2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingBar.Value += e.ProgressPercentage;
        }

        private void thread2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int[,] temp = (int[,])e.Result;
            for (int row = 0; row < 4; row++)
                for (int col = 4; col < 8; col++)
                    gridItemID[row, col] = temp[row, col];
            SortingHat();
        }

        private void thread3_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Rectangle[,] temp = new Rectangle[8, 8];
            int tempI = 0, tempJ = 0;
            for (int row = cH; row <= cH + 7 * s; row += s)
            {
                for (int col = cW; col <= cW + 7 * s; col += s)
                {
                    temp[tempI, tempJ] = new Rectangle(col, row, picW, picH);
                    tempJ++;
                }
                tempJ = 0;
                tempI++;
            }
            int[,] gridID = new int[8, 8];
            Bitmap prts;
            prts = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prts))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
                for (int row = 4; row < 8; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        gridID[row, col] = ItemDetector(prts.Clone(temp[row, col], prts.PixelFormat));
                        worker.ReportProgress(15625);
                    }
                }
                prts.Dispose();
                e.Result = gridID;
            }
        }

        private void thread3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingBar.Value += e.ProgressPercentage;
        }

        private void thread3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int[,] temp = (int[,])e.Result;
            for (int row = 4; row < 8; row++)
                for (int col = 0; col < 4; col++)
                    gridItemID[row, col] = temp[row, col];
            SortingHat();
        }

        private void thread4_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Rectangle[,] temp = new Rectangle[8, 8];
            int tempI = 0, tempJ = 0;
            for (int row = cH; row <= cH + 7 * s; row += s)
            {
                for (int col = cW; col <= cW + 7 * s; col += s)
                {
                    temp[tempI, tempJ] = new Rectangle(col, row, picW, picH);
                    tempJ++;
                }
                tempJ = 0;
                tempI++;
            }
            int[,] gridID = new int[8, 8];
            Bitmap prts;
            prts = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prts))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
                for (int row = 4; row < 8; row++)
                {
                    for (int col = 4; col < 8; col++)
                    {
                        gridID[row, col] = ItemDetector(prts.Clone(temp[row, col], prts.PixelFormat));
                        worker.ReportProgress(15625);
                    }
                }
                prts.Dispose();
                e.Result = gridID;
            }
        }

        private void thread4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingBar.Value += e.ProgressPercentage;
        }

        private void thread4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int[,] temp = (int[,])e.Result;
            for (int row = 4; row < 8; row++)
                for (int col = 4; col < 8; col++)
                    gridItemID[row, col] = temp[row, col];
            SortingHat();
        }

        private void editCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoryEditor ce = new CategoryEditor();
            ce.ShowDialog();
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
        }

        private void itemButton_MouseLeave(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = -1;
        }

        private void itemButton00_Click(object sender, EventArgs e)
        {
            itemClicked[0, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 0] == -1)
            {
                gridItemID[0, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton00_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 0]] == true && canAdd[0, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton00_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 0];
        }

        private void itemButton01_Click(object sender, EventArgs e)
        {
            itemClicked[0, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 1] == -1)
            {
                gridItemID[0, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton01_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 1]] == true && canAdd[0, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton01_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 1];
        }

        private void itemButton02_Click(object sender, EventArgs e)
        {
            itemClicked[0, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 2] == -1)
            {
                gridItemID[0, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton02_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 2]] == true && canAdd[0, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton02_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 2];
        }

        private void itemButton03_Click(object sender, EventArgs e)
        {
            itemClicked[0, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 3] == -1)
            {
                gridItemID[0, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton03_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 3]] == true && canAdd[0, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton03_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 3];
        }

        private void itemButton04_Click(object sender, EventArgs e)
        {
            itemClicked[0, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 4] == -1)
            {
                gridItemID[0, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton04_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 4]] == true && canAdd[0, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton04_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 4];
        }

        private void itemButton05_Click(object sender, EventArgs e)
        {
            itemClicked[0, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 5] == -1)
            {
                gridItemID[0, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton05_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 5]] == true && canAdd[0, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton05_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 5];
        }

        private void itemButton06_Click(object sender, EventArgs e)
        {
            itemClicked[0, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 6] == -1)
            {
                gridItemID[0, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton06_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 6]] == true && canAdd[0, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton06_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 6];
        }

        private void itemButton07_Click(object sender, EventArgs e)
        {
            itemClicked[0, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[0, 7] == -1)
            {
                gridItemID[0, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(0, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[0, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton07_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[0, 7]] == true && canAdd[0, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[0, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[0, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton07_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[0, 7];
        }

        private void itemButton10_Click(object sender, EventArgs e)
        {
            itemClicked[1, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 0] == -1)
            {
                gridItemID[1, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 0]] == true && canAdd[1, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton10_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 0];
        }

        private void itemButton11_Click(object sender, EventArgs e)
        {
            itemClicked[1, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 1] == -1)
            {
                gridItemID[1, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 1]] == true && canAdd[1, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton11_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 1];
        }

        private void itemButton12_Click(object sender, EventArgs e)
        {
            itemClicked[1, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 2] == -1)
            {
                gridItemID[1, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 2]] == true && canAdd[1, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton12_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 2];
        }

        private void itemButton13_Click(object sender, EventArgs e)
        {
            itemClicked[1, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 3] == -1)
            {
                gridItemID[1, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 3]] == true && canAdd[1, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton13_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 3];
        }

        private void itemButton14_Click(object sender, EventArgs e)
        {
            itemClicked[1, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 4] == -1)
            {
                gridItemID[1, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 4]] == true && canAdd[1, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton14_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 4];
        }

        private void itemButton15_Click(object sender, EventArgs e)
        {
            itemClicked[1, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 5] == -1)
            {
                gridItemID[1, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton15_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 5]] == true && canAdd[1, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton15_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 5];
        }

        private void itemButton16_Click(object sender, EventArgs e)
        {
            itemClicked[1, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 6] == -1)
            {
                gridItemID[1, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton16_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 6]] == true && canAdd[1, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton16_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 6];
        }

        private void itemButton17_Click(object sender, EventArgs e)
        {
            itemClicked[1, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[1, 7] == -1)
            {
                gridItemID[1, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(1, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[1, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton17_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[1, 7]] == true && canAdd[1, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[1, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[1, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton17_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[1, 7];
        }

        private void itemButton20_Click(object sender, EventArgs e)
        {
            itemClicked[2, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 0] == -1)
            {
                gridItemID[2, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton20_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 0]] == true && canAdd[2, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton20_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 0];
        }

        private void itemButton21_Click(object sender, EventArgs e)
        {
            itemClicked[2, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 1] == -1)
            {
                gridItemID[2, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton21_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 1]] == true && canAdd[2, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton21_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 1];
        }

        private void itemButton22_Click(object sender, EventArgs e)
        {
            itemClicked[2, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 2] == -1)
            {
                gridItemID[2, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton22_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 2]] == true && canAdd[2, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton22_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 2];
        }

        private void itemButton23_Click(object sender, EventArgs e)
        {
            itemClicked[2, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 3] == -1)
            {
                gridItemID[2, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton23_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 3]] == true && canAdd[2, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton23_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 3];
        }

        private void itemButton24_Click(object sender, EventArgs e)
        {
            itemClicked[2, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 4] == -1)
            {
                gridItemID[2, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton24_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 4]] == true && canAdd[2, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton24_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 4];
        }

        private void itemButton25_Click(object sender, EventArgs e)
        {
            itemClicked[2, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 5] == -1)
            {
                gridItemID[2, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton25_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 5]] == true && canAdd[2, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton25_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 5];
        }

        private void itemButton26_Click(object sender, EventArgs e)
        {
            itemClicked[2, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 6] == -1)
            {
                gridItemID[2, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton26_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 6]] == true && canAdd[2, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton26_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 6];
        }

        private void itemButton27_Click(object sender, EventArgs e)
        {
            itemClicked[2, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[2, 7] == -1)
            {
                gridItemID[2, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(2, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[2, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton27_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[2, 7]] == true && canAdd[2, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[2, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[2, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton27_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[2, 7];
        }

        private void itemButton30_Click(object sender, EventArgs e)
        {
            itemClicked[3, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 0] == -1)
            {
                gridItemID[3, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton30_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 0]] == true && canAdd[3, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton30_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 0];
        }

        private void itemButton31_Click(object sender, EventArgs e)
        {
            itemClicked[3, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 1] == -1)
            {
                gridItemID[3, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton31_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 1]] == true && canAdd[3, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton31_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 1];
        }

        private void itemButton32_Click(object sender, EventArgs e)
        {
            itemClicked[3, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 2] == -1)
            {
                gridItemID[3, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton32_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 2]] == true && canAdd[3, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton32_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 2];
        }

        private void itemButton33_Click(object sender, EventArgs e)
        {
            itemClicked[3, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 3] == -1)
            {
                gridItemID[3, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton33_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 3]] == true && canAdd[3, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton33_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 3];
        }

        private void itemButton34_Click(object sender, EventArgs e)
        {
            itemClicked[3, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 4] == -1)
            {
                gridItemID[3, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton34_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 4]] == true && canAdd[3, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton34_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 4];
        }

        private void itemButton35_Click(object sender, EventArgs e)
        {
            itemClicked[3, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 5] == -1)
            {
                gridItemID[3, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton35_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 5]] == true && canAdd[3, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton35_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 5];
        }

        private void itemButton36_Click(object sender, EventArgs e)
        {
            itemClicked[3, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 6] == -1)
            {
                gridItemID[3, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton36_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 6]] == true && canAdd[3, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton36_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 6];
        }

        private void itemButton37_Click(object sender, EventArgs e)
        {
            itemClicked[3, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[3, 7] == -1)
            {
                gridItemID[3, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(3, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[3, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton37_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[3, 7]] == true && canAdd[3, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[3, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[3, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton37_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[3, 7];
        }

        private void itemButton40_Click(object sender, EventArgs e)
        {
            itemClicked[4, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 0] == -1)
            {
                gridItemID[4, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton40_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 0]] == true && canAdd[4, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton40_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 0];
        }

        private void itemButton41_Click(object sender, EventArgs e)
        {
            itemClicked[4, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 1] == -1)
            {
                gridItemID[4, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton41_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 1]] == true && canAdd[4, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton41_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 1];
        }

        private void itemButton42_Click(object sender, EventArgs e)
        {
            itemClicked[4, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 2] == -1)
            {
                gridItemID[4, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton42_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 2]] == true && canAdd[4, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton42_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 2];
        }

        private void itemButton43_Click(object sender, EventArgs e)
        {
            itemClicked[4, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 3] == -1)
            {
                gridItemID[4, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton43_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 3]] == true && canAdd[4, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton43_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 3];
        }

        private void itemButton44_Click(object sender, EventArgs e)
        {
            itemClicked[4, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 4] == -1)
            {
                gridItemID[4, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton44_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 4]] == true && canAdd[4, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton44_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 4];
        }

        private void itemButton45_Click(object sender, EventArgs e)
        {
            itemClicked[4, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 5] == -1)
            {
                gridItemID[4, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton45_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 5]] == true && canAdd[4, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton45_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 5];
        }

        private void itemButton46_Click(object sender, EventArgs e)
        {
            itemClicked[4, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 6] == -1)
            {
                gridItemID[4, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton46_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 6]] == true && canAdd[4, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton46_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 6];
        }

        private void itemButton47_Click(object sender, EventArgs e)
        {
            itemClicked[4, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[4, 7] == -1)
            {
                gridItemID[4, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(4, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[4, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton47_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[4, 7]] == true && canAdd[4, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[4, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[4, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton47_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[4, 7];
        }

        private void itemButton50_Click(object sender, EventArgs e)
        {
            itemClicked[5, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 0] == -1)
            {
                gridItemID[5, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton50_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 0]] == true && canAdd[5, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton50_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 0];
        }

        private void itemButton51_Click(object sender, EventArgs e)
        {
            itemClicked[5, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 1] == -1)
            {
                gridItemID[5, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton51_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 1]] == true && canAdd[5, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton51_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 1];
        }

        private void itemButton52_Click(object sender, EventArgs e)
        {
            itemClicked[5, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 2] == -1)
            {
                gridItemID[5, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton52_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 2]] == true && canAdd[5, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton52_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 2];
        }

        private void itemButton53_Click(object sender, EventArgs e)
        {
            itemClicked[5, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 3] == -1)
            {
                gridItemID[5, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton53_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 3]] == true && canAdd[5, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton53_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 3];
        }

        private void itemButton54_Click(object sender, EventArgs e)
        {
            itemClicked[5, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 4] == -1)
            {
                gridItemID[5, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton54_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 4]] == true && canAdd[5, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton54_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 4];
        }

        private void itemButton55_Click(object sender, EventArgs e)
        {
            itemClicked[5, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 5] == -1)
            {
                gridItemID[5, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton55_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 5]] == true && canAdd[5, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton55_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 5];
        }

        private void itemButton56_Click(object sender, EventArgs e)
        {
            itemClicked[5, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 6] == -1)
            {
                gridItemID[5, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton56_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 6]] == true && canAdd[5, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton56_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 6];
        }

        private void itemButton57_Click(object sender, EventArgs e)
        {
            itemClicked[5, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[5, 7] == -1)
            {
                gridItemID[5, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(5, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[5, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton57_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[5, 7]] == true && canAdd[5, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[5, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[5, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton57_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[5, 7];
        }

        private void itemButton60_Click(object sender, EventArgs e)
        {
            itemClicked[6, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 0] == -1)
            {
                gridItemID[6, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton60_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 0]] == true && canAdd[6, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton60_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 0];
        }

        private void itemButton61_Click(object sender, EventArgs e)
        {
            itemClicked[6, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 1] == -1)
            {
                gridItemID[6, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton61_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 1]] == true && canAdd[6, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton61_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 1];
        }

        private void itemButton62_Click(object sender, EventArgs e)
        {
            itemClicked[6, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 2] == -1)
            {
                gridItemID[6, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton62_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 2]] == true && canAdd[6, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton62_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 2];
        }

        private void itemButton63_Click(object sender, EventArgs e)
        {
            itemClicked[6, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 3] == -1)
            {
                gridItemID[6, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton63_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 3]] == true && canAdd[6, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton63_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 3];
        }

        private void itemButton64_Click(object sender, EventArgs e)
        {
            itemClicked[6, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 4] == -1)
            {
                gridItemID[6, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton64_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 4]] == true && canAdd[6, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton64_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 4];
        }

        private void itemButton65_Click(object sender, EventArgs e)
        {
            itemClicked[6, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 5] == -1)
            {
                gridItemID[6, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton65_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 5]] == true && canAdd[6, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton65_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 5];
        }

        private void itemButton66_Click(object sender, EventArgs e)
        {
            itemClicked[6, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 6] == -1)
            {
                gridItemID[6, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton66_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 6]] == true && canAdd[6, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton66_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 6];
        }

        private void itemButton67_Click(object sender, EventArgs e)
        {
            itemClicked[6, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[6, 7] == -1)
            {
                gridItemID[6, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(6, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[6, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton67_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[6, 7]] == true && canAdd[6, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[6, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[6, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton67_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[6, 7];
        }

        private void itemButton70_Click(object sender, EventArgs e)
        {
            itemClicked[7, 0] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 0] == -1)
            {
                gridItemID[7, 0] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 0);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 0] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton70_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 0]] == true && canAdd[7, 0] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 0] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 0] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton70_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 0];
        }

        private void itemButton71_Click(object sender, EventArgs e)
        {
            itemClicked[7, 1] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 1] == -1)
            {
                gridItemID[7, 1] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 1);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 1] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton71_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 1]] == true && canAdd[7, 1] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 1] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 1] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton71_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 1];
        }

        private void itemButton72_Click(object sender, EventArgs e)
        {
            itemClicked[7, 2] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 2] == -1)
            {
                gridItemID[7, 2] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 2);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 2] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton72_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 2]] == true && canAdd[7, 2] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 2] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 2] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton72_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 2];
        }

        private void itemButton73_Click(object sender, EventArgs e)
        {
            itemClicked[7, 3] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 3] == -1)
            {
                gridItemID[7, 3] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 3);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 3] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton73_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 3]] == true && canAdd[7, 3] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 3] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 3] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton73_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 3];
        }

        private void itemButton74_Click(object sender, EventArgs e)
        {
            itemClicked[7, 4] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 4] == -1)
            {
                gridItemID[7, 4] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 4);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 4] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton74_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 4]] == true && canAdd[7, 4] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 4] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 4] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton74_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 4];
        }

        private void itemButton75_Click(object sender, EventArgs e)
        {
            itemClicked[7, 5] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 5] == -1)
            {
                gridItemID[7, 5] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 5);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 5] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton75_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 5]] == true && canAdd[7, 5] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 5] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 5] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton75_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 5];
        }

        private void itemButton76_Click(object sender, EventArgs e)
        {
            itemClicked[7, 6] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 6] == -1)
            {
                gridItemID[7, 6] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 6);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 6] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton76_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 6]] == true && canAdd[7, 6] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 6] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 6] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton76_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 6];
        }

        private void itemButton77_Click(object sender, EventArgs e)
        {
            itemClicked[7, 7] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[7, 7] == -1)
            {
                gridItemID[7, 7] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(7, 7);
            }
            if (modeCheck.Checked == true && sessionPaused == false)
                pauseSession();
            ie.ShowDialog();
            itemClicked[7, 7] = false;
            databaseLoad();
            itemOrganization.Items.Clear();
            SortingHat();
            if (modeCheck.Checked == true && sessionPaused == true)
                pauseSession();
        }

        private void itemButton77_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[7, 7]] == true && canAdd[7, 7] == true)
            {
                if (modeCheck.Checked == true && sessionPaused == false)
                    pauseSession();
                itemClicked[7, 7] = true;
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[7, 7] = false;
                if (modeCheck.Checked == true && sessionPaused == true)
                    pauseSession();
            }
        }

        private void itemButton77_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
                itemOrganization.SelectedIndex = gridOverviewIndex[7, 7];
        }

        private void categoryOverviewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryOverviewList.SelectedIndex = -1;
        }
    }
}