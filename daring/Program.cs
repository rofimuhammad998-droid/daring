using System;


namespace TugasPemrogramanCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TUGAS PEMROGRAMAN C# - SMKN 2 BUDURAN (X RPL) ===");
            Console.WriteLine("======================================================\n");


            Console.WriteLine("--- I. KATEGORI FOR ---");


            Console.WriteLine("\n[For 1] Menampilkan Angka 1-5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n[For 2] Angka Genap 2-10:");
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine("Angka genap: " + i);
            }


            Console.WriteLine("\n[For 3] Hitung Mundur Roket:");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Mulai!");


            Console.WriteLine("\n[For 4] Perkalian 5:");
            int perkalian = 5;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i} x {perkalian} = {i * perkalian}");
            }


            Console.WriteLine("\n[For 5] Segitiga Bintang:");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n--- II. KATEGORI WHILE ---");


            Console.WriteLine("\n[While 1] Menampilkan Angka 1-5:");
            int w1 = 1;
            while (w1 <= 5)
            {
                Console.WriteLine(w1);
                w1++;
            }


            Console.WriteLine("\n[While 2] Kelipatan 3 Kurang dari 15:");
            int w2 = 3;
            while (w2 < 15)
            {
                Console.WriteLine("Nilai i: " + w2);
                w2 += 3;
            }


            Console.WriteLine("\n[While 3] Simulasi Saldo Tabungan:");
            int saldo = 50000;
            while (saldo > 0)
            {
                Console.WriteLine($"Saldo saat ini: Rp {saldo}");
                saldo -= 15000;
            }
            Console.WriteLine("Saldo habis.");


            Console.WriteLine("\n[While 4] Cetak Pesan 4 Kali:");
            int counter = 1;
            while (counter <= 4)
            {
                Console.WriteLine("Belajar C# itu menyenangkan ke-" + counter);
                counter++;
            }


            Console.WriteLine("\n[While 5] Kelipatan Perkalian 2:");
            int w5 = 2;
            while (w5 <= 20)
            {
                Console.WriteLine("Angka: " + w5);
                w5 *= 2;
            }


            Console.WriteLine("\n--- III. KATEGORI DO WHILE ---");


            Console.WriteLine("\n[Do While 1] Menampilkan Angka 1-5:");
            int dw1 = 1;
            do
            {
                Console.WriteLine(dw1);
                dw1++;
            } while (dw1 <= 5);


            Console.WriteLine("\n[Do While 2] Cetak Minimal Sekali (Kondisi False):");
            int dw2 = 10;
            do
            {
                Console.WriteLine("Pesan ini pasti tercetak minimal sekali, nilai x = " + dw2);
                dw2++;
            } while (dw2 < 5);


            Console.WriteLine("\n[Do While 3] Penjumlahan Bertahap:");
            int dw3 = 1;
            int totalDw3 = 0;
            do
            {
                totalDw3 += dw3;
                dw3++;
            } while (dw3 <= 4);
            Console.WriteLine("Total jumlah: " + totalDw3);


            Console.WriteLine("\n[Do While 4] Menu Pilihan:");
            int menu = 1;
            do
            {
                Console.WriteLine("Menjalankan menu sistem ke-" + menu);
                menu++;
            } while (menu <= 3);


            Console.WriteLine("\n[Do While 5] Hitung Mundur:");
            int dw5 = 3;
            do
            {
                Console.WriteLine("Hitung mundur: " + dw5);
                dw5--;
            } while (dw5 > 0);


            Console.WriteLine("\n--- IV. KATEGORI FOREACH ---");


            Console.WriteLine("\n[Foreach 1] Menampilkan Array Angka:");
            int[] angkaFe = { 1, 2, 3, 4, 5 };
            foreach (int a in angkaFe)
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("\n[Foreach 2] Daftar Nama Buah:");
            string[] buah = { "Apel", "Mangga", "Jeruk", "Pisang" };
            foreach (string b in buah)
            {
                Console.WriteLine("Buah: " + b);
            }


            Console.WriteLine("\n[Foreach 3] Koleksi Nilai Siswa:");
            int[] nilaiUjian = { 80, 85, 90, 75, 95 };
            foreach (int nilai in nilaiUjian)
            {
                Console.WriteLine("Nilai siswa: " + nilai);
            }


            Console.WriteLine("\n[Foreach 4] Huruf dari String 'RPL':");
            string kata = "RPL";
            foreach (char huruf in kata)
            {
                Console.WriteLine("Karakter: " + huruf);
            }


            Console.WriteLine("\n[Foreach 5] Daftar Hari Aktif:");
            string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat" };
            foreach (string h in hari)
            {
                Console.WriteLine("Hari aktif: " + h);
            }


            Console.WriteLine("\n--- V. KATEGORI ARRAY ---");


            Console.WriteLine("\n[Array 1] 5 Nama Siswa:");
            string[] namaSiswa = { "Andi", "Budi", "Citra", "Dani", "Eva" };
            for (int i = 0; i < namaSiswa.Length; i++)
            {
                Console.WriteLine(namaSiswa[i]);
            }


            Console.WriteLine("\n[Array 2] Daftar Mata Pelajaran:");
            string[] mapel = { "Matematika", "Pemrograman Berorientasi Objek", "Basis Data", "PKK" };
            for (int i = 0; i < mapel.Length; i++)
            {
                Console.WriteLine($"Mapel ke-{i + 1}: {mapel[i]}");
            }


            Console.WriteLine("\n[Array 3] Hitung Rata-Rata Nilai:");
            int[] nilaiArr = { 75, 80, 90, 85 };
            int totalArr = 0;
            for (int i = 0; i < nilaiArr.Length; i++)
            {
                totalArr += nilaiArr[i];
            }
            double rataRata = (double)totalArr / nilaiArr.Length;
            Console.WriteLine("Rata-rata nilai: " + rataRata);


            Console.WriteLine("\n[Array 4] Mengakses Indeks Spesifik:");
            string[] hobi = { "Membaca", "Coding", "Gaming", "Olahraga" };
            Console.WriteLine("Hobi utama saya: " + hobi[1]);
            Console.WriteLine("Hobi cadangan saya: " + hobi[2]);


            Console.WriteLine("\n[Array 5] Mengubah Nilai Elemen Array:");
            string[] warna = { "Merah", "Hijau", "Biru" };
            warna[1] = "Kuning";
            for (int i = 0; i < warna.Length; i++)
            {
                Console.WriteLine(warna[i]);
            }


            Console.WriteLine("--- VI. KATEGORI LIST ---");


            Console.WriteLine("[List 1] Menambah & Menampilkan Data Siswa:");
            List<string> siswaList = new List<string>();
            siswaList.Add("Andi");
            siswaList.Add("Budi");
            siswaList.Add("Citra");
            foreach (string s in siswaList)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("[List 2] Menambah & Menghapus Item (Kota):");
            List<string> kota = new List<string> { "Surabaya", "Sidoarjo", "Malang" };
            kota.Add("Gresik");
            kota.Remove("Malang");
            foreach (string k in kota)
            {
                Console.WriteLine("Kota: " + k);
            }


            Console.WriteLine("[List 3] Menhitung Jumlah Item (Count):");
            List<int> angkaList = new List<int> { 10, 20, 30, 40 };
            angkaList.Add(50);
            Console.WriteLine("Total item dalam list: " + angkaList.Count);


            Console.WriteLine("[List 4] Pencarian Data (Contains):");
            List<string> hobiList = new List<string> { "Gaming", "Coding", "Badminton" };
            if (hobiList.Contains("Coding"))
            {
                Console.WriteLine("Hobi Coding ada di dalam list!");
            }


            Console.WriteLine("[List 5] Hitung Total Belanja:");
            List<int> hargaBarang = new List<int>();
            hargaBarang.Add(5000);
            hargaBarang.Add(12000);
            hargaBarang.Add(7500);
            int totalBelanja = 0;
            foreach (int harga in hargaBarang)
            {
                totalBelanja += harga;
            }
            Console.WriteLine("Total belanjaan: Rp " + totalBelanja);

            Console.WriteLine("======================================================");
            Console.WriteLine("Selesai! 30 Program Pemrograman C# telah dieksekusi.");
        }
    }
}