using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_obj
{
    public class ServerObj : MarshalByRefObject
    {
        public double ServerMethod(string data)
        {
            var res = 0.0;
            var number = Convert.ToInt32(data);

            for (int i = 1; i <= number; i++)
            {
                res += Math.Pow(i, 2);
            }

            Console.WriteLine("Вызов метода 1");
            return a2;
        }
    }
}
