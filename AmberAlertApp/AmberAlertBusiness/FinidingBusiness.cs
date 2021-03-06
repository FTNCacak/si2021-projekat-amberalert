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
            this.findingRepository = _findings;
        }

        
        public List<Find> GetFindings()
        {
            return findingRepository.GetAllFinding();
        }

        public String FindingsIn(Find f)
        {
            int rowsAffected = this.findingRepository.InsertFinding(f);

            return rowsAffected > 0 ? "Uspešno ste uneli pronalazak nestale osobe." : "Došlo je od greške, probajte ponovo.";
        }
    }
}
