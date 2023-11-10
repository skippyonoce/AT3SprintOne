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
            Status.Text = "Neutrino data sorted in ascending order.";
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
            try
            {
                int search = validIntInput();
                sortNeutrinos();
                List<int> neutrinos = neutrinosArray.ToList();
                int idx = neutrinos.BinarySearch(search);
                if (idx > 0)
                {
                    listBox1.SetSelected(idx, true);
                    Status.Text = "'" + search + "' was found and highlighted.";
                }
                else
                {
                    listBox1.ClearSelected();
                    Status.Text = "'" + search + "' was not be found.";
                }
            }
            catch(InvalidDataException e1) { }
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
                Status.Text = "Error: '"+textBox1.Text+"' is not a valid integer.";
                throw new InvalidDataException("Input is not a valid integer.");
            }

            return validInt;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int value = validIntInput();
                int preValue = neutrinosArray[listBox1.SelectedIndex];
                neutrinosArray[listBox1.SelectedIndex] = value;
                Status.Text = "'"+preValue+"' changed to '"+value+"'";
                bs.ResetBindings(false);
            }
            catch(InvalidDataException e1) { }
        }
    }
}
