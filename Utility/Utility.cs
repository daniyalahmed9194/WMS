using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSLibrary
{
    public class Utility
    {
        private static string ConnectionString = "Data Source = DANIYALS\\SQLEXPRESS; Initial Catalog = WMS; Integrated Security = True;";
        public static string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
 