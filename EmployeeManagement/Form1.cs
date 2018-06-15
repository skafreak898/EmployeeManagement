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
    }
}
