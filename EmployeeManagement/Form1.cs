 //Brandon Walker
 //POS/409
 //Week 1 Individual Employee Management
 //Instructor: John Becton
 //Due Date: June 11, 2018
 

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

        // Outdated/Removed
        private void rbShow3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        // Outdated/Removed
        private void rbShow5_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        // Outdated/Removed
        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
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
                        emp.Developer.DeveloperType = lineDataRow.ElementAt(6);
                        emp.Manager.CostCenter = lineDataRow.ElementAt(7);
                        emp.Developer.Supervisor = lineDataRow.ElementAt(8);
                        emp.Developer.TaxType = lineDataRow.ElementAt(9);

                        // With each pass, add new employee record to employeeData list
                        employeeData.Add(emp);
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
