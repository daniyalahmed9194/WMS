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
    public partial class DonorForm : Form
    {
        public DonorForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClearDataFromForm()
        {
            DonorName.Text = string.Empty;
            phone.Text = string.Empty;
            PreferenceText.Text = string.Empty;
            //History.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name, mobile, pref, gender,pass ;
            int Age = int.Parse(textBox1.Text);
            pass = textBox2.Text;
            int qty;
            //DateTime date;
            gender = gendertxt.Text;
            pref = PreferenceText.Text;
            mobile = phone.Text;
            Name = DonorName.Text;
            //date = dateTimePicker1.Value;
            qty = int.Parse(QtyText.Text);
            
            //Console.WriteLine(Name);
            
            Donor donor = new Donor(Name,Age, gender, pref, mobile, qty, pass);
            Inventories inven = new Inventories(pref, qty);

            //ObjectHandler.GetVolunteerDL().AddVolunteer(volunteers);
            if (ObjectHandler.GetDonorDL().AddDonor(donor))
            {
                MessageBox.Show("Congratulations!Account Has Been Created.");
                ClearDataFromForm();
            }
            else
            {
                MessageBox.Show("Error! Try Again.");
                ClearDataFromForm();
            }

            if(ObjectHandler.GetInventoryDL().UpdateInventoryAdd(inven))
            {
                MessageBox.Show("Congratulations!Inventory Has Been Created.");
                ClearDataFromForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            this.Hide();
            admin.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DonorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
