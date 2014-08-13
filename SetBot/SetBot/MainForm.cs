using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetBot
{
    public partial class MainForm : Form
    {
        public bool settingArea = false;
        public Rectangle area = new Rectangle();

        Bitmap bmp;

        public Point cardStart;
        public Size cardSize;
        public Size gapSize;

        public MainForm()
        {
            InitializeComponent();
        }

        private void setAreaButton_Click(object sender, EventArgs e)
        {
            if (!settingArea)
            {
                area.X = Cursor.Position.X;
                area.Y = Cursor.Position.Y;

                settingArea = true;
                setAreaButton.BackColor = SystemColors.ControlDark;
            }

            else
            {
                area.Width = Cursor.Position.X - area.X;
                area.Height = Cursor.Position.Y - area.Y;

                settingArea = false;
                setAreaButton.BackColor = SystemColors.Control;
            }
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(area.Width, area.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(area.X, area.Y, 0, 0, area.Size);            
        }

        private void findCardsButton_Click(object sender, EventArgs e)
        {
            int currentX, currentY;

            #region X axis

            currentX = 0;
            currentY = 50;

            while (!isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentX++;
            }

            cardStart.X = currentX;

            while (isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentY--;
            }
            currentY++;

            while (isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentX++;
            }

            cardSize.Width = currentX - cardStart.X;

            while (!isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentX++;
            }

            gapSize.Width = currentX - (cardStart.X + cardSize.Width);

            #endregion

            #region Y axis

            currentX = 50;
            currentY = 0;

            while (!isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentY++;
            }

            cardStart.Y = currentY;

            while (isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentX--;
            }
            currentX++;

            while (isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentY++;
            }

            cardSize.Height = currentY - cardStart.Y;

            while (!isWhite(bmp.GetPixel(currentX, currentY)))
            {
                currentY++;
            }

            gapSize.Height = currentY - (cardStart.Y + cardSize.Height);

            #endregion
            MessageBox.Show("X:" + cardStart.X + "|Y:" + cardStart.Y);
            MessageBox.Show("X:" + cardSize.Width + "|Y:" + cardSize.Height);
            MessageBox.Show("X:" + gapSize.Width + "|Y:" + gapSize.Height);
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bmp);

            for (int i = 0; i < 4*4; i++)
            {
                graphics.DrawRectangle(Pens.Black,
                    cardStart.X + (cardSize.Width + gapSize.Width) * (i % 4),
                    cardStart.Y + (cardSize.Height + gapSize.Height) * (i / 4),
                    cardSize.Width, cardSize.Height);
            }
        }

        public bool isWhite(Color color)
        {
            return color.R > 200 && color.G > 200 && color.B > 200;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            bmp.Save(@"C:\Users\isti\Desktop\test.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
