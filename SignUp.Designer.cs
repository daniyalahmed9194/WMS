namespace WMSForms
{
    partial class SignIn
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(26, 28);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(26, 84);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(153, 25);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 22);
            this.UserText.TabIndex = 3;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(153, 84);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(100, 22);
            this.PassText.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(37, 374);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(109, 36);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(114, 223);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 32);
            this.Save.TabIndex = 6;
            this.Save.Text = "SignUp";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Volunteer\t",
            "Beneficiary",
            "Donor"});
            this.comboBox1.Location = new System.Drawing.Point(153, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PassText);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UserText);
            this.panel1.Location = new System.Drawing.Point(255, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 270);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welfare ManagementSystem";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

