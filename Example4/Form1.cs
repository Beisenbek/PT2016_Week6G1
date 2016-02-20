using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(200, 200);

        public Form1()
        {
            InitializeComponent();
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.Clear(Color.Green);
            gfx.DrawEllipse(new Pen(Color.Yellow), 0, 0, 10, 10);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 10, 10);
        }
    }
}
