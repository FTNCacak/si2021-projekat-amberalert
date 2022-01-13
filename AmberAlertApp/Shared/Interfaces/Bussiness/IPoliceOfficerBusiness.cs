using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shared.Models;

namespace Shared.Interfaces.Business
{
    public interface IPoliceOfficerBusiness
    {
<<<<<<< HEAD
        List<PoliceOfficer> GetAllPoliceOfficers();
        String PoliceIn(PoliceOfficer officer);
        /*String PoliceDel(int officerBadge);*/
=======

        String PoliceIn(PoliceOfficer officer);
        String PoliceDel(int officerBadge);
        List<PoliceOfficer> PoliceAll();
>>>>>>> Business-test
    }
}
