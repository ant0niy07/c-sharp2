using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[1000];
        
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i,(int)(Math.Sin((double)i/10)*100 + 200));
            }
            graphics.DrawLines(pen, points);
        }   
            
    }
}
