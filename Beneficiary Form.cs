using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using WMSLibrary.BL;
using WMSLibrary;

namespace WMSForms
{
    public partial class BeneficiaryForm : Form
    {
        public BeneficiaryForm()
        {
            InitializeComponent();
        }

        private void BeneficiaryForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearDataFromForm()
        {
            ContactInfoText.Text = string.Empty;
            gender.Text = string.Empty;
            NameText.Text = string.Empty;
            AgeText.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name, Gender, Needs, ContactInfo;
            int Age,Quantity;
            string pass = textBox2.Text;
            ContactInfo = ContactInfoText.Text;
            Quantity = int.Parse(textBox1.Text);
            Gender = gender.Text;
            Needs = comboBox2.Text;
            Age = int.Parse(AgeText.Text);
            Name = NameText.Text;
            Console.WriteLine(Name);
            Beneficiary beneficiary = new Beneficiary(Name, Age,  ContactInfo , Needs, Quantity, Gender , pass);

            if (ObjectHandler.GetBeneficiaryDL().AddBeneficiaryDB(beneficiary))
            {
                MessageBox.Show("Congratulations!Account Has Been Created.");
                ClearDataFromForm();
            }
            else
            {
                MessageBox.Show("Error! Try Again.");
                ClearDataFromForm();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            this.Hide();
            admin.ShowDialog();
        }

        private void ContactInfoText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
