using System;

namespace reSchedule
{
    public class Tugas : DefaultOne, Thing
    {
        private string Name { get; set; }
        private int Duration { get; set; }
        private string deadline{ get;set;}

        public string Nama { get { return Name; } set { Name = value; } }
        public int Durasi { 
            get { return Duration; } 
            set { Duration = value; } 
        }
        public string Deadline { 
            get { return deadline; } 
            set { deadline = value; } 
        }

        public Tugas(string name, int duration)
        {
            Name = name;
            Duration = duration;
            DateTime dt = DateTime.Today.AddDays(duration);
            deadline = dt.ToShortDateString();
        }

        public override string getName() => Nama;

    }
}
