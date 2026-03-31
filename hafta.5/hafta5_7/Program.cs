using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_7
{
  


    
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Lütfen bir sayı giriniz: ");

                if (int.TryParse(Console.ReadLine(), out int sayi))
                {

                    int islemeAlinacakSayi = Math.Abs(sayi);

                    int toplam = BasamakToplamiHesapla(islemeAlinacakSayi);

                    Console.WriteLine($"\n{sayi} sayısının basamakları toplamı: {toplam}");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir tam sayı giriniz.");
                }
            }

            static int BasamakToplamiHesapla(int n)
            {

                if (n == 0)
                {
                    return 0;
                }


                int sonBasamak = n % 10;


                return sonBasamak + BasamakToplamiHesapla(n / 10);
            }
        }
    }

    

