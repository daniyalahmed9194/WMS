using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.BL
{
    internal class Tasks
    {
        private string TaskName;
        private int VolunteerId;
        private int BeneficiaryID;
        private int InventoryID;

        public Tasks(string taskName, int volunteerId, int beneficiaryID, int InventoryID)
        {
            TaskName = taskName;
            VolunteerId = volunteerId;
            BeneficiaryID = beneficiaryID;
            this.InventoryID = InventoryID;
        }

        //Getters and Setters

        public void SetTask(string Task)
        { TaskName = Task; }

        public string GetTask() { return this.TaskName;}
        public int GetVolunteerId() {  return this.VolunteerId;}

        public int GetBeneficiaryId()
        {
            return this.BeneficiaryID;
        }

        public int InventoryId()
        {
            return this.InventoryID;
        }
    }
}
