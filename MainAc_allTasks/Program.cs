using System;

namespace Task_1_3
{

    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            4. Guess the number
             ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4:
                    Guess_the_number();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
           
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.White;
            //     3827183; 3817283

            Console.WriteLine("Please,  type numbers by step ");
            bool way1 = true;
            for (int i = 1; i <= 7; i++)
            {
                bool exitCycle = true;

                int num = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        {
                            if (num == 3)
                            {
                                Console.Write("Good!\n");
                            }
                            else
                            {
                                exitCycle = false;
                                Console.Write("----------You loser!-----------");

                            }

                        }
                        break;
                    case 2:
                        {
                            if (num == 8)
                            {
                                Console.Write("Good!\n");
                            }
                            else
                            {
                                exitCycle = false;
                                Console.Write("----------You loser!-----------");

                            }
                        }
                        break;
                    case 3:
                        {
                            if (num == 1)
                            {
                                way1 = true;
                                Console.Write("Good!\n");
                            }
                            else if (num == 2) { d = false; Console.Write("Good!\n"); }
                            else
                            {
                                exitCycle = false;

                                Console.Write("----------You loser!-----------");

                            }
                        }
                        break;
                    case 4:
                        {
                            if (num == 7)
                            {
                                Console.Write("Good!\n");
                            }
                            else
                            {
                                exitCycle = false;
                                Console.Write("----------You loser!-----------");

                            }
                        }
                        break;
                    case 5:
                        {
                            //Console.Write (d);
                            if ((num == 2) && (way1 == true) || (num == 1) && (way1 == false))
                            {
                                Console.Write("Good!\n");
                            }

                            else
                            {
                                exitCycle = false;
                                Console.Write("----------You loser!-----------");

                            }
                        }
                        break;
                    case 6:
                        {
                            if (num == 8)
                            {

                                Console.Write("Good!\n");
                            }
                            else
                            {
                                exitCycle = false;
                                Console.Write("----------You loser!-----------");

                            }
                        }
                        break;
                    case 7:
                        {
                            if (num == 3)
                            {
                                Console.Write("Good!\n");
                            }
                            else
                            {
                                exitCycle = false;
                                Console.Write("----------You loser!-----------");

                            }
                        }
                        break;
                }
                if (exitCycle == false) break;
            }
            // Если бы вариант был один
           /* for (int i = 3817283; i >= 3; i = i / 10)
            {

                Console.WriteLine("Please,  type numbers by step ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == i % 10) Console.Write("Good!\n");
                else
                {
                    Console.Write("----------You loser!-----------");
                    break;
                }
            }
   */
                //     3827183; 3817283

            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

        }
        #endregion

        #region calculator
        static void Calculator()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter 1 number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result;
            // Set Console.ForegroundColor  value
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"Select the arithmetic operation:
            1. Multiplication 
            2. Divide 
            3. Addition 
            4. Subtraction
            5. Exponentiation ");
            int numberOp = Convert.ToInt32(Console.ReadLine());
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
            switch (numberOp)
            {
                case 1:
                    {
                        result = number1 * number2;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Multiplication " + number1 + " and " + number2 + " is " + result);
                    }
                    break;
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        result = number1 / number2;
                        Console.WriteLine("Divide " + number1 + " and " + number2 + " is " + result);
                    }
                    break;
                case 3:
                    {
                        result = number1 + number2;
                        Console.WriteLine("Addition " + number1 + " and " + number2 + " is " + result);
                    }
                    break;
                case 4:
                    {
                        result = number1 - number2;
                        Console.WriteLine("Subtraction " + number1 + " and " + number2 + " is " + result);
                    }
                    break;
                case 5:
                    {
                        result = Math.Pow(number1, number2);
                        Console.WriteLine("Exponentiation " + number1 + " and " + number2 + " is " + result);
                    }
                    break;


            }
            
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.WriteLine("Enter number to calculate factorial of the number");
            ulong number = Convert.ToUInt64(Console.ReadLine());
            ulong factorial = number;
            for (ulong i = number-1; i >= 1; i--)
            {
           factorial = factorial * i;
            }
            Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Factorial of the number " + number + " is " + factorial);
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result
        }
        #endregion

        static void Guess_the_number()
        {
            
            Random r = new Random();
            int rand = r.Next(0, 1000); //diapason
            for (int i = 1; ;i++ )
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter your guess : ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < rand) Console.Write("Too Low!\n");
                else if (number > rand) Console.Write("Too Hight!\n");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Is right! Congratulations!\n ");
                    break;
                }
            }

        }
    }
}

