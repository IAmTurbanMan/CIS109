/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 5: Create a Picture Viewer
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

namespace MyPictureViewer
{
    public partial class pictureViewer : Form
    {
        public pictureViewer()
        {
            InitializeComponent();
        }

        //Exit the program.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Open Color dialog box. If user clicks OK,
        //set pictureBox1 BackColor property to selected color.
        private void btnBGColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = dlgColor.Color;
            }
        }
    
        //Clear the current picture from pictureBox1.
        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        //Show Open File dialog box. If user clicks OK,
        //load the selected file into pictureBox1.
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dlgPictureSelect.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(dlgPictureSelect.FileName);
            }
        }

        //If user checks Stretch check box,
        //change pictureBox1 Size Mode property to "Stretch".
        //If user clears the check box
        //change Size Mode property back to "Normal".
        private void chkbxStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxStretch.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
