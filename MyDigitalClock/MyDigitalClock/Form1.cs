/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 11: Create a Simple Digital Clock
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

namespace MyDigitalClock
{
    public partial class form_DigtalClock : Form
    {
        Timer t = new Timer();

        public form_DigtalClock()
        {
            InitializeComponent();
        }

        private void form_DigtalClock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += " : ";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += " : ";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label_DigitalClock.Text = time;
        }
    }
}
