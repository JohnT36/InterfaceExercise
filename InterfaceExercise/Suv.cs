using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {
        }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Honk { get; set; }
        public string Engine { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }



        public bool CanTow { get; set; }
        public int CargoSize { get; set; }

    }
}
