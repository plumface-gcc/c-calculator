using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class Form1 : Form 
    {
        private MouseEventHandler mouseClick;
        private String clicked;
        private String clicked2;
        private int added = 0;
        private int subtracted = 0;
        private int multiplied = 0;
        private int divided = 0;
        private int Decimal = 0;
        private int percent = 0;
        private decimal finale = 0;
        private decimal finalClicked1 = 0;
        private decimal finalClicked2 = 0;
        private int operatorCheck = 0;
        private int decimalCheck = 0;

        public Form1() //todo: make key inputs allowed from keyboard
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void calculatorClear_click(object sender, EventArgs e)
        {
            clicked = null;
            clicked2 = null;
            added = 0;
            subtracted = 0;
            multiplied = 0;
            divided = 0;
            decimalCheck = 0;
            Decimal = 0;
            operatorCheck = 0;
            finalClicked1 = 0;
            finalClicked2 = 0;
            percent = 0;
            textBox1.Text = String.Empty;
        }

        private void calculatorEquals_click(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text + "=";

            if (Decimal == 1) 
            {
                finalClicked1 = Convert.ToDecimal(clicked);
                finalClicked2 = Convert.ToDecimal(clicked2);
                Console.WriteLine(finalClicked1);
                Console.WriteLine(finalClicked2);
            }

            if (added == 1)
            {
               finale = finalClicked1 + finalClicked2;
               textBox1.Text = textBox1.Text + finale;
               added = 0;
            }
            if (subtracted == 1)
            {
               finale = finalClicked1 - finalClicked2;
               textBox1.Text = textBox1.Text + finale;
               subtracted = 0;
            }
            if (divided == 1)
            {
               finale = finalClicked1 / finalClicked2;
               textBox1.Text = textBox1.Text + finale;
               divided = 0;
            }
            if (multiplied == 1)
            {
               finale = finalClicked1 * finalClicked2;
               textBox1.Text = textBox1.Text + finale;
               multiplied = 0;
            }
            if (percent == 1)
             {
               decimal pValue = finalClicked1 / 100;
               decimal finale = pValue * finalClicked2;
               textBox1.Text = textBox1.Text + finale;
               percent = 0;
             }
        }

        private void calculator00_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "00";
                textBox1.Text = textBox1.Text + "00";
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "00";
                textBox1.Text = textBox1.Text + "00";
            }
        }

        private void calculator0_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "0";
                textBox1.Text = textBox1.Text + 0;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "0";
                textBox1.Text = textBox1.Text + 0;
            }
        }

        private void calculator1_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "1";
                textBox1.Text = textBox1.Text + 1;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "1";
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void calculator2_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "2";
                textBox1.Text = textBox1.Text + 2;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "2";
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void calculator3_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "3";
                textBox1.Text = textBox1.Text + 3;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "3";
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void calculator4_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "4";
                textBox1.Text = textBox1.Text + 4;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "4";
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void calculator5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(clicked);
            Console.WriteLine(clicked2);
            if (operatorCheck == 0)
            { 
                clicked = clicked + "5";
                textBox1.Text = textBox1.Text + 5;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "5";
                textBox1.Text = textBox1.Text + 5;
            }
    }

        private void calculator6_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "6";
                textBox1.Text = textBox1.Text + 6;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "6";
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void calculator7_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "7";
                textBox1.Text = textBox1.Text + 7;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "7";
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void calculator8_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "8";
                textBox1.Text = textBox1.Text + 8;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "8";
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void calculator9_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                clicked = clicked + "9";
                textBox1.Text = textBox1.Text + 9;
            }
            if (operatorCheck == 1)
            {
                clicked2 = clicked2 + "9";
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void calculatorAddition_click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                added = 1;
                subtracted = 0;
                divided = 0;
                multiplied = 0;
                percent = 0;
                decimalCheck = 1;
                operatorCheck = 1;
                textBox1.Text = textBox1.Text + "+";
            }
        }

        private void calculatorSubtract_click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                added = 0;
                subtracted = 1;
                divided = 0;
                multiplied = 0;
                operatorCheck = 1;
                decimalCheck = 1;
                percent = 0;
                textBox1.Text = textBox1.Text + "-";
            }
        }

        private void calculatorMultiply_click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                added = 0;
                subtracted = 0;
                divided = 0;
                multiplied = 1;
                operatorCheck = 1;
                percent = 0;
                decimalCheck = 1;
                textBox1.Text = textBox1.Text + "*";
            }
        }

        private void calculatorDivision_click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                added = 0;
                subtracted = 0;
                divided = 1;
                multiplied = 0;
                percent = 0;
                decimalCheck = 1;
                textBox1.Text = textBox1.Text + "/";
            }
        }

        private void button15_Click(object sender, EventArgs e) //decimal
        {

        }

        private void button17_Click(object sender, EventArgs e) //percent
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void calculatorPercent_click(object sender, EventArgs e)
        {
            if (operatorCheck == 0)
            {
                added = 0;
                subtracted = 0;
                divided = 0;
                multiplied = 0;
                operatorCheck = 1;
                percent = 1;
                decimalCheck = 1;
                textBox1.Text = textBox1.Text + "%";
            }
        }

        private void calculatorDecimal_click(object sender, EventArgs e)
        {
            if (decimalCheck == 0)
            {
                textBox1.Text = textBox1.Text + ".";
                Decimal = 1;
                clicked = clicked + ".";
            }
            if (decimalCheck == 1)
            {
                textBox1.Text = textBox1.Text + ".";
                Decimal = 1;
                clicked2 = clicked2 + ".";
            }
        }
    }
}
