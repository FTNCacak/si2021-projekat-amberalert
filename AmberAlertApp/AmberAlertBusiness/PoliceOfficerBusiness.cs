using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace AmberAlertBusiness
{
    //Sadrži funkcije za održavanje baze policajaca
    public class PoliceOfficerBusiness : IPoliceOfficerBusiness
    {
        private readonly IPoliceOfficerRepository policeRepository;

        public PoliceOfficerBusiness(IPoliceOfficerRepository _officer)
        {
            policeRepository = _officer;
        }

        public String PoliceIn(PoliceOfficer officer)
        {
            int rowsAffected = this.policeRepository.InsertPoliceOfficers(officer);

            return rowsAffected > 0 ? "Uspešno ste uneli novog službenika" : "Došlo je od greške, probajte ponovo.";
        }
        public String PoliceDel(int badgeNo)
        {
            int rowsAffected = this.policeRepository.DeletePoliceOfficer(badgeNo);

            return rowsAffected > 0 ? "Uspešno ste obrisali nestalu osobu" : "Došlo je od greške, probajte ponovo.";
        }
        public List<PoliceOfficer> PoliceAll()
        {
            return this.policeRepository.GetAllPoliceOfficers();
        }
    }
}
