namespace WMSForms
{
    partial class BeneficiaryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AgeText = new System.Windows.Forms.TextBox();
            this.ContactInfoText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Homebutton = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(102, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(102, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(102, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Needs";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(102, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "ContactInfo";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(408, 32);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 22);
            this.NameText.TabIndex = 6;
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(408, 95);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(100, 22);
            this.AgeText.TabIndex = 7;
            // 
            // ContactInfoText
            // 
            this.ContactInfoText.Location = new System.Drawing.Point(408, 272);
            this.ContactInfoText.Name = "ContactInfoText";
            this.ContactInfoText.Size = new System.Drawing.Size(100, 22);
            this.ContactInfoText.TabIndex = 10;
            this.ContactInfoText.TextChanged += new System.EventHandler(this.ContactInfoText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(408, 147);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 24);
            this.gender.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ration Bag",
            "Financial Aid",
            "Clothes",
            "Medical Supplies"});
            this.comboBox2.Location = new System.Drawing.Point(408, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // Homebutton
            // 
            this.Homebutton.Location = new System.Drawing.Point(83, 364);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(75, 23);
            this.Homebutton.TabIndex = 15;
            this.Homebutton.Text = "Home";
            this.Homebutton.UseVisualStyleBackColor = true;
            this.Homebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(102, 239);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 16);
            this.quantity.TabIndex = 16;
            this.quantity.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(102, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(408, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // BeneficiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Homebutton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContactInfoText);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BeneficiaryForm";
            this.Text = "Beneficiary Form";
            this.Load += new System.EventHandler(this.BeneficiaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox AgeText;
        private System.Windows.Forms.TextBox ContactInfoText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Homebutton;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}