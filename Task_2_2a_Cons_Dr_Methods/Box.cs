using System;

namespace Task_2_2a_Cons_Dr_Methods
{
    class Box
    {
        //private int top;
        //internal int Left;

        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box

        public int Width { get; set; } = Convert.ToInt32(Console.ReadLine());

        public int Height { get; set; } = Convert.ToInt32(Console.ReadLine());

        public string Simbol { get; set; } = Convert.ToString(Console.ReadLine());

        public int Left { get; set; } = Convert.ToInt32(Console.ReadLine());

        public int Top { get; set; } = Convert.ToInt32(Console.ReadLine());

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        public void Draw()
        {
            // Console.WriteLine("Enter Wigth,Height,Simbol,Left,Top");
            int square = draw(3, 5, "f", Left, Top);
            Console.WriteLine("\nSquare = " + square);
        }
        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
        private int draw(int Height, int Width, string Simbol, int Left, int Top)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if ((i == 0 || i == Height - 1) || (j == 0 || j == Width - 1))
                    {
                        Console.SetCursorPosition(Left + i, Top + j);
                        Console.Write(Simbol);
                    }
                    else
                    {
                        Console.SetCursorPosition(Left + i, Top + j);
                        Console.Write(" ");
                    } //prints inside other than border
                }
            }
            return Width * Height;
        }

    }
}
