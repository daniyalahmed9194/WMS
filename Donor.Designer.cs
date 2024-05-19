namespace WMSForms
{
    partial class DonorForm
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
            this.name = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.preference = new System.Windows.Forms.Label();
            this.DonorName = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QtyText = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.ComboBox();
            this.PreferenceText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(208, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // preference
            // 
            this.preference.AutoSize = true;
            this.preference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preference.Location = new System.Drawing.Point(366, 94);
            this.preference.Name = "preference";
            this.preference.Size = new System.Drawing.Size(91, 20);
            this.preference.TabIndex = 1;
            this.preference.Text = "Preference";
            // 
            // DonorName
            // 
            this.DonorName.Location = new System.Drawing.Point(211, 141);
            this.DonorName.Name = "DonorName";
            this.DonorName.Size = new System.Drawing.Size(100, 22);
            this.DonorName.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(615, 409);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(587, 94);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(86, 20);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.Text = "Phone No.";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(590, 152);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 22);
            this.phone.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity";
            // 
            // QtyText
            // 
            this.QtyText.Location = new System.Drawing.Point(200, 260);
            this.QtyText.Name = "QtyText";
            this.QtyText.Size = new System.Drawing.Size(100, 22);
            this.QtyText.TabIndex = 11;
            // 
            // agetxt
            // 
            this.agetxt.AutoSize = true;
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.Location = new System.Drawing.Point(587, 212);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(38, 20);
            this.agetxt.TabIndex = 13;
            this.agetxt.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // gendertxt
            // 
            this.gendertxt.FormattingEnabled = true;
            this.gendertxt.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendertxt.Location = new System.Drawing.Point(369, 258);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(121, 24);
            this.gendertxt.TabIndex = 16;
            // 
            // PreferenceText
            // 
            this.PreferenceText.FormattingEnabled = true;
            this.PreferenceText.Items.AddRange(new object[] {
            "Ration Bag",
            "Clothes",
            "Medical Supplies",
            "Amount"});
            this.PreferenceText.Location = new System.Drawing.Point(369, 141);
            this.PreferenceText.Name = "PreferenceText";
            this.PreferenceText.Size = new System.Drawing.Size(121, 24);
            this.PreferenceText.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(764, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // DonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 505);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
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
            this.Name = "DonorForm";
            this.Text = "Donor Form";
            this.Load += new System.EventHandler(this.DonorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label preference;
        private System.Windows.Forms.TextBox DonorName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QtyText;
        private System.Windows.Forms.Label agetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox gendertxt;
        private System.Windows.Forms.ComboBox PreferenceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}