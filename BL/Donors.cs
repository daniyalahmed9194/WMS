using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    public class Donor : MUser
    {
       // private DateTime DonationHistory;
        private string Name;
        private string PhoneNo;
        private int Age;
        private string Gender;
        private int ID;
        Donation donation;
        private string Pass;

        public Donor(string Name, int Age, string Gender,  string Preference, string PhoneNo, int Quantity, string Pass)
        { 
            this.Name = Name;
            this.PhoneNo = PhoneNo;
            this.Age = Age;
            this.Gender = Gender;
            donation = new Donation(Preference,  Quantity);
            this.Pass = Pass;
        }

        public Donor(int Id, string Name, int Age, string Gender ,string PhoneNo, string Preference, int Quantity)
        {
            this.ID = Id;
            this.Name = Name;
            this.PhoneNo = PhoneNo;
            this.Age = Age;
            this.Gender = Gender;
            donation = new Donation(Preference, Quantity);
            
        }

        //Getters and setters

        public string GetPhoneNo()
        {
            return this.PhoneNo;
        }
        public string GetName()
        {
             return this.Name;
        }

        public Donation GetDonation()
        {
            return donation;
        }

        public int GetID()
        {
            return this.ID;
        }
        public int GetAge()
        {
            return this.Age;
        }

        public string GetGender()
        {
            return this.Gender;
        }
        public string GetPass()
        {
            return this.Pass;
        }
    }
}
