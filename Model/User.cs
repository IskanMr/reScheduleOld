using System;
using System.Collections.Generic;

namespace reSchedule
{
    public class User :  Thing
    {
        private static string Name { get; set; }
        public static List<Tugas> taskList { get; set; } = new List<Tugas>();
        private static string objek = "Tugas";
        public string Nama { get { return Name; } set{ Name = value; } }

        public static string Objek { 
            get { return objek; } 
            set { objek = value; } 
        }

        public static void addTask() => Func.Add(Objek);
        public static void deleteTask() => Func.Delete(Objek);
        public static void showTask()
        {
            string opt = "1";
            while(opt != "0")
            {
                Func.Show();
                Console.Write("Ketik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
        }

        public static string getName() => Name;
    }
}
