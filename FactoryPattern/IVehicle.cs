﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IVehicle
    {
        public abstract void Drive();

        public string Description { get; set; }

        public string Name { get; set; }


    }
}
