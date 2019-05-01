using System;

namespace Task_2_2a_Cons_Dr_Methods
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box
        private int width;
        public int Width
		{
			get {return width;}
			set {width = value;}
		}
        private int height;
        public int Height
		{
			get {return height;}
			set {height = value;}
		}
		private string simbol;
        public string Simbol
		{
			get {return simbol;}
			set {simbol = value;}
		}
        private int left;
        public int Left
		{
			get {return left;}
			set {left = value;}
		}
        private int top;
        public int Top
		{
			get {return top;}
			set {top = value;}
		}
        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        public void Draw()
        {
            // Console.WriteLine("Enter Wigth,Height,Simbol,Left,Top");
            int square = draw(width, height, simbol, left, top);
            Console.WriteLine("\nSquare = " + square);
        }
        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
        private int draw(int height, int width, string simbol, int left, int top)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i == 0 || i == height - 1) || (j == 0 || j == width - 1))
                    {
                        Console.SetCursorPosition(left + i, top + j);
                        Console.Write(simbol);
                    }
                    else
                    {
                        Console.SetCursorPosition(left + i, top + j);
                        Console.Write(" ");
                    } //prints inside other than border
                }
            }
            return width * height;
        }

    }
}
