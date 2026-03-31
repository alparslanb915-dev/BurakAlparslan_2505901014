using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_2
{
 


    
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Lütfen n değerini giriniz: ");

                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    Console.WriteLine($"\n{n}'den 1'e kadar olan sayılar:");

                    GeriyeDogruYazdir(n);
                }
                else
                {
                    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
                }
            }

            static void GeriyeDogruYazdir(int n)
            {
         
                if (n == 0)
                {
                    return;
                }

                Console.WriteLine(n);

          
                GeriyeDogruYazdir(n - 1);
            }
        }
    }

    

