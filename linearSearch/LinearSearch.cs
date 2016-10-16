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
                int? answer = null;
                for (int i = 0; i < strS.Length; i++)
                {
                    if (str.ToLower() == strS[i].ToLower()) 
                    {
                        answer = i;
                    }
                }
                if (answer != null)
                {

                    Console.WriteLine("Искомый элемент находится на позиции: {0}\nЭлемент: {1}", answer + 1, strS[(int)answer]);
                }
                else 
                {
                    Console.WriteLine("Элемент не найден!");
                }
         }
    }
}
