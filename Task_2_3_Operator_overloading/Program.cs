using System;

namespace Task_2_3_Operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
              // 10) declare 2 objects
            Money amount1 = new Money(4.0m, CurrencyTypes.USD);
            Money amount1a = new Money(7.0m, CurrencyTypes.USD);
            Money amount2 = new Money(1.0m, CurrencyTypes.EUR);
            Money amount3 = new Money(1.0m, CurrencyTypes.UAH);	
            // 11) do operations
            // add 2 objects of Money
            Money sum = new Money();
            sum = amount1 + amount1a; // USD and USD
            Console.WriteLine("Sum: " + sum.Amount + " " + sum.CurrencyType);
	    // add 2 objects of  Money with anoter CurrencyType
	    Console.WriteLine("Amount1: " + (double)amount1 + "\r\nAmount2: " + (double)amount2);
            Console.WriteLine("Course USD: " +(int)CurrencyTypes.USD + "\r\nCourse EUR: " + (int)CurrencyTypes.EUR);
            Money sum2 = new Money();
	    sum2 = amount1 + amount2; // EUR and UAH
            Console.WriteLine("Sum2: " + sum2.Amount + " " + sum2.CurrencyType);			
            // add 1st object of Money and double
           //  double doubAm1 = Convert.ToDouble(amount1.Amount);
            double sum1 = (double)amount1 + 1.789;
            Console.WriteLine("Sum: Amount1 + 1.789= " + sum1);
            // decrease 2nd object of Money by 1 
            Money decrea = new Money();
            decrea = amount1a--;
            Console.WriteLine("Decrease: Amount1a-- = " + decrea.Amount + " " + decrea.CurrencyType);
            // increase 1st object of Money
            Money incX3 = new Money();
            incX3 = amount1 * 3;
            Console.WriteLine("Increase 1st object 3 times = " + incX3.Amount + " " + incX3.CurrencyType);
            // compare 2 objects of Money
            Console.WriteLine(amount1.Amount > amount1a.Amount ? "Amount1 > Amount 1a" : "Amount1 < Amount 1a");
            // compare 2nd object of Money and string
            Console.WriteLine(amount1.Amount == amount1a.Amount ? "Amount1 = Amount 1a" : "Amount1 =! Amount 1a");
            Console.WriteLine(amount1.CurrencyType == amount1a.CurrencyType ? "It's both USD " : "It's NOT both USD");
            // check CurrencyType of every object
            // convert 1st object of Money to string
            string Str_amount1 = (string)amount1;
            Console.WriteLine(Str_amount1);
            Console.ReadLine();
        }
    }
}
