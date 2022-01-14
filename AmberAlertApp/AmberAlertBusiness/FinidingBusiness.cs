using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace AmberAlertBusiness
{
    //Sadrži funkcije za održavanje tabele pronađenih lica
    public class FinidingBusiness : IFindingBusiness
    {

        private readonly IFindingRepository findingRepository;

        public FinidingBusiness(IFindingRepository _findings)
        {
            findingRepository = _findings;
        }

        public FinidingBusiness()
        {
        }

        public List<Find> GetFindings()
        {
            return this.findingRepository.GetAllFinding();
        }

        public String FindingsIn(Find f)
        {
            int rowsAffected = this.findingRepository.InsertFinding(f);

            return rowsAffected > 0 ? "Uspešno ste uneli nestalu osobu" : "Došlo je od greške, probajte ponovo.";
        }
    }
}
