using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;
using WMSLibrary.Interfaces;

namespace WMSLibrary.DL
{
    public class BeneficiaryDL : IBeneficiaryDL
    {
        public bool AddBeneficiaryDB(Beneficiary beneficiary)
        {
            if (beneficiary != null)
            {
                string connection = Utility.GetConnectionString();
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO MUser (Username, Password, Category) OUTPUT INSERTED.ID VALUES (@Username, @Password, @Category)", con);
                    cmd.Parameters.AddWithValue("@Username", beneficiary.GetName());
                    cmd.Parameters.AddWithValue("@Password", beneficiary.GetPass());
                    cmd.Parameters.AddWithValue("@Category", "Beneficiary");

                    // Get the auto-generated MUserId
                    int mUserId = (int)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("Insert into Beneficiary (Name, Age, Quantity, Gender, Needs, ContactInfo,MUserID) OUTPUT Inserted.ID VALUES (@Name, @Age, @Quantity, @Gender, @Needs, @ContactInfo, @MUserID)", con);
                    cmd1.Parameters.AddWithValue("@Name", beneficiary.GetName());
                    cmd1.Parameters.AddWithValue("@Age", beneficiary.GetAge());
                    cmd1.Parameters.AddWithValue("@Quantity", beneficiary.GetQuantity());
                    cmd1.Parameters.AddWithValue("@Gender", beneficiary.GetGender());
                    cmd1.Parameters.AddWithValue("@Needs", beneficiary.GetNeeds());
                    cmd1.Parameters.AddWithValue("@ContactInfo", beneficiary.GetContactInfo());
                    cmd1.Parameters.AddWithValue("@MUserID", mUserId);

                    int ID = (int)cmd1.ExecuteScalar();

                    return ID > 0;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteBeneficiary(int Id)
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());

            conn.Open();

            SqlCommand cmd1 = new SqlCommand("DELETE FROM MUser WHERE ID = (SELECT ID FROM Beneficiary WHERE ID = @Id)", conn);
            cmd1.Parameters.AddWithValue("@Id", Id);
            int rowsAffectedUser = cmd1.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("DELETE FROM Beneficiary WHERE ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsAffectedBeneficiary = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowsAffectedBeneficiary > 0 || rowsAffectedUser > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateBeneficiary(Beneficiary beneficiary)
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Beneficiary SET Name = @Name, Age = @Age, Gender = @Gender, Needs = @Needs , Quantity = @Quantity, ContactInfo = @ContactInfo  WHERE  ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Name", beneficiary.GetName());
            cmd.Parameters.AddWithValue("@Age", beneficiary.GetAge());
            cmd.Parameters.AddWithValue("@Gender", beneficiary.GetGender());
            cmd.Parameters.AddWithValue("@Needs", beneficiary.GetNeeds());
            cmd.Parameters.AddWithValue("@Quantity", beneficiary.GetQuantity());
            cmd.Parameters.AddWithValue("@ContactInfo", beneficiary.GetContactInfo());
            cmd.Parameters.AddWithValue("@Id", beneficiary.GetID());
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

        public List<Beneficiary> GetAllBeneficiaries()
        {
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select ID,Name,Age, Gender,Needs,Quantity,ContactInfo from Beneficiary";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Name = reader.GetString(1);
                int Age = reader.GetInt32(2);
                string Gender = reader.GetString(3);
                string Needs = reader.GetString(4);
                int Quantity = reader.GetInt32(5);
                string ContactInfo = reader.GetString(6);


                BeneficiaryList.Add(new Beneficiary(Id, Name, Age, ContactInfo,Needs,Quantity,Gender));
            }
            reader.Close();
            conn.Close();
            return BeneficiaryList;
        }

        public static List<int> GetBeneficiaryIDs()
        {
            string Connection = Utility.GetConnectionString();
            List<int> UserId = new List<int>();

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string query = "SELECT ID FROM Beneficiary";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userid = reader.GetInt32(0);
                            UserId.Add(userid);
                        }
                    }
                }
            }
            return UserId;
        }

        public static string FindBeneName(int id)
        {
            string BeneName;
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Name from Beneficiary where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (reader.HasRows) // Check if there are any rows returned
                {
                    reader.Read(); // Move to the first row
                    BeneName = reader.GetString(0); // Retrieve the value
                }
                else
                {
                    return "";
                }
            }

            conn.Close();
            return BeneName;
        }

        public static string FindBeneNeed(int id)
        {
            string BeneNeed;
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Needs from Beneficiary where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (reader.HasRows) // Check if there are any rows returned
                {
                    reader.Read(); // Move to the first row
                    BeneNeed = reader.GetString(0); // Retrieve the value
                }
                else
                {
                    return "";
                }
            }

            conn.Close();
            return BeneNeed;
        }

        public static int FindBeneNeedQty(int id)
        {
            int NeedQty;
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Quantity from Beneficiary where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (reader.HasRows) // Check if there are any rows returned
                {
                    reader.Read(); // Move to the first row
                    NeedQty = reader.GetInt32(0); // Retrieve the value
                }
                else
                {
                    return 0;
                }
            }
            conn.Close();
            return NeedQty;
        }
    }
}

