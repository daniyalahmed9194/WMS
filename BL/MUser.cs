using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    public class MUser
    {
        protected string Username;
        protected string Password;
        protected string Category;
        public MUser(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;

        }
        public MUser(string Username, string Password, string Category)
        {
            this.Username = Username;
            this.Password = Password;
            this.Category = Category;
        }
        public MUser()
        { }
        public string GetUsername()
        {
            return this.Username;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public string GetCategory()
        {
            return this.Category;
        }
    }
}
