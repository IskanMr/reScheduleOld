using System;

namespace reSchedule
{
    public class Tugas
    {

        public string Nama { get; set; }
        public int Durasi { get; set; }

        public string Deadline{ get;set;}

        public Tugas(string name, int duration)
        {
            Nama = name;
            Durasi = duration;
            DateTime dt = DateTime.Today.AddDays(duration);
            Deadline = dt.ToShortDateString();
        }
    }
}
