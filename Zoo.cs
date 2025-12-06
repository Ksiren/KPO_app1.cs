using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_app
{
    public class Zoo
    {
        public List<Animal> animals = new();
        public List<Thing> things = new();
        private IHealthCheck healthCheck;
        private int inventNum;
        public Zoo(IHealthCheck _healthCheck)
        {
            healthCheck = _healthCheck;
            inventNum = 0;
        }

        public bool AddAnimal(Animal animal)
        {
            if (healthCheck.IsHealthyCheck(animal)) 
            {
                animals.Add(animal);
                Console.WriteLine($"Congratulations! You have new animal {animal.ToString().Substring(8)}");
                return true;
            }
            else
            {
                Console.WriteLine("Whoops, your animal is sick");
                return false;
            }
        }
        public void AddThing(Thing thing)
        {
            inventNum++;
            thing.Number = inventNum;
            things.Add(thing);
            Console.WriteLine($"Now you have ({thing.Number}) {thing.ToString().Substring(8)}\n");
        }

        public int NumOfAnimals() => animals.Count();
        
        public int NumOfFood() => animals.Sum(anim => anim.Food);
        
        public List<Animal> ListOfContAnimals() => animals.OfType<Herbo>().Where(anim => anim.Kindness > 5).Cast<Animal>().ToList();

    }
}
