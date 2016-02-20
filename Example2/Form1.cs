using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Red, (float)2.4);
        Timer t = new Timer();
        float x = 10;
        float y = 10;
        float w = 200;
        float h = 200;

        public Form1()
        {
            InitializeComponent();
            t.Interval = 1000;
            t.Tick += DoIt;
            t.Start();
        }

        private void DoIt(object sender, EventArgs e)
        {
            x += 10;
            y += 10;
            //label1.Text = DateTime.Now.ToString("HH:mm:ss:fff");
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(p, x, y, w, h);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
