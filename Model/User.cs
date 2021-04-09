using System;
using System.Collections.Generic;

namespace reSchedule
{
    class User : DefaultOne
    {
        private static string Name;
        public static List<Tugas> taskList { get; set; } = new List<Tugas>();
        private static string objek = "Tugas";

        public static string Objek { 
            get { return objek; } 
            set { objek = value; } 
        }

        public static string Nama
        {
            get { return Name; }
            set { Name = value; }
        }

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

        public override string getName()
        {
            return Name;
        }
    }
}
