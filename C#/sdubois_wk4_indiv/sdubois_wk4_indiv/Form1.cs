////////////////////////////////////
//         Scott DuBois           //
//           POS/409              //
//          Wk4 Indiv             //
////////////////////////////////////
//
//Create - A class called "Employee" that will include all the attributes
//of all employees of your organization. Include at least five attributes.
//If you are not currently working, you may use a fictional organization
//or one with which you are familiar.
//
//Add - a second class that inherits from the Employee class and describes
//a subgroup of employees. For example, you may define the class as Managers.
//In the case of city employees, you may define the class as Police Officers.
//Define at least three attributes that are specific to this subclass.
//
//Design, implement, test and debug a C# program that asks the user to enter
//attributes for members of the subclass on a single form. The entries will
//include fields for the attributes of the main Employee class as well as the
//subclass. Include a second form that will display a cumulative list of all 
//the employee data that the user has entered.
//
//References:
//
//www.speakcomputers.com/windows-forms-programming/FormAccess.aspx

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
    public partial class Form1 : Form
    {
        //Combine varable
        string allEmployee;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {

            //Create employee profile
            Employee newEmployee = new Employee();
            Officers newOfficer = new Officers();

            //Get data from Employee class
            GetEmployeeData(newEmployee);

            //Get data from Officers class
            GetOfficersData(newOfficer);

            //Assign fields to global variable
            allEmployee = newEmployee.fname + "  " + newEmployee.lname + "  " + newEmployee.city + "  " + newEmployee.state + "  " +
                          newEmployee.email + "  " + newOfficer.title + "  " +  newOfficer.uname + "  " + newOfficer.pass;

            try
            {
                //Open Streamwriter with amend boolean true
                System.IO.StreamWriter people = new System.IO.StreamWriter("people.txt", true);

                //Write values to file
                people.WriteLine(allEmployee);

                //Give notice that ifo has been written
                MessageBox.Show("Data has been written to file");

                //Close file
                people.Close();
            }

            catch
            {
                MessageBox.Show("Could not write to file");
            }
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        public void btnView_Click(object sender, EventArgs e)
        {
            //Create Form2 instance
            Form2 form2 = new Form2();

            //Create instance of Form2 to be owned by Form1
            this.AddOwnedForm(form2);

            //Open form to view info
            form2.ShowDialog();
        }

        private void GetEmployeeData(Employee emp)
        {
            //Get first name
            emp.fname = txtFirstName.Text;

            //Get last name
            emp.lname = txtLastName.Text;

            //Get city
            emp.city = txtCity.Text;

            //Get state
            emp.state = txtState.Text;

            //Get email
            emp.email = txtEmail.Text;
        }

        private void GetOfficersData(Officers sub)
        {
            //Get title
            sub.title = txtTitle.Text;

            //Get user name
            sub.uname = txtUser.Text;

            //Get password
            sub.pass = txtPass.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all values
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtEmail.Text = "";
            txtTitle.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
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
