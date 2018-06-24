 //Brandon Walker
 //POS/409
 //Week 2 Individual Employee Management
 //Instructor: John Becton
 //Due Date: June 18, 2018
 

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

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>(); // Create a typed list of contacts
        Employee currentEmployee; // Create a single Employee instance
        int currentPosition;      // Used to hold current position

        public Form1()
        {
            InitializeComponent();
        }

        // Exit Code
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // When show 3 is checked, only show 3 rows
        private void rbShow3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShow3.Checked == true)
            {
                // For loop to get row count and hide all rows
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
        }

        // When show 5 is checked, only show 5 rows
        private void rbShow5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShow5.Checked == true)
            {
                // For loop to get row count and hide all rows
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
        }

        // When show all is checked, show everything
        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowAll.Checked == true)
            {
                // For loop to get rown count and make all rows visible.
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void tsbFindContact_Click(object sender, EventArgs e)
        {
            LoadFile();

            // Show if nothing entered in search bar
            if (String.IsNullOrEmpty(tspSearchTerm.Text))
            {
                MessageBox.Show("Gotta enter something");
                return;
            }

            try
            {
                // Using LINQ to objects query to get first matching first name
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
                MessageBox.Show("No Results Found");
            }
        }

        private void ClearScreen()
        {
            // Clears all text fields
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStreetAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip.Text = string.Empty;
            //Rest goes here
        }

        private void LoadCurrentEmployee()
        {
            // Populate Text Fields with Employee Data
            txtFirstName.Text = currentEmployee.FirstName;
            txtLastName.Text = currentEmployee.LastName;
            txtStreetAddress.Text = currentEmployee.StreetAddress;
            txtCity.Text = currentEmployee.City;
            txtState.Text = currentEmployee.State;
            txtZip.Text = currentEmployee.Zip;
        }

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
                // Read file data
                StreamReader sr = new StreamReader(fileToRead);

                // Read the whole file into a single string
                string allData = sr.ReadToEnd();

                // Rows of strings split into array
                string[] stringArray = allData.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

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
        }

        // Line to Debug
        string randomStringForDebug = "";
    }
}


