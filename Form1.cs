using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT3SprintOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] neutrinosArray = new int[24];

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void binarySearchBtn_Click(object sender, EventArgs e)
        {
            int search = validIntInput();
            sortNeutrinos();
            List<int> neutrinos = neutrinosArray.ToList();
            int idx = neutrinos.BinarySearch(search);
            listBox1.SetSelected(idx, true);
        }

        private int validIntInput()
        {
            int validInt;
            if (int.TryParse(textBox1.Text, out validInt)){
                //validInt = int.Parse(textBox1.Text);
            }
            else{
                Status.Text = "Error: Input is not a valid integer.";
            }           
            
            return validInt;
        }

    }
}
