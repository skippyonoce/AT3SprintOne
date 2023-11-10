using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT3SprintOne
{
    public partial class Form1 : Form
    {

        Random rand;
        int[] neutrinosArray = new int[24];
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = neutrinosArray;
            listBox1.DataSource = bs;
            rand = new Random();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            sortNeutrinos();
        }
        private void sortNeutrinos()
        {
            int temp;
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < neutrinosArray.Length - 1; i++)
                {
                    if (neutrinosArray[i] > neutrinosArray[i + 1])
                    {
                        sorted = false;
                        temp = neutrinosArray[i + 1];
                        neutrinosArray[i + 1] = neutrinosArray[i];
                        neutrinosArray[i] = temp;
                    }
                }
            }
            bs.ResetBindings(false);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < neutrinosArray.Length; i++)
            {
                neutrinosArray[i] = rand.Next(11, 99);
            }
            bs.ResetBindings(false);
        }
        private void binarySearchBtn_Click(object sender, EventArgs e)
        {
            int search = int.Parse(textBox1.Text);

        }

        private int validIntInput()
        {
            int validInt;
            if (int.TryParse(textBox1.Text, out validInt))
            {
                //validInt = int.Parse(textBox1.Text);
            }
            else
            {
                Status.Text = "Error: Input is not a valid integer.";
            }

            return validInt;
        }
    }
}
