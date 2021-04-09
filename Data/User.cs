using ConsoleTables;
using System;
using System.Collections.Generic;

namespace reSchedule
{
    class User
    {

        public void Add()
        {
            string opt="1";
            while(opt!="0")
            {
                Console.Clear();
                showList();

                Console.Write("Nama Tugas\t\t: ");
                string a = Console.ReadLine();
                Console.Write("Durasi Tugas (Hari) \t: ");
                int b = Convert.ToInt16(Console.ReadLine());

                myList.taskList.Add(new Tugas(a, b));
                myList.taskList = ListOrder(myList.taskList);

                Console.WriteLine("\nKetik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
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
            string opt = "1";
            while (opt != "0")
            {
                int i = 0;
                Console.Clear();
                showList();
                Console.WriteLine("Pilih Tugas yang dihapus: ");
                string ops = Console.ReadLine().ToLowerInvariant();
                while(true)
                {
                        if (ops == myList.taskList[i].Nama.ToLower() || ops == Convert.ToString(i+1))
                        {
                            Console.Clear();
                            string name = myList.taskList[i].Nama;
                            myList.taskList.RemoveAt(i);
                            showList();
                            Console.WriteLine("Tugas " + name + " telah dihapus\n");
                            break;
                        }
                    i++;
                }
                Console.Write("Ketik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
        }

        public void showList()
        {
            ConsoleTable
                .From(myList.taskList)
                .Write();
            Console.WriteLine("\n");
        }

    }
}
