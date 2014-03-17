//*************************
//     Scott DuBois
//Wk1 Individual Assignemnt
//        POS409
//*************************
//
//*Design, implement, test and debug C# program
//*that displays a pet's name when a button is clicked.
//
//Create a graphical user interface (GUI) 
//with a button labeled "Pet's name."
//
//When the Pet's name button is clicked, 
//the program will display the name of the pet
//in a label on the form.
//
//Zip the files of the project together and 
//submit the zipped file.
//
//**************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace sdubois_wk1_indiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetPet_Click(object sender, EventArgs e)
        {
            lblPetName.Visible = true;
        }

        private void lblPetName_Click(object sender, EventArgs e)
        {

        }
    }
}
