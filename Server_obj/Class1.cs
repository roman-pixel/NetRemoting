using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_obj
{
    public class ServerObj : MarshalByRefObject
    {
        public double ServerMethod(int a1, double a2)
        {
            a2 = a1 + Math.Sqrt(a2);
            Console.WriteLine("Вызов метода 1");
            return a2;
        }
    }
}
