using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;

namespace WMSLibrary.Interfaces
{
    public interface IBeneficiaryDL
    {
        bool AddBeneficiaryDB(Beneficiary beneficiary);
        List<Beneficiary> GetAllBeneficiaries();
        bool UpdateBeneficiary(Beneficiary beneficiary);
        bool DeleteBeneficiary(int Id);
    }
}
