using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearSearch
{
    static class LinearSearch
    {
        public static void Search(string[] strS,string str)
        {
                int i = 0;
                string last = strS[strS.Length-1];
                strS[strS.Length-1] = str;
                while (strS[i] != str) i++;
                strS[strS.Length - 1] = last;
                if (i < strS.Length || strS[strS.Length - 1] == str) {
                Console.WriteLine("Искомый элемент находится на позиции: {0}\nЭлемент: {1}", i + 1, strS[i]);
                }
                else 
                {
                    Console.WriteLine("Элемент не найден!");
                }
         }
    }
}
