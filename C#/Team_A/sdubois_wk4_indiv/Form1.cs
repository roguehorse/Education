////////////////////////////////////
//           Team A               //
//           POS/409              //
//             Wk5                //
////////////////////////////////////
//
//Build a database using the attributes of the
//Employees class and the subclass defined in 
//Week Four as your fields. Populate the database
//with at least five employees.
//
//Design, implement, test and debug a C# program
//to access the database and display the entries.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sdubois_wk4_indiv
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        public void btnView_Click(object sender, EventArgs e)
        {
            //Open form to view info
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all values
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            emailTextBox.Text = "";
            titleTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);
            MessageBox.Show("Item Saved");
        }

        private void employeesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }

    class Employee
    {
        //Fields
        string _fname;
        string _lname;
        string _city;
        string _state;
        string _email;

        //Constructor
        public Employee()
        {
            _fname = "";
            _lname = "";
            _city = "";
            _state = "";
            _email = "";
        }

        //First Name properties
        public string fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        //Last Name properties
        public string lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        //City properties
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        //State properties
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        //Email properties
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

    }

    class Officers : Employee
    {
        //Fields
        string _title;
        string _uname;
        string _pass;

        //Constructor
        public Officers()
        {
            _title = "";
            _uname = "";
            _pass = "";
        }

        //Title properties
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        //Title properties
        public string uname
        {
            get { return _uname; }
            set { _uname = value; }
        }

        //Title properties
        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

    }

}
