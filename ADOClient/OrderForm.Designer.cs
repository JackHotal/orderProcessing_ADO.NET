namespace ADOClient
{
    partial class OrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxCName = new System.Windows.Forms.TextBox();
            this.tbxCid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbOid = new System.Windows.Forms.ComboBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxOnhand = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPid = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbxCName);
            this.groupBox1.Controls.Add(this.tbxCid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxCName
            // 
            this.tbxCName.Location = new System.Drawing.Point(100, 47);
            this.tbxCName.Name = "tbxCName";
            this.tbxCName.Size = new System.Drawing.Size(100, 20);
            this.tbxCName.TabIndex = 3;
            // 
            // tbxCid
            // 
            this.tbxCid.Location = new System.Drawing.Point(100, 20);
            this.tbxCid.Name = "tbxCid";
            this.tbxCid.Size = new System.Drawing.Size(67, 20);
            this.tbxCid.TabIndex = 2;
            this.tbxCid.TextChanged += new System.EventHandler(this.tbxCid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer No     :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbOid);
            this.groupBox2.Controls.Add(this.lstOrders);
            this.groupBox2.Location = new System.Drawing.Point(62, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // cmbOid
            // 
            this.cmbOid.FormattingEnabled = true;
            this.cmbOid.Location = new System.Drawing.Point(20, 20);
            this.cmbOid.Name = "cmbOid";
            this.cmbOid.Size = new System.Drawing.Size(121, 21);
            this.cmbOid.TabIndex = 1;
            this.cmbOid.SelectedIndexChanged += new System.EventHandler(this.cmbOid_SelectedIndexChanged);
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(20, 61);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(319, 95);
            this.lstOrders.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnBuy);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.tbxQuantity);
            this.groupBox3.Controls.Add(this.tbxOnhand);
            this.groupBox3.Controls.Add(this.tbxPrice);
            this.groupBox3.Controls.Add(this.tbxDescription);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbPid);
            this.groupBox3.Location = new System.Drawing.Point(62, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(181, 149);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(170, 119);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(83, 20);
            this.tbxQuantity.TabIndex = 9;
            // 
            // tbxOnhand
            // 
            this.tbxOnhand.Location = new System.Drawing.Point(170, 93);
            this.tbxOnhand.Name = "tbxOnhand";
            this.tbxOnhand.Size = new System.Drawing.Size(83, 20);
            this.tbxOnhand.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(170, 68);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(83, 20);
            this.tbxPrice.TabIndex = 7;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(170, 41);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(154, 20);
            this.tbxDescription.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantity    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Onhand     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price         :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Id";
            // 
            // cmbPid
            // 
            this.cmbPid.FormattingEnabled = true;
            this.cmbPid.Location = new System.Drawing.Point(10, 34);
            this.cmbPid.Name = "cmbPid";
            this.cmbPid.Size = new System.Drawing.Size(73, 21);
            this.cmbPid.TabIndex = 0;
            this.cmbPid.SelectedIndexChanged += new System.EventHandler(this.cmbPid_SelectedIndexChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxCName;
        private System.Windows.Forms.TextBox tbxCid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOid;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxOnhand;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPid;
    }
}

