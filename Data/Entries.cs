﻿namespace reSchedule
{
    class Entries
    {
        public static Entry[] entries1 { get; set; } = new Entry[]{
            new Entry("Menu", "1"),
            new Entry("Keluar", "0"),
        };

        public static Entry[] entries2 { get; set; } = new Entry[]{
            new Entry("Tambahkan " + User.Objek,"1"),
            new Entry("Hapus " + User.Objek, "2"),
            new Entry("Tunjukan Semua " + User.Objek, "3"),
            new Entry("Kembali", "0")
        };
    }
}
