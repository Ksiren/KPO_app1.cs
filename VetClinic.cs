using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_app
{
    public class VetClinic : IHealthCheck
    {
        public bool IsHealthyCheck(Animal animal)
        {
            animal.IsHealthy = new Random().Next(0, 10) > 3;
            Console.WriteLine($"Doc said that {animal.ToString().Substring(8)} is {(animal.IsHealthy ? "healthy" : "unhealthy and going to heal")}\n");
            return animal.IsHealthy;
        }
    }
}
