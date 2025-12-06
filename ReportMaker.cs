using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_app
{
    public class ReportMaker
    {
        Zoo zoo;
        public ReportMaker(Zoo zoo_) => zoo = zoo_;
        public void PrintNumOfAnimals() => Console.WriteLine($"Total Animals: {zoo.NumOfAnimals()}\n");

        public void PrintFoodPerDay() => Console.WriteLine($"Total kg Food per day: {zoo.NumOfFood()}\n");

        public void PrintListOfContact()
        {
            Console.WriteLine("\tList of contact animals:\n");
            var contactZoo = zoo.ListOfContAnimals();
            if (contactZoo.Count() == 0) {
                Console.WriteLine("No one :(\n");
            } else {
                foreach (var animal in contactZoo)
                {
                    var herb = (Herbo)animal;
                    Console.WriteLine($"{animal.ToString().Substring(8)}, kindness - {herb.Kindness}\n");
                }
            }
        }

        public void PrintListOfAnimals()
        {
            Console.WriteLine("\tList of animals:\n");
            var animalZoo = zoo.animals;
            if (animalZoo.Count() == 0)
            {
                Console.WriteLine("No one :(\n");
            }
            else
            {
                foreach (var animal in animalZoo)
                {
                    Console.WriteLine($"{animal.ToString().Substring(8)}\n");
                }
            }

        }
        public void PrintListOfThings()
        {
            Console.WriteLine("\tList of things:\n");
            var thingsZoo = zoo.things;
            if (thingsZoo.Count() == 0)
            {
                Console.WriteLine("Nothing :(\n");
            }
            else
            {
                foreach (var thing in thingsZoo)
                {
                    Console.WriteLine($"({thing.Number}) {thing.ToString().Substring(8)}\n");
                }
            }

        }

        public void PrintWholeReport()
        {
            Console.WriteLine("\tReport about happening in zoo:\n");
            PrintNumOfAnimals();
            PrintFoodPerDay();
            PrintListOfContact();
            PrintListOfAnimals();
            PrintListOfThings();
        }
    }
}
