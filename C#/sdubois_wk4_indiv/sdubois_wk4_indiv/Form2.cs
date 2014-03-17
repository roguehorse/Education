using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sdubois_wk4_indiv
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();      
        }

        public void btnGet_Click(object sender, EventArgs e)
        {
            //Assign variable for gathering from file
            string thePeople;

            //Open Streamreader to read from file
            StreamReader getPeople;

            try
            {

                //Assign variable to hold data from file
                getPeople = File.OpenText("people.txt");

                //Loop until the end of the file
                while (!getPeople.EndOfStream)
                {
                    //Assign each line of data from file to variable
                    thePeople = getPeople.ReadLine();

                    //Write each line to the listbox
                    listBox1.Items.Add(thePeople);
                }

                getPeople.Close();

            }

            catch
            {
                MessageBox.Show("Could not read file");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
