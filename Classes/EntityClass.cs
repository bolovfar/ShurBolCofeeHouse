using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShurBolCofeeHouse.DataBase;

namespace ShurBolCofeeHouse.Classes
{
    internal class EntityClass
    {
        public static Entities Context { get; } = new Entities();
        public static int IDChange = 0;
        public static bool Change = false;
    }
}
