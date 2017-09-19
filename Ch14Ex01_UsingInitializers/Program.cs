using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Ex01_UsingInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            //With collection intializers, the compiler calls the Add() method of the collection for each item you supply.
            Farm<Animal> farm = new Farm<Animal>
            {
                new Cow { Name = "Norris" },
                new Chicken { Name = "Rita" },
                new Chicken(),
                new SuperCow { Name = "Chesney" }
            };

            //Instead of using the Add() method of the Farm class, we could have used the Add() method of it's Animals property (which is List<T>) 
            Farm<Animal> farm2 = new Farm<Animal>
            {
                Animals =
                {
                    new Cow { Name = "Norris2" },
                    new Chicken { Name = "Rita2" },
                    new Chicken(),
                    new SuperCow { Name = "Chesney2" }
                }
            };

            farm.MakeNoises();
            Console.WriteLine();
            farm2.MakeNoises();
            Console.ReadKey();
        }
    }
}
