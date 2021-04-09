using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    public class Tugas
    {

        public string Nama { get; set; }
        public int Durasi { get; set; }

        public string Deadline{ get;set;}

        public Tugas(string name, int duration)
        {
            this.Nama = name;
            this.Durasi = duration;
            DateTime dt = DateTime.Today.AddDays(duration);
            this.Deadline = dt.ToShortDateString();
        }
    }
}
