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
            }

            else
            {
                area.Width = Cursor.Position.X - area.X;
                area.Height = Cursor.Position.Y - area.Y;
            }
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(area.Width, area.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(area.X, area.Y, 0, 0, area.Size);

            bmp.Save(@"C:\Users\isti\Desktop\test.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
