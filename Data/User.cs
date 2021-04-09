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

        public void Add()
        {
            string opt;
            do
            {
                Console.Clear();
                Console.Write("Nama Tugas\t\t: ");
                string a = Console.ReadLine();
                Console.Write("Durasi Tugas (Hari) \t: ");
                int b = Convert.ToInt16(Console.ReadLine());

                myList.taskList.Add(new Tugas(a, b));
                Console.WriteLine("\nKetik 0 untuk kembali! ");
                opt = Console.ReadLine();
            } while (opt != "0");
            myList.taskList =  ListOrder(myList.taskList);
        }

        public List<Tugas> ListOrder(List<Tugas> list)
        {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (list[j - 1].Durasi > list[j].Durasi)
                        {
                            Tugas temp = list[j - 1];
                            list[j - 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            return list;
         }

        public void removeTask()
        {
            string opt;
            do
            {
                Console.Clear();
                Console.WriteLine("Tugas " + myList.taskList[0].Nama + " telah dihapus\n");
                myList.taskList.RemoveAt(0);
                Console.Write("Ketik 0 untuk kembali! ");
                opt = Console.ReadLine();
            } while (opt != "0");
        }

        public void showList()
        {
            ConsoleTable
                .From(myList.taskList)
                .Write();
        }

    }
}
