using System;

namespace Task_2_2b_factorial
{
    class Program
    {

        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
            Console.WriteLine("Enter number");
            int Numb;
            for (; ; )
            {
                int testNumb = Convert.ToInt32(Console.ReadLine());
                if (testNumb <= 0)
                {
                    Console.WriteLine("Enter positive integer");
                }
                else
                {
                    Numb = testNumb;
                    break;
                }
            }
            int z = Fact(Numb);
            Console.WriteLine(z);
            Console.ReadLine();
        }
        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator
        static int Fact(int x)
        {
            return x = (x == 0) ? 1 : x * Fact(x - 1);
            //if (x == 0)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return x * fact(x - 1);
            //}
        }
    }



}
