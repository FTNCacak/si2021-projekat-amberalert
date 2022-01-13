using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shared.Models;

namespace Shared.Interfaces.Business
{
    public interface IFindingBusiness
    {
        List<Find> GetFindings();
        String FindingsIn(Find f);
    }
}
