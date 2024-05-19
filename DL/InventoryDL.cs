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
    public class InventoryDL : IInventoryDL
    {
        public bool UpdateInventoryAdd(Inventories inventory)
            
        {
            bool check  = false;
            if (inventory != null)
            {
                SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE InventoryItem SET Quantity = Quantity + @Quantity  WHERE ItemName = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", inventory.GetName());
                cmd.Parameters.AddWithValue("@Quantity", inventory.GetQuantity());


                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i > 0)
                {
                    check =  true;
                }
            }
            return check;

        }


        public bool UpdateInventoryDel(Inventories inventory)

        {
            bool check = false;
            if (inventory != null)
            {
                SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE InventoryItem SET Quantity = Quantity - @Quantity  WHERE ItemName = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", inventory.GetName());
                cmd.Parameters.AddWithValue("@Quantity", inventory.GetQuantity());


                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i > 0)
                {
                    check = true;
                }
            }
            return check;

        }        

        public static List<int> GetInventoryIDs()
        {
            string Connection = Utility.GetConnectionString();
            List<int> InvenId = new List<int>();

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string query = "SELECT ID FROM InventoryItem";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userid = reader.GetInt32(0);
                            InvenId.Add(userid);
                        }
                    }
                }
            }
            return InvenId;
        }

        public static string FindItemName(int id)
        {
            string ItemName;
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ItemName from InventoryItem where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (reader.HasRows) 
                {
                    reader.Read(); 
                    ItemName = reader.GetString(0); 
                }
                else
                {
                    return "";
                }
            }

            conn.Close();
            return ItemName;
        }

        public static int FindInvenQty(int id)
        {
            int qty;
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Quantity from InventoryItem where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (reader.HasRows) 
                {
                    reader.Read(); 
                    qty = reader.GetInt32(0); 
                }
                else
                {
                    return 0;
                }
            }

            conn.Close();
            return qty;
        }

        public List<Inventories> GetAllInventory()
        {
            string connection = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select ID,ItemName,Quantity from InventoryItem";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Inventories> InventoryList = new List<Inventories>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string ItemName = reader.GetString(1);
                int Quantity = reader.GetInt32(2);

                InventoryList.Add(new Inventories(Id , ItemName , Quantity));
            }
            reader.Close();
            conn.Close();
            return InventoryList;
        }

        public static int Check(string Name)
        {
            int quantity = 0; 
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());

            conn.Open(); 

            string query = "SELECT Quantity FROM InventoryItem WHERE ItemName = @Name";


            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@Name", Name);

            object result = cmd.ExecuteScalar();

            
            if (result != null && int.TryParse(result.ToString(), out quantity))
            {
                Console.WriteLine("Quantity retrieved successfully");
            }


            conn.Close();

            return quantity; 
        }


        public bool UpdateInventryDel(Inventories inventory)

        {
            bool check = false;
            if (inventory != null)
            {
                SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Beneficiary  SET Quantity = Quantity - @DonationQuantity  WHERE needs = @ItemName;", conn);
                cmd.Parameters.AddWithValue("@Name", inventory.GetName());
                cmd.Parameters.AddWithValue("@Quantity", inventory.GetQuantity());


                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i > 0)
                {
                    check = true;
                }
            }
            return check;

        }


        public bool UpdateInventryAdd(Inventories inventory)

        {
            bool check = false;
            if (inventory != null)
            {
                SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(D.Quantity) AS DonationQuantity  FROM Donation D   INNER JOIN InventoryItem I ON D.Preference = I.ItemName WHERE I.ItemName = @ItemName; = Quantity + @Quantity  WHERE ItemName = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", inventory.GetName());
                cmd.Parameters.AddWithValue("@Quantity", inventory.GetQuantity());


                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i > 0)
                {
                    check = true;
                }
            }
            return check;

        }

    }
}
