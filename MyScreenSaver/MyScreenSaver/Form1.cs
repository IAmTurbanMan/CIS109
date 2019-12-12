/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 3: Create a Screen Saver
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

namespace MyScreenSaver
{
    public partial class frmScreenSaver : Form
    {
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic
        {
            public int picNum;
            public float x;
            public float y;
        }

        public frmScreenSaver()
        {
            InitializeComponent();
        }

        private void frmScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void frmScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");

            foreach (string image in images)
            {
                BGImages.Add(new Bitmap(image));
            }

            for (int i = 0; i < 50; i++)
            {
                BritPic mp = new BritPic();
                mp.picNum = i % BGImages.Count;
                mp.x = rand.Next(0, Width);
                mp.y = rand.Next(0, Height);
                BritPics.Add(mp);
            }
        }

        private void screenTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics)
            {
                e.Graphics.DrawImage(BGImages[bp.picNum], bp.x, bp.y);
                bp.x -= 2;

                if (bp.x < -250)
                {
                    bp.x = Width + rand.Next(20, 100);
                }
            }
        }
    }
}
