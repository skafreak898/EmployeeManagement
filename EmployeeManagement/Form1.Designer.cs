namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbShow3 = new System.Windows.Forms.RadioButton();
            this.rbShow5 = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCenterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupervisorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspSearchTerm = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFindContact = new System.Windows.Forms.ToolStripButton();
            this.tsbNavBack = new System.Windows.Forms.ToolStripButton();
            this.tsbNavForward = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load/Process Employee File";
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Location = new System.Drawing.Point(157, 4);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(75, 23);
            this.btnProcessFile.TabIndex = 1;
            this.btnProcessFile.Text = "Process File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbShow3
            // 
            this.rbShow3.AutoSize = true;
            this.rbShow3.Checked = true;
            this.rbShow3.Location = new System.Drawing.Point(15, 289);
            this.rbShow3.Name = "rbShow3";
            this.rbShow3.Size = new System.Drawing.Size(104, 17);
            this.rbShow3.TabIndex = 3;
            this.rbShow3.TabStop = true;
            this.rbShow3.Text = "Show 3 Records";
            this.rbShow3.UseVisualStyleBackColor = true;
            this.rbShow3.CheckedChanged += new System.EventHandler(this.rbShow3_CheckedChanged);
            // 
            // rbShow5
            // 
            this.rbShow5.AutoSize = true;
            this.rbShow5.Location = new System.Drawing.Point(125, 289);
            this.rbShow5.Name = "rbShow5";
            this.rbShow5.Size = new System.Drawing.Size(104, 17);
            this.rbShow5.TabIndex = 4;
            this.rbShow5.Text = "Show 5 Records";
            this.rbShow5.UseVisualStyleBackColor = true;
            this.rbShow5.CheckedChanged += new System.EventHandler(this.rbShow5_CheckedChanged);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(235, 289);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(109, 17);
            this.rbShowAll.TabIndex = 5;
            this.rbShowAll.Text = "Show All Records";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.rbShowAll_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameCol,
            this.LastNameCol,
            this.AddressCol,
            this.CityCol,
            this.StateCol,
            this.ZipCol,
            this.EmployeeTypeCol,
            this.DevTypeCol,
            this.CostCenterCol,
            this.SupervisorCol,
            this.TaxTypeCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 236);
            this.dataGridView1.TabIndex = 6;
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.HeaderText = "First Name";
            this.FirstNameCol.Name = "FirstNameCol";
            this.FirstNameCol.ReadOnly = true;
            // 
            // LastNameCol
            // 
            this.LastNameCol.HeaderText = "Last Name";
            this.LastNameCol.Name = "LastNameCol";
            this.LastNameCol.ReadOnly = true;
            // 
            // AddressCol
            // 
            this.AddressCol.HeaderText = "Address";
            this.AddressCol.Name = "AddressCol";
            this.AddressCol.ReadOnly = true;
            // 
            // CityCol
            // 
            this.CityCol.HeaderText = "City";
            this.CityCol.Name = "CityCol";
            this.CityCol.ReadOnly = true;
            // 
            // StateCol
            // 
            this.StateCol.HeaderText = "State";
            this.StateCol.Name = "StateCol";
            this.StateCol.ReadOnly = true;
            // 
            // ZipCol
            // 
            this.ZipCol.HeaderText = "Zip";
            this.ZipCol.Name = "ZipCol";
            this.ZipCol.ReadOnly = true;
            // 
            // EmployeeTypeCol
            // 
            this.EmployeeTypeCol.HeaderText = "Employee Type";
            this.EmployeeTypeCol.Name = "EmployeeTypeCol";
            this.EmployeeTypeCol.ReadOnly = true;
            // 
            // DevTypeCol
            // 
            this.DevTypeCol.HeaderText = "Dev Type";
            this.DevTypeCol.Name = "DevTypeCol";
            this.DevTypeCol.ReadOnly = true;
            // 
            // CostCenterCol
            // 
            this.CostCenterCol.HeaderText = "Cost Center";
            this.CostCenterCol.Name = "CostCenterCol";
            this.CostCenterCol.ReadOnly = true;
            // 
            // SupervisorCol
            // 
            this.SupervisorCol.HeaderText = "Supervisor";
            this.SupervisorCol.Name = "SupervisorCol";
            this.SupervisorCol.ReadOnly = true;
            // 
            // TaxTypeCol
            // 
            this.TaxTypeCol.HeaderText = "Tax Type";
            this.TaxTypeCol.Name = "TaxTypeCol";
            this.TaxTypeCol.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSearchTerm,
            this.tsbFindContact,
            this.tsbNavBack,
            this.tsbNavForward});
            this.toolStrip1.Location = new System.Drawing.Point(254, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(183, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspSearchTerm
            // 
            this.tspSearchTerm.Name = "tspSearchTerm";
            this.tspSearchTerm.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbFindContact
            // 
            this.tsbFindContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindContact.Image = ((System.Drawing.Image)(resources.GetObject("tsbFindContact.Image")));
            this.tsbFindContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindContact.Name = "tsbFindContact";
            this.tsbFindContact.Size = new System.Drawing.Size(23, 22);
            this.tsbFindContact.Text = "Find Contact By Name";
            this.tsbFindContact.Click += new System.EventHandler(this.tsbFindContact_Click);
            // 
            // tsbNavBack
            // 
            this.tsbNavBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavBack.Image")));
            this.tsbNavBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavBack.Name = "tsbNavBack";
            this.tsbNavBack.Size = new System.Drawing.Size(23, 22);
            this.tsbNavBack.Text = "toolStripButton1";
            // 
            // tsbNavForward
            // 
            this.tsbNavForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavForward.Image")));
            this.tsbNavForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavForward.Name = "tsbNavForward";
            this.tsbNavForward.Size = new System.Drawing.Size(23, 22);
            this.tsbNavForward.Text = "toolStripButton2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Zip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Employee Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dev Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cost Center";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Supervisor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tax Type";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(233, 20);
            this.txtFirstName.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(75, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(233, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(75, 113);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(233, 20);
            this.txtStreetAddress.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(75, 143);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(233, 20);
            this.txtCity.TabIndex = 22;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(75, 173);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(74, 20);
            this.txtState.TabIndex = 23;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(192, 173);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(116, 20);
            this.txtZip.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(428, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(233, 20);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(428, 80);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(233, 20);
            this.textBox8.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(428, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(233, 20);
            this.textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(428, 140);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(233, 20);
            this.textBox10.TabIndex = 28;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(428, 173);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(233, 20);
            this.textBox11.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbShowAll);
            this.Controls.Add(this.rbShow5);
            this.Controls.Add(this.rbShow3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProcessFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbShow3;
        private System.Windows.Forms.RadioButton rbShow5;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCenterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxTypeCol;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tspSearchTerm;
        private System.Windows.Forms.ToolStripButton tsbFindContact;
        private System.Windows.Forms.ToolStripButton tsbNavBack;
        private System.Windows.Forms.ToolStripButton tsbNavForward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
    }
}

