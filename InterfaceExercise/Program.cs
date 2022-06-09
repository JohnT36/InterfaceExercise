using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var jesiah = new Car();
            jesiah.Doors = 4;
            jesiah.Trunk = true;
            jesiah.SunRoof = true;
            jesiah.Engine = "V6";
            jesiah.Wheels = 4;
            jesiah.Honk = "HOOOONK";

            var alina = new Suv();
            alina.Doors = 4;            
            alina.Engine = "V6";
            alina.Wheels = 4;
            alina.Honk = "BBBEEEEEP";


            var john = new Truck();
            john.Doors = 4;            
            john.Engine = "V6";
            john.Wheels = 4;
            john.Honk = "WWWWWWAAAAAAAAAHHHHWWWWW";

            Console.WriteLine(john.Doors);
            Console.WriteLine(john.Engine);
            Console.WriteLine(john.Wheels);
            Console.WriteLine(john.Honk);

            Console.WriteLine(jesiah.Doors);
            Console.WriteLine(jesiah.Engine);
            Console.WriteLine(jesiah.Wheels);
            Console.WriteLine(jesiah.Honk);

            Console.WriteLine(alina.Doors);
            Console.WriteLine(alina.Engine);
            Console.WriteLine(alina.Wheels);
            Console.WriteLine(alina.Honk);

            var vehicles = new List<IVehicle>();
            vehicles.Add(john);
            vehicles.Add(alina);
            vehicles.Add(jesiah);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Engine, vehicle.Wheels, vehicle.Honk, vehicle.Doors);

            }

          

        }
    }
}
