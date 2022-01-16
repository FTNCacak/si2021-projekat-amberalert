using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shared.Models;

namespace Shared.Interfaces.Business
{
    public interface IMissingBusiness
    {
        String MissingIn(Missing person);
       /* String MissingDel(int personId);*/
        List<Missing> MissingByName(String firstName);
        List<Missing> MissingAll();
        int DeleteMissing(int m);
       /* int UpdateMissing(Missing m);*/
    }
}
