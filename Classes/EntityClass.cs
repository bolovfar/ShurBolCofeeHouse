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
        public static Entities2 Context { get; } = new Entities2();
    }
}
