using System;

namespace reSchedule
{
    public class Tugas
    {
        private string Name { get; set; }
        private int Duration { get; set; }
        private string Deadline{ get;set;}

        public string Nama { 
            get { return Name; } 
            set { Name = value; } 
        }
        public int Durasi { 
            get { return Duration; } 
            set { Duration = value; } 
        }
        public string deadline { 
            get { return Deadline; } 
            set { Deadline = value; } 
        }

        public Tugas(string name, int duration)
        {
            Name = name;
            Duration = duration;
            DateTime dt = DateTime.Today.AddDays(duration);
            Deadline = dt.ToShortDateString();
        }
    }
}
