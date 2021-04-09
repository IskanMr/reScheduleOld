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
                    Show.delay("Bye bye~");
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

                if (op == Entries.entries2[0].key.ToLower() || op == Entries.entries2[0].name.ToLower())
                {
                    Console.Clear();
                    User.addTask();
                    UserInt.Fungsi();
                }
                else if (op == Entries.entries2[1].key.ToLower() || op == Entries.entries2[1].name.ToLower())
                {
                    Console.Clear();
                    User.deleteTask();
                    UserInt.Fungsi();
                }
                else if (op == Entries.entries2[2].key.ToLower() || op == Entries.entries2[2].name.ToLower())
                {
                    Console.Clear();
                    User.showTask();
                    UserInt.Fungsi();
                }
                else if (op == Entries.entries2[3].key.ToLower() || op == Entries.entries2[3].name.ToLower())
                {
                    Console.Clear();
                    Program.Main();
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
