using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle 
    {
        public string Description { get; set; } = "Boy she's fast!!";

        public string Name { get; set; } = "BMW";

        public void Drive() 
        {
            Console.WriteLine($"Driving {Name} - {Description}");
        }
        
         
    }
}
