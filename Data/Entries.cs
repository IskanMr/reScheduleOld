﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reSchedule
{
    class Entries
    {
        public static Entry[] entries1 { get; set; } = new Entry[]{
            new Entry("Menu", "1"),
            new Entry("Keluar", "0"),
        };

        public static Entry[] entries2 { get; set; } = new Entry[]{
            new Entry("Tambahkan Tugas", "1"),
            new Entry("Hapus Tugas", "2"),
            new Entry("Tunjukan Semua Tugas", "3"),
            new Entry("Kembali", "0")
        };
    }
}
