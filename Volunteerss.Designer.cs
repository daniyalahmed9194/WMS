namespace WMSForms
{
    partial class Volunteerss
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
            this.VName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Volage = new System.Windows.Forms.TextBox();
            this.profession = new System.Windows.Forms.TextBox();
            this.volph = new System.Windows.Forms.TextBox();
            this.VAge = new System.Windows.Forms.Label();
            this.Prof = new System.Windows.Forms.Label();
            this.VolPhone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VName
            // 
            this.VName.Location = new System.Drawing.Point(134, 131);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(100, 22);
            this.VName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // Volage
            // 
            this.Volage.Location = new System.Drawing.Point(596, 131);
            this.Volage.Name = "Volage";
            this.Volage.Size = new System.Drawing.Size(100, 22);
            this.Volage.TabIndex = 14;
            // 
            // profession
            // 
            this.profession.Location = new System.Drawing.Point(440, 131);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(100, 22);
            this.profession.TabIndex = 13;
            // 
            // volph
            // 
            this.volph.Location = new System.Drawing.Point(283, 131);
            this.volph.Name = "volph";
            this.volph.Size = new System.Drawing.Size(100, 22);
            this.volph.TabIndex = 12;
            // 
            // VAge
            // 
            this.VAge.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAge.Location = new System.Drawing.Point(602, 80);
            this.VAge.Name = "VAge";
            this.VAge.Size = new System.Drawing.Size(66, 25);
            this.VAge.TabIndex = 11;
            this.VAge.Text = "Age";
            // 
            // Prof
            // 
            this.Prof.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prof.Location = new System.Drawing.Point(446, 80);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(129, 25);
            this.Prof.TabIndex = 10;
            this.Prof.Text = "Profession";
            // 
            // VolPhone
            // 
            this.VolPhone.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolPhone.Location = new System.Drawing.Point(289, 80);
            this.VolPhone.Name = "VolPhone";
            this.VolPhone.Size = new System.Drawing.Size(106, 25);
            this.VolPhone.TabIndex = 9;
            this.VolPhone.Text = "PhoneNo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(679, 287);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(140, 51);
            this.add.TabIndex = 18;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            // 
            // Volunteerss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Volage);
            this.Controls.Add(this.profession);
            this.Controls.Add(this.volph);
            this.Controls.Add(this.VAge);
            this.Controls.Add(this.Prof);
            this.Controls.Add(this.VolPhone);
            this.Name = "Volunteerss";
            this.Text = "Volunteerss";
            this.Load += new System.EventHandler(this.Volunteerss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Volage;
        private System.Windows.Forms.TextBox profession;
        private System.Windows.Forms.TextBox volph;
        private System.Windows.Forms.Label VAge;
        private System.Windows.Forms.Label Prof;
        private System.Windows.Forms.Label VolPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}