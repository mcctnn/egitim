namespace PostgreSqlDb
{
    partial class Employee
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
            this.btnGetEmployeeById = new System.Windows.Forms.Button();
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.tbxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEmployeeDep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetEmployeeById
            // 
            this.btnGetEmployeeById.BackColor = System.Drawing.Color.Turquoise;
            this.btnGetEmployeeById.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetEmployeeById.Location = new System.Drawing.Point(174, 427);
            this.btnGetEmployeeById.Name = "btnGetEmployeeById";
            this.btnGetEmployeeById.Size = new System.Drawing.Size(193, 34);
            this.btnGetEmployeeById.TabIndex = 50;
            this.btnGetEmployeeById.Text = "Id\'ye Göre getir";
            this.btnGetEmployeeById.UseVisualStyleBackColor = false;
            this.btnGetEmployeeById.Click += new System.EventHandler(this.btnGetEmployeeById_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.Turquoise;
            this.btnEmployeeList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeList.Location = new System.Drawing.Point(174, 267);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(193, 34);
            this.btnEmployeeList.TabIndex = 49;
            this.btnEmployeeList.Text = "Listele";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 505);
            this.dataGridView1.TabIndex = 48;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(174, 387);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(193, 34);
            this.btnUpdateEmployee.TabIndex = 47;
            this.btnUpdateEmployee.Text = "Güncelle";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.Turquoise;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(174, 347);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(193, 34);
            this.btnRemoveEmployee.TabIndex = 46;
            this.btnRemoveEmployee.Text = "Sil";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.BackColor = System.Drawing.Color.Turquoise;
            this.btnCreateEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateEmployee.Location = new System.Drawing.Point(174, 307);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(193, 34);
            this.btnCreateEmployee.TabIndex = 45;
            this.btnCreateEmployee.Text = "Ekle";
            this.btnCreateEmployee.UseVisualStyleBackColor = false;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // tbxEmployeeSalary
            // 
            this.tbxEmployeeSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmployeeSalary.Location = new System.Drawing.Point(174, 178);
            this.tbxEmployeeSalary.Name = "tbxEmployeeSalary";
            this.tbxEmployeeSalary.Size = new System.Drawing.Size(193, 30);
            this.tbxEmployeeSalary.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Çalışan Maaşı: ";
            // 
            // tbxEmployeeSurname
            // 
            this.tbxEmployeeSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmployeeSurname.Location = new System.Drawing.Point(174, 126);
            this.tbxEmployeeSurname.Name = "tbxEmployeeSurname";
            this.tbxEmployeeSurname.Size = new System.Drawing.Size(193, 30);
            this.tbxEmployeeSurname.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Çalışan Soyadı :";
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmployeeName.Location = new System.Drawing.Point(174, 73);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(193, 30);
            this.tbxEmployeeName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Çalışan Adı :";
            // 
            // tbxEmployeeId
            // 
            this.tbxEmployeeId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmployeeId.Location = new System.Drawing.Point(174, 28);
            this.tbxEmployeeId.Name = "tbxEmployeeId";
            this.tbxEmployeeId.Size = new System.Drawing.Size(193, 30);
            this.tbxEmployeeId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Çalışan Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "Departman : ";
            // 
            // cbxEmployeeDep
            // 
            this.cbxEmployeeDep.FormattingEnabled = true;
            this.cbxEmployeeDep.Location = new System.Drawing.Point(174, 215);
            this.cbxEmployeeDep.Name = "cbxEmployeeDep";
            this.cbxEmployeeDep.Size = new System.Drawing.Size(121, 24);
            this.cbxEmployeeDep.TabIndex = 52;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 609);
            this.Controls.Add(this.cbxEmployeeDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetEmployeeById);
            this.Controls.Add(this.btnEmployeeList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.tbxEmployeeSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxEmployeeSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEmployeeId);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetEmployeeById;
        private System.Windows.Forms.Button btnEmployeeList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.TextBox tbxEmployeeSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmployeeSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEmployeeDep;
    }
}