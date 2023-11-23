using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// De Jean Felix and Kyle Haddleton, Team: Digi-wise, Sprint Number 2
// Date: 22/11/2023
// Version: 2.0
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

        Random rand; //For randomly generating numbers
        int[] neutrinosArray = new int[24]; //For storing hourly (for 24 hours) of neutrino radiation data.
        BindingSource bs = new BindingSource(); //For GUI's viewList pre-coded functionalities.

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
        /*
         * This function uses a binary search algorithm to search for the same value, typed into the input textbox of the GUI,
         * in the neutrinosArray. It validates the input textbox before performing the search.
         * and Updates the status bar as to whether the search was successful or not.
         */
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
                    Status.Text = "'" + search + "' was found and highlighted. [Index: "+idx+"]";
                }
                else
                {
                    listBox1.ClearSelected();
                    Status.Text = "'" + search + "' was not found.";
                }
            }
            catch(InvalidDataException e1) { }
        }
        /*
         * This function validates the contents of the GUI's textbox. (Whether the contents is an integer).
         * and Updates the status bar as to whether the validation was successful or not.
         * If unsuccessful, the function will also throw an InvalidDataException.
         */
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
        /*
         * This function auto fills (matching with selection) the GUI's input textbox, 
         * whenever a new item/value is selected in the GUI's viewlist. 
         */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
        /*
         * This function validates the contents of the GUI's textbox using the validIntInput().
         * It does nothing (simply catches the InvalidDataException) if the validation fails.
         * Otherwise, it sets selected items value in the viewlist 
         * (same index for neutrinosArray), as the same value shown in the input textbox.
         */
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
        /*
         * This function calculates and displays (in the statistics results textbox) the range of the neutrinosArray.
         * It also displays the min and max values in the neutrinosArray. 
         */
        private void RangeBtn_Click(object sender, EventArgs e)
        {
            int lowest, highest;
            lowest = neutrinosArray[0];
            highest = neutrinosArray[neutrinosArray.Length - 1];

            for (int i = 0; i < neutrinosArray.Length; i++)
            {
                if (neutrinosArray[i] < lowest) {lowest = neutrinosArray[i];}
                if(neutrinosArray[i] > highest) { highest = neutrinosArray[i];}
            }

            //statsBox.AcceptsReturn = true;
            string nL = Environment.NewLine;

            statsBox.Text = "Range: " + (highest - lowest) +nL+
                "Min: " + lowest +nL+
                "Max: " + highest;
        }
        /*
         * This function does a sequential (linear) search of neutrinosArray for the value in the input text box.
         * It will display a message appropriate for the outcome, and will select the item if it was found.
         */
        private void SeqSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int searchTarget = validIntInput();
                int index;
                bool foundTarget = false;
                for (index = 0; (index < neutrinosArray.Length) && !foundTarget;)
                {
                    if (searchTarget == neutrinosArray[index])
                    {
                        foundTarget = true;
                    }
                    else
                    {
                        index++;
                    }
                }

                switch (foundTarget)
                {
                    case true:
                        listBox1.SetSelected(index, true);
                        Status.Text = "'" + searchTarget + "' was found and highlighted. [Index: " + index + "]";
                        break;

                    case false:
                        listBox1.ClearSelected();
                        Status.Text = "'" + searchTarget + "' was not found.";
                        break;
                }
            }
            catch (InvalidDataException e1) { }
        }

        /*
         * This function will find the first mode in the array, disregarding cases in which
         * there is no mode because all values are unique, and will ignore other modes in multi-modal data sets.
         */
        private void ModeBtn_Click(object sender, EventArgs e)
        {
            var elementCount = new Dictionary<int, int>();
            foreach (int element in neutrinosArray)
            {
                if (!elementCount.ContainsKey(element))
                {
                    elementCount[element] = 1;
                }
                else 
                { 
                    elementCount[element]++; 
                }
            }
            int maxCount = elementCount.Values.Max();
            if (maxCount == 1)
            {
                statsBox.Text = "Data has no mode, all values are distinct";
            }
            else
            {
                int mode = elementCount.First(kvp => kvp.Value == maxCount).Key;
                statsBox.Text = $"Mode: {mode} ({elementCount[mode]} occurances)";
            }
        }
    }
}
