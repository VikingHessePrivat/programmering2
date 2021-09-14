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

namespace Programmering2_arrayuppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try { 
                    string x = inputSiffror.Text;
                    string[] stringArray = x.Split(' ');
                    int[] number = Array.ConvertAll(stringArray, int.Parse);
                    int target = Convert.ToInt32(inputTarget.Text);
                    bool svar = false;


                    for (int i = 0; i < number.Length; i++)
                    {

                        for (int j = 0; j < number.Length; j++)
                        {

                            if (number[i] + number[j] == target)
                            {
                                outputSvar.Text = $"{number[i]} och {number[j]}";
                                svar = true;
                            }

                        }

                        if (svar == true)
                        {
                            break;
                        }
                    }

                    //om man ändrar siffrorna och det inte finns två som tillsammans blir target
                    if (svar == false)
                    {
                        outputSvar.Text = $"Finns inte två siffror som tillsammans blir {target}";
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ange siffror i nummerform", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
