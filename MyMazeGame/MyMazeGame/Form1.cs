/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 4: Create a Maze Game
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

namespace MyMazeGame
{
    public partial class frmMazeGame : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\media\chord.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\media\tada.wav");

        public frmMazeGame()
        {
            InitializeComponent();
            moveToStart();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!!!");
            Close();
        }

        private void moveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = pnlMazeGame.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            moveToStart();
        }
    }
}
