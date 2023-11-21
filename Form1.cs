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

// De Jean Felix and Kyle Haddleton, Team: Digi-wise, Sprint Number 1
// Date: 13/11/2023
// Version: 1.0
// Astronomical Processing
// This program simulates reading in neutrino radiation readings and
// is able to sort the data set and search for specific data points.
// It is also able to edit specific data points.
//Inputs for this program are click-based, and typed into a GUI.

//Processes are as described above. To be more specific:
//The search function for this program is using a Binary Search algorithm.
//The sorting function is using a Bubble Sort algorithm.
//The data generation function uses an iterative algorithm.

//All relavent outputs are displayed on the programs GUI.

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
        /* 
         * When the Sort button is pressed this function calls the sortNeutrinos() function.
         */
        private void sortBtn_Click(object sender, EventArgs e)
        {
            sortNeutrinos();
        }
        /*
         * This function uses a bubble sort algorithm to sort the 
         * neutrinosArray (neutrino data set) into ascending order.
         * And then refreshes the GUI's viewList (of the neutrinosArray) 
         * and Updates the status bar.
         */
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
        /*
         * This function itteratively generates random neutrino radiation readings for
         * the neutrinosArray. All values being within the range of 10-99.
         * And then refreshes the GUI's viewList (of the neutrinosArray) 
         * and Updates the status bar.
         */
        private void generateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < neutrinosArray.Length; i++)
            {
                neutrinosArray[i] = rand.Next(11, 99);
            }
            bs.ResetBindings(false);
            Status.Text = "New data generated.";
        }

        private void binarySearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int search = validIntInput();
                sortNeutrinos();
                List<int> neutrinos = neutrinosArray.ToList();
                int idx = neutrinos.BinarySearch(search);
                if (idx >= 0)
                {
                    listBox1.SetSelected(idx, true);
                    Status.Text = "'" + search + "' was found and highlighted. [Index:"+idx+"]";
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
