using System;

namespace Task_1_4
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType
        {
            Desktop ,
            Laptop,
            Server
        }

        // 2) declare struct Computer
        struct Computer
        {
            public int CPUcore;
            public float CPUfreq;
            public int memory;
            public int HDD;
       

 }


        static void Main(string[] args)
        {
           
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer [,][] computers = new Computer[4,3][];

            // 4) set the size of every array in jagged array (number of computers)
            computers[0,0] = new Computer[2];
            computers[0,1] = new Computer[2];
            computers[0,2] = new Computer[1];
            computers[1,0] = new Computer[0];
            computers[1,1] = new Computer[3];
            computers[1,2] = new Computer[0];
            computers[2,0] = new Computer[3];
            computers[2,1] = new Computer[2];
            computers[2,2] = new Computer[0];
            computers[3, 0] = new Computer[1];
            computers[3, 1] = new Computer[1];
            computers[3, 2] = new Computer[2];
            // 5) initialize array
            // Note: use loops and if-else statements
       //   Console.WriteLine(computers.GetLength(0));
    //    Console.WriteLine(computers.GetLength(1));
                        for (int i = 0; i < computers.GetLength(0); i++)
                        {
                            for (int j = 0; j < computers.GetLength(1); j++)
                            {
                                for (int k = 0; k < computers[i, j].Length; k++)
                                {
                                    if (j == (int)ComputerType.Desktop)
                                    {
                                        //Desktop
                                        computers[i, j][k].CPUcore = (byte)(4 + 2 * k);
                                        computers[i, j][k].CPUfreq = 2.5f;
                                        computers[i, j][k].memory = 6;
                                        computers[i, j][k].HDD = 500;
                                    }
                                    if (j == (int)ComputerType.Laptop)
                                    {
                                        //Laptop
                                        computers[i, j][k].CPUcore = 2;
                                        computers[i, j][k].CPUfreq = 1.7f;
                                        computers[i, j][k].memory = 4;
                                        computers[i, j][k].HDD = 250;
                                    }
                                    if (j == (int)ComputerType.Server)
                                    {
                                        //Server
                                        computers[i, j][k].CPUcore = 8;
                                        computers[i, j][k].CPUfreq = 3.0f;
                                        computers[i, j][k].memory = 16;
                                        computers[i, j][k].HDD = 2000;
                                    }
                                }
                            }
                        }


            // 6) count total number of every type of computers
            Console.WriteLine("- Count total number of every type of computers ");
            int totalCount = 0;
                      for (int i = 0; i < computers.GetLength(0); i++)
                      {
                          for (int j = 0; j < computers.GetLength(1); j++)
                          {
                            for (int k = 0; k < computers[i, j].Length; k++)
                                {
                                   totalCount++;
                                }
                          }
                      }
            Console.WriteLine($"count total number of every type of computers " +totalCount);
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            Console.WriteLine("- Count total number of all computers ");
            int totalDesktop = 0;
            int totalLaptop = 0;
            int totalServer = 0;
            for (int i = 0; i < computers.GetLength(0); i++)
            {
                for (int j = 0; j < computers.GetLength(1); j++)
                {
                    for (int k = 0; k < computers[i, j].Length; k++)
                    {
                        if (j == (int)ComputerType.Desktop)
                        {
                            totalDesktop++;
                        }
                        if (j == (int)ComputerType.Laptop)
                        {
                            totalLaptop++;
                        }
                        if (j == (int)ComputerType.Server)
                        {
                            totalServer++;
                        }
                    }
                }
            }
            Console.WriteLine($"Count Desktop is " + totalDesktop);
            Console.WriteLine($"Count Laptop is " + totalLaptop);
            Console.WriteLine($"Count Server is " + totalServer);

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            Console.WriteLine("- Find computer with the largest storage (HDD) ");
            int countHDD = 0;
            for (int i = 0; i < computers.GetLength(0); i++)
            {
                for (int j = 0; j < computers.GetLength(1); j++)
                {
                    for (int k = 0; k < computers[i, j].Length; k++)
                    {
                        if (computers[i, j][k].HDD == 2000)
                        {
                            countHDD++;
                            Console.WriteLine($"{countHDD} computer with the largest storage (HDD) has index [{i}],[{j}]");
                        }
                        
                    }
                }
            }


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
           Console.WriteLine("- Find computer with the lowest productivity (CPU and memory)");
           int productivity = 0;
            for (int i = 0; i < computers.GetLength(0); i++)
            {
                for (int j = 0; j < computers.GetLength(1); j++)
                {
                    for (int k = 0; k < computers[i, j].Length; k++)
                    {
                        if ((computers[i, j][k].CPUcore == 8) && (computers[i, j][k].memory == 16))
                        {
                            productivity++;
                            Console.WriteLine($"{productivity} computer with the largest productivity has index [{i}],[{j}]");
                        }
                    }
                }
            }

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            Console.WriteLine("- Make desktop upgrade: change memory up to 8");
            int upgrate = 0;
            for (int i = 0; i < computers.GetLength(0); i++)
            {
                for (int j = 0; j < computers.GetLength(1); j++)
                {
                    for (int k = 0; k < computers[i, j].Length; k++)
                    {
                        if ((j == (int)ComputerType.Desktop) && (computers[i, j][k].memory == 6))
                        {
                            computers[i, j][k].memory = 8;
                            upgrate++;
                            Console.WriteLine($"{upgrate} Desktop [{i}],[{j}] memory changed to 8");
                        }
                    }
                }
            }
            Console.WriteLine("Finish");
            Console.ReadLine();
        }

    }
}
