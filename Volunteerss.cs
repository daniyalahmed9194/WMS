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
    public partial class Volunteerss : Form
    {
        public Volunteerss()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            volph.Text = string.Empty;
            profession.Text = string.Empty;
            Volage.Text = string.Empty;
            VName.Text = string.Empty;
        }
        private void add_Click(object sender, EventArgs e)
        {
            string Pass = textBox1.Text;
            string  Name;
            int Age;
            string Phone = volph.Text;
            string pref = profession.Text;
            Age = int.Parse(Volage.Text);
            Name = VName.Text;
            Console.WriteLine(Name);
            Volunteer volunteers = new Volunteer(Name, Age, Phone, pref, Pass);

            //ObjectHandler.GetVolunteerDL().AddVolunteer(volunteers);
            if (ObjectHandler.GetVolunteerDL().AddVolunteer(volunteers))
            {
                MessageBox.Show("Congratulations!Account Has Been Created.");
                //Load_Volunteers();
                ClearDataFromForm();
            }
            else
            {
                MessageBox.Show("Error! Try Again.");
                ClearDataFromForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            this.Hide();
            a.ShowDialog();
        }

        private void Volunteerss_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
