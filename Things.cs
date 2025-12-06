using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_app
{
    public class Thing : IInventory
    {
        public int Number {  get; set; }
        public int InventNum { get; set; }
    }

    public class Table : Thing
    {
        public Table() { }
    }
    public class Computer : Thing
    {
        public Computer() { }
    }
}
