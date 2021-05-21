using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotterNumberGenerator
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int max = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //6 variable numbers
            int num1 = randGen.Next(1, max);
            int num2;
            int num3;
            int num4;
            int num5;
            int num6;

            //random generate 6 different numbers, 1-49 ("max" 50)
            do
            {
                num2 = randGen.Next(1, max);
            }
            while (num2 == num1);
            do
            {
                num3 = randGen.Next(1, max);
            }
            while (num3 == num1 || num3 == num2);
            do
            {
                num4 = randGen.Next(1, max);
            }
            while (num4 == num1 || num4 == num2 || num4 == num3);
            do
            {
                num5 = randGen.Next(1, max);
            }
            while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4);
            do
            {
                num6 = randGen.Next(1, max);
            }
            while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5);

            numberOutput.Text = $"{num1} {num2} {num3} {num4} {num5} {num6}";
        }
    }
}
