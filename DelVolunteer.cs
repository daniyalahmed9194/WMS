using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WMSLibrary;

namespace WMSForms
{
    public partial class DelVolunteer : Form
    {
        public DelVolunteer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VolunteerForm volunteer = new VolunteerForm();
            this.Hide();
            volunteer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Id!");
            }
            else
            {
                int id = int.Parse(textBox1.Text);
                if (ObjectHandler.GetVolunteerDL().DeleteVolunteer(id))
                {
                    MessageBox.Show("Successfully Deleted.");
                    textBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Does not find.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DelVolunteer_Load(object sender, EventArgs e)
        {

        }
    }
}
