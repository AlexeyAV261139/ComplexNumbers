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
            ComplexNumbers complexNumbers = new ComplexNumbers(double.Parse(textBoxRealNumA.Text), double.Parse(textBoxRealNumB.Text));
            labelFinal.Text = complexNumbers.Summ(double.Parse(textBoxSummA.Text), double.Parse(textBoxSummB.Text));
            label1.Text = complexNumbers.ToString();
        }
    }
}
