﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.Materials
{
    public class Material : IMaterial
    {
        public string Name { get; set;  }
        public decimal Price { get; set;  }
    }
}
