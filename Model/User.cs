using System;
using System.Collections.Generic;

namespace reSchedule
{
    class User
    {
        public static List<Tugas> taskList { get; set; } = new List<Tugas>();
        public static string objek = "Tugas";

        public static void addTask()
        {
            Func.Add(objek);
        }
        public static void deleteTask()
        {
            Func.Delete(objek);
        }
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
    }
}
