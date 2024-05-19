using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSLibrary.BL;

namespace WMSLibrary.Interfaces
{
    public interface IInventoryDL
    {
        bool UpdateInventoryAdd(Inventories inventory);
        bool UpdateInventoryDel(Inventories inventory);
        List<Inventories> GetAllInventory();
    }
}
