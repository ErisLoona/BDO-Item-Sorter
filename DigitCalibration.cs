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
using System.Diagnostics;
using System.Drawing.Imaging;

namespace BDO_Item_Sorter
{
    public partial class DigitCalibration : Form
    {
        int step = 0;
        Screen activeScreen = Screen.PrimaryScreen;
        Rectangle item;

        public DigitCalibration()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void DigitCalibration_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
            int cW, cH, s, picW, picH;
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
            item = new Rectangle(cW + picW / 2, cH + picH, picW / 2, picW - picH);
            for (int i = 0; i < 10; i++)
                MainMenu.digits[i].Dispose();
        }

        private void getDigitButton_Click(object sender, EventArgs e)
        {
            step++;
            tooltipLabel.Text = "Please place a stack of " + Convert.ToString(step + 1) + " in your top-left inventory slot";
            Bitmap prtscr = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prtscr))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
            }
            Bitmap testPic = prtscr.Clone(item, prtscr.PixelFormat);
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
                MessageBox.Show("No digits found. Please make sure the alignment is correct, and the item is in the correct spot!", "Digit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tooltipLabel.Text = "Please place a stack of " + Convert.ToString(step) + " in your top-left inventory slot";
                step--;
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
                demoBox.BackgroundImage = result;
                demoBox.Height = result.Height;
                demoBox.Width = result.Width;
                demoBox.Left = (this.ClientSize.Width - demoBox.Width) / 2;
                File.Delete(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\" + Convert.ToString(step) + ".bmp");
                result.Save(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\" + Convert.ToString(step) + ".bmp");
            }
            else
            {
                try
                {
                    Bitmap testWidth = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\1.bmp");
                    Bitmap result = new Bitmap(nrCol - testWidth.Width, nrRow, PixelFormat.Format32bppArgb);
                    for (int row = 0; row < nrRow; row++)
                    {
                        for (int col = 0; col < nrCol - testWidth.Width; col++)
                        {
                            result.SetPixel(col, row, destination.GetPixel(colListIndex[col + testWidth.Width], rowListIndex[row]));
                        }
                    }
                    File.Delete(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\0.bmp");
                    result.Save(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\0.bmp");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("That was not a stack of 10, was it?\nOr maybe it was in the wrong spot. Try again!", "Bitmap error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tooltipLabel.Text = "Please place a stack of 10 in your top-left inventory slot";
                    step--;
                    return;
                }
            }
            prtscr.Dispose();
            testPic.Dispose();
            destination.Dispose();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo website = new ProcessStartInfo();
            website.FileName = "https://youtu.be/WmSPHVduDfc";
            Process.Start(website);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DigitCalibration_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 10; i++)
                    MainMenu.digits[i] = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\Sorting Mode\\Digits\\" + Convert.ToString(i) + ".bmp");
        }
    }
}
