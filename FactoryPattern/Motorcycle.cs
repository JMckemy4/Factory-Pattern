using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public string Description { get; set; } = "Loud and usually ready to rock and roll!!";

        public string Name { get; set; } = "Harley Man";

        public void Drive()
        {


        }
    }
}
