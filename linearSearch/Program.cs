using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            string[] array = {"one","two","three","four","five",
                             "six","seveN","Eight","NINE","TeN"};
            do
            {
                Console.Write("Введите элемент поиска: ");
                LinearSearch.Search(array, Console.ReadLine());
                Console.Write("Продолжить? [yes][no]: ");
                string ans = Console.ReadLine();
                key = (ans.ToLower() == "yes") ? key = true : key = false;
            } while (key);
            Console.WriteLine("Поиск окончен.");
            Console.ReadLine();
        }
    }
}
