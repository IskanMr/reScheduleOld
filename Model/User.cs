using System.Collections.Generic;

namespace reSchedule
{
    class User
    {
        public static List<Tugas> taskList { get; set; } = new List<Tugas>();
        private static string obj = "Tugas";

        public static void addTask()
        {
            Func.Add(obj);
        }
        public static void deleteTask()
        {
            Func.Delete(obj);
        }
        public static void showTask()
        {
            Func.Show();
        }
    }
}
