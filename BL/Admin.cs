using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    internal class Admin : MUser
    {
        private string FirstName;
        private int Phone;
        public Admin (string Username, string Password, string Category, string firstName, int phone)
        {
            this.Username = Username;
            this.Password = Password;
            this.Category = Category;
            FirstName = firstName;
            Phone = phone;
        }
        public Admin(string Username, string Password, string Category)
        {
            this.Username = Username;
            this.Password = Password;
            this.Category = Category;
        }

        public new string GetUsername()
        {
            return this.Username;

        }

        public new string GetPassword()
        { return this.Password; }

        public new string  GetCategory()
        {
            return this.Category;
        }
        public string GetFirstName()
        {
            return this.FirstName;
        }
        public int GetPhone()
        {
            return this.Phone;
        }
    }
}
