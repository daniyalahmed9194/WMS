using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    public class Donation
    {
        private string Preference;
        //private DateTime Date;
        private int Quantity;

        public Donation(string Preference,  int Quantity)
        {
            this.Preference = Preference;
            this.Quantity = Quantity;
        }
        // Getters and Setters

        public string GetPreference()
        { return this.Preference; }
        //public DateTime GetDate() { return this.Date; } 
        //public int GetDonorId() { return this.DonorId; }
        public int GetQuantity()
        {
            return this.Quantity;

        }


    }
}
