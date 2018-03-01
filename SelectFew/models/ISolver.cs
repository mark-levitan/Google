﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectFew.models
{
    public interface ISolver
    {
        async Task<VehicleResults> Solve(DataSet data);
    }
}
