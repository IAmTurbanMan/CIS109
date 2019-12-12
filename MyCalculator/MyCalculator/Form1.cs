/* Rashidul Kader
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * udemy: 17 Beginner C# Walkthrough Projects Step by Step
 * Project 9: Create your own calculator
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

namespace MyCalculator
{
    public partial class frm_Main : Form
    {
        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (tbo_Result.Text == "0" || (isOperatorClicked))
            {
                tbo_Result.Clear();
            }

            isOperatorClicked = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!tbo_Result.Text.Contains("."))
                {
                    tbo_Result.Text = tbo_Result.Text + button.Text;
                }
            }

            else
            {
                tbo_Result.Text = tbo_Result.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btn_Equals.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;
            }

            else
            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(tbo_Result.Text);
                isOperatorClicked = true;
            }

            operatorClicked = button.Text;
            resultValue = Double.Parse(tbo_Result.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbo_Result.Text = "0";
            resultValue = 0;
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    tbo_Result.Text = (resultValue + Double.Parse(tbo_Result.Text)).ToString();
                    break;
                case "-":
                    tbo_Result.Text = (resultValue - Double.Parse(tbo_Result.Text)).ToString();
                    break;
                case "×":
                    tbo_Result.Text = (resultValue * Double.Parse(tbo_Result.Text)).ToString();
                    break;
                case "÷":
                    tbo_Result.Text = (resultValue / Double.Parse(tbo_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
