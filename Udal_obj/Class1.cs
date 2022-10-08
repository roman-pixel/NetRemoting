using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udal_obj
{
    public class Udal_obj : MarshalByRefObject
    {
        public int Letter(string word)
        {
            Console.WriteLine("Вызов метода 2");
            word = word.ToLower();
            var res = word.Where(x => "о".IndexOf(x) != -1).Count();
            return res;
        }
    }
}
