using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_app
{
    public class Animal : IAlive
    {
        public int Food { get; set; }
        public int InventNum { get; set; }
        public bool IsHealthy { get; set; }
    }

    public class Herbo : Animal
    {
        public int Kindness { get; set; }
    }

    public class Predator : Animal { }


    public class Monkey : Herbo
    {
        public Monkey(int kindness)
        {
            Food = 3;
            Kindness = kindness;
        }
    }
    public class Rabbit : Herbo
    {
        public Rabbit(int kindness)
        {
            Food = 1;
            Kindness = kindness;
        }
    }
    public class Tiger : Predator 
    {
        public Tiger() 
        {
            Food = 9;
        }
    }
    public class Wolf : Predator 
    {
        public Wolf() 
        {
            Food = 5;
        }
    }
}
