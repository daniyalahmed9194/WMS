using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;
using WMSLibrary.Interfaces;

namespace WMSLibrary.DL
{
    public class VolunteerDL : IVolunteerDL
    {
        /*public bool AddVolunteer(Volunteer volunteer)
        {
            bool var;
            if (volunteer != null)
            {
                string connection = Utility.GetConnectionString();
                SqlConnection con = new SqlConnection(connection);
                con.Open();


                //Insert into Volunteer table
                SqlCommand cmd1 = new SqlCommand("Insert into Volunteer (Name, Age, Availability, AssignedTask) OUTPUT Inserted.ID VALUES (@Name, @Age, @Availability, @AssignedTask)", con);
                cmd1.Parameters.AddWithValue("@Name", volunteer.GetName());
                cmd1.Parameters.AddWithValue("@Age", volunteer.GetAge());
                cmd1.Parameters.AddWithValue("@Availability", volunteer.GetAvailablity());
                cmd1.Parameters.AddWithValue("@AssignedTask", volunteer.GetAssignedTask());
                

                //Get auto-generated ID
                int ID = (int)cmd1.ExecuteScalar();
                int rowsAffected = cmd1.ExecuteNonQuery();

                if( rowsAffected > 0)
                {
                    var = true;
                }
                return var;
            }
            else 
            {
                return var = false;
            }
            return var;
            
        }*/
        //public int GetLastVolunteerId()
        //{
        //    int lastId = 0;
        //    using (SqlConnection connection = new SqlConnection(Utility.GetConnectionString()))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT MAX(UserID) FROM Volunteer", connection);
        //        lastId = (int)command.ExecuteScalar();
        //    }
        //    return lastId;
        //}





        public bool AddVolunteer(Volunteer volunteer)
        {

            if (volunteer != null)
            {
                string connection = Utility.GetConnectionString();
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("INSERT INTO MUser (Username, Password, Category) OUTPUT INSERTED.ID VALUES (@Username, @Password, @Category)", con);
                    cmd.Parameters.AddWithValue("@Username", volunteer.GetName());
                    cmd.Parameters.AddWithValue("@Password", volunteer.GetPass());
                    cmd.Parameters.AddWithValue("@Category", "Volunteer");

                    // Get the auto-generated MUserId
                    int mUserId = (int)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("Insert into Volunteer (Name, Age, Phone, Profession, UserID) OUTPUT Inserted.ID VALUES (@Name, @Age, @Phone, @Profession, @UserID)", con);
                    cmd1.Parameters.AddWithValue("@Name", volunteer.GetName());
                    cmd1.Parameters.AddWithValue("@Age", volunteer.GetAge());
                    cmd1.Parameters.AddWithValue("@Phone", volunteer.GetPhone());
                    cmd1.Parameters.AddWithValue("@Profession", volunteer.GetProfession());
                    cmd1.Parameters.AddWithValue("@UserID", mUserId);


                    int ID = (int)cmd1.ExecuteScalar();

                    return ID > 0;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteVolunteer(int Id)
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());

            conn.Open();

            SqlCommand cmd1 = new SqlCommand("DELETE FROM MUser WHERE ID = (SELECT ID FROM Volunteer WHERE ID = @Id)", conn);
            cmd1.Parameters.AddWithValue("@Id", Id);
            int rowsAffectedUser = cmd1.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("DELETE FROM Volunteer WHERE ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsAffectedVolunteer = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowsAffectedVolunteer > 0 || rowsAffectedUser > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateVolunteer(Volunteer volunteer)
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Volunteer SET Name = @Name, Age = @Age, Phone = @Phone, Profession = @Profession  WHERE  ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Name", volunteer.GetName());
            cmd.Parameters.AddWithValue("@Age", volunteer.GetAge());
            cmd.Parameters.AddWithValue("@Phone", volunteer.GetPhone());
            cmd.Parameters.AddWithValue("@Profession", volunteer.GetProfession());
            cmd.Parameters.AddWithValue("@Id", volunteer.GetID());
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

        public List<Volunteer> GetAllVolunteers()
        {
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select ID,Name,Age,Phone,Profession from Volunteer";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Volunteer> volunteerList = new List<Volunteer>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Name = reader.GetString(1);
                int Age = reader.GetInt32(2);
                string Phone = reader.GetString(3);
                string Profession = reader.GetString(4);

                volunteerList.Add(new Volunteer(Id, Name, Age, Phone, Profession));
            }
            reader.Close();
            conn.Close();
            return volunteerList;
        }


        public static  List<int> GetVolunteerIDs()
        {
            string Connection = Utility.GetConnectionString();
            List<int> volunteerIdList = new List<int>();

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string query = "SELECT ID FROM Volunteer";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userid = reader.GetInt32(0);
                            volunteerIdList.Add(userid);
                        }
                    }
                }
            }
            return volunteerIdList;
        }

        public static string FindVolName(int id)
        {
            string VolName;
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Name from Volunteer where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (reader.HasRows) 
                {
                    reader.Read(); 
                    VolName = reader.GetString(0); 
                }
                else
                {
                    return "";
                }
            }

            conn.Close();
            return VolName;
        }

    }
}
