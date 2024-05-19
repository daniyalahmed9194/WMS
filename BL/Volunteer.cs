using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    public class Volunteer : MUser
    {
        private string Name;
        private string Phone;
        private string Profession;
        private int Age;
        private int ID;
        private string Pass;
       /* public Volunteer (string Username, string Password, string Category,string Availablity, string AssignedTasks , int Age)
        {
            this.Username = Username;
            this.Password = Password;
            this.Category = Category;
            this.AssignedTasks = AssignedTasks;
            this.Age = Age;
            this.Availablity = Availablity;
        }*/

        public Volunteer(string Name, int Age, string Phone, string Profession, string Pass)
        {
            this.Name = Name;
            this.Age = Age;
            this.Phone = Phone;
            this.Profession = Profession;
            this.Pass = Pass;
        }

        public Volunteer(int id, string Name, int Age, string Phone, string Profession)
        {
            this.Name = Name;
            this.Age = Age;
            this.Phone = Phone;
            this.Profession = Profession;
            this.ID = id;
        }
        //Getters and Setters 


        public string GetProfession()
        {
            return this.Profession;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public string GetPhone()
        {
            return this.Phone;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetID()
        {
            return this.ID;
        }

        public string GetPass()
        {
            return this.Pass;
        }
    }
}
