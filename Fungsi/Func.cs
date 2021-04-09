using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    class Func
    {
        public static void Add(string obj)
        {
            string opt = "1";
            while (opt != "0")
            {
                Console.Clear();
                Show();

                Console.Write("Nama " + obj + " \t\t: ");
                string a = Console.ReadLine();

                Console.Write("Durasi " + obj + " (Hari) \t: ");
                int b = Convert.ToInt16(Console.ReadLine());

                User.taskList.Add(new Tugas(a, b));
                User.taskList = Sort.linearSort(User.taskList);

                Console.WriteLine("\nKetik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
        }

        public static void Delete(string obj)
        {
            string opt = "1";
            while (opt != "0")
            {
                int i = 0;
                Console.Clear();
                Show();
                Console.WriteLine("Pilih " + obj + " yang dihapus: ");
                string ops = Console.ReadLine().ToLowerInvariant();
                while (true)
                {
                    if (ops == User.taskList[i].Nama.ToLower() || ops == Convert.ToString(i + 1))
                    {
                        Console.Clear();
                        string name = User.taskList[i].Nama;
                        User.taskList.RemoveAt(i);
                        Show();
                        Console.WriteLine("Tugas " + name + " telah dihapus\n");
                        break;
                    }
                    i++;
                }
                Console.Write("Ketik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
        }

        public static void Show()
        {
            ConsoleTable
                .From(User.taskList)
                .Write();
            Console.WriteLine("\n");
        }

    }
}
