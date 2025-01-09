namespace mongoDb
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
            this.tbxCustomerId = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCustomerCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCustomerBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCustomerShoppingCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnGetCustomerById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Id : ";
            // 
            // tbxCustomerId
            // 
            this.tbxCustomerId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerId.Location = new System.Drawing.Point(171, 26);
            this.tbxCustomerId.Name = "tbxCustomerId";
            this.tbxCustomerId.Size = new System.Drawing.Size(193, 30);
            this.tbxCustomerId.TabIndex = 1;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerName.Location = new System.Drawing.Point(171, 71);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(193, 30);
            this.tbxCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı :";
            // 
            // tbxCustomerSurname
            // 
            this.tbxCustomerSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerSurname.Location = new System.Drawing.Point(171, 124);
            this.tbxCustomerSurname.Name = "tbxCustomerSurname";
            this.tbxCustomerSurname.Size = new System.Drawing.Size(193, 30);
            this.tbxCustomerSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri Soyadı :";
            // 
            // tbxCustomerCity
            // 
            this.tbxCustomerCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerCity.Location = new System.Drawing.Point(171, 176);
            this.tbxCustomerCity.Name = "tbxCustomerCity";
            this.tbxCustomerCity.Size = new System.Drawing.Size(193, 30);
            this.tbxCustomerCity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Müşteri Şehri: ";
            // 
            // tbxCustomerBalance
            // 
            this.tbxCustomerBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerBalance.Location = new System.Drawing.Point(171, 225);
            this.tbxCustomerBalance.Name = "tbxCustomerBalance";
            this.tbxCustomerBalance.Size = new System.Drawing.Size(193, 30);
            this.tbxCustomerBalance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bakiye :";
            // 
            // tbxCustomerShoppingCount
            // 
            this.tbxCustomerShoppingCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerShoppingCount.Location = new System.Drawing.Point(171, 265);
            this.tbxCustomerShoppingCount.Name = "tbxCustomerShoppingCount";
            this.tbxCustomerShoppingCount.Size = new System.Drawing.Size(193, 30);
            this.tbxCustomerShoppingCount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alışveriş Tutarı : ";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCreateCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCustomer.Location = new System.Drawing.Point(171, 341);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(193, 34);
            this.btnCreateCustomer.TabIndex = 13;
            this.btnCreateCustomer.Text = "Ekle";
            this.btnCreateCustomer.UseVisualStyleBackColor = false;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCustomer.Location = new System.Drawing.Point(171, 381);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(193, 34);
            this.btnRemoveCustomer.TabIndex = 14;
            this.btnRemoveCustomer.Text = "Sil";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(171, 421);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(193, 34);
            this.btnUpdateCustomer.TabIndex = 15;
            this.btnUpdateCustomer.Text = "Güncelle";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 346);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCustomerList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.Location = new System.Drawing.Point(171, 301);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(193, 34);
            this.btnCustomerList.TabIndex = 17;
            this.btnCustomerList.Text = "Listele";
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnGetCustomerById
            // 
            this.btnGetCustomerById.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGetCustomerById.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCustomerById.Location = new System.Drawing.Point(171, 461);
            this.btnGetCustomerById.Name = "btnGetCustomerById";
            this.btnGetCustomerById.Size = new System.Drawing.Size(193, 34);
            this.btnGetCustomerById.TabIndex = 18;
            this.btnGetCustomerById.Text = "Id\'ye Göre getir";
            this.btnGetCustomerById.UseVisualStyleBackColor = false;
            this.btnGetCustomerById.Click += new System.EventHandler(this.btnGetCustomerById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 507);
            this.Controls.Add(this.btnGetCustomerById);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.tbxCustomerShoppingCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxCustomerBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCustomerCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCustomerId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCustomerId;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCustomerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCustomerCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCustomerBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCustomerShoppingCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnGetCustomerById;
    }
}

