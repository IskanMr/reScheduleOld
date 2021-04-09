using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    class myList
    {
        public static List<Tugas> taskList { get; set; } = new List<Tugas>();
        public static Entry[] entries { get; set; } = new Entry[]{
            new Entry("Tambahkan Tugas", "1"),
            new Entry("Hapus Tugas Paling Dekat", "2"),
            new Entry("Tunjukan Semua Tugas", "3"),
            new Entry("Kembali", "0")
        };
    }
}
