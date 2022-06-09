using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Honk { get; set; }
        public string Engine { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public string TruckBed { get; set; }
        public double TowWeight { get; set; }



    }
}
