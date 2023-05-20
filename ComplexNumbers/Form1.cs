using System;
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
            labelFinalDif.Text = $"(a + bi) - (c + di) = \n\r= ({complexNumbersAB} - ({complexNumbersCD}) = " +
                $"{complexNumbersAB.Difference(double.Parse(textBoxSummA.Text),double.Parse(textBoxSummB.Text))}";

            ComplexMulti complexMulti = new ComplexMulti(double.Parse(textBoxRealNumA.Text), double.Parse(textBoxRealNumB.Text));
            labelMulti.Text = $"(a + bi) * (c + di) =\n\r" +
                $"({complexMulti.RealNumberA} + {complexMulti.RealNumberB}i) * ({textBoxSummA.Text} + {textBoxSummB.Text}i) =\n\r" +
                $"{complexMulti.Multiplication(double.Parse(textBoxSummA.Text), double.Parse(textBoxSummB.Text))}";
        }

        
    }
}
