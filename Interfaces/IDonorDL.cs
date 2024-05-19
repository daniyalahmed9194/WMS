using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;
using WMSLibrary.DL;

namespace WMSLibrary.Interfaces
{
    public interface IDonorDL
    {
        bool AddDonor(Donor donor);
        bool UpdateDonor(Donor donor);

        List<Donor> GetAllDonors();
    }
}
