/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 6: Create a Drawing Paint App
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaintApp
{
    public partial class form_Paint : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;
        public form_Paint()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
                drawing = false;
            else
                drawing = true;
        }

        private void pictureBox_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox_Paint.Image = bmp;
            }
        }

        private void btn_Red_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void btn_Purp_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void btn_Black_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_Paint = new SaveFileDialog();
            saveFileDialog_Paint.Filter = "JPeg Image|*.jpg|Bitmap Image *.bmp|";
            saveFileDialog_Paint.Title = "Save your image file";
            saveFileDialog_Paint.ShowDialog();

            if (saveFileDialog_Paint.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog_Paint.OpenFile();
                switch (saveFileDialog_Paint.FilterIndex)
                {

                    case 1:
                        this.pictureBox_Paint.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox_Paint.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
        }
    }
}
