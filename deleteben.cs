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
    public partial class deleteben : Form
    {
        public deleteben()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                    if (ObjectHandler.GetBeneficiaryDL().DeleteBeneficiary(id))
                    {
                        MessageBox.Show("Deleted.");
                        textBox1.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Successfully Deleted.");
                    }
                }
            
        }

        private void deleteben_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeneficiaryCRUD beneficiaryCRUD = new BeneficiaryCRUD();
            this.Hide();
            beneficiaryCRUD.ShowDialog();
        }
    }
}
