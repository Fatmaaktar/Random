using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin, hak=5;
            bool durum=false;
            Random random = new Random();
            int rastgeleSayi = random.Next(0, 100);

            for (int kalanHak = hak; kalanHak > 0 ; kalanHak--)
            {
                Console.WriteLine("Hak {0}", kalanHak);
                Console.WriteLine("Tahmininiz : ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler");
                    durum = true;
                    break;
                }
                else if (rastgeleSayi>tahmin && kalanHak!=1)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                }
                else if (rastgeleSayi < tahmin && kalanHak != 1)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                }
            }
                Console.WriteLine("Tekrar Deneyin");
                Console.WriteLine("Sayı : {0}", rastgeleSayi);

            Console.ReadKey();
        }
    }
}
