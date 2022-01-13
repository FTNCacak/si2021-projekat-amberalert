using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces.Repository
{
    public interface IPoliceOfficerRepository
    {
        List<PoliceOfficer> GetAllPoliceOfficers();

        int InsertPoliceOfficers(PoliceOfficer p);

        /*int DeletePoliceOfficer(int badgeNo);*/

    }
}
