/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 10:Create Digital Clock Showing Date and Day
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

namespace MyDigitalCalendar
{
    public partial class form_Calendar : Form
    {
        public form_Calendar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToString("HH : mm");
            
            label_Seconds.Text = DateTime.Now.ToString("ss");

            if (DateTime.Now.ToString("dd").StartsWith("0"))
                label_Date.Text = DateTime.Now.ToString("d MMMMMMMMM yyyy");
            else
                label_Date.Text = DateTime.Now.ToString("dd MMMMMMMMM yyyy");

            label_Day.Text = DateTime.Now.ToString("ddddddddd");
        }

        private void form_Calendar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}