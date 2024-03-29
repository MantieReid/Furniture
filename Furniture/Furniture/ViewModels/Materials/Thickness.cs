﻿namespace Furniture.ViewModels.Materials
{
    public class Thickness
    {
        private decimal _value;
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Value
        {
            get => _value;
            set
            {
                if (value > 1)
                    _value = 1;
                else if (value < 0)
                    _value = 0;
                else
                    _value = value;
            }
        }
    }
}