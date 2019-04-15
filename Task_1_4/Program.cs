namespace Task_1_4
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType
        {
            Desktop = 1,
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
            //Computer Desktop;
            //Desktop.CPU = 4;
            //Desktop.memory = 6;
            //Desktop.HDD = 4;

            //Computer Laptop;
            //Laptop.CPU = 2;
            //Laptop.memory = 4;
            //Laptop.HDD = 250;

            //Computer Server;
            //Server.CPU = 8;
            //Server.memory = 16;
            //Server.HDD = 2000;
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




            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)



            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        }

    }
}
