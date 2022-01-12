﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shared.Models;

namespace Shared.Interfaces.Business
{
    public interface IPoliceOfficerBusiness
    {
        
        String PoliceIn(PoliceOfficer officer);
        String PoliceDel(int officerBadge);
    }
}