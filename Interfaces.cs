using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_app
{
    interface IAlive
    {
        int Food { get; }

    }
    interface IInventory
    {
        int Number { get; }
    }
    public interface IHealthCheck
    {
        bool IsHealthyCheck(Animal animal);
    }
}
