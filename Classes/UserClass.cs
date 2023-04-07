using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShurBolCofeeHouse.DataBase;

namespace ShurBolCofeeHouse.Classes
{
    internal class UserClass
    {
        public static Staff Staff { get; set; } = new Staff();
        public static Client Client { get; set; } = new Client();
    }
}
