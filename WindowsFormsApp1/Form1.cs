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
        private int finale = 0;
        private int finalClicked1 = 0;
        private int finalClicked2 = 0;
        private int operatorCheck = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            clicked = null;
            clicked2 = null;
            added = 0;
            subtracted = 0;
            multiplied = 0;
            divided = 0;
            operatorCheck = 0;
            finalClicked1 = 0;
            finalClicked2 = 0;
            percent = 0;
            textBox1.Text = String.Empty;
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (added == 1)
            {
                Console.WriteLine("=");
                textBox1.Text = textBox1.Text + "=";
                finalClicked1 = Int32.Parse(clicked);
                finalClicked2 = Int32.Parse(clicked2);
                finale = finalClicked1 + finalClicked2;
                Console.WriteLine(finale);
                textBox1.Text = textBox1.Text + finale;
                subtracted = 0;
            }
            if (subtracted == 1)
            {
                Console.WriteLine("=");
                textBox1.Text = textBox1.Text + "=";
                finalClicked1 = Int32.Parse(clicked);
                finalClicked2 = Int32.Parse(clicked2);
                finale = finalClicked1 - finalClicked2;
                textBox1.Text = textBox1.Text + finale;
                Console.WriteLine(finale);
                divided = 0;
            }
            if (divided == 1)
            {
                Console.WriteLine("=");
                textBox1.Text = textBox1.Text + "=";
                finalClicked1 = Int32.Parse(clicked);
                finalClicked2 = Int32.Parse(clicked2);
                finale = finalClicked1 / finalClicked2;
                textBox1.Text = textBox1.Text + finale;
                Console.WriteLine(finale);
                multiplied = 0;
            }
            if (multiplied == 1)
            {
                Console.WriteLine("=");
                textBox1.Text = textBox1.Text + "=";
                finalClicked1 = Int32.Parse(clicked);
                finalClicked2 = Int32.Parse(clicked2);
                finale = finalClicked1 * finalClicked2;
                textBox1.Text = textBox1.Text + finale;
                Console.WriteLine(finale);
                added = 0;
            }
            if (Decimal == 1) // todo: how the fuck decimals work - cant put in string, c# wont understand
            {
                Console.WriteLine("=");
                textBox1.Text = textBox1.Text + "=";
            }
            if (percent == 1)
            {
                Console.WriteLine("=");
                textBox1.Text = textBox1.Text + "=";
                decimal finalClicked1 = Convert.ToDecimal(clicked);
                decimal finalClicked2 = Convert.ToDecimal(clicked2);
                decimal pValue = finalClicked1 / 100;
                decimal finale = pValue * finalClicked2;
                textBox1.Text = textBox1.Text + finale;
                Console.WriteLine(finale);
                Decimal = 0;
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "00";
                textBox1.Text = textBox1.Text + "00";
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "00";
                textBox1.Text = textBox1.Text + "00";
                Console.WriteLine(clicked2);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "0";
                textBox1.Text = textBox1.Text + 0;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "0";
                textBox1.Text = textBox1.Text + 0;
                Console.WriteLine(clicked2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "1";
                textBox1.Text = textBox1.Text + 1;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "1";
                textBox1.Text = textBox1.Text + 1;
                Console.WriteLine(clicked2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "2";
                textBox1.Text = textBox1.Text + 2;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "2";
                textBox1.Text = textBox1.Text + 2;
                Console.WriteLine(clicked2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "3";
                textBox1.Text = textBox1.Text + 3;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "3";
                textBox1.Text = textBox1.Text + 3;
                Console.WriteLine(clicked2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "4";
                textBox1.Text = textBox1.Text + 4;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "4";
                textBox1.Text = textBox1.Text + 4;
                Console.WriteLine(clicked2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            { 
                clicked = clicked + "5";
                textBox1.Text = textBox1.Text + 5;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "5";
                textBox1.Text = textBox1.Text + 5;
                Console.WriteLine(clicked2);
            }
    }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "6";
                textBox1.Text = textBox1.Text + 6;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "6";
                textBox1.Text = textBox1.Text + 6;
                Console.WriteLine(clicked2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "7";
                textBox1.Text = textBox1.Text + 7;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "7";
                textBox1.Text = textBox1.Text + 7;
                Console.WriteLine(clicked2);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "8";
                textBox1.Text = textBox1.Text + 8;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "8";
                textBox1.Text = textBox1.Text + 8;
                Console.WriteLine(clicked2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorCheck == 0 & added == 0 & subtracted == 0 & multiplied == 0 & divided == 0 & percent == 0)
            {
                clicked = clicked + "9";
                textBox1.Text = textBox1.Text + 9;
                Console.WriteLine(clicked);
            }
            if (added == 1 | subtracted == 1 | multiplied == 1 | divided == 1 | percent == 1)
            {
                clicked2 = clicked2 + "9";
                textBox1.Text = textBox1.Text + 9;
                Console.WriteLine(clicked2);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            added = 1;
            subtracted = 0;
            divided = 0;
            multiplied = 0;
            Decimal = 0;
            percent = 0;
            Console.WriteLine("+");
            textBox1.Text = textBox1.Text + "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            added = 0;
            subtracted = 1;
            divided = 0;
            multiplied = 0;
            operatorCheck = 1;
            Decimal = 0;
            percent = 0;
            Console.WriteLine("-");
            textBox1.Text = textBox1.Text + "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            added = 0;
            subtracted = 0;
            divided = 0;
            multiplied = 1;
            Decimal = 0;
            percent = 0;
            Console.WriteLine("*");
            textBox1.Text = textBox1.Text + "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            added = 0;
            subtracted = 0;
            divided = 1;
            multiplied = 0;
            Decimal = 0;
            percent = 0;
            Console.WriteLine("/");
            textBox1.Text = textBox1.Text + "/";
        }

        private void button15_Click(object sender, EventArgs e) //decimal
        {
            added = 0;
            subtracted = 0;
            divided = 0;
            multiplied = 0;
            Decimal = 1;
            percent = 0;
            Console.WriteLine(".");
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e) //percent
        {
            added = 0;
            subtracted = 0;
            divided = 0;
            multiplied = 0;
            Decimal = 0;
            percent = 1;
            Console.WriteLine("%");
            textBox1.Text = textBox1.Text + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            added = 0;
            subtracted = 0;
            divided = 0;
            multiplied = 0;
            Decimal = 0;
            percent = 1;
            Console.WriteLine("%");
            textBox1.Text = textBox1.Text + "%";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }
    }
}
