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
            if (double.TryParse(textBoxRealNumA.Text, out double numA) & double.TryParse(textBoxRealNumB.Text, out double numB) &
               double.TryParse(textBoxSummA.Text, out double numC) & double.TryParse(textBoxSummB.Text, out double numD))
            {
                ComplexNumbers complexNumbersAB = new ComplexNumbers(numA, numB);
                ComplexNumbers complexNumbersCD = new ComplexNumbers(numC, numD);
                labelAB.Text = $"a + bi = {complexNumbersAB}";
                labelCD.Text = $"c + di = {complexNumbersCD}";


                labelFinal.Text = $"(a + bi) + (c + di) = \n\r= ({complexNumbersAB}) + ({complexNumbersCD}) = " +
                    $"{complexNumbersAB.Summ(numC, numD)}";

                labelFinalDif.Text = $"(a + bi) - (c + di) = \n\r= ({complexNumbersAB} - ({complexNumbersCD}) = " +
                    $"{complexNumbersAB.Difference(numC, numD)}";

                ComplexMulti complexMulti = new ComplexMulti (numA, numB);
                labelMulti.Text = $"(a + bi) * (c + di) =\n\r" +
                    $"({complexMulti.RealNumberA} + {complexMulti.RealNumberB}i) * ({numC} + {numD}i) =\n\r" +
                    $"{complexMulti.Multiplication(numC, numD)}";
            }
            else { MessageBox.Show("Введены некорректные данные"); }
        }

        
    }
}
