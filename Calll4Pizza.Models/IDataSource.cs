﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call4Pizza.Models
{
    public interface IDataSource<TDTO>
        where TDTO: IDTO
    {
    }
}
