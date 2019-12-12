/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 8: Create your own web browser
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

namespace MyWebBrowser
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void cbo_Location_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser.Navigate(cbo_Location.Text);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(cbo_Location.Text);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Al Thawra - " + webBrowser.Document.Title;
        }
    }
}