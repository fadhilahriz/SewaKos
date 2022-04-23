using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PAW
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remarks>Class Program dapat membuat Input, Proses, Output</remarks>>
    public class Program
    {
        /// <summary>
        /// Method utama yang digunakan untuk memanggil method method diatas
        /// </summary>
        /// <param name="args">Hasil output</param>
        static void Main(string[] args)
        {
            Sewakos p = new Sewakos();
            Console.WriteLine("===================================================");
            Console.WriteLine(" Program Input Data Sewa Kos");
            Console.WriteLine("===================================================");
            //memanggil method method
            p.Satu();
            p.DuaA();
            p.DuaB();
            p.Tiga();
        }
    }

    public class Sewakos
    {
        /// Deklarasi Variabel dengan Tipe data String, Int, Double
        public string nama, status;
        public double h,d,kmr, sewa, harga, ttl, ktp, tlp;

        /// <summary>
        /// Method Satu yg berfungsi sebagai inputan dalam aplikasi
        /// </summary>
        public void Satu()
        {
            //Input Nama
            Console.Write(" Masukkan Nama         : ");
            nama = Convert.ToString(Console.ReadLine());
            //Input No Identitas
            Console.Write(" Masukkan No Identitas : ");
            ktp = Convert.ToDouble(Console.ReadLine());
            //Input No Telpon
            Console.Write(" Masukkan No Telepon   : ");
            tlp = Convert.ToDouble(Console.ReadLine());
            //Input Status
            Console.Write(" Masukkan Status       : ");
            status = Convert.ToString(Console.ReadLine());
        }

        /// <summary>
        /// Method DuaA yang berisi if else untuk memilih tipe kamar
        /// </summary>
        public void DuaA()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine(" Tipe Kamar ");
            Console.WriteLine(" 1. Kamar Mandi Luar  ");
            Console.WriteLine(" 2. Kamar Mandi Dalam ");
            Console.WriteLine("===================================================");
            //Untuk menginputkan Pilihan Kamar
            Console.Write(" Masukkan Pilihan Kamar [1/2] : ");
            kmr = Convert.ToDouble(Console.ReadLine());
            //Percabangan
            if (kmr == 1)
            {
                h = 70000;
            }
            else
            {
                h = 85000;
            }
        }

        /// <summary>
        /// Method DuaB yg berisi if else untuk memilih tipe sewa dan kemudian untuk memasukan durasi sewa
        /// </summary>
        public void DuaB()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine(" Tipe Sewa ");
            Console.WriteLine(" 1. Harian");
            Console.WriteLine(" 2. Bulanan");
            Console.WriteLine("===================================================");
            //Untuk menginputkan Pilihan Sewa
            Console.Write(" Masukkan Pilihan Sewa [1/2]  : ");
            sewa = Convert.ToDouble(Console.ReadLine());
            //Percabangan
            if (sewa == 1)
            {
                //Untuk menginputkan durasi sewa
                Console.Write(" Masukkan Durasi Sewa [Hari]  : ");
                d = Convert.ToDouble(Console.ReadLine());
                ttl = Day(h,d);
            }
            else
            {
                //Untuk menginputkan durasi sewa
                Console.Write(" Masukkan Durasi Sewa [Bulan] : ");
                d = Convert.ToDouble(Console.ReadLine());
                ttl = Month(h,d);
            }
        }

        public double Day(double h,double d)
        {
            //Operasi Aritmatika untuk menghitung total
            return h * d;
        }

        public double Month(double h, double d)
        {
            //Operasi Aritmatika untuk menghitung total
            return (h * 10) * d;
        }

        /// <summary>
        /// Method Tiga untuk menampilkan output
        /// </summary>
        public void Tiga()
        {
            Console.WriteLine("===================================================");
            Console.Write(" Total Biaya           : " + ttl);
            Console.ReadKey();
        }
    }
}
