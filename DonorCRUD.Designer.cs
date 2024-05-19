namespace WMSForms
{
    partial class DonorCRUD
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
            this.PreferenceText = new System.Windows.Forms.ComboBox();
            this.gendertxt = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.Label();
            this.QtyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.DonorName = new System.Windows.Forms.TextBox();
            this.preference = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PreferenceText
            // 
            this.PreferenceText.FormattingEnabled = true;
            this.PreferenceText.Items.AddRange(new object[] {
            "Ration Bag",
            "Clothes",
            "Medical Supplies",
            "Amount"});
            this.PreferenceText.Location = new System.Drawing.Point(402, 88);
            this.PreferenceText.Name = "PreferenceText";
            this.PreferenceText.Size = new System.Drawing.Size(121, 24);
            this.PreferenceText.TabIndex = 33;
            // 
            // gendertxt
            // 
            this.gendertxt.FormattingEnabled = true;
            this.gendertxt.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendertxt.Location = new System.Drawing.Point(402, 197);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(121, 24);
            this.gendertxt.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(576, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gender";
            // 
            // agetxt
            // 
            this.agetxt.AutoSize = true;
            this.agetxt.Location = new System.Drawing.Point(573, 156);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(32, 16);
            this.agetxt.TabIndex = 29;
            this.agetxt.Text = "Age";
            this.agetxt.Click += new System.EventHandler(this.agetxt_Click);
            // 
            // QtyText
            // 
            this.QtyText.Location = new System.Drawing.Point(258, 197);
            this.QtyText.Name = "QtyText";
            this.QtyText.Size = new System.Drawing.Size(100, 22);
            this.QtyText.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quantity";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(576, 90);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 22);
            this.phone.TabIndex = 25;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(573, 55);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.PhoneNumber.TabIndex = 24;
            this.PhoneNumber.Text = "Phone No.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(249, 276);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 39);
            this.Add.TabIndex = 22;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DonorName
            // 
            this.DonorName.Location = new System.Drawing.Point(258, 90);
            this.DonorName.Name = "DonorName";
            this.DonorName.Size = new System.Drawing.Size(100, 22);
            this.DonorName.TabIndex = 21;
            // 
            // preference
            // 
            this.preference.AutoSize = true;
            this.preference.Location = new System.Drawing.Point(408, 55);
            this.preference.Name = "preference";
            this.preference.Size = new System.Drawing.Size(73, 16);
            this.preference.TabIndex = 19;
            this.preference.Text = "Preference";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(255, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 18;
            this.name.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 168);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(740, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 37;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DonorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PreferenceText);
            this.Controls.Add(this.gendertxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.QtyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DonorName);
            this.Controls.Add(this.preference);
            this.Controls.Add(this.name);
            this.Name = "DonorCRUD";
            this.Text = "DonorCRUD";
            this.Load += new System.EventHandler(this.DonorCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PreferenceText;
        private System.Windows.Forms.ComboBox gendertxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label agetxt;
        private System.Windows.Forms.TextBox QtyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox DonorName;
        private System.Windows.Forms.Label preference;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}