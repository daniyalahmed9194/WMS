using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary;


namespace WMSLibrary.BL
{
    public class Beneficiary : MUser
    {
        private string Name;
        private string ContactInfo;
        private string Gender;
        private int Age;
        private string Needs;
        private int Quantity;
        private int ID;
        private string pass;


        public Beneficiary(string Name, int Age, string ContactInfo, string Needs, int Quantity, string Gender, string pass)
        {
            this.Name = Name;
            this.Age = Age;
            this.Needs = Needs;
            this.Quantity = Quantity;
            this.ContactInfo = ContactInfo;
            this.Gender = Gender;
            this.pass = pass;
        }
        public Beneficiary(int id, string Name, int Age, string ContactInfo, string Needs, int Quantity, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Needs = Needs;
            this.Quantity = Quantity;
            this.ContactInfo = ContactInfo;
            this.Gender = Gender;
            this.ID = id;  
        }

        //getters and setters'

        public string GetName()
        {
            return this.Name;
        }
        public int GetID()
        {
            return this.ID;
        }
        public string GetGender()
        {
            return this.Gender;
        }

        public string GetNeeds()
        { return this.Needs; }
        public int GetAge() { return this.Age; }
        public string GetContactInfo()
        { return this.ContactInfo; }
        public int GetQuantity()
        {
            return this.Quantity;
        }
        public string GetPass()
        {
            return this.pass;
        }
    }
}
