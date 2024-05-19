using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;

namespace WMSLibrary.Interfaces
{
    public interface IVolunteerDL
    {
        bool AddVolunteer(Volunteer volunteer);
        bool DeleteVolunteer(int id);
        bool UpdateVolunteer(Volunteer volunteer);
        List<Volunteer> GetAllVolunteers();
    }
}
