﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    public interface IjwtHandler
    {
        JsonWebToken Create(int userId);
    }
}
