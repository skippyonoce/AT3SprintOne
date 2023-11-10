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

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < neutrinosArray.Length - 1; i++)
            {
                neutrinosArray[i] = rand.Next(100);
            }
            bs.ResetBindings(false);
        }
    }
}
