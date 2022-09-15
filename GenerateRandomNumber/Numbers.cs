using System;
using System.Windows.Forms;

namespace GenerateRandomNumber
{
    public partial class Numbers : Form
    {
        public Numbers()
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
                    ? NumberGenerator.UniqueGenerateRandom((int)LowerBorder.Value, 
                                                     (int)UpperBorder.Value, 
                                                     (int)countNumbers.Value)
                    : NumberGenerator.GenerateRandom((int)LowerBorder.Value, 
                                               (int)UpperBorder.Value, 
                                               (int)countNumbers.Value);

                if (OrderNumbers.Checked)
                    Array.Sort(randomNumbers);

                LabelNumbers.Text = string.Join(" ", randomNumbers);
            }
            else
            {
                InvalidNumbers.Text = "Количество должно быть меньше или равным " + count;
            }
        }
    }
}


