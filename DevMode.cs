using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BDO_Item_Sorter
{
    public partial class DevMode : Form
    {
        Screen activeScreen = Screen.PrimaryScreen;
        int iconTopLeftX, iconTopY, iconTotalHeight, iconWidth, hStepSum, vStepSum, currentUIScale, gottenItems1, gottenItems2;
        int[] vSteps = new int[7], hSteps = new int[7];
        Rectangle[,] items = new Rectangle[8, 8];
        JObject APIGrindSpots;
        bool gettingIcons = false;

        public DevMode()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void DevMode_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Garmoth Autofiller Data");
            outputLabel1.Text = null;
            displayLabel.Text = null;
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev") == false)
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev");
            APIGrindSpots = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Grind Spots.json"));
        }

        private void grabSlotsButton_Click(object sender, EventArgs e)
        {
            outputLabel2.Text = null;
            grabSlotsButton.Enabled = false;
            cropCheck.Enabled = false;
            getCurrentUIScale();
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Icons") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Icons");
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Icons\\" + Convert.ToString(currentUIScale));
            }
            else
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Icons\\" + Convert.ToString(currentUIScale)) == false)
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Icons\\" + Convert.ToString(currentUIScale));
            }
            if (displayCheck.Checked == false)
                if (getCurrentScreen() == false)
                {
                    grabSlotsButton.Enabled = true;
                    cropCheck.Enabled = true;
                    return;
                }
            if (getInventoryPosition() == false)
            {
                grabSlotsButton.Enabled = true;
                cropCheck.Enabled = true;
                return;
            }
            if (getSlotRectangles(false) == false)
            {
                grabSlotsButton.Enabled = true;
                cropCheck.Enabled = true;
                return;
            }
            Bitmap prtscr = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prtscr))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
            }
            int nameCounter = 0;
            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                {
                    Bitmap temp = prtscr.Clone(items[row, col], prtscr.PixelFormat);
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Icons\\" + Convert.ToString(currentUIScale) + "\\" + Convert.ToString(nameCounter) + ".bmp") == true)
                        File.Delete(Directory.GetCurrentDirectory() + "\\Dev\\Icons\\" + Convert.ToString(currentUIScale) + "\\" + Convert.ToString(nameCounter) + ".bmp");
                    temp.Save(Directory.GetCurrentDirectory() + "\\Dev\\Icons\\" + Convert.ToString(currentUIScale) + "\\" + Convert.ToString(nameCounter) + ".bmp");
                    temp.Dispose();
                    nameCounter++;
                }
            prtscr.Dispose();
            outputLabel2.Visible = true;
            outputLabel2.Text = "Done for UI Scale " + Convert.ToString(currentUIScale);
            cropCheck.Enabled = true;
            grabSlotsButton.Enabled = true;
        }

        private void grabDigitsButton_Click(object sender, EventArgs e)
        {
            outputLabel2.Text = null;
            grabDigitsButton.Enabled = false;
            getCurrentUIScale();
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Digits") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Digits");
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale));
            }
            else
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale)) == false)
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale));
            }
            if (displayCheck.Checked == false)
                if (getCurrentScreen() == false)
                {
                    grabDigitsButton.Enabled = true;
                    return;
                }
            if (getInventoryPosition() == false)
            {
                grabDigitsButton.Enabled = true;
                return;
            }
            if (getSlotRectangles(true) == false)
            {
                grabDigitsButton.Enabled = true;
                return;
            }
            Bitmap prtscr = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prtscr))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
            }
            int step = 0;
            for (int iconRow = 0; iconRow < 8; iconRow++)
                for (int iconCol = 0; iconCol < 8; iconCol++)
                {
                    step++;
                    Bitmap testPic = prtscr.Clone(items[iconRow, iconCol], prtscr.PixelFormat);
                    Bitmap destination = new Bitmap(testPic.Width, testPic.Height, PixelFormat.Format32bppArgb);
                    bool equalLowerColors, isRedHigher, isRedWithinSpec;
                    for (int i = 0; i < testPic.Width; i++)
                    {
                        for (int j = 0; j < testPic.Height; j++)
                        {
                            equalLowerColors = testPic.GetPixel(i, j).G == testPic.GetPixel(i, j).B;
                            isRedHigher = testPic.GetPixel(i, j).R > testPic.GetPixel(i, j).G;
                            isRedWithinSpec = testPic.GetPixel(i, j).R - testPic.GetPixel(i, j).G <= 5 && testPic.GetPixel(i, j).R - testPic.GetPixel(i, j).G >= 1;
                            if ((equalLowerColors == true && isRedHigher == true && isRedWithinSpec == true) || (testPic.GetPixel(i, j).G == testPic.GetPixel(i, j).B && testPic.GetPixel(i, j).R == testPic.GetPixel(i, j).B))
                            {
                                destination.SetPixel(i, j, testPic.GetPixel(i, j));
                            }
                            else
                            {
                                destination.SetPixel(i, j, Color.FromArgb(0, 0, 0, 0));
                            }
                        }
                    }
                    int[] nonTransparentPixelsPerRow = new int[destination.Height], nonTransparentPixelsPerColumn = new int[destination.Width];
                    for (int y = 0; y < destination.Height; y++)
                    {
                        for (int x = 0; x < destination.Width; x++)
                        {
                            if (destination.GetPixel(x, y).A > 0)
                            {
                                nonTransparentPixelsPerRow[y]++;
                                nonTransparentPixelsPerColumn[x]++;
                            }
                        }
                    }
                    List<int> goodRows = new List<int>(), goodCols = new List<int>(), rowValue = new List<int>(), colValue = new List<int>();
                    int nrRow = 0, nrCol = 0, rowSum = 0, colSum = 0;
                    for (int i = 0; i < destination.Width; i++)
                    {
                        if (nonTransparentPixelsPerColumn[i] != 0)
                        {
                            goodCols.Add(i);
                            colValue.Add(nonTransparentPixelsPerColumn[i]);
                            colSum += nonTransparentPixelsPerColumn[i];
                        }
                    }
                    for (int i = 0; i < destination.Height; i++)
                    {
                        if (nonTransparentPixelsPerRow[i] != 0)
                        {
                            goodRows.Add(i);
                            rowValue.Add(nonTransparentPixelsPerRow[i]);
                            rowSum += nonTransparentPixelsPerRow[i];
                        }
                    }
                    int[] colListIndex = new int[colValue.Count], rowListIndex = new int[rowValue.Count];
                    int colIndex = 0, rowIndex = 0;
                    try
                    {
                        colSum = Convert.ToInt32(Math.Round(Convert.ToDecimal(colSum) / Convert.ToDecimal(goodCols.Count), 0, MidpointRounding.AwayFromZero));
                        rowSum = Convert.ToInt32(Math.Round(Convert.ToDecimal(rowSum) / Convert.ToDecimal(goodRows.Count), 0, MidpointRounding.AwayFromZero));
                    }
                    catch
                    {
                        MessageBox.Show("No digits found for stack supposed\nto have " + Convert.ToString(step) + " items.", "Digit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grabDigitsButton.Enabled = true;
                        return;
                    }
                    foreach (int i in colValue)
                    {
                        if (i > Convert.ToInt32(Math.Round(Convert.ToDecimal(colSum) / 2M, 0, MidpointRounding.AwayFromZero)))
                        {
                            colListIndex[nrCol] = goodCols[colIndex];
                            nrCol++;
                        }
                        colIndex++;
                    }
                    foreach (int i in rowValue)
                    {
                        if (i > Convert.ToInt32(Math.Round(Convert.ToDecimal(rowSum) / 2M, 0, MidpointRounding.AwayFromZero)))
                        {
                            rowListIndex[nrRow] = goodRows[rowIndex];
                            nrRow++;
                        }
                        rowIndex++;
                    }
                    if (step < 10)
                    {
                        Bitmap result = new Bitmap(nrCol, nrRow, PixelFormat.Format32bppArgb);
                        for (int row = 0; row < nrRow; row++)
                        {
                            for (int col = 0; col < nrCol; col++)
                            {
                                result.SetPixel(col, row, destination.GetPixel(colListIndex[col], rowListIndex[row]));
                            }
                        }
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + Convert.ToString(step) + ".bmp"))
                            File.Delete(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + Convert.ToString(step) + ".bmp");
                        result.Save(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + "\\" + Convert.ToString(step) + ".bmp");
                    }
                    else
                    {
                        try
                        {
                            Bitmap testWidth = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + "\\1.bmp");
                            Bitmap result = new Bitmap(nrCol - testWidth.Width, nrRow, PixelFormat.Format32bppArgb);
                            for (int row = 0; row < nrRow; row++)
                            {
                                for (int col = 0; col < nrCol - testWidth.Width; col++)
                                {
                                    result.SetPixel(col, row, destination.GetPixel(colListIndex[col + testWidth.Width], rowListIndex[row]));
                                }
                            }
                            if (File.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + "\\0.bmp"))
                                File.Delete(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + "\\0.bmp");
                            result.Save(Directory.GetCurrentDirectory() + "\\Dev\\Digits\\" + Convert.ToString(currentUIScale) + "\\0.bmp");
                            prtscr.Dispose();
                            testPic.Dispose();
                            destination.Dispose();
                            result.Dispose();
                            outputLabel2.Text = "Done for UI Scale " + Convert.ToString(currentUIScale);
                            grabDigitsButton.Enabled = true;
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("That was not a stack of 10, was it?", "Bitmap error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            grabDigitsButton.Enabled = true;
                            return;
                        }
                    }
                }
        }

        private void saveLocations_Click(object sender, EventArgs e)
        {
            saveLocations.Enabled = false;
            int spotCount = 0;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Dev\\All Grind Spot Locations.txt") == false)
                using (File.Create(Directory.GetCurrentDirectory() + "\\Dev\\All Grind Spot Locations.txt")) { }
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Dev\\All Grind Spot Locations.txt"))
            {
                foreach (var x in APIGrindSpots)
                {
                    JToken value = x.Value;
                    writer.WriteLine((string)value.SelectToken("id") + ": " + (string)value.SelectToken("name"));
                    spotCount++;
                }
                writer.WriteLine("--------------------------");
                writer.WriteLine("Total:" + Convert.ToString(spotCount));
            }
            saveLocations.Enabled = true;
        }

        private void saveSpecialLocations_Click(object sender, EventArgs e)
        {
            saveSpecialLocations.Enabled = false;
            int spotCount = 0;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Grind Spot Locations With Items.txt") == false)
                using (File.Create(Directory.GetCurrentDirectory() + "\\Dev\\Grind Spot Locations With Items.txt")) { }
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Dev\\Grind Spot Locations With Items.txt"))
            {
                foreach (var x in APIGrindSpots)
                {
                    JToken value = x.Value;
                    if (value.SelectToken("items").HasValues == true)
                    {
                        writer.WriteLine((string)value.SelectToken("id") + ": " + (string)value.SelectToken("name"));
                        spotCount++;
                    }
                }
                writer.WriteLine("--------------------------");
                writer.WriteLine("Total:" + Convert.ToString(spotCount));
            }
            saveSpecialLocations.Enabled = true;
        }

        private void saveItemsButton_Click(object sender, EventArgs e)
        {
            saveItemsButton.Enabled = false;
            List<string> uniqueItems = new List<string>();
            int itemCount = 0;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Items List.txt") == false)
                using (File.Create(Directory.GetCurrentDirectory() + "\\Dev\\Items List.txt")) { }
            foreach (var x in APIGrindSpots)
            {
                JToken value = x.Value;
                foreach (var y in value.SelectToken("items"))
                {
                    if (uniqueItems.Contains((string)y.SelectToken("name")) == false)
                    {
                        uniqueItems.Add((string)y.SelectToken("name"));
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Dev\\Items List.txt"))
            {
                foreach (string item in uniqueItems)
                {
                    writer.WriteLine(item);
                    itemCount++;
                }
                writer.WriteLine("--------------------------");
                writer.WriteLine("Total:" + Convert.ToString(itemCount));
            }
            saveItemsButton.Enabled = true;
        }

        private void getScreenButton_Click(object sender, EventArgs e)
        {
            getCurrentScreen();
        }

        [DllImport("user32.dll")] public static extern bool GetWindowRect(IntPtr handle, ref Rectangle rectangle);

        public bool getCurrentScreen()
        {
            bool found = false;
            IntPtr BDOHandle = IntPtr.Zero;
            Rectangle gameRectangle = new Rectangle();
            Process[] BDOProcess = Process.GetProcessesByName("BlackDesert64");
            if (BDOProcess != null && BDOProcess.Length > 0)
                foreach (Process process in BDOProcess)
                {
                    BDOHandle = process.MainWindowHandle;
                }
            if (BDOHandle != IntPtr.Zero)
            {
                GetWindowRect(BDOHandle, ref gameRectangle);
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.Bounds.IntersectsWith(gameRectangle))
                    {
                        activeScreen = screen;
                        found = true;
                    }
                }
            }
            if (found == false)
            {
                MessageBox.Show("BDO is not running!\nPlease start BDO and try again.", "BDO not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            displayLabel.Text = activeScreen.DeviceName;
            return true;
        }

        private void getInventoryButton_Click(object sender, EventArgs e)
        {
            getInventoryPosition();
        }

        public bool getInventoryPosition()
        {
            outputLabel1.Text = null;
        RetryFindingInventory:
            Bitmap prtscr = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prtscr))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
            }
            Bitmap capture = prtscr.Clone(new Rectangle(prtscr.Width / 2, 0, prtscr.Width / 2, prtscr.Height), prtscr.PixelFormat);
            prtscr.Dispose();
            //finding the top right corner of the inventory
            int topRightX = -1, topLeftX = -1, topY = -1;
            for (int col = capture.Width - 1; col > capture.Width / 2; col--)
            {
                for (int row = 0; row < capture.Height; row++)
                {
                    if (capture.GetPixel(col, row).R == 36 && capture.GetPixel(col, row).G == 36 && capture.GetPixel(col, row).B == 39)
                    {
                        bool found = true;
                        for (int icol = col; icol > col - 50; icol--)
                            if (capture.GetPixel(icol, row).R != 36 || capture.GetPixel(icol, row).G != 36 || capture.GetPixel(icol, row).B != 39)
                            {
                                found = false;
                                break;
                            }
                        if (found == true)
                            for (int irow = row; irow < row + 50; irow++)
                                if (capture.GetPixel(col, irow).R != 36 || capture.GetPixel(col, irow).G != 36 || capture.GetPixel(col, irow).B != 39)
                                {
                                    found = false;
                                    break;
                                }
                        if (found == true)
                        {
                            topRightX = col;
                            topY = row;
                            goto FoundTheInventory;
                        }
                    }
                }
            }
            if (topRightX == -1 && topY == -1)
            {
                if (MessageBox.Show("Couldn't find your inventory!\nPlease make sure your inventory is open.", "Inventory not found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    return false;
                else
                    goto RetryFindingInventory;
            }
        FoundTheInventory:
            //finding the top left corner of the inventory
            topLeftX = topRightX;
            while (true)
            {
                if (capture.GetPixel(topLeftX, topY).R != 36 || capture.GetPixel(topLeftX, topY).G != 36 || capture.GetPixel(topLeftX, topY).B != 39)
                {
                    topLeftX++;
                    break;
                }
                topLeftX--;
            }
            //finding the slot by going diagonally down
            iconTopLeftX = topLeftX;
            iconTopY = topY;
            while (true)
            {
                iconTopLeftX++;
                iconTopY++;
                if (capture.GetPixel(iconTopLeftX, iconTopY).R != 36 || capture.GetPixel(iconTopLeftX, iconTopY).G != 36 || capture.GetPixel(iconTopLeftX, iconTopY).B != 39)
                    break;
            }
            //finding the left-most pixel of the slot
            while (true)
            {
                iconTopLeftX--;
                if (capture.GetPixel(iconTopLeftX, iconTopY).R == 36 && capture.GetPixel(iconTopLeftX, iconTopY).G == 36 && capture.GetPixel(iconTopLeftX, iconTopY).B == 39)
                {
                    iconTopLeftX++;
                    break;
                }
            }
            //finding the total height of the slot
            int counter = iconTopY;
            while (true)
            {
                counter++;
                if (capture.GetPixel(iconTopLeftX, counter).R == 36 && capture.GetPixel(iconTopLeftX, counter).G == 36 && capture.GetPixel(iconTopLeftX, counter).B == 39)
                {
                    counter--;
                    iconTotalHeight = counter - iconTopY + 1;
                    break;
                }
            }
            int previousLastPixel = iconTopY;
            for (int i = 0; i < 7; i++)
            {
                //using counter to get all the vertical steps
                while (true)
                {
                    counter++;
                    if (capture.GetPixel(iconTopLeftX, counter).R != 36 || capture.GetPixel(iconTopLeftX, counter).G != 36 || capture.GetPixel(iconTopLeftX, counter).B != 39)
                    {
                        vSteps[i] = counter - previousLastPixel;
                        previousLastPixel = counter;
                        break;
                    }
                }
                while (true)
                {
                    counter++;
                    if (capture.GetPixel(iconTopLeftX, counter).R == 36 && capture.GetPixel(iconTopLeftX, counter).G == 36 && capture.GetPixel(iconTopLeftX, counter).B == 39)
                    {
                        counter--;
                        break;
                    }
                }
            }
            //finding the width of the slot
            counter = iconTopLeftX;
            while (true)
            {
                counter++;
                if (capture.GetPixel(counter, iconTopY).R == 36 && capture.GetPixel(counter, iconTopY).G == 36 && capture.GetPixel(counter, iconTopY).B == 39)
                {
                    counter--;
                    iconWidth = counter - iconTopLeftX + 1;
                    break;
                }
            }
            previousLastPixel = iconTopLeftX;
            for (int i = 0; i < 7; i++)
            {
                while (true)
                {
                    counter++;
                    if (capture.GetPixel(counter, iconTopY).R != 36 || capture.GetPixel(counter, iconTopY).G != 36 || capture.GetPixel(counter, iconTopY).B != 39)
                    {
                        hSteps[i] = counter - previousLastPixel;
                        previousLastPixel = counter;
                        break;
                    }
                }
                while (true)
                {
                    counter++;
                    if (capture.GetPixel(counter, iconTopY).R == 36 && capture.GetPixel(counter, iconTopY).G == 36 && capture.GetPixel(counter, iconTopY).B == 39)
                    {
                        counter--;
                        break;
                    }
                }
            }
            capture.Dispose();
            iconTopLeftX += +activeScreen.Bounds.Width / 2;
            outputLabel1.Text += "Top left corner width (horizontal)" + ' ' + Convert.ToString(iconTopLeftX) + ";\n";
            outputLabel1.Text += "Top left corner height (vertical)" + ' ' + Convert.ToString(iconTopY) + ";\n";
            outputLabel1.Text += "Horizontal steps to next slots" + ' ' + Convert.ToString(hSteps[0]) + ' ' + Convert.ToString(hSteps[1]) + ' ' + Convert.ToString(hSteps[2]) + ' ' + Convert.ToString(hSteps[3]) + ' ' + Convert.ToString(hSteps[4]) + ' ' + Convert.ToString(hSteps[5]) + ' ' + Convert.ToString(hSteps[6]) + ";\n";
            outputLabel1.Text += "Vertical steps to next slots" + ' ' + Convert.ToString(vSteps[0]) + ' ' + Convert.ToString(vSteps[1]) + ' ' + Convert.ToString(vSteps[2]) + ' ' + Convert.ToString(vSteps[3]) + ' ' + Convert.ToString(vSteps[4]) + ' ' + Convert.ToString(vSteps[5]) + ' ' + Convert.ToString(vSteps[6]) + ";\n";
            outputLabel1.Text += "Width of slot" + ' ' + Convert.ToString(iconWidth) + ';';
            hStepSum = 0;
            vStepSum = 0;
            for (int i = 0; i < 7; i++)
            {
                hStepSum += hSteps[i];
                vStepSum += vSteps[i];
            }
            return true;
        }

        public bool getSlotRectangles(bool digitCheck)
        {
            if (digitCheck == false)
            {
                int tempI = 0, tempJ = 0, hStepCounter, vStepCounter = 0;
                for (int row = iconTopY; row <= vStepSum + iconTopY; row += 0)
                {
                    hStepCounter = 0;
                    for (int col = iconTopLeftX; col <= hStepSum + iconTopLeftX; col += 0)
                    {
                        if (cropCheck.Checked == false)
                            items[tempI, tempJ] = new Rectangle(col, row, iconWidth, iconTotalHeight);
                        else
                        {
                            try
                            {
                                Bitmap testHeight = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Icons\\" + Convert.ToString(currentUIScale) + "\\0.bmp");
                                items[tempI, tempJ] = new Rectangle(col, row, iconWidth, testHeight.Height);
                                testHeight.Dispose();
                            }
                            catch
                            {
                                MessageBox.Show("Sample bitmap not found for UI Scale " + Convert.ToString(currentUIScale) + ".", "Sample missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        tempJ++;
                        if (hStepCounter <= 6)
                        {
                            col += hSteps[hStepCounter];
                            hStepCounter++;
                        }
                        else
                            col++;
                    }
                    tempJ = 0;
                    tempI++;
                    if (vStepCounter <= 6)
                    {
                        row += vSteps[vStepCounter];
                        vStepCounter++;
                    }
                    else
                        row++;
                }
            }
            else
            {
                int tempI = 0, tempJ = 0, hStepCounter, vStepCounter = 0;
                for (int row = iconTopY; row <= vStepSum + iconTopY; row += 0)
                {
                    hStepCounter = 0;
                    for (int col = iconTopLeftX; col <= hStepSum + iconTopLeftX; col += 0)
                    {
                        items[tempI, tempJ] = new Rectangle(col + iconWidth / 2, row + iconTotalHeight / 2, iconWidth / 2, iconTotalHeight / 2);
                        tempJ++;
                        if (hStepCounter <= 6)
                        {
                            col += hSteps[hStepCounter];
                            hStepCounter++;
                        }
                        else
                            col++;
                    }
                    tempJ = 0;
                    tempI++;
                    if (vStepCounter <= 6)
                    {
                        row += vSteps[vStepCounter];
                        vStepCounter++;
                    }
                    else
                        row++;
                }
            }
            return true;
        }

        public void getCurrentUIScale()
        {
            string[] temp = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\GameOption.txt");
            string subtemp = temp[66].Substring(temp[66].Length - 4, 4);
            currentUIScale = Convert.ToInt32(subtemp.Split('.')[0] + subtemp.Split('.')[1]);
            if (currentUIScale % 2 != 0)
                MessageBox.Show("Odd UI Scales are wonky at the moment, results will be unpredictable.", "Odd UI Scale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void getAnimatedIcons_Click(object sender, EventArgs e)
        {
            cropCheck.Enabled = false;
            getCurrentUIScale();
            if (gettingIcons == false)
            {
                if (displayCheck.Checked == false)
                    if (getCurrentScreen() == false)
                    {
                        getAnimatedIcons.Text = "Get Animated Icons\r\nRead ToolTip";
                        cropCheck.Enabled = true;
                        return;
                    }
                if (getInventoryPosition() == false)
                {
                    getAnimatedIcons.Text = "Get Animated Icons\r\nRead ToolTip";
                    cropCheck.Enabled = true;
                    return;
                }
                if (getSlotRectangles(false) == false)
                {
                    getAnimatedIcons.Text = "Get Animated Icons\r\nRead ToolTip";
                    cropCheck.Enabled = true;
                    return;
                }
                gottenItems1 = 1;
                gottenItems2 = 1;
                reportLabel1.Text = "Unique icons on thread 1: 1";
                reportLabel2.Text = "Unique icons on thread 2: 1";
                reportLabel1.Visible = true;
                reportLabel2.Visible = true;
                gettingIcons = true;
                getAnimatedIcons.Text = "Stop";
                Bitmap prtscr = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(prtscr))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                }
                Bitmap item1 = prtscr.Clone(items[7, 6], prtscr.PixelFormat);
                Bitmap item2 = prtscr.Clone(items[7, 7], prtscr.PixelFormat);
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale)) == false)
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale));
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 1");
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 2");
                }
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 1") == false)
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 1");
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 2") == false)
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 2");
                item1.Save(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 1\\0.png", ImageFormat.Png);
                item2.Save(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 2\\0.png", ImageFormat.Png);
                prtscr.Dispose();
                item1.Dispose();
                item2.Dispose();
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.RunWorkerAsync();
            }
            else
            {
                backgroundWorker1.CancelAsync();
                backgroundWorker2.CancelAsync();
                cropCheck.Enabled = true;
                getAnimatedIcons.Text = "Get Animated Icons\r\nRead ToolTip";
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = 1;
            List<Bitmap> bmpl = new List<Bitmap>();
            bmpl.Add((Bitmap)System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 1\\0.png"));
            while (backgroundWorker1.CancellationPending == false)
            {
                Bitmap prtscr = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(prtscr))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                }
                Bitmap item = prtscr.Clone(items[7, 6], prtscr.PixelFormat);
                bool found = false;
                for (int test = 0; test < bmpl.Count; test++)
                {
                    if (CompareBitmaps(item, bmpl[test]) == true)
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    Bitmap gitem = item.Clone(new Rectangle(0, 0, item.Width, item.Height), item.PixelFormat);
                    bmpl.Add(gitem);
                    item.Save(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 1\\" + Convert.ToString(i) + ".png", ImageFormat.Png);
                    i++;
                    worker.ReportProgress(1);
                }
                prtscr.Dispose();
                item.Dispose();
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = 1;
            List<Bitmap> bmpl = new List<Bitmap>();
            bmpl.Add((Bitmap)System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 2\\0.png"));
            while (backgroundWorker2.CancellationPending == false)
            {
                Bitmap prtscr = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(prtscr))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                }
                Bitmap item = prtscr.Clone(items[7, 7], prtscr.PixelFormat);
                bool found = false;
                for (int test = 0; test < bmpl.Count; test++)
                {
                    if (CompareBitmaps(item, bmpl[test]) == true)
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    Bitmap gitem = item.Clone(new Rectangle(0, 0, item.Width, item.Height), item.PixelFormat);
                    bmpl.Add(gitem);
                    item.Save(Directory.GetCurrentDirectory() + "\\Dev\\Animated Icons\\" + Convert.ToString(currentUIScale) + "\\Item 2\\" + Convert.ToString(i) + ".png", ImageFormat.Png);
                    i++;
                    worker.ReportProgress(1);
                }
                prtscr.Dispose();
                item.Dispose();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            gottenItems1++;
            reportLabel1.Text = "Unique icons on thread 1: " + Convert.ToString(gottenItems1);
        }

        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            gottenItems2++;
            reportLabel2.Text = "Unique icons on thread 2: " + Convert.ToString(gottenItems2);
        }

        public bool CompareBitmaps(Bitmap bmp1, Bitmap bmp2) //returns true if the given pics are the same || false if not
        {
            int bytes = bmp1.Width * bmp1.Height * (System.Drawing.Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);
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

        private void DevMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
        }

        private void DevMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
