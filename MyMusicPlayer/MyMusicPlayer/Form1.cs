/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 2: Create a Music Player
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

namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            Player.URL = textBox1.Text;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
