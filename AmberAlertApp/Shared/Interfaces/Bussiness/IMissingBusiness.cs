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
        Missing MissingIn(Missing person);
        int MissingDel(int personId);
        List<Missing> MissingAll();
    }
}
