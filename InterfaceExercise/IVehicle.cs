using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {


        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Honk { get; set; }
        public string Engine { get; set; }
        
    }
}
