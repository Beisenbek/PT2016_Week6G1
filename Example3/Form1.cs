using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Red, (float)2.4);
        Timer t = new Timer();
        float x = 10;
        float y = 10;
        float w = 200;
        float h = 200;

        int dx = 3;
        int dy = 2;
        int fx = 1;
        int fy = 1;

        public Form1()
        {
            InitializeComponent();
            t.Interval = 100;
            t.Tick += DoIt;
            t.Start();
        }

        private void DoIt(object sender, EventArgs e)
        {
            if(x + w + dx* fx > Width)
            {
                fx = -1;
            }
            else if(x + dx * fx <= 0)
            {
                fx = 1;
            }

            if (y + dy * fy + h > Height)
            {
                fy = -1;
            }
            else if (y + dy * fy <= 0)
            {
                fy = 1;
            }

            x += dx * fx;
            y += dy * fy;

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(sb, 0, 0, Width, Height);

            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(p, x, y, w, h);

            e.Graphics.DrawRectangle(p,0, 0, Width, Height);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
