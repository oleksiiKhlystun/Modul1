using System;
//Тут я просто тестирую все для себя
namespace forTests
{
    class Program
    {
        static void Main(string[] args)
        {
            int hldr;
            string a_str = "";
            int a=55;
            while (a > 0)
            { 
            hldr = a % 2;
             //Console.WriteLine(hldr);
            a_str += hldr;
         //    Console.WriteLine(a_str);
                a = a / 2;
            }
            Console.WriteLine(a_str);
            Console.ReadLine();
        }
    }
}
