﻿using System.Collections.Generic;
using System.Linq;
using Furniture.Caption;
using Newtonsoft.Json;

namespace Furniture.Materials
{
    public class Plywood
    {
        [JsonIgnore] public ComboBoxItem<decimal> Max => Thicknesses.OrderByDescending(x => x.Value).First();

        [JsonIgnore] public ComboBoxItem<decimal> Min => Thicknesses.OrderByDescending(x => x.Value).Last();

        public List<ComboBoxItem<decimal>> Thicknesses { get; set; }
    }
}