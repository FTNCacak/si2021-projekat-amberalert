using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces.Repository
{
    public interface IFindingRepository
    {
        List<Find> GetAllFinding();
        int InsertFinding(Find f);
    }
}
