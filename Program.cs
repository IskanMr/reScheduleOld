using System;
using System.Threading;


namespace reSchedule
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.Title = "reSchedule";
            mainMenu();
        }

        static void mainMenu()
        {
            Console.WriteLine("Pilihan: ");
            Console.WriteLine("\t[1] Menu");
            Console.WriteLine("\t[0] Exit");

            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();
            
                if (op == "1" || op == "menu")
                {
                    Input();
                }
                else if (op == "0" || op == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Bye bye~");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Pilihan Salah!");
                    Thread.Sleep(1000);
                    Main();
                }
                if(op == "e")
                {
                    break;
                }
                Console.WriteLine("Pilihan: ");
                Console.WriteLine("\t[1] Menu");
                Console.WriteLine("\t[0] Exit");
            }
            
        }
        static void  Input()
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("Pilihan: ");

            foreach(Entry entry in myList.entries)
            {
                Console.WriteLine("\t[" + entry.key + "] - " + entry.name);
            }

            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();

                if (op == myList.entries[0].key.ToLower() || op == myList.entries[0].name.ToLower())
                {
                    Console.Clear();
                    user.Add();
                    Input();
                }
                else if (op == myList.entries[1].key.ToLower() || op == myList.entries[1].name.ToLower())
                {
                    Console.Clear();
                    user.removeTask();
                    Input();
                }
                else if (op == myList.entries[2].key.ToLower() || op == myList.entries[2].name.ToLower())
                {
                    Console.Clear();
                    user.showList();
                    Console.Write("\nKetik 0 untuk kembali! ");
                    string p = Console.ReadLine();
                    if (p == "0")
                    {
                        Input();
                    }
                }
                else if (op == myList.entries[3].key.ToLower() || op == myList.entries[3].name.ToLower())
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Pilihan Salah!");
                    Thread.Sleep(1000);
                    Input();
                }
                if (op == "e")
                {
                    break;
                }

                Console.WriteLine("Pilihan: ");

                foreach (Entry entry in myList.entries)
                {
                    Console.WriteLine("\t[" + entry.key + "] - " + entry.name);
                }
            }
            
        }
    }
}
