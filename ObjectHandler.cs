using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.DL;
using WMSLibrary.Interfaces;
using WMSLibrary.BL;
using System.Runtime.CompilerServices;

namespace WMSLibrary
{
    public class ObjectHandler
    {
        public ObjectHandler() { }
        private static IMUserDL msuerDl = new MUserDL();
        private static IVolunteerDL volunteerDl = new VolunteerDL();
        public static IBeneficiaryDL beneficiaryDl = new BeneficiaryDL();
        public static IDonorDL donorDl = new DonorDL();
        public static IInventoryDL inventoryDL = new InventoryDL();
        public static IAdminDL adminDL = new AdminDL();


        public static IInventoryDL GetInventoryDL()
        {
            return inventoryDL;
        }
        public static IMUserDL GetMUserDL()
        {
            return msuerDl;
        }
        public static IVolunteerDL GetVolunteerDL()
        {
            return volunteerDl;
        }

        public static IBeneficiaryDL GetBeneficiaryDL()
        {
            return beneficiaryDl;
        }

        public static IDonorDL GetDonorDL()
        {
            return donorDl;
        }
        public static IAdminDL GetAdminDL()
        {
            return adminDL;
        }
    }
}
