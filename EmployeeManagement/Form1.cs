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

        
        private void rbShow3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShow3.Checked == true)
            {
                // For loop to get row count and hide all rows
               for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // *Might work to fix bug* dataGridView1.Rows[i].Visible = true;
                    dataGridView1.Rows[i].Visible = false;

                    // Iterate through rows and make first 3 visible
                    for (int j = 0; j < 3; j++)
                    {
                        dataGridView1.Rows[j].Visible = true;
                    }
                }
            }
        }
        

        
        private void rbShow5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShow5.Checked == true)
            {
                // For loop to get row count and hide all rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // *Might work to fix bug* dataGridView1.Rows[i].Visible = true;
                    dataGridView1.Rows[i].Visible = false;

                    // Iterate through rows and make first 5 visible
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridView1.Rows[j].Visible = true;
                    }
                }
            }
        }
        

        
        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowAll.Checked == true)
            {
                // For loop to get row count and make all rows visible.
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
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
                        if (rbShow3.Checked)
                        {
                            /* This statement might eliminate the checked event
                             * for each of the radio buttons */
                             if (dataGridView1.Rows.Count < 3)
                            {
                                dataGridView1.Rows.Add(
                                    lineDataRow.ElementAt(0),
                                    lineDataRow.ElementAt(1),
                                    lineDataRow.ElementAt(2),
                                    lineDataRow.ElementAt(3),
                                    lineDataRow.ElementAt(4),
                                    lineDataRow.ElementAt(5),
                                    lineDataRow.ElementAt(6),
                                    lineDataRow.ElementAt(7),
                                    lineDataRow.ElementAt(8),
                                    lineDataRow.ElementAt(9)
                                );
                            }
                        }

                        if (rbShow5.Checked)
                        {
                            /* This statement might eliminate the checked event
                             *  for each of the radio buttons */
                             if (dataGridView1.Rows.Count < 5)
                            {
                                dataGridView1.Rows.Add(
                                    lineDataRow.ElementAt(0),
                                    lineDataRow.ElementAt(1),
                                    lineDataRow.ElementAt(2),
                                    lineDataRow.ElementAt(3),
                                    lineDataRow.ElementAt(4),
                                    lineDataRow.ElementAt(5),
                                    lineDataRow.ElementAt(6),
                                    lineDataRow.ElementAt(7),
                                    lineDataRow.ElementAt(8),
                                    lineDataRow.ElementAt(9)
                                );
                            }
                        }

                        if (rbShowAll.Checked)
                        {
                            // Read all data into dataGrid
                            dataGridView1.Rows.Add(
                                lineDataRow.ElementAt(0),
                                lineDataRow.ElementAt(1),
                                lineDataRow.ElementAt(2),
                                lineDataRow.ElementAt(3),
                                lineDataRow.ElementAt(4),
                                lineDataRow.ElementAt(5),
                                lineDataRow.ElementAt(6),
                                lineDataRow.ElementAt(7),
                                lineDataRow.ElementAt(8),
                                lineDataRow.ElementAt(9)
                            );
                        }
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
