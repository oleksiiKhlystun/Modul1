using System;
using System.Threading;
namespace Task_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Abcolute value of difference between 2 numbers
              written as a unary string.
            2. Record of the number as binary string
            3. SOS Morse code
            
             ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    unary();
                    Console.WriteLine("");
                    break;
                case 2:
                    binary();
                    Console.WriteLine("");
                    break;
                case 3:
                    Morse();
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        
         }

        static void unary()
        {
            Console.WriteLine("Enter two positive integers");
            int number1;
            int number2;
            for (; ; )
            {
                int testNumber1 = Convert.ToInt32(Console.ReadLine());
                if (testNumber1 <= 0)
                {
                    Console.WriteLine("Enter positive integer");
                }
                else
                {
                    number1 = testNumber1;
                    break;
                }
            }
            for (; ; )
            {
                int testNumber2 = Convert.ToInt32(Console.ReadLine());
                if (testNumber2 <= 0)
                {
                    Console.WriteLine("Enter positive integer");
                }
                else
                {
                    number2 = testNumber2;
                    break;
                }
            }
            int SubtrAbsNum1Nam2;
            string num1str = "";
            string num2str = "";
            string allStr = "";
       //
            for (int i = 1; i<=number1;i++)
            {
               num1str= num1str+ "1";
            }
            for (int j = 1; j <= number2; j++)
            {
                num2str = num2str + "1";
            }
            allStr = num1str + "#"+ num2str;
            Console.WriteLine(allStr);
        //
            if (number1 > number2) { SubtrAbsNum1Nam2 = number2; } else { SubtrAbsNum1Nam2 = number1; }      
            for (int z = 1; z <= SubtrAbsNum1Nam2; z++)
            {
                allStr = allStr.Substring(1);
                allStr = allStr.Substring(0, allStr.Length - 1);
                Console.WriteLine(allStr);  
            }
            if (number1 > number2) { allStr = allStr.Substring(0, allStr.Length - 1); } else { allStr = allStr.Substring(1); }
            Console.WriteLine(allStr);

            Console.WriteLine($"obtained value as unary string is " + allStr);  
            Console.WriteLine($"obtained value as number is " + allStr.Length);
            Console.ReadKey();
        }
        static void binary()
        {
            int number;
            Console.WriteLine("Enter positive integer");
            for (; ; )
            {
                int testNumber = Convert.ToInt32(Console.ReadLine());
                if (testNumber <= 0)
                {
                    Console.WriteLine("Enter positive integer");
                }
                else
                {
                    number = testNumber;
                    break;
                }
            }
            int hldr;
            string number_str = "";
            while (number > 0)
            {
                hldr = number % 2;
                number_str += hldr;
                number = number / 2;
            }
            //Convert to charArray
            char[] chars_number_str = number_str.ToCharArray();
            //reverse
            Array.Reverse(chars_number_str);
            Console.WriteLine("After reversing:");
            //convert to string
            number_str = new string (chars_number_str);
            Console.WriteLine(number_str);
        }
        static void Morse()
        {
            Console.WriteLine("Morse sound");
            // Console.WriteLine(" Stop - press 0");
            // bool Stop = true;
           
                for (int i = 1; i <= 3; i++)
                {
                    Console.Beep(1000, 666);
                    Thread.Sleep(500);
                }
                for (int i2 = 1; i2 <= 3; i2++)
                {
                    Console.Beep(1000, 333);
                    Thread.Sleep(250);
                }
                for (int i3 = 1; i3 <= 3; i3++)
                {
                    Console.Beep(1000, 666);
                    Thread.Sleep(500);
                }
         }
    }
}
