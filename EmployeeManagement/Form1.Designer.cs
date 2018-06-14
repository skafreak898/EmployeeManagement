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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCenterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupervisorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show 3 Records";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(122, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Show 5 Records";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(232, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Show All Records";
            this.radioButton3.UseVisualStyleBackColor = true;
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
            this.CostCenterCol,
            this.SupervisorCol,
            this.DevTypeCol,
            this.TaxTypeCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
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
            // DevTypeCol
            // 
            this.DevTypeCol.HeaderText = "Dev Type";
            this.DevTypeCol.Name = "DevTypeCol";
            this.DevTypeCol.ReadOnly = true;
            // 
            // TaxTypeCol
            // 
            this.TaxTypeCol.HeaderText = "Tax Type";
            this.TaxTypeCol.Name = "TaxTypeCol";
            this.TaxTypeCol.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProcessFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCenterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxTypeCol;
    }
}

