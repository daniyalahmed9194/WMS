using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary.Interfaces
{
    public interface IAdminDL
    {
        int CountVolunteers();
        int CountDonors();
        int CountBeneficiary();
    }
}
