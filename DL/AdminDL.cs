using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;
using WMSLibrary.Interfaces;

namespace WMSLibrary.DL
{
    public class AdminDL : IAdminDL
    {
        public int CountVolunteers() 
        {

            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*)from Volunteer", conn);
            int countVolun = (int)cmd.ExecuteScalar();
            conn.Close();
            return countVolun;
        }

        public int CountDonors()
        {

            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*)from Donor", conn);
            int countDonor = (int)cmd.ExecuteScalar();
            conn.Close();
            return countDonor;
        }

        public int CountBeneficiary()
        {

            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*)from Beneficiary", conn);
            int countBene = (int)cmd.ExecuteScalar();
            conn.Close();
            return countBene;
        }



    }
}
