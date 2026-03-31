using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_3
{



    
        class Program
        {
            static void Main(string[] args)
            {
 
                int[] sayilar = { 10, 20, 30, 40, 50 };

                Console.WriteLine("--- Dizinin Elemanları (Rekürsif) ---");

                DiziYazdir(sayilar, 0);
            }

            static void DiziYazdir(int[] dizi, int indeks)
            {
 
                if (indeks == dizi.Length)
                {
                    return;
                }

                Console.WriteLine($"İndeks {indeks}: {dizi[indeks]}");

                DiziYazdir(dizi, indeks + 1);
            }
        }
    }

    

