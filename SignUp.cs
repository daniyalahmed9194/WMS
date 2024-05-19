using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMSLibrary.DL;
using WMSLibrary.BL;
using WMSLibrary;

namespace WMSForms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
        private void ClearDataFromForm()
        {
            UserText.Text = string.Empty;
            PassText.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Username.Text == string.Empty || Password.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Input data!");
            }
            else
            {
                string username = UserText.Text;
                string password = PassText.Text;
                string role = comboBox1.Text;

                MUser user = new MUser(username, password, role);
                try
                {
                    ObjectHandler.GetMUserDL().SignUp(user);
                    MessageBox.Show("Congratulations!Account Has Been Created.");
                    ClearDataFromForm();


                }
                catch
                {

                    MessageBox.Show("Error! Try Again.");
                    ClearDataFromForm();

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

