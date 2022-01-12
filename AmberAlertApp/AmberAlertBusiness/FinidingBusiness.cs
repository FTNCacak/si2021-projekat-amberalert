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
    public class FinidingBusiness : IFindingBusiness
    {

        private readonly IFindingRepository findingRepository;

        public FinidingBusiness(IFindingRepository _findings)
        {
            findingRepository = _findings;
        }

        public List<Find> GetFindings()
        {
            return this.findingRepository.GetAllFinding();
        }
    }
}
