using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMSLibrary.BL;
using WMSLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WMSForms
{
    public partial class DonorCRUD : Form
    {
        int identity = 0;
        public DonorCRUD()
        {
            InitializeComponent();
            Load_Donors();
        }

        private void agetxt_Click(object sender, EventArgs e)
        {

        }

        private void ClearDataFromForm()
        {
            DonorName.Text = string.Empty;
            phone.Text = string.Empty;
            PreferenceText.Text = string.Empty;
            //History.Text = string.Empty;
            textBox2.Text = string.Empty;

        }
        private static DataTable dataTable = new DataTable();
        private void Load_Donors()
        {
            dataTable.Clear();
            AddColumnIfNotExists("Donor ID", typeof(int));
            AddColumnIfNotExists("Name", typeof(string));
            AddColumnIfNotExists("Age", typeof(int));
            AddColumnIfNotExists("Gender", typeof(string));
            AddColumnIfNotExists("Phone", typeof(string));
            //AddColumnIfNotExists("MuserID", typeof(int));


            // Bind DataGridView to the DataTable
            dataGridView1.DataSource = dataTable;

            // Populate the DataTable with data from ReceptionistDL
            List<Donor> DonorList = ObjectHandler.GetDonorDL().GetAllDonors();
            foreach (Donor dnr in DonorList)
            {
                dataTable.Rows.Add(dnr.GetID(), dnr.GetName(), dnr.GetAge(), dnr.GetGender(), dnr.GetPhoneNo());
            }
        }

        private void AddColumnIfNotExists(string columnName, Type columnType)
        {
            if (!dataTable.Columns.Contains(columnName))
            {
                dataTable.Columns.Add(columnName, columnType);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string Name, mobile, pref, gender,pass;
            int Age = int.Parse(textBox1.Text);
            pass = textBox2.Text;
            int qty;
            //DateTime date;
            gender = gendertxt.Text;
            pref = PreferenceText.Text;
            mobile = phone.Text;
            Name = DonorName.Text;
            qty = int.Parse(QtyText.Text);


            Donor donor = new Donor(Name, Age, gender, pref, mobile, qty,pass);
            Inventories inven = new Inventories(pref, qty);

            //ObjectHandler.GetVolunteerDL().AddVolunteer(volunteers);
            if (ObjectHandler.GetDonorDL().AddDonor(donor))
            {
                MessageBox.Show("Congratulations!Account Has Been Created.");
                ClearDataFromForm();
                //Load_Donors();
            }
            else
            {
                MessageBox.Show("Error! Try Again.");
                ClearDataFromForm();
            }

            if (ObjectHandler.GetInventoryDL().UpdateInventoryAdd(inven))
            {
                MessageBox.Show("Congratulations!Inventory Has Been Created.");
                ClearDataFromForm();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {


                DonorName.Text = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                gendertxt.Text = row.Cells[3].Value.ToString();
                QtyText.Text = row.Cells[4].Value.ToString();
            }
            identity = string.IsNullOrEmpty(row.Cells[0].Value?.ToString()) ? 0 : Convert.ToInt32(row.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            this.Hide();
            admin.ShowDialog();
        }

        private void DonorCRUD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DonorName.Text == string.Empty || PreferenceText.Text == string.Empty || phone.Text == string.Empty || QtyText.Text == string.Empty || gendertxt.Text == string.Empty || textBox1.Text == string.Empty || textBox2.Text ==  string.Empty )
            {
                MessageBox.Show("Please Enter input First!");
            }
            else
            {
                string gender = gendertxt.Text;
                int  Quantity = int . Parse(QtyText.Text);
                string name = DonorName.Text;
                int Age = int.Parse(textBox2.Text);
                string Preff = PreferenceText.Text;
                string Phone = phone.Text;
                Donor donr = new Donor(identity, name, Age,gender,Phone,Preff,Quantity);
                if (ObjectHandler.GetDonorDL().UpdateDonor(donr))
                {
                    MessageBox.Show("Donor Updated Successfully");
                    Load_Donors();
                    ClearDataFromForm();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
