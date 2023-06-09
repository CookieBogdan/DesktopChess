﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cell
    {
        public Figure Figure { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"{X}/{Y}";
        }
    }
}
