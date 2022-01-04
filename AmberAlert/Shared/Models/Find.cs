using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Find
    {
        public DateTime DateOfFinding { get; set; }
        public string Location { get; set; }
        public bool Dead { get; set; }
        public int PoliceId { get; set; }
        public int IdMis { get; set; }

    }
}
