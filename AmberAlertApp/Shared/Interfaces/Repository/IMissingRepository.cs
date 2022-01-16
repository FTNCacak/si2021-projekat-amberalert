using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces.Repository
{
    public interface IMissingRepository
    {
        List<Missing> GetAllMissing();
        int InsertMissing(Missing m);
        /*int DeleteMissing(int missID);
        */
        int DeleteMissing(int m);
        int UpdateMissing(Missing m);
    }
}
