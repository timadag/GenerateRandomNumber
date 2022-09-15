using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateRandomNumber
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateNumber_Click(object sender, EventArgs e)
        {

            int count = (int)UpperBorder.Value - (int)LowerBorder.Value + 1;
            if (LowerBorder.Value > UpperBorder.Value)
                (LowerBorder.Value, UpperBorder.Value) = (UpperBorder.Value, LowerBorder.Value);

            if (countNumbers.Value <= count)
            {
                InvalidNumbers.Text = "";

                int[] randomNumbers = ExcludeNumbers.Checked
                    ? Generator.UniqueGenerateRandom((int)LowerBorder.Value, (int)UpperBorder.Value, (int)countNumbers.Value)
                    : Generator.GenerateRandom((int)LowerBorder.Value, (int)UpperBorder.Value, (int)countNumbers.Value);

                if (OrderNumbers.Checked)
                    Array.Sort(randomNumbers);

                Numbers.Text = string.Join(" ", randomNumbers);
            }
            else
            {
                InvalidNumbers.Text = "Количество должно быть меньше или равным " + count;
            }
        }
    }
}


