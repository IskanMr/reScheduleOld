using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    class User
    {

        public List<Tugas> Add(List<Tugas> list)
        {
            string opt;
            do
            {
                Console.Clear();
                Console.Write("Nama Tugas\t: ");
                string a = Console.ReadLine();
                Console.Write("Durasi Tugas\t: ");
                int b = Convert.ToInt16(Console.ReadLine());

                list.Add(new Tugas(a, b));
                Console.WriteLine("\nKetik 0 untuk keluar! ");
                opt = Console.ReadLine();
            } while (opt != "0");
            return ListOrder(list);
        }

        public List<Tugas> ListOrder(List<Tugas> list)
        {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (list[j - 1].duration > list[j].duration)
                        {
                            Tugas temp = list[j - 1];
                            list[j - 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            return list;
         }

        public List<Tugas> removeTask(List<Tugas> list)
        {
            string opt;
            do
            {
                Console.Clear();
                list.RemoveAt(0);
                Console.Write("\nKetik 0 untuk keluar! ");
                opt = Console.ReadLine();
            } while (opt != "0");
            return list;
        }

        public void showList(List<Tugas> list)
        {
            foreach (Tugas tugas in list)
            {
                Console.WriteLine(tugas.name);
                Console.WriteLine(tugas.date);
            }
        }

    }
}
