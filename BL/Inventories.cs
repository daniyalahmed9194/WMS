using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    public class Inventories
    {
        private string InventoryName;
        private int Quantity;
        private int ID;
        public Inventories(string InventoryName, int Quantity)
        { 
            this.InventoryName = InventoryName;
            this.Quantity = Quantity;
        }

        public Inventories(int id ,string InventoryName, int Quantity)
        {
            this.InventoryName = InventoryName;
            this.Quantity = Quantity;
            this.ID = id;
        }


        //Getters

        public string GetName()
        {
            return this.InventoryName; 
        }
        public int GetQuantity() 
        { 
            return this. Quantity; 
        }
        public int GetID()
        {
            return this.ID;
        }
    }
}
