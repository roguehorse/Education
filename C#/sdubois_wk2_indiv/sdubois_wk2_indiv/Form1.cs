//******************************
//
//       Scott DuBois
//          POS409
//  Week 2 Individual Project
//
//******************************
//
//Design, implement, test, and debug a C# program
//to simulate the rolling of two dice 100 times,
//and write and read results from a file.
//
//When the user clicks a Write button, the program will write
//the sum of the dice for each roll into a sequential data file.
//After the file is written, the user may click a Read button
//to read the items back in and display the results.
//
//Design a GUI for the program that will be intuitive for a novice user.
//
//***********************************************************************
//References
//
//www.c-sharpcorner.com/UploadFile/mahesh/WorkingwithProgressBarinCSharp11302005045625AM/WorkingwithProgressBarinCSharp.aspx
//
//forum.codecall.net/topic/65434-c-working-with-timers/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sdubois_wk2_indiv
{
    public partial class Form1 : Form
    {
        //Assign global variables
        int vDice1;
        int vDice2;
        int vDiceSum;

        //Array to hold totals;
        const int TOTALS = 100;
        int[] dieTotals = new int[TOTALS];
  
        //Assign roll counter variable
        int rollCounter;

        //Assign roll display counter variable
        int displayCounter;

        //Assign random roll variable
        Random roll = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        //Initiate loop timer on button click
        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Set roll counter to 0
            rollCounter = 0;

            //Enable the timer
            timer1.Enabled = true;

            //Roll the dice every 1/2 second
            timer1.Interval = 500;

            //Start the loop timer
            timer1.Start();

            //Progress bar values
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

        //Loop iterates once for every "tick" of the counter set @ 2 seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Roll the dice
            if (displayCounter == 0)
            {
                //Generate random number for Die 1 and display
                vDice1 = roll.Next(6) + 1;
                txtDie1.Text = vDice1.ToString();
            }

            if (displayCounter == 1)
            {
                //Generate random number for Die 2 and display
                vDice2 = roll.Next(6) + 1;
                txtDie2.Text = vDice2.ToString();
            }

            if (displayCounter == 2)
            {
                //Sum value of Die1 to Die2 and display
                vDiceSum = vDice1 + vDice2;
                txtTotal.Text = vDiceSum.ToString();
                dieTotals[rollCounter] = vDiceSum;

                //Add step to progress bar
                progressBar1.Value++;
            }

            if (displayCounter == 4)
            {
                //Clear the roll displays
                txtDie1.Text = "";
                txtDie2.Text = "";
                txtTotal.Text = "";

                //Reset the roll displays for next iteration
                displayCounter = -1;

                //Add one to the roll counter
                rollCounter++;

                if (rollCounter >= 100)
                {
                    //Stop the iteration timer
                    timer1.Stop();

                    try
                    {
                        StreamWriter storeTotals;
                        storeTotals = File.CreateText("saved.txt");
                        for (int i = 0; i < rollCounter; i++)
                        {
                            storeTotals.WriteLine("     " + dieTotals[i] + " = Roll number " + (i+1));
                        }

                        storeTotals.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Could not write to file!");
                    }

                    //Show message that all the rolls have been completed
                    MessageBox.Show("The bones are done rolling and have been written to a file.");
                }
            }

            //Add 1 to the display counter
            displayCounter++;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Variable to read from file
            string dieTotals;

            try
            {
                //Open file and read each line
                StreamReader readTotals;
                readTotals = File.OpenText("saved.txt");

                //Loop to read each line from file
                while (!readTotals.EndOfStream)
                {
                    //Read line from file
                    dieTotals = readTotals.ReadLine();

                    //Write lines to listbox
                    listBox1.Items.Add(dieTotals);
                }

                //Close the file
                readTotals.Close();
            }

            catch
            {
                MessageBox.Show("Can't open the file");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
