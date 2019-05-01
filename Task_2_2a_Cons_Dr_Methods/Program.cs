using System;

namespace Task_2_2a_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Implement start position, width and height, symbol, message input
                //Create Box class instance
                Console.WriteLine("Enter Wigth,Height,Simbol,Left,Top");
                Box box = new Box();
                box.Width = Convert.ToInt32(Console.ReadLine());
				box.Height = Convert.ToInt32(Console.ReadLine());
				box.Simbol = Convert.ToString(Console.ReadLine());
				box.Left = Convert.ToInt32(Console.ReadLine());
			    box.Top = Convert.ToInt32(Console.ReadLine());
                //Use  Box.Draw() method
                box.Draw();
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
            }

        }
    }
}
