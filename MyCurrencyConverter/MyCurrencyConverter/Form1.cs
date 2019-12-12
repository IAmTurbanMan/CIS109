/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 7: Create a Currency Converter
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

namespace MyCurrencyConverter
{
    public partial class form_CurrencyConverter : Form
    {
        public form_CurrencyConverter()
        {
            InitializeComponent();
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {
            brwsr_Converter.Navigate("https://www.foreignexchangeresource.com/currency-converter.php?c=CAD&a=USD&amt=1&panel=1&button=2");
        }
    }
}
