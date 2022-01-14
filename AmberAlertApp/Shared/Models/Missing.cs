using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Missing
    {
        public int IdMiss { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfDisappearance { get; set; }
        public bool ImageOfPerson { get; set; }

    }
}
