using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMSLibrary;

namespace WMSForms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            label1.Text = ObjectHandler.GetAdminDL().CountVolunteers().ToString();
            label2.Text = ObjectHandler.GetAdminDL().CountBeneficiary().ToString();
            label4.Text = ObjectHandler.GetAdminDL().CountDonors().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            this.Hide();
            tasks.Show();
        }

        private void addVolunteer_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            BeneficiaryCRUD beneficiaryForm = new BeneficiaryCRUD();
            this.Hide();
            beneficiaryForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DonorCRUD donor = new DonorCRUD();
            this.Hide();
            donor.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            VolunteerForm v = new VolunteerForm();
            this.Hide();
            v.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Tasks inventory = new Tasks();
            this.Hide();
            inventory.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Donor_Click(object sender, EventArgs e)
        {

        }
    }
}
