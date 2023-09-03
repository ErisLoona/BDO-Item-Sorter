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
using System.Net.Http;
using WindowsInput;
using System.Net;
using System.IO.Compression;
using System.Security.Policy;

namespace BDO_Item_Sorter
{
    public partial class MainMenu : Form
    {
        #region Global variable declaration

        public static int[] itemID = new int[10000];
        public static int[,] gridItemID = new int[8, 8], gridOverviewIndex = new int[8, 8], gridStackNumber = new int[8, 8];
        public static string[] itemName = new string[10000], itemCategory = new string[10000], menuCategories = new string[100], menuCities = new string[100], menuCategoryAttribution = new string[100], menuCityAttribution = new string[100];
        public static bool[] itemIgnored = new bool[10000], itemProblematic = new bool[10000];
        public static bool[,] knownItemCheck = new bool[8, 8], itemClicked = new bool[8, 8], canAdd = new bool[8, 8];
        public static int cW = 0, cH = 0, s = 0, picW = 0, picH = 0;
        public static bool firstSetup = false, fmode, iconsMode;

        Screen activeScreen = Screen.PrimaryScreen;
        public static Button[,] itemButtons;
        public static Rectangle[,] itemCoords = new Rectangle[8, 8], stack = new Rectangle[8, 8];
        Bitmap prtscr, currentItem;
        Bitmap unknownItemOverlay, problematicItemOverlay, ignoredItemOverlay;
        public static Bitmap[] digits = new Bitmap[10];
        Graphics g;

        public static int menuCategoriesIndex = 0, menuCitiesIndex = 0, itemDatabaseIndex = 0, categoryAttributionIndex = 0;

        //Sorting Mode extras
        public static string[] script = new string[200], itemRemember = new string[128];
        public static int itemListControls = 0, hh = 0, mm = 0, ss = 0, rememberIndex = 0, scriptIndex = 0, websiteLoadDelay = 5000, rememborLocationIndex;
        public static bool sessionActive = false, sessionPaused = false, clearTrigger = false, rememborDecision;
        Image timerButtonPlayIcon, timerButtonPauseIcon;
        NumericUpDown[] stackCounter = new NumericUpDown[50];
        Label[] stackLabel = new Label[50];
        Panel[] stackPanel = new Panel[50];

        #endregion

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
                if (MessageBox.Show("Support files not found, doing first time setup.\nPlease make sure BDO is running!\nSome of the files will be downloaded, is that okay?", "Support files not found", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    System.Environment.Exit(0);
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
                    MessageBox.Show("Error creating support files!", "IO error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(1);
                }
            }
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Sorting Mode") == false)
            {
                if (firstSetup == false)
                {
                    if (MessageBox.Show("Your file structure is outdated and the program needs to download the update.\nIs that okay?", "Old file structure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        MessageBox.Show("The program will now exit.\nYou can update the file structure yourself from github.", "Download declined", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Environment.Exit(0);
                    }
                }
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile("https://github.com/ErisLoona/support-files/raw/main/BDO%20Sorting%20Mode.zip", Directory.GetCurrentDirectory() + "\\sorting.zip");
                    }
                    catch
                    {
                        MessageBox.Show("The download failed!\nYou can download it yourself from github.", "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Environment.Exit(1);
                    }
                }
                try
                {
                    ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "\\sorting.zip", Directory.GetCurrentDirectory());
                    File.Delete(Directory.GetCurrentDirectory() + "\\sorting.zip");
                }
                catch
                {
                    MessageBox.Show("File extraction failed!\nYou can extract it yourself, then delete the archive.", "Extraction IO error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(2);
                }
            }
            timerButtonPlayIcon = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\play.png");
            timerButtonPauseIcon = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\pause.png");
            unknownItemOverlay = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\unknownitem.png");
            problematicItemOverlay = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\problematicitem.png");
            ignoredItemOverlay = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\ignoreditem.png");
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                string[] tempAttributes = new string[5];
                tempAttributes = reader.ReadLine().Split(',');
                fmode = Convert.ToBoolean(tempAttributes[0]);
                iconsMode = Convert.ToBoolean(tempAttributes[3]);
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
                buttonReset();
                if (modeCheck.Checked == false)
                {
                    int overviewIndexCounter = 0;
                    gridOverviewIndex = ClearIntMatrix(gridOverviewIndex);
                    itemOrganization.Items.Clear();
                    for (int row = 0; row < 8; row++)
                        for (int col = 0; col < 8; col++)
                        {
                            if (gridItemID[row, col] == -1)
                            {
                                if (iconsMode == true)
                                    iconsModeOverlay(2, row, col);
                                else
                                {
                                    itemButtons[row, col].BackColor = Color.Red;
                                    itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                    itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkRed;
                                }
                                itemButtons[row, col].Visible = true;
                                itemButtons[row, col].Enabled = true;
                            }
                            else
                            {
                                if (itemIgnored[gridItemID[row, col]] == true && gridItemID[row, col] != 0 && gridItemID[row, col] != 1 && gridItemID[row, col] != 2)
                                {
                                    if (itemProblematic[gridItemID[row, col]] == false)
                                    {
                                        if (iconsMode == true)
                                            iconsModeOverlay(4, row, col);
                                        else
                                        {
                                            itemButtons[row, col].BackColor = Color.White;
                                            itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Silver;
                                            itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.Gray;
                                        }
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        if (iconsMode == true)
                                            iconsModeOverlay(3, row, col);
                                        else
                                        {
                                            itemButtons[row, col].BackColor = Color.Orange;
                                            itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                            itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        }
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
                                        if (iconsMode == true)
                                            iconsModeOverlay(1, row, col);
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        gridOverviewIndex[row, col] = overviewIndexCounter;
                                        overviewIndexCounter++;
                                        if (iconsMode == true)
                                            iconsModeOverlay(3, row, col);
                                        else
                                        {
                                            itemButtons[row, col].BackColor = Color.Orange;
                                            itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                            itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        }
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
                    for (int i = 0; i < itemListControls; i++)
                        stackCounter[i].Value = 0;
                    for (int row = 0; row < 8; row++)
                        for (int col = 0; col < 8; col++)
                        {
                            if (gridItemID[row, col] == -1)
                            {
                                if (iconsMode == true)
                                    iconsModeOverlay(2, row, col);
                                else
                                {
                                    itemButtons[row, col].BackColor = Color.Red;
                                    itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                    itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkRed;
                                }
                                itemButtons[row, col].Visible = true;
                                itemButtons[row, col].Enabled = true;
                            }
                            else
                            {
                                if (itemIgnored[gridItemID[row, col]] == true && gridItemID[row, col] != 0 && gridItemID[row, col] != 1 && gridItemID[row, col] != 2)
                                {
                                    if (itemProblematic[gridItemID[row, col]] == false)
                                    {
                                        if (iconsMode == true)
                                            iconsModeOverlay(4, row, col);
                                        else
                                        {
                                            itemButtons[row, col].BackColor = Color.White;
                                            itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Silver;
                                            itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.Gray;
                                        }
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        if (iconsMode == true)
                                            iconsModeOverlay(3, row, col);
                                        else
                                        {
                                            itemButtons[row, col].BackColor = Color.Orange;
                                            itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                            itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        }
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    if (sessionActive == false)
                                    {
                                        for (int i = 0; i < itemListControls; i++)
                                        {
                                            if (itemName[gridItemID[row, col]].ToLower() == stackLabel[i].Text.ToLower())
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
                                        if (iconsMode == true)
                                            iconsModeOverlay(1, row, col);
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    else
                                    {
                                        if (iconsMode == true)
                                            iconsModeOverlay(3, row, col);
                                        else
                                        {
                                            itemButtons[row, col].BackColor = Color.Orange;
                                            itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Goldenrod;
                                            itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod;
                                        }
                                        itemButtons[row, col].Visible = true;
                                        itemButtons[row, col].Enabled = true;
                                    }
                                    if (sessionActive == false)
                                    {
                                        for (int i = 0; i < itemListControls; i++)
                                        {
                                            if (itemName[gridItemID[row, col]].ToLower() == stackLabel[i].Text.ToLower())
                                            {
                                                itemRemember[rememberIndex] = Convert.ToString(gridStackNumber[row, col]);
                                                itemRemember[rememberIndex + 1] = itemName[gridItemID[row, col]];
                                                rememberIndex += 2;
                                            }
                                        }
                                    }
                                    for (int i = 0; i < itemListControls; i++)
                                    {
                                        if (stackLabel[i].Text.ToLower() == itemName[gridItemID[row, col]].ToLower())
                                        {
                                            int forgor = 0;
                                            for (int j = 1; j < rememberIndex; j += 2)
                                            {
                                                if (itemRemember[j].ToLower() == stackLabel[i].Text.ToLower())
                                                {
                                                    forgor = Convert.ToInt32(itemRemember[j - 1]);
                                                    break;
                                                }
                                            }
                                            if (gridStackNumber[row, col] - forgor < 0)
                                                stackCounter[i].Value = 0;
                                            else
                                                stackCounter[i].Value = gridStackNumber[row, col] - forgor;
                                            break;
                                        }
                                        if (stackLabel[i].Text == "Any Artifact" && (itemName[gridItemID[row, col]].Contains("Artifact") || itemName[gridItemID[row, col]].Contains("artifact")) && sessionActive == false)
                                        {
                                            stackCounter[i].Value += 1;
                                        }
                                    }
                                }
                            }
                        }
                    startSession();
                }
                analyzeButton.Enabled = true;
                loadingBar.Visible = false;
                loadingBar.Enabled = false;
            }
        }

        private void iconsModeOverlay(uint state, int row, int col) //state 1 = item is known, no overlay; state 2 = item is unknown; state 3 = item is problematic; state 4 = item is ignored
        {
            Rectangle itemPic = new Rectangle(itemCoords[row, col].X, itemCoords[row, col].Y, picW, picW);
            itemButtons[row, col].BackgroundImage = prtscr.Clone(itemPic, prtscr.PixelFormat);
            if (state == 1)
                return;
            if (state == 2)
            {
                itemButtons[row, col].Image = unknownItemOverlay;
                return;
            }
            if (state == 3)
            {
                itemButtons[row, col].Image = problematicItemOverlay;
                return;
            }
            if (state == 4)
            {
                itemButtons[row, col].Image = ignoredItemOverlay;
                return;
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
                    itemButtons[row, col].Visible = false;
                    itemButtons[row, col].Enabled = false;
                    itemButtons[row, col].BackColor = Color.Lime;
                    itemButtons[row, col].FlatAppearance.MouseOverBackColor = Color.Green;
                    itemButtons[row, col].FlatAppearance.MouseDownBackColor = Color.DarkGreen;
                    itemButtons[row, col].BackgroundImage = null;
                    itemButtons[row, col].Image = null;
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
            if (clearTrigger == true)
            {
                rememborLocationIndex = locationBox.SelectedIndex;
                clearSessionButton_Click(sender, e);
                if (rememborDecision == true)
                {
                    locationBox.SelectedIndex = rememborLocationIndex;
                }
                else
                {
                    return;
                }

            }
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
                infoLabel.Text = "Analyze again to check the\r\nnumber of items you've\r\nobtained so far and/or end\r\nthe session.";
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
            if (temp == false && sessionActive == true)
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
                clearTrigger = false;
                rememborDecision = true;
                infoLabel.Text = "Select your grinding location\r\nand Analyze to start a new \r\ngrinding session.";
                GC.Collect();
            }
            else
            {
                if (temp == false && sessionActive == true)
                    pauseSession();
                rememborDecision = false;
            }
        }

        #region Support code for pushing to Garmoth

        static Point FindAddButton(Bitmap largeBitmap, Bitmap smallBitmap)
        {
            for (int y = 0; y <= largeBitmap.Height - smallBitmap.Height; y++)
            {
                for (int x = 0; x <= largeBitmap.Width - smallBitmap.Width; x++)
                {
                    bool found = true;
                    for (int dy = 0; dy < smallBitmap.Height; dy++)
                    {
                        for (int dx = 0; dx < smallBitmap.Width; dx++)
                        {
                            if (largeBitmap.GetPixel(x + dx, y + dy) != smallBitmap.GetPixel(dx, dy))
                            {
                                found = false;
                                break;
                            }
                        }
                        if (!found)
                            break;
                    }
                    if (found)
                        return new Point(x, y);
                }
            }
            return Point.Empty;
        }

        [DllImport("user32.dll")] public static extern bool GetWindowRect(IntPtr handle, ref Rectangle rectangle);
        [DllImport("user32.dll")] public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")] public static extern bool ShowWindow(IntPtr handle, int state);
        public enum ShowWindowIDs
        {
            Hide = 0, Normal = 1, Minimized = 2, Maximized = 3
        }
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public ShowWindowIDs windowState;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public Rectangle normalPosition;
            public Rectangle Device;
        }
        [DllImport("user32.dll")] public static extern bool GetWindowPlacement(IntPtr handle, ref WINDOWPLACEMENT placement);
        public static WINDOWPLACEMENT getWindowState(IntPtr handle)
        {
            WINDOWPLACEMENT state = new WINDOWPLACEMENT();
            state.length = Marshal.SizeOf(state);
            GetWindowPlacement(handle, ref state);
            return state;
        }

        public const int LMB_Down = 0x02;
        public const int LMB_Up = 0x04;
        [DllImport("user32.dll")] public static extern void mouse_event(int Flags, int x, int y, int Data, int ExtraInfo);
        [DllImport("user32.dll")] public static extern bool SetCursorPos(int x, int y);

        #endregion

        private void endSessionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to end your current session and push it to garmoth.\nAre you sure you want to end the session?", "End session", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                noTouchyLabel.Enabled = true;
                noTouchyLabel.Visible = true;
                string userID;
                string[] timer = new string[3];
                int hours = 0, minutes = 0;
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
                {
                    string[] tempAttributes = new string[5];
                    tempAttributes = reader.ReadLine().Split(',');
                    userID = tempAttributes[1];
                    websiteLoadDelay = Convert.ToInt32(tempAttributes[2]);
                }
                if (userID == "undefined")
                {
                    MessageBox.Show("Please set your ID first in the settings!", "ID not set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clearTrigger = true;
                infoLabel.Text = "Select your grinding location\r\nand Analyze to start a new \r\ngrinding session.";
                playPauseButton.Enabled = false;
                playPauseButton.Visible = false;
                modeCheck.Enabled = true;
                locationBox.Enabled = true;
                sessionActive = false;
                sessionPaused = false;
                swapPauseButtonIcon(false);
                timer = timerLabel.Text.Split(':');
                hours = Convert.ToInt32(timer[0]);
                if (Convert.ToInt32(timer[2]) >= 30)
                    minutes = Convert.ToInt32(timer[1]) + 1;
                else
                    minutes = Convert.ToInt32(timer[1]);
                //push to garmoth
                ProcessStartInfo website = new ProcessStartInfo();
                website.FileName = "https://garmoth.com/grind-tracker/" + userID + "/summary";
                Process.Start(website);
                if (CheckUrlStatus("https://garmoth.com/grind-tracker/" + userID + "/summary") == false)
                {
                    MessageBox.Show("Garmoth is currently unavailable!\nPlease try again later.", "Garmoth is down", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Thread.Sleep(websiteLoadDelay);
                IntPtr handle;
                handle = GetForegroundWindow();
                string state = Convert.ToString(getWindowState(handle).windowState);
                int garmothX, garmothY;
                if (state != "Maximized")
                    ShowWindow(handle, 3);
                Thread.Sleep(500);
                Rectangle rectangle = new Rectangle();
                GetWindowRect(handle, ref rectangle);
                rectangle.X += 8;
                rectangle.Y += 8;
                rectangle.Width -= rectangle.X + 8;
                rectangle.Height -= rectangle.Y + 8;
                Bitmap reference = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\garmothadd.bmp");
                Bitmap browserPic = new Bitmap(rectangle.Width, rectangle.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Point garmothAdd;
                using (Graphics g = Graphics.FromImage(browserPic))
                {
                    g.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size);
                    garmothAdd = FindAddButton(browserPic.Clone(new Rectangle(0, 0, rectangle.Width, rectangle.Height), browserPic.PixelFormat), reference);
                }
                garmothX = rectangle.Right - (rectangle.Width - garmothAdd.X);
                garmothY = rectangle.Top + (rectangle.Height - (rectangle.Height - garmothAdd.Y));
                SetCursorPos(garmothX, garmothY);
                mouse_event(LMB_Down, garmothX, garmothY, 0, 0);
                mouse_event(LMB_Up, garmothX, garmothY, 0, 0);
                Thread.Sleep(400);
                new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.TAB)
                    .TextEntry(script[0])
                    .KeyPress(VirtualKeyCode.TAB)
                    .KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(1200);
                noTouchyLabel.Enabled = false;
                noTouchyLabel.Visible = false;
                new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.TAB)
                    .TextEntry(Convert.ToString(hours))
                    .KeyPress(VirtualKeyCode.TAB)
                    .TextEntry(Convert.ToString(minutes))
                    .KeyPress(VirtualKeyCode.TAB);
                for (int i = 0; i < itemListControls; i++)
                {
                    new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.TAB)
                        .TextEntry(Convert.ToString(stackCounter[i].Value));
                }
                if (state != "Maximized")
                {
                    if (state == "Hide")
                        ShowWindow(handle, 0);
                    if (state == "Normal")
                        ShowWindow(handle, 1);
                    if (state == "Minimized")
                        ShowWindow(handle, 2);
                }
                GC.Collect();
            }
        }

        public static bool CheckUrlStatus(string website)
        {
            try
            {
                var request = WebRequest.Create(website) as HttpWebRequest;
                request.Method = "HEAD";
                request.UserAgent = "heyo just checking in";
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch
            {
                return false;
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
            if (locationBox.SelectedIndex == -1)
            {
                locationBox.SelectedIndex = 0;
                return;
            }
            scriptIndex = 0;
            for (int i = 0; i < itemListControls; i++)
            {
                stackCounter[i].Dispose();
                stackLabel[i].Dispose();
                stackPanel[i].Dispose();
            }
            itemListControls = 0;
            if (locationBox.SelectedIndex != 0)
            {
                string[] temp = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv");
                script = temp[locationBox.SelectedIndex].Split(',');
                scriptIndex = temp[locationBox.SelectedIndex].Split(',').Length;
                for (int i = 1; i < scriptIndex; i++)
                {
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
                    if (script[i] != "Silver")
                        label.ForeColor = Color.White;
                    else
                        label.ForeColor = Color.Red;
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
                    stackPanel[itemListControls] = panel;
                    panel.Controls.Add(stackCounter[itemListControls]);
                    panel.Controls.Add(stackLabel[itemListControls]);
                    itemPanel.Controls.Add(panel);
                    itemPanel.SetFlowBreak(panel, true);
                    itemListControls++;
                }
            }
        }

        private void modeCheck_Click(object sender, EventArgs e)
        {
            buttonReset();
            string[] temp = new string[5];
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv"))
            {
                temp = reader.ReadLine().Split(',');
            }
            lineEditor(Convert.ToString(modeCheck.Checked) + ',' + temp[1] + ',' + temp[2] + ',' + temp[3], Directory.GetCurrentDirectory() + "\\Sorting Mode\\Grind Location Scripts.csv", 0);
            if (modeCheck.Checked == true)
            {
                loadingBar.Maximum = 2000000;
                itemOrganization.Items.Clear();
                itemLookup.SelectedIndex = -1;
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
                playPauseButton.BackgroundImage = timerButtonPlayIcon;
            else
                playPauseButton.BackgroundImage = timerButtonPauseIcon;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            bool prevState = sessionPaused;
            if (modeCheck.Checked == true && sessionPaused == false && sessionActive == true)
                pauseSession();
            Settings s = new Settings();
            s.ShowDialog();
            GC.Collect();
            databaseLoad();
            if (prevState == false && sessionActive == true)
                pauseSession();
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

        private void itemButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int brow = 0, bcol = 0;
            bool found = false;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (button == itemButtons[row, col])
                    {
                        found = true;
                        brow = row;
                        bcol = col;
                        break;
                    }
                }
                if (found == true)
                    break;
            }
            itemClicked[brow, bcol] = true;
            ItemEditor ie = new ItemEditor();
            if (gridItemID[brow, bcol] == -1)
            {
                gridItemID[brow, bcol] = itemDatabaseIndex;
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Item Attributions.csv", true))
                {
                    writer.WriteLine(Convert.ToString(itemDatabaseIndex) + ",(placeholder),(none),False,False");
                }
                ItemGrabber(brow, bcol);
            }
            bool prevState = sessionPaused;
            if (modeCheck.Checked == true && sessionPaused == false && sessionActive == true)
                pauseSession();
            string oldName = itemName[gridItemID[brow, bcol]];
            ie.ShowDialog();
            itemClicked[brow, bcol] = false;
            databaseLoad();
            if (sessionActive == true)
            {
                for (int i = 0; i < itemListControls; i++)
                {
                    if (itemName[gridItemID[brow, bcol]] == stackLabel[i].Text)
                    {
                        itemRemember[rememberIndex] = Convert.ToString(gridStackNumber[brow, bcol]);
                        itemRemember[rememberIndex + 1] = itemName[gridItemID[brow, bcol]];
                        rememberIndex += 2;
                    }
                }
                for (int i = 1; i < rememberIndex; i += 2)
                    if (itemRemember[i] == oldName)
                    {
                        int c = 1;
                        for (int j = 1; j < rememberIndex; j += 2)
                        {
                            if ((j == 1 && j == i) || j + 2 == i)
                            {
                                j += 2;
                                itemRemember[c] = itemRemember[j];
                                c += 2;
                            }
                        }
                        rememberIndex -= 2;
                        break;
                    }
            }
            itemOrganization.Items.Clear();
            SortingHat();
            if (prevState == false && sessionActive == true)
                pauseSession();
        }

        private void itemButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int brow = 0, bcol = 0;
            bool found = false;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (button == itemButtons[row, col])
                    {
                        found = true;
                        brow = row;
                        bcol = col;
                        break;
                    }
                }
                if (found == true)
                    break;
            }
            if (e.Button == MouseButtons.Right && itemProblematic[gridItemID[brow, bcol]] == true && canAdd[brow, bcol] == true)
            {
                bool prevState = sessionPaused;
                if (modeCheck.Checked == true && sessionPaused == false && sessionActive == true)
                    pauseSession();
                itemClicked[brow, bcol] = true;
                string oldName = itemName[gridItemID[brow, bcol]];
                DuplicateSelector ds = new DuplicateSelector();
                ds.ShowDialog();
                databaseLoad();
                if (sessionActive == true)
                {
                    for (int i = 0; i < itemListControls; i++)
                    {
                        if (itemName[gridItemID[brow, bcol]] == stackLabel[i].Text)
                        {
                            itemRemember[rememberIndex] = Convert.ToString(gridStackNumber[brow, bcol]);
                            itemRemember[rememberIndex + 1] = itemName[gridItemID[brow, bcol]];
                            rememberIndex += 2;
                        }
                    }
                    for (int i = 1; i < rememberIndex; i += 2)
                        if (itemRemember[i] == oldName)
                        {
                            int c = 1;
                            for (int j = 1; j < rememberIndex; j += 2)
                            {
                                if ((j == 1 && j == i) || j + 2 == i)
                                {
                                    j += 2;
                                    itemRemember[c] = itemRemember[j];
                                    c += 2;
                                }
                            }
                            rememberIndex -= 2;
                            break;
                        }
                }
                itemOrganization.Items.Clear();
                SortingHat();
                itemClicked[brow, bcol] = false;
                if (prevState == false && sessionActive == true)
                    pauseSession();
            }
        }

        private void itemButton_MouseEnter(object sender, EventArgs e)
        {
            if (modeCheck.Checked == false)
            {
                Button button = sender as Button;
                int brow = 0, bcol = 0;
                bool found = false;
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        if (button == itemButtons[row, col])
                        {
                            found = true;
                            brow = row;
                            bcol = col;
                            break;
                        }
                    }
                    if (found == true)
                        break;
                }
                itemOrganization.SelectedIndex = gridOverviewIndex[brow, bcol];
            }
        }

        private void categoryOverviewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryOverviewList.SelectedIndex = -1;
        }
    }
}