using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;
using WMSLibrary.Interfaces;

namespace WMSLibrary.DL
{
    public class MUserDL: IMUserDL
    {
        public MUserDL() { }
        public bool SignUp(MUser user)
        {
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into MUser values (@Username,@Password,@Category)", conn);
            cmd.Parameters.AddWithValue("@Username", user.GetUsername());
            cmd.Parameters.AddWithValue("@Password", user.GetPassword());
            cmd.Parameters.AddWithValue("@Category", user.GetCategory());

            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MUser> GetUsers()
        {
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select Username,Password,Category from Muser";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<MUser> users = new List<MUser>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Username = reader.GetString(0);
                string Password = reader.GetString(1);
                string Category = reader.GetString(2);
                users.Add(new MUser(Username, Password, Category));
            }
            return users;
        }

        public string Login(MUser user)
        {
            string role = "Invalid Credentials";
            foreach (MUser users in GetUsers())
            {
                if (users.GetUsername() == user.GetUsername() && users.GetPassword() == user.GetPassword())
                {
                    role = users.GetCategory();
                    return role;

                }
            }
            return role;
        }


        /*public string Login1(MUser user)
        {
            string role = "";
            foreach (MUser users in GetUsers())
            {
                if (users.GetUsername()==user.GetUsername() && users.GetPassword() == user.GetPassword())
                {
                    role = users.GetCategory();
                    return role;
                }
            }
            return role;
        }*/

        public  MUser Login1(MUser user)
        {
            string connectionString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from MUser where Username = '{0}' and Password = '{1}'", user.GetUsername(), user.GetPassword());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            if (data.Read())
            {
                MUser storedUser = new MUser(data.GetString(1), data.GetString(2), data.GetString(3));
                connection.Close();
                return storedUser;
            }
            connection.Close();
            return null;
        }

    }
}
