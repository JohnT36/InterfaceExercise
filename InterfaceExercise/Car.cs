using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{


    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Honk { get; set; }
        public string Engine { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }


        public bool Trunk { get; set; }
        public bool SunRoof { get; set; }



    }

    
}
