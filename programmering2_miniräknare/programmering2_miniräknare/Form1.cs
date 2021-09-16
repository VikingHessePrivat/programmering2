using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace programmering2_miniräknare
{
    public partial class Form1 : Form
    {

        string[] nummer = new string[2];

        float num01;
        float num02;
        float result;
        string operatorTyp;
        string firstChar;


        bool operatorVar = false;
        bool commaUsednum1 = false;
        bool commaUsednum2 = false;


        public Form1()
        {
            InitializeComponent();
            operatorVar = false;
            commaUsednum1 = false;
            commaUsednum2 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "1");

                richTextBox1.Text = nummer[0];
            }else if(operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "1");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "2");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "2");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "3");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "3");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "4");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "4");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "5");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "5");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "6");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "6");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "7");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "7");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "8");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "8");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "9");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "9");

                richTextBox1.Text = nummer[1];
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (operatorVar == false)
            {
                nummer[0] = String.Concat(nummer[0], "0");

                richTextBox1.Text = nummer[0];
            }
            else if (operatorVar == true)
            {
                nummer[1] = String.Concat(nummer[1], "0");

                richTextBox1.Text = nummer[1];
            }
        }

        private void buttoncomma_Click(object sender, EventArgs e)
        {

                if (operatorVar == false & commaUsednum1 == false)
                {
                    nummer[0] = String.Concat(nummer[0], ".");

                    richTextBox1.Text = nummer[0];
                    commaUsednum1 = true;

                }else if(operatorVar == false & commaUsednum1 == true)
                {
                    MessageBox.Show("Kan inte ha dubbla kommatecken", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
                
                if(operatorVar == true & commaUsednum2 == false)
                {
                    nummer[1] = String.Concat(nummer[1], ".");

                    richTextBox1.Text = nummer[1];
                    commaUsednum2 = true;

                }else if(operatorVar == true & commaUsednum2 == true)
                {
                MessageBox.Show("Kan inte ha dubbla kommatecken", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        private void buttonequal_Click(object sender, EventArgs e)
        {
            if (nummer[1] == null || nummer[1].Length == 0)
            {
                MessageBox.Show("Använd först en operator", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(nummer[1] != null || nummer[1].Length != 0)
            {
                num01 = float.Parse(nummer[0], CultureInfo.InvariantCulture.NumberFormat);
                num02 = float.Parse(nummer[1], CultureInfo.InvariantCulture.NumberFormat);

                if(operatorTyp == "plus")
                {
                    result = num01 + num02;
                    richTextBox1.Text = Convert.ToString(result);
                    richTextBox2.Text = richTextBox2.Text + Convert.ToString(num02);
                    nummer[1] = "";
                    nummer[0] = Convert.ToString(result);
                }
                else if(operatorTyp == "minus")
                {
                    result = num01 - num02;
                    richTextBox1.Text = Convert.ToString(result);
                    richTextBox2.Text = richTextBox2.Text + Convert.ToString(num02);
                    nummer[1] = "";
                    nummer[0] = Convert.ToString(result);
                }
                else if(operatorTyp == "multi")
                {
                    result = num01 * num02;
                    richTextBox1.Text = Convert.ToString(result);
                    richTextBox2.Text = richTextBox2.Text + Convert.ToString(num02);
                    nummer[1] = "";
                    nummer[0] = Convert.ToString(result);
                }
                else if(operatorTyp == "divi")
                {
                    result = num01 / num02;

                    if(result == float.PositiveInfinity) {

                        MessageBox.Show("Kan inte dividera med noll", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result != float.PositiveInfinity)
                    {
                        richTextBox1.Text = Convert.ToString(result);
                        richTextBox2.Text = richTextBox2.Text + Convert.ToString(num02);
                        nummer[1] = "";
                        nummer[0] = Convert.ToString(result);
                    }

                }
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nummer[0]) == false){
                operatorVar = true;
                richTextBox1.Text = "";
                richTextBox2.Text = nummer[0] + " + ";
                operatorTyp = "plus";
            }

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            operatorVar = true;
            richTextBox1.Text = "";
            richTextBox2.Text = nummer[0] + " - ";
            operatorTyp = "minus";
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            operatorVar = true;
            richTextBox1.Text = "";
            richTextBox2.Text = nummer[0] + " x ";
            operatorTyp = "multi";
        }

        private void buttondivi_Click(object sender, EventArgs e)
        {
            operatorVar = true;
            richTextBox1.Text = "";
            richTextBox2.Text = nummer[0] + " / ";
            operatorTyp = "divi";
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            if(operatorVar == false)
            {
                nummer[0] = nummer[0].Remove(nummer[0].Length - 1);
                richTextBox1.Text = nummer[0];
            }else if(operatorVar == true)
            {
                nummer[1] = nummer[1].Remove(nummer[1].Length - 1);
                richTextBox1.Text = nummer[1];
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            operatorVar = false;
            nummer[0] = "";
            nummer[1] = "";

            operatorVar = false;
            commaUsednum1 = false;
            commaUsednum2 = false;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void buttonnegative_Click(object sender, EventArgs e)
        { 

            if(operatorVar == false & String.IsNullOrEmpty(nummer[0]) == false) { //den första är full
                firstChar = Convert.ToString(nummer[0][0]);
            }else if(operatorVar == true & String.IsNullOrEmpty(nummer[1]) == false) //om andra är full
            {
                firstChar = Convert.ToString(nummer[1][0]);
            }else if ((operatorVar == true & String.IsNullOrEmpty(nummer[1]) == true) | (operatorVar == false & String.IsNullOrEmpty(nummer[0]) == true))
            {
                MessageBox.Show("Ange ett nummer först", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (operatorVar == false & firstChar != "-" & String.IsNullOrEmpty(nummer[0]) == false)
            {
                nummer[0] = String.Concat("-", nummer[0]);
                richTextBox1.Text = "-" + richTextBox1.Text;

            }
            else if(operatorVar == false & firstChar == "-" & String.IsNullOrEmpty(nummer[0]) == false)
            {
                Debug.WriteLine(nummer[0]);
                nummer[0] = nummer[0].Substring(1);
                Debug.WriteLine(nummer[0]);
                richTextBox1.Text = richTextBox1.Text.Substring(1);
            }
            else if(operatorVar == true & firstChar != "-" & String.IsNullOrEmpty(nummer[1]) == false)
            {
                nummer[1] = nummer[1] = String.Concat("-", nummer[1]);
                richTextBox1.Text = "-" + richTextBox1.Text;
            }
            else if(operatorVar == true & firstChar == "-" & String.IsNullOrEmpty(nummer[1]) == false)
            {
                nummer[1] = nummer[1].Remove(0);
                richTextBox1.Text = richTextBox1.Text.Substring(1);
            }

        }

        private void buttonexp_Click(object sender, EventArgs e)
        {
            operatorVar = true;
            num01 = float.Parse(richTextBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
            richTextBox2.Text = nummer[0] + "^2";

            result = num01 * num01;
            richTextBox1.Text = Convert.ToString(result);

            nummer[1] = "";
            nummer[0] = Convert.ToString(result);

        }
    }
}