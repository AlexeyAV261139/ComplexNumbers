using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplexNumbers complexNumbersAB = new ComplexNumbers(double.Parse(textBoxRealNumA.Text), double.Parse(textBoxRealNumB.Text));
            ComplexNumbers complexNumbersCD = new ComplexNumbers(double.Parse(textBoxSummA.Text), double.Parse(textBoxSummB.Text));
            labelFinal.Text = $"(a + bi) + (c + di) = \n\r= ({complexNumbersAB}) + ({complexNumbersCD}) = " +
                $"{complexNumbersAB.Summ(double.Parse(textBoxSummA.Text), double.Parse(textBoxSummB.Text))}" ;
            label1.Text = $"a + bi = {complexNumbersAB}";
        }

      
    }
}
