using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMSLibrary.BL;
using WMSLibrary;

namespace WMSForms
{
    public partial class VolunteerForm : Form
    {
        public VolunteerForm()
        {
            InitializeComponent();
            Load_Volunteers();
        }
        int identity = 0;

        private static DataTable dataTable = new DataTable();

        private void Load_Volunteers()
        {
            dataTable.Clear();
            AddColumnIfNotExists("Volunteer ID", typeof(int));
            AddColumnIfNotExists("Name", typeof(string));
            AddColumnIfNotExists("Age", typeof(int));
            AddColumnIfNotExists("Profession", typeof(string));
            AddColumnIfNotExists("Phone", typeof(string));
            //AddColumnIfNotExists("MuserID", typeof(int));


            // Bind DataGridView to the DataTable
            dataGridView1.DataSource = dataTable;

            // Populate the DataTable with data from ReceptionistDL
            List<Volunteer> VolunteerList = ObjectHandler.GetVolunteerDL().GetAllVolunteers();
            foreach (Volunteer vol in VolunteerList)
            {
                dataTable.Rows.Add(vol.GetID(), vol.GetName(),vol.GetAge(), vol.GetProfession(), vol.GetPhone());
            }
        }

        private void AddColumnIfNotExists(string columnName, Type columnType)
        {
            if (!dataTable.Columns.Contains(columnName))
            {
                dataTable.Columns.Add(columnName, columnType);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Pass = textBox1.Text;
            string Available, AssignedTask, Name;
            int Age;
            Available = Availability.Text;
            AssignedTask = task.Text;
            Age = int.Parse(age.Text);
            Name = Vname.Text;
            Console.WriteLine(Name);
            Volunteer volunteers = new Volunteer(Name , Age , Available, AssignedTask,Pass);

            //ObjectHandler.GetVolunteerDL().AddVolunteer(volunteers);
            if (ObjectHandler.GetVolunteerDL().AddVolunteer(volunteers))
            {
                MessageBox.Show("Congratulations!Account Has Been Created.");
                Load_Volunteers();
                ClearDataFromForm();
            }
            else
            {
                MessageBox.Show("Error! Try Again.");
                ClearDataFromForm();
            }

        }

        private void VolunteerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            this.Hide();
            admin.ShowDialog();
        }

        private void AssignedTask_Click(object sender, EventArgs e)
        {

        }

        private void ClearDataFromForm()
        {
            Availability.Text = string.Empty;
            task.Text = string.Empty;
            age.Text = string.Empty;
            Vname.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Availability.Text == string.Empty || task.Text == string.Empty || age.Text == string.Empty || Vname.Text == string.Empty )
            {
                MessageBox.Show("Please Enter input First!");
            }
            else
            {
                string Pass = textBox1.Text;
                string name = Vname.Text;
                int Age = int.Parse(age.Text);
                string Phone = Availability.Text;
                string Profession = task.Text;
                Volunteer volunteers = new Volunteer(identity, name, Age, Phone, Profession);
                if (ObjectHandler.GetVolunteerDL().UpdateVolunteer(volunteers))
                {
                    MessageBox.Show("Volunteer Updated Successfully");
                    Load_Volunteers();
                    ClearDataFromForm();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {


                Vname.Text = row.Cells[1].Value.ToString();
                age.Text = row.Cells[2].Value.ToString();
                task.Text = row.Cells[3].Value.ToString();
                Availability.Text = row.Cells[4].Value.ToString();
            }
            identity = string.IsNullOrEmpty(row.Cells[0].Value?.ToString()) ? 0 : Convert.ToInt32(row.Cells[0].Value);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            this.Hide();
            admin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelVolunteer del = new DelVolunteer();
            this.Hide();
            del.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            vsignin v = new vsignin();
            this.Hide();
            v.ShowDialog();
        }
    }
}
