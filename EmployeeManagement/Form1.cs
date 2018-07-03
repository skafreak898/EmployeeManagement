 //Brandon Walker
 //POS/409
 //Week 3 Individual Employee Management
 //Instructor: John Becton
 //Due Date: June 25, 2018
 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        // *** These are my member variables ***
        List<Employee> employees = new List<Employee>(); // Create a typed list of contacts
        Employee currentEmployee; // Create a single Employee instance
        int currentPosition;      // Used to hold current position

        public Form1()
        {
            InitializeComponent();
        }


        // *** This section is for my event handlers ***


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Exits Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Only shows 3 records
        private void rbShow3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShow3.Checked == true)
            {
                IfShow3();
            }
        }

        // Only Shows 5 records
        private void rbShow5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShow5.Checked == true)
            {
                IfShow5();
            }
        }

        // Shows all records
        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowAll.Checked == true)
            {
                IfShowAll();
            }
        }

        // Loads file
        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        // Loads json file
        private void btnProcessJson_Click(object sender, EventArgs e)
        {
            LoadJson();
        }

        // Searches contacts
        private void tsbFindContact_Click(object sender, EventArgs e)
        {
            LoadFile();

            // Show if nothing entered in search bar
            if (String.IsNullOrEmpty(tspSearchTerm.Text))
            {
                MessageBox.Show("Gotta enter something");
                return;
            }

            // Start if statement for combo box (cboSearch) first name
            if (cboSearch.SelectedText == "First Name")
            {
                IfFirstName();
            }

            // Start if statement for combo box (cboSearch) last name
            if (cboSearch.SelectedText == "Last Name")
            {
                IfLastName();
            }

            
            //Start if statement for combo box (cboSearch) Street address
            if (cboSearch.SelectedText == "Street Address")
            {
                IfAddress();
            }
        }

        // Scroll through previous contacts
        private void tsbNavBack_Click(object sender, EventArgs e)
        {
            // Dont exceed the left limit
            if (currentPosition != 0)
            {
                currentPosition--;
                currentEmployee = employees[currentPosition];
                LoadCurrentEmployee();
                
            }
        }

        // Scroll through next contacts
        private void tsbNavForward_Click(object sender, EventArgs e)
        {
            // dont exceed the right limit
            if (currentPosition < employees.Count - 1)
            {
                currentPosition++;
                currentEmployee = employees[currentPosition];
                LoadCurrentEmployee();
            }
        }

        
        // *** This section is simply for cleaning up my code ***

        
        // For loop to get row count and hide all rows for showing 3 records
        private void IfShow3()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Initially hide each row
                dataGridView1.Rows[i].Visible = false;

                // Iterate through rows and make first 3 visible
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[j].Visible = true;
                }
            }
        }

        // For loop to get row count and hide all rows for showing 5 records
        private void IfShow5()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Initially hide each row
                dataGridView1.Rows[i].Visible = false;

                // Iterate through rows and make first 5 visible
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[j].Visible = true;
                }
            }
        }

        // For loop to get row count and make all rows visible.
        private void IfShowAll()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }
            
        // If try/catch statement for searching first name
        private void IfFirstName()
        {
            try
            {
                // Using LINQ to objects query to get first matchin first name
                var foundEmployee =
                    (from Employee in employees
                     where Employee.FirstName == tspSearchTerm.Text
                     select Employee).FirstOrDefault<Employee>();

                // set the current employee to the found employee for first name
                currentEmployee = foundEmployee;
                currentPosition = employees.IndexOf(currentEmployee);

                //Update the display by loading the found employee
                LoadCurrentEmployee();

                //Clear the search term textbox and return
                tspSearchTerm.Text = string.Empty;
                return;
            }

            catch
            {
                MessageBox.Show("No results found");
            }
        }

        // If try/catch statement for searching last name
        private void IfLastName()
        {
            try
            {
                // Using LINQ to objects query to get first matching last name
                var foundEmployee =
                    (from Employee in employees
                     where Employee.LastName == tspSearchTerm.Text
                     select Employee).FirstOrDefault<Employee>();

                // set the current employee to the found employee for last name
                currentEmployee = foundEmployee;
                currentPosition = employees.IndexOf(currentEmployee);

                // Update the display by loading the found employee
                LoadCurrentEmployee();

                //Clear the search term textbox and return
                tspSearchTerm.Text = string.Empty;
                return;
            }

            catch
            {
                MessageBox.Show("No results found");
            }
        }

        // If try/catch statement for searching street address
        private void IfAddress()
        {
            try
            {
                // Using LINQ to objects query to get first matching street address
                var foundEmployee =
                    (from Employee in employees
                     where Employee.StreetAddress == tspSearchTerm.Text
                     select Employee).FirstOrDefault<Employee>();

                // set the current employee to the found employee for street address
                currentEmployee = foundEmployee;
                currentPosition = employees.IndexOf(currentEmployee);

                // update the display by loading the found employee
                LoadCurrentEmployee();

                // Clear the search term textbox and return
                tspSearchTerm.Text = string.Empty;
                return;
            }

            catch
            {
                MessageBox.Show("No results found");
            }
        }

        // Clears all text fields
        private void ClearScreen()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStreetAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip.Text = string.Empty;
            //Rest goes here
        }

        // Populate Text Fields with Employee Data
        private void LoadCurrentEmployee()
        {
            txtFirstName.Text = currentEmployee.FirstName;
            txtLastName.Text = currentEmployee.LastName;
            txtStreetAddress.Text = currentEmployee.StreetAddress;
            txtCity.Text = currentEmployee.City;
            txtState.Text = currentEmployee.State;
            txtZip.Text = currentEmployee.Zip;

            // Rest goes here
        }

        // Loads file and adds information into objects
        private void LoadFile()
        {
            // Load File Here
            string fileToRead = "";

            // Locate and load target file
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            fileToRead = file.FileName;

            // If file exists
            if (file.CheckFileExists)
            {
                // Try/Catch statement created to catch cancelled manual file selection
                try
                {
                    // Read file data
                    StreamReader sr = new StreamReader(fileToRead);

                    // Read the whole file into a single string
                    string allData = sr.ReadToEnd();

                    // Rows of strings split into array
                    string[] stringArray = allData.Split
                        (new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                    // Create data collection
                    List<Employee> employeeData = new List<Employee>();

                    // Loop through the array of strings to make employeeData
                    foreach (string line in stringArray)
                    {
                        // Seperate each row by , or | into an indexed array
                        var lineDataRow = line.Split(',', '|');

                        // Create new object called employee for each row
                        try
                        {
                            // Create new object
                            Employee emp = new Employee();
                            emp.Developer = new Developer();
                            emp.Manager = new Manager();

                            // Assign the data to the employee object from the array by index
                            emp.FirstName = lineDataRow.ElementAt(0);
                            emp.LastName = lineDataRow.ElementAt(1);
                            emp.StreetAddress = lineDataRow.ElementAt(2);
                            emp.City = lineDataRow.ElementAt(3);
                            emp.State = lineDataRow.ElementAt(4);
                            emp.Zip = lineDataRow.ElementAt(5);
                            // *****Developer type should only show IF employee is a developer*****
                            // *****Cost center only for managers, otherwise display 0*****
                            emp.Developer.DeveloperType = lineDataRow.ElementAt(6);
                            emp.Manager.CostCenter = lineDataRow.ElementAt(7);
                            emp.Developer.Supervisor = lineDataRow.ElementAt(8);
                            emp.Developer.TaxType = lineDataRow.ElementAt(9);

                            // With each pass, add new employee record to employeeData and employees list
                            employeeData.Add(emp);
                            employees.Add(emp);


                            // Add data to DGV
                            dataGridView1.Rows.Add(lineDataRow);

                        }
                        catch (Exception)
                        {
                            // Dump bad data
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Cancelled");
                }
            }
        }

        // Loads json file and adds information into objects
        public void LoadJson()
        {
            // Read json file
            using (StreamReader r = new StreamReader ("data.json"))
            {
                try
                {
                    // Read whole file into variable
                    var json = r.ReadToEnd();

                    // Create data collection
                    List<Employee> employeeDataJson = JsonConvert.DeserializeObject<List<Employee>>(json);

                    // Delete current columns on DGV
                    dataGridView1.Columns.Remove("FirstNameCol");
                    dataGridView1.Columns.Remove("LastNameCol");
                    dataGridView1.Columns.Remove("AddressCol");
                    dataGridView1.Columns.Remove("CityCol");
                    dataGridView1.Columns.Remove("StateCol");
                    dataGridView1.Columns.Remove("ZipCol");
                    dataGridView1.Columns.Remove("EmployeeTypeCol");
                    dataGridView1.Columns.Remove("DevTypeCol");
                    dataGridView1.Columns.Remove("CostCenterCol");
                    dataGridView1.Columns.Remove("SupervisorCol");
                    dataGridView1.Columns.Remove("TaxTypeCol");

                    
                    var newdata = new List<Employee>(employeeDataJson);

                    // Add data to DGV
                    dataGridView1.DataSource = newdata;
                    
                }
                catch
                {
                    MessageBox.Show("Something went horribly horribly WRRRONNNGGGGG");
                }

            }
        }

        // Line to Debug
        string randomStringForDebug = "";

    }
}


