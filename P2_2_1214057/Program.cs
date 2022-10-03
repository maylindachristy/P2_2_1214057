using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gaji Maylinda");
            Console.Write("Masukkan Gaji : ");

            int Gajipokok = int.Parse(Console.ReadLine());
            int tunjangan = (Gajipokok * 20) / 100;
            int bonus = (Gajipokok * 15) / 100;
            double satu = (Gajipokok * 3.5) / 100;
            double dua = (Gajipokok + tunjangan + bonus);
            double tiga = (Gajipokok + tunjangan + bonus) - satu;

            Console.WriteLine("Gaji Pokok = " + Gajipokok);
            Console.WriteLine("Tunjangan = " + tunjangan);
            Console.WriteLine("Bonus = " + bonus);
            Console.WriteLine("PPH = " + satu);
            Console.WriteLine("Total Gaji = " + dua);
            Console.WriteLine("Gaji Bersih = " + tiga);
        }
    }
}
