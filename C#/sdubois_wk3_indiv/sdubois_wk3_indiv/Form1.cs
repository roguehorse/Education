//******************************
//
//       Scott DuBois
//          POS409
//  Week 3 Individual Project
//
//******************************
//Option B
//
//Design, implement, test, and debug a C# program to
//show the frequencies of the sum of two dice for 100 rolls.
//The program will read the file you created in the dice
//simulation in Week Two.
//
//Include the following:
//Declare an array that represents the possible results of throws of two dice.
//For each entry in the file, increment the element of the array corresponding to that result
//Last, display the frequency count for that simulation.
//
//
//***********************************************************************
//References
//
//www.c-sharpcorner.com/UploadFile/mahesh/WorkingwithProgressBarinCSharp11302005045625AM/WorkingwithProgressBarinCSharp.aspx
//
//forum.codecall.net/topic/65434-c-working-with-timers/
//
//www.dotnetperls.com/string-length


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
        int bigTotal;

        //Array to hold totals;
        const int TOTALS = 100;
        int[] dieTotals = new int[TOTALS];
  
        //Assign roll counter variable
        int rollCounter;

        //Assign roll display counter variable
        int displayCounter;

        //Assign random roll variable
        Random roll = new Random();

        //Convert totals value to string to count string length
        string[] totalConvert = new string[TOTALS];

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

            //Roll the dice every 1/4 second
            timer1.Interval = 250;

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

            if (displayCounter == 3)
            {
                //Sum value of Die1 to Die2 and display
                vDiceSum = vDice1 + vDice2;
                bigTotal = bigTotal + vDiceSum;
                txtTotal.Text = vDiceSum.ToString();

                //Add dice sum value to int array with iteration counter
                dieTotals[rollCounter] = vDiceSum;

                //Convert int sum value to string for formatting
                totalConvert[rollCounter] = vDiceSum.ToString();

                //Add step to progress bar
                progressBar1.Value++;
            }

            if (displayCounter == 6)
            {
                //Clear the roll displays
                txtDie1.Text = "";
                txtDie2.Text = "";
                txtTotal.Text = "";

                //Variables to count number of each total rolled
                int ones = 0;
                int twos = 0;
                int threes = 0;
                int fours = 0;
                int fives = 0;
                int sixs = 0;
                int sevens = 0;
                int eights = 0;
                int nines = 0;
                int tens = 0;
                int elevens = 0;
                int twelves = 0;

                //Reset the roll displays for next iteration
                displayCounter = -1;

                //Add one to the roll counter
                rollCounter++;

                //Stop process once MAX value 100 has been reached
                if (rollCounter >= 100)
                {
                    //Stop the iteration timer
                    timer1.Stop();

                    //Try writing to the files
                    try
                    {
                        //Create file to write each roll total to
                        StreamWriter storeTotals;
                        storeTotals = File.CreateText("saved.txt");

                        //Create file to write frequency sums to
                        StreamWriter ofEach;
                        ofEach = File.CreateText("eachcounts.txt");

                        //Loop to write objects from array to file
                        for (int i = 0; i < rollCounter; i++)

                            //Reads string length of stored values to format and make look "pretty"
                            if (totalConvert[i].Length < 2)
                            {
                                //Arguments determine value in array index during each iteration
                                //and adds one to associated variable depending on value read
                                if (dieTotals[i] == 1)
                                {
                                    ones++;
                                }

                                if (dieTotals[i] == 2)
                                {
                                    twos++;
                                }

                                if (dieTotals[i] == 3)
                                {
                                    threes++;
                                }

                                if (dieTotals[i] == 4)
                                {
                                    fours++;
                                }

                                if (dieTotals[i] == 5)
                                {
                                    fives++;
                                }

                                if (dieTotals[i] == 6)
                                {
                                    sixs++;
                                }

                                if (dieTotals[i] == 7)
                                {
                                    sevens++;
                                }

                                if (dieTotals[i] == 8)
                                {
                                    eights++;
                                }

                                if (dieTotals[i] == 9)
                                {
                                    nines++;
                                }

                                //If total is 9 or less write this
                                storeTotals.WriteLine("      " + dieTotals[i] + " = Roll number " + (i + 1));
                            }

                            else
                            {
                                //Die total values that have > 2 characters
                                if (dieTotals[i] == 10)
                                {
                                    tens++;
                                }

                                if (dieTotals[i] == 11)
                                {
                                    elevens++;
                                }

                                if (dieTotals[i] == 12)
                                {
                                    twelves++;
                                }

                                //If total is 10 or more write this for correct formatting
                                storeTotals.WriteLine("    " + dieTotals[i] + " = Roll number " + (i + 1));
                            }

                        //Write the stored values for each variable based on the 
                        //value that was rolled
                        ofEach.WriteLine("     2's rolled = " + twos);
                        ofEach.WriteLine("     3's rolled = " + threes);
                        ofEach.WriteLine("     4's rolled = " + fours);
                        ofEach.WriteLine("     5's rolled = " + fives);
                        ofEach.WriteLine("     6's rolled = " + sixs);
                        ofEach.WriteLine("     7's rolled = " + sevens);
                        ofEach.WriteLine("     8's rolled = " + eights);
                        ofEach.WriteLine("     9's rolled = " + nines);
                        ofEach.WriteLine("   10's rolled = " + tens);
                        ofEach.WriteLine("   11's rolled = " + elevens);
                        ofEach.WriteLine("   12's rolled = " + twelves);

                        //Close the text files
                        storeTotals.Close();
                        ofEach.Close();
                    }

                    //If file could not be created for writing
                    catch
                    {
                        MessageBox.Show("Could not write to file!");
                    }

                    //Show message that all the rolls have been completed
                    MessageBox.Show("The bones are done rolling and the values have been written.");
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
            //Variables to read from file
            string dieTotals;
            string ofEach;

            //Try opening and reading individual rolls file
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

            //If file can't be opened for reading
            catch
            {
                MessageBox.Show("Can't open the file");
            }

            //Try opening and reading sum of rolls file
            try
            {
                //Open file and read each line
                StreamReader readEach;
                readEach = File.OpenText("eachcounts.txt");

                //Loop to read each line from file
                while (!readEach.EndOfStream)
                {
                    //Read line from file
                    ofEach = readEach.ReadLine();

                    //Write lines to listbox
                    lstFrequency.Items.Add(ofEach);
                }
            }

            //If file can't be opened for reading 
            catch
            {
                MessageBox.Show("Can't open the file");
            }

            //Show the results of all sums rolled
            txtBigTotal.Text = bigTotal.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBigTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
