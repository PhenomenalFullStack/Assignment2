using System;
using System.Collections.Generic;

namespace Assignment2_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animalia> animals = new List<Animalia>();

            Carnivora lion = new Carnivora
            {
                CommonName = "Lion",
                BinomalName = "Panthera leo",
                conservation = ConservationStatus.VU
            };
            animals.Add(lion);

            Squamata housesnek = new Squamata
            {
                CommonName = "African house snake",
                BinomalName = "Boaedon fuliginosus"
            };
            animals.Add(housesnek);

            // TODO: Add nemo


            foreach (Animalia animal in animals)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("New Arrival:");
                Console.ResetColor();
                Console.WriteLine("Common Name: " + animal.CommonName);
                Console.WriteLine("Binomal Name: " + animal.BinomalName);
                Console.WriteLine("Bloodtype: " + animal.bloodtype.ToString());
                Console.Write("Conservation Status: ");
                switch (animal.conservation) {
                    case ConservationStatus.EX: Console.Write("Extinct"); break;
                    case ConservationStatus.EW: Console.Write("Extinct in the Wild"); break;
                    case ConservationStatus.CR: Console.Write("Critically Endangered"); break;
                    case ConservationStatus.EN: Console.Write("Endangered"); break;
                    case ConservationStatus.VU: Console.Write("Vulnerable"); break;
                    case ConservationStatus.NT: Console.Write("Near Threatened"); break;
                    case ConservationStatus.LC: Console.Write("Least Concern"); break;
                    default: Console.Write("Unknown"); break;
                }
                Console.WriteLine();
                Console.WriteLine("Hierarchy: ");
                Type type = animal.GetType();
                while (type.Name != "Object")
                {
                    Console.WriteLine("  - "+type.Name);
                    type = type.BaseType;
                }

                Console.WriteLine("");

            }

            Console.ReadKey();
        }
    }
}
