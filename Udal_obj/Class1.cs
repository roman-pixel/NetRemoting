using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udal_obj
{
    public class Udal_obj : MarshalByRefObject
    {
        public string LetterWrapping(string word, int k)
        {
            var res = "";

            Console.WriteLine("Вызов метода 2");

            if (word.Length > k)
            {
                var firstLetters = word.Substring(0, k);
                word = word.Remove(0, k);
                res = word + firstLetters;
            }
            else
            {
                res = "Длина слова меньше значения k";
            }

            return res;
        }
    }
}
