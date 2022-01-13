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
    //Sadrži funkcije za održavanje baze nestalih osoba
    public class MissingBusiness : IMissingBusiness
    {
        private readonly IMissingRepository missingRepository;

        public MissingBusiness(IMissingRepository _missings)
        {
            missingRepository = _missings;
        }

        public MissingBusiness()
        {
        }

        public String MissingIn(Missing person)
        {
            int rowsAffected = this.missingRepository.InsertMissing(person);

            return rowsAffected > 0 ? "Uspešno ste uneli nestalu osobu" : "Došlo je od greške, probajte ponovo.";
        }
       /* public String MissingDel(int personId)
        {
            int rowsAffected = this.missingRepository.DeleteMissing(personId);

            return rowsAffected > 0 ? "Uspešno ste obrisali nestalu osobu" : "Došlo je od greške, probajte ponovo.";
        }*/
        public List<Missing> MissingAll()
        {
            return this.missingRepository.GetAllMissing();
        }

        public List<Missing> MissingByName(String firstName)
        {
            return MissingAll().Where(person => person.FirstName.Contains(firstName)).ToList();
        }

        /*public bool DeleteMissing(Missing m)
        {
            if (this.missingRepository.DeleteMissing(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*  public bool UpdateMissing(Missing m)
        {
            if (this.missingRepository.UpdateMissing(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
