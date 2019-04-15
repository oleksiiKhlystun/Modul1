using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Хороший день";
            // обрезаем начиная с третьего символа
            text = text.Substring(2);
            // результат "роший день"
            Console.WriteLine(text);
            string text2 = "12345";
            // обрезаем сначала до последних двух символов
            text2 = text2.Substring(0, text2.Length - 1);
            // результат "роший де"
            Console.WriteLine(text2);
            Console.ReadKey();
        }
    }
}
