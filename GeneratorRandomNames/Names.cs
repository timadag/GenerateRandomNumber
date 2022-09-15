using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeneratorRandomNames
{
    public partial class Names : Form
    {
        NamesParser parser = new NamesParser();
        public Names()
        {
            InitializeComponent();
            GenderPersonСheckBox.SelectedIndex = 0;
            string[] names = null;


            numericUpDown1.Maximum = parser.NamesMans.Length + parser.NamesWomens.Length;
            names = parser.getAllNames((int)numericUpDown1.Value);

            foreach (string name in names)
            {
                NamesList.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NamesList.Items.Clear();

            string[] names = null;
            switch (GenderPersonСheckBox.SelectedIndex)
            {
                case 0:
                    names = parser.getAllNames((int)numericUpDown1.Value);
                    break;
                case 1:
                    names = parser.getManNames((int)numericUpDown1.Value);
                    break;
                case 2:
                    names = parser.getWomenNames((int)numericUpDown1.Value);
                    break;
            }
            foreach (string name in names)
            {
                NamesList.Items.Add(name);
            }

        }

        private void GenderPersonСheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamesList.Items.Clear();

            string[] names = null;
            switch (GenderPersonСheckBox.SelectedIndex)
            {
                case 0:
                    numericUpDown1.Maximum = parser.NamesMans.Length + parser.NamesWomens.Length;
                    names = parser.getAllNames((int)numericUpDown1.Value);
                    break;
                case 1:
                    numericUpDown1.Maximum = parser.NamesMans.Length - 1;
                    names = parser.getManNames((int)numericUpDown1.Value);
                    break;
                case 2:
                    numericUpDown1.Maximum = parser.NamesWomens.Length - 1;
                    names = parser.getWomenNames((int)numericUpDown1.Value);
                    break;
            }
            foreach (string name in names)
            {
                NamesList.Items.Add(name);
            }
        }
    }
}
