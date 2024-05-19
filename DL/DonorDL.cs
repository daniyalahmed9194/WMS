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
    public class DonorDL : IDonorDL
    {
        public bool AddDonor(Donor donor)
        {
            bool check = false;
            if (donor != null)
            {
                string connection = Utility.GetConnectionString();
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("INSERT INTO MUser (Username, Password, Category) OUTPUT INSERTED.ID VALUES (@Username, @Password, @Category)", con);
                    cmd.Parameters.AddWithValue("@Username", donor.GetName());
                    cmd.Parameters.AddWithValue("@Password", donor.GetPass());
                    cmd.Parameters.AddWithValue("@Category", "Donor");

                    // Get the auto-generated MUserId
                    int mUserId = (int)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("Insert into Donor (Name, PhoneNo, Age, Gender,UserID) OUTPUT Inserted.ID VALUES (@Name, @PhoneNo,  @Age, @Gender,@UserID)", con);
                    cmd1.Parameters.AddWithValue("@Name", donor.GetName());
                    cmd1.Parameters.AddWithValue("@PhoneNo", donor.GetPhoneNo());
                    cmd1.Parameters.AddWithValue("@Age", donor.GetAge());
                    //cmd1.Parameters.AddWithValue("@Preference", donor.GetCity());
                    cmd1.Parameters.AddWithValue("@Gender", donor.GetGender());
                    cmd1.Parameters.AddWithValue("@UserID", mUserId);

                    int ID = (int)cmd1.ExecuteScalar();



                    int donorid = ID;

                    SqlCommand cmd2 = new SqlCommand("Insert into Donation (Preference, Quantity, DonorID) OUTPUT Inserted.ID VALUES (@Preference, @Quantity, @DonorID )", con);
                    cmd2.Parameters.AddWithValue("@Preference",donor.GetDonation().GetPreference());
                    cmd2.Parameters.AddWithValue("@Quantity", donor.GetDonation().GetQuantity());
                    cmd2.Parameters.AddWithValue("@DonorID", donorid);
                    //cmd2.Parameters.AddWithValue("@Date", donor.GetDonation().GetDate());

                    int id = (int)cmd2.ExecuteScalar();

                    if (id > 0 && ID > 0)
                    {
                        check = true;
                    }
                    return check;
                }
            }
            else
            {
                return check;
            }
        }

        /*public List<Donor> GetAllDonors()
        {
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select ID,Name,PhoneNo, Age,Gender from Donor";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Donor> DonorList = new List<Donor>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Name = reader.GetString(1);
                string Phone = reader.GetString(2);
                int Age = reader.(3);
                string Gender = reader.GetString(4);

                DonorList.Add(new Donor(Id, Name, Age,Gender, Phone));
            }
            reader.Close();
            conn.Close();
            return DonorList;
        }*/

        public bool UpdateDonor(Donor donor)
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Volunteer SET Name = @Name, Phone = @Phone, Age = @Age, Gender = @Gender  WHERE  ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Name", donor.GetName());
            cmd.Parameters.AddWithValue("@Phone", donor.GetPhoneNo());
            cmd.Parameters.AddWithValue("@Age", donor.GetAge());
            cmd.Parameters.AddWithValue("@Gender",donor.GetGender());
            cmd.Parameters.AddWithValue("@Id", donor.GetID());
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Donor> GetAllDonors()
        {
            List<Donor> donorList = new List<Donor>();

                string connection = Utility.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = @"SELECT D.ID, D.Name, D.PhoneNo, D.Age, D.Gender, DD.Preference, DD.Quantity
                             FROM Donor D
                             INNER JOIN Donation DD ON D.ID = DD.DonorID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string phone = reader.GetString(2);
                        int age = reader.GetInt32(3);
                        string gender = reader.GetString(4);
                        string preference = reader.GetString(5); 
                        int quantity = reader.GetInt32(6); 

                        Donor donor = new Donor(id, name, age, gender, phone,preference,quantity);

                        donorList.Add(donor);
                    }

                    reader.Close();
                }
            return donorList;
        }



    }
}
