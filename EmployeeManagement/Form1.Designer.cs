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
            // rbShow3
            // 
            this.rbShow3.AutoSize = true;
            this.rbShow3.Location = new System.Drawing.Point(12, 37);
            this.rbShow3.Name = "rbShow3";
            this.rbShow3.Size = new System.Drawing.Size(104, 17);
            this.rbShow3.TabIndex = 3;
            this.rbShow3.TabStop = true;
            this.rbShow3.Text = "Show 3 Records";
            this.rbShow3.UseVisualStyleBackColor = true;
            // 
            // rbShow5
            // 
            this.rbShow5.AutoSize = true;
            this.rbShow5.Location = new System.Drawing.Point(122, 37);
            this.rbShow5.Name = "rbShow5";
            this.rbShow5.Size = new System.Drawing.Size(104, 17);
            this.rbShow5.TabIndex = 4;
            this.rbShow5.TabStop = true;
            this.rbShow5.Text = "Show 5 Records";
            this.rbShow5.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(232, 37);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(109, 17);
            this.rbShowAll.TabIndex = 5;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All Records";
            this.rbShowAll.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCenterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxTypeCol;
    }
}

