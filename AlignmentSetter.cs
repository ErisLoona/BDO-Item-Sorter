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

namespace BDO_Item_Sorter
{
    public partial class AlignmentSetter : Form
    {
        public static int screenWidth = Screen.PrimaryScreen.Bounds.Width, screenHeight = Screen.PrimaryScreen.Bounds.Height, reticleX, reticleY, mouseX, mouseY, step, tempX = 0, tempY = 0;
        public static bool resize;
        public static Screen activeScreen = Screen.PrimaryScreen;

        public AlignmentSetter()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void AlignmentSetter_Load(object sender, EventArgs e)
        {
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
            screenWidth = activeScreen.Bounds.Width;
            screenHeight = activeScreen.Bounds.Height;
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BDO Item Sorter Data");
            step = 0;
            Bitmap prts = new Bitmap(activeScreen.Bounds.Width, activeScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(prts))
            {
                g.CopyFromScreen(activeScreen.Bounds.X, activeScreen.Bounds.Y, 0, 0, activeScreen.Bounds.Size);
                screenBox.Image = prts.Clone(new Rectangle(0, 0, screenWidth, screenHeight), prts.PixelFormat);
                prts.Dispose();
                g.Flush();
            }
            screenBox.Width = screenWidth;
            screenBox.Height = screenHeight;
            zoomReticle.Location = new Point(screenWidth / 2 - 98, screenHeight / 2 - 98);
            this.Location = activeScreen.WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            updateReticle();
        }

        void updateReticle()
        {
            reticleX = zoomReticle.Location.X + 98;
            reticleY = zoomReticle.Location.Y + 98;
            using (Bitmap i = new Bitmap(screenBox.Image))
            {
                using (Bitmap o = new Bitmap(195, 195, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                {
                    int inputV = 7, inputH;
                    for (int vertical = 0; vertical < 195; vertical += 13)
                    {
                        inputH = 7;
                        for (int horizontal = 0; horizontal < 195; horizontal += 13)
                        {
                            for (int insideV = vertical; insideV < vertical + 13; insideV++)
                            {
                                for (int insideH = horizontal; insideH < horizontal + 13; insideH++)
                                {
                                    o.SetPixel(insideH, insideV, i.GetPixel(reticleX - inputH, reticleY - inputV));
                                }
                            }
                            inputH--;
                        }
                        inputV--;
                    }
                    zoomReticle.BackgroundImage = o.Clone(new Rectangle(0, 0, 195, 195), o.PixelFormat);
                }
            }
        }

        private void zoomReticle_MouseDown(object sender, MouseEventArgs e)
        {
            resize = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void zoomReticle_MouseMove(object sender, MouseEventArgs e)
        {
            if (resize == true)
            {
                //if I don't subtract the initial mouse coords it will always grab the image at the origin, top left corner, which is weird
                zoomReticle.Location = new Point(zoomReticle.Location.X + e.X - mouseX, zoomReticle.Location.Y + e.Y - mouseY);
            }
        }

        private void zoomReticle_MouseUp(object sender, MouseEventArgs e)
        {
            resize = false;
            updateReticle();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (step == 2)
            {
                MainMenu.lineEditor("Step to next slots" + ',' + Convert.ToString(reticleX - tempX), Directory.GetCurrentDirectory() + "\\Position Settings.csv", 2);
                this.Close();
            }
            if (step == 1)
            {
                MainMenu.lineEditor("Width of slot" + ',' + Convert.ToString(reticleX - tempX + 1), Directory.GetCurrentDirectory() + "\\Position Settings.csv", 3);
                MainMenu.lineEditor("Height of slot" + ',' + Convert.ToString(reticleY - tempY + 1), Directory.GetCurrentDirectory() + "\\Position Settings.csv", 4);
                step++;
                setButton.Text = "Set top left corner of next slot to the left INSIDE THE BORDER";
            }
            if (step == 0)
            {
                MainMenu.lineEditor("Top left corner width (horizontal)" + ',' + Convert.ToString(reticleX), Directory.GetCurrentDirectory() + "\\Position Settings.csv", 0);
                MainMenu.lineEditor("Top left corner height (vertical)" + ',' + Convert.ToString(reticleY), Directory.GetCurrentDirectory() + "\\Position Settings.csv", 1);
                tempX = reticleX;
                tempY = reticleY;
                step++;
                setButton.Text = "Set bottom right of same item JUST ABOVE THE STACK NUMBER";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys key) //angry code, because fuck me I guess
        {
            var handled = false;
            if (key == Keys.Left)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X - 1, zoomReticle.Location.Y);
                handled = true;
                updateReticle();
            }
            if (key == Keys.Up)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X, zoomReticle.Location.Y - 1);
                handled = true;
                updateReticle();
            }
            if (key == Keys.Right)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X + 1, zoomReticle.Location.Y);
                handled = true;
                updateReticle();
            }
            if (key == Keys.Down)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X, zoomReticle.Location.Y + 1);
                handled = true;
                updateReticle();
            }
            return handled || base.ProcessCmdKey(ref msg, key);
        }

        /* no idea why this doesn't work, it just doesn't, it's a piece of shit
         * honestly, intended method my ass, it took me 4 hours of debugging just to end up with nothing
         * if anyone can solve this debucle please, for the love of god, help me

        private void AlignmentSetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X - 1, zoomReticle.Location.Y);
                e.SuppressKeyPress = true;
                updateReticle();
            }
            if (e.KeyCode == Keys.Up)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X, zoomReticle.Location.Y - 1);
                e.SuppressKeyPress = true;
                updateReticle();
            }
            if (e.KeyCode == Keys.Right)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X + 1, zoomReticle.Location.Y);
                e.SuppressKeyPress = true;
                updateReticle();
            }
            if (e.KeyCode == Keys.Down)
            {
                zoomReticle.Location = new Point(zoomReticle.Location.X, zoomReticle.Location.Y + 1);
                e.SuppressKeyPress = true;
                updateReticle();
            }
        }*/

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}