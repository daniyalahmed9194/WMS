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

namespace WMSForms
{
    public partial class vsignin : Form
    {
        public vsignin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                if (UserLogin.Text == string.Empty || UserPass.Text == string.Empty)
                {
                    MessageBox.Show("Input Data First.");
                }
                else
                {
                    string username = UserLogin.Text;
                    string password = UserPass.Text;
                    //string category = comboBox1.Text;
                    MUser user = new MUser(username, password);
                    string category1 = ObjectHandler.GetMUserDL().Login1(user).GetCategory();
                    {
                        if (category1 == "Volunteer")
                        {
                            ObjectHandler.GetMUserDL().Login1(user).GetUsername();
                            Volunteerss v = new Volunteerss();
                            this.Hide();
                            v.ShowDialog();
                        }
                        else if (category1 == "Admin" || category1 == "admin" || category1 == "ADMIN")
                        {
                            AdminForm admin = new AdminForm();
                            this.Hide();
                            admin.ShowDialog();
                        }
                        else if (category1 == "Beneficiary" || category1 == "beneficiary" || category1 == "BENEFICIARY")
                        {
                            BeneficiaryForm beneficiaryForm = new BeneficiaryForm();
                            this.Hide();
                            beneficiaryForm.ShowDialog();
                        }
                        else if (category1 == "Donor" || category1 == "donor" || category1 == "DONOR")
                        {
                            DonorForm donorForm = new DonorForm();
                            this.Hide();
                            donorForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }

                }
            }
        
    }
}
