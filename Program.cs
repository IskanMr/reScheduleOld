using CommandDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            Console.WriteLine("\t[2] Exit");

            Console.Write("\nPilihan anda: ");
            string opt = Console.ReadLine();
            string op = opt.ToLower();

            if (op == "1" || op == "menu")
            {
                Input();
            }
            else if (op == "2" || op == "exit")
            {
                Console.Clear();
                Console.WriteLine("Bye bye~");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Pilihan Salah !");
                Thread.Sleep(1000);
                Main();
            }
        }
        static void  Input()
        {
            List<Tugas> list = new List<Tugas>();
            User user = new User();

            Entry[] entries = new Entry[]
            {
                new Entry("Add Task", "A"),
                new Entry("Remove Task", "R"),
                new Entry("Show Task List", "S"),
                new Entry("Return", "E")
            };

            Console.Clear();

            Console.WriteLine("Pilihan: ");

            foreach(Entry entry in entries)
            {
                Console.WriteLine("\t[" + entry.key + "] - " + entry.name);
            }

            Console.Write("\nPilihan anda: ");
            string opt = Console.ReadLine();
            string op = opt.ToLower();

            if (op == entries[0].key.ToLower() || op == entries[0].name.ToLower())
            {
                Console.Clear();
                list = user.Add(list);
                Input();
            }
            else if (op == entries[1].key.ToLower() || op == entries[1].name.ToLower())
            {
                Console.Clear();
                list = user.removeTask(list);
                Input();
            }
            else if (op == entries[2].key.ToLower() || op == entries[2].name.ToLower())
            {
                Console.Clear();
                user.showList(list);
                Input();
            }
            else if (op == entries[3].key.ToLower() || op == entries[3].name.ToLower())
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Pilihan Salah !");
                Thread.Sleep(1000);
                Input();
            }
        }
    }
}
