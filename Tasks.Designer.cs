namespace WMSForms
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.VolunteerCombo = new System.Windows.Forms.ComboBox();
            this.BeneficiaryCombo = new System.Windows.Forms.ComboBox();
            this.VolName = new System.Windows.Forms.Label();
            this.BeneficiaryNeed = new System.Windows.Forms.Label();
            this.BeneficiaryName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Item = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.Label();
            this.InvenCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VolunteerCombo
            // 
            this.VolunteerCombo.FormattingEnabled = true;
            this.VolunteerCombo.Location = new System.Drawing.Point(277, 55);
            this.VolunteerCombo.Name = "VolunteerCombo";
            this.VolunteerCombo.Size = new System.Drawing.Size(121, 24);
            this.VolunteerCombo.TabIndex = 0;
            this.VolunteerCombo.SelectedIndexChanged += new System.EventHandler(this.VolunteerCombo_SelectedIndexChanged);
            // 
            // BeneficiaryCombo
            // 
            this.BeneficiaryCombo.FormattingEnabled = true;
            this.BeneficiaryCombo.Location = new System.Drawing.Point(277, 124);
            this.BeneficiaryCombo.Name = "BeneficiaryCombo";
            this.BeneficiaryCombo.Size = new System.Drawing.Size(121, 24);
            this.BeneficiaryCombo.TabIndex = 1;
            this.BeneficiaryCombo.SelectedIndexChanged += new System.EventHandler(this.BeneficiaryCombo_SelectedIndexChanged);
            // 
            // VolName
            // 
            this.VolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolName.Location = new System.Drawing.Point(479, 44);
            this.VolName.Name = "VolName";
            this.VolName.Size = new System.Drawing.Size(125, 35);
            this.VolName.TabIndex = 2;
            this.VolName.Text = "Name";
            this.VolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VolName.Click += new System.EventHandler(this.VolName_Click);
            // 
            // BeneficiaryNeed
            // 
            this.BeneficiaryNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeneficiaryNeed.Location = new System.Drawing.Point(608, 125);
            this.BeneficiaryNeed.Name = "BeneficiaryNeed";
            this.BeneficiaryNeed.Size = new System.Drawing.Size(100, 23);
            this.BeneficiaryNeed.TabIndex = 3;
            this.BeneficiaryNeed.Text = "Need";
            this.BeneficiaryNeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BeneficiaryNeed.Click += new System.EventHandler(this.BeneficiaryNeed_Click);
            // 
            // BeneficiaryName
            // 
            this.BeneficiaryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeneficiaryName.Location = new System.Drawing.Point(447, 125);
            this.BeneficiaryName.Name = "BeneficiaryName";
            this.BeneficiaryName.Size = new System.Drawing.Size(100, 23);
            this.BeneficiaryName.TabIndex = 4;
            this.BeneficiaryName.Text = "Name";
            this.BeneficiaryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BeneficiaryName.Click += new System.EventHandler(this.BeneficiaryName_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 214);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(769, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Donate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 194);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.Location = new System.Drawing.Point(480, 188);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(57, 22);
            this.Item.TabIndex = 5;
            this.Item.Text = "Name";
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(640, 188);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(53, 22);
            this.qty.TabIndex = 6;
            this.qty.Text = "Need";
            // 
            // InvenCombo
            // 
            this.InvenCombo.FormattingEnabled = true;
            this.InvenCombo.Location = new System.Drawing.Point(277, 180);
            this.InvenCombo.Name = "InvenCombo";
            this.InvenCombo.Size = new System.Drawing.Size(121, 24);
            this.InvenCombo.TabIndex = 7;
            this.InvenCombo.SelectedIndexChanged += new System.EventHandler(this.InvenCombo_SelectedIndexChanged);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InvenCombo);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.BeneficiaryName);
            this.Controls.Add(this.BeneficiaryNeed);
            this.Controls.Add(this.VolName);
            this.Controls.Add(this.BeneficiaryCombo);
            this.Controls.Add(this.VolunteerCombo);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VolunteerCombo;
        private System.Windows.Forms.ComboBox BeneficiaryCombo;
        private System.Windows.Forms.Label VolName;
        private System.Windows.Forms.Label BeneficiaryNeed;
        private System.Windows.Forms.Label BeneficiaryName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.ComboBox InvenCombo;
    }
}