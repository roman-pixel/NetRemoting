using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_obj
{
    public class ServerObj : MarshalByRefObject
    {
        public int ServerMethod(string data)
        {
            var res = 1;
            var number = Convert.ToInt32(data);

            for (int i = 1; i <= number; i++)
            {
                res *= i;
            }

            Console.WriteLine("Вызов метода 1");
            return res;
        }
    }
}
