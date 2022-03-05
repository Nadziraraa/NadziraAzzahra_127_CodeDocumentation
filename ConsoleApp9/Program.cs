using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekSuhuMasukBioskop
{
    /// <summary>
    /// main class
    /// </summary>
    class Program
    {
        public double sh;
        /// <summary>
        /// Method input untuk memasukan angka suhu tubuh
        /// </summary>
        public void input()
        {
            Console.Write("masukkan angka suhu =");
            sh = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// method keterangan apakah angka suhu sesuai atau tidak dan sayrat bisa masuk atau tidak
        /// </summary>
        /// <returns> jika angka sedang maka diperbolehkan masuk jika normal juga bisa, jika berat tidak bisa</returns>
        public string ket()
        {
           
            string status;
            if (sh <= 37)
            {
                status = "SEDANG";
                Console.WriteLine("ANDA DIPERBOLEHKAN MASUK, \nKARENA SUHU ANDA {0}", sh);
            }
            else if (sh == 37)
            {
                status = "NORMAL";
                Console.WriteLine("ANDA DIPERBOLEHKAN MASUK, \nKARENA SUHU ANDA {0}", sh);
            }

            else
            {
                status = "BERAT";
                Console.WriteLine("ANDA TIDAK DIPERBOLEHKAN MASUK, \nKARENA SUHU ANDA {0}", sh);
            }
            return status;
        }

        /// <summary>
        /// method output untuk menampilan nilai
        /// </summary>
        public void output()
        {
            Console.WriteLine("hasil cek suhu = {0}", ket());
            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"> parameter nama untuk menampung argumen</param>
        static void Main(string[] args)
        {
            Program pr = new Program();

            pr.input();
            Console.WriteLine();
            pr.output();
        }
    }
}