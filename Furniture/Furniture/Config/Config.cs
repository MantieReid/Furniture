﻿using System.Collections.Generic;
using Caliburn.Micro;
using Furniture.Materials;

namespace Furniture.Config
{
    public class Config
    {
        public List<Material> Materials { get; set; }
        public Plywood Plywood { get; set; }
        public BindableCollection<Quotation.Quotation> Work { get; set; }

        public List<decimal> Widths { get; set; }
        public List<decimal> Lengths { get; set; }
    }
}