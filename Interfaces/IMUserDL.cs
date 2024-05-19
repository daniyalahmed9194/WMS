using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;

namespace WMSLibrary.Interfaces
{
    public interface IMUserDL
    {
        bool SignUp(MUser user);
        List<MUser> GetUsers();
        string Login(MUser user);
        MUser Login1(MUser user);
       // string Login1(MUser user);

    }
}
