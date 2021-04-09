using System;

namespace reSchedule
{
    class Opsi
    {
        public static void Menu()
        {
            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();

                if (op == "1" || op == "menu")
                {
                    UserInt.Fungsi();
                }
                else if (op == "0" || op == "exit")
                {
                    Show.delay("Bye bye " + User.Nama + "~");
                    Environment.Exit(0);
                }
                else
                {
                    Show.delay("Pilihan Salah! ");
                    Program.Main();
                }
                if (op == "e")
                {
                    break;
                }
                Show.entry(Entries.entries1);
            }
        }

        public static void Fungsi()
        {
            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();

                if (op == Entries.entries2[0].getKey().ToLower() || op == Entries.entries2[0].getName().ToLower())
                {
                    Console.Clear();
                    User.addTask();
                    UserInt.Fungsi();
                }
                else if (op == Entries.entries2[1].getKey().ToLower() || op == Entries.entries2[1].getName().ToLower())
                {
                    Console.Clear();
                    User.deleteTask();
                    UserInt.Fungsi();
                }
                else if (op == Entries.entries2[2].getKey().ToLower() || op == Entries.entries2[2].getName().ToLower())
                {
                    Console.Clear();
                    User.showTask();
                    UserInt.Fungsi();
                }
                else if (op == Entries.entries2[3].getKey().ToLower() || op == Entries.entries2[3].getName().ToLower())
                {
                    Console.Clear();
                    UserInt.Menu();
                }
                else
                {
                    Show.delay("Pilihan Salah! ");
                    UserInt.Fungsi();
                }
                if (op == "e")
                {
                    break;
                }
                Show.entry(Entries.entries2);
            }
        }
    }
}
