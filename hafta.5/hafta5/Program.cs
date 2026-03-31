using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
 


    
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Lütfen n değerini giriniz: ");

                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    Console.WriteLine($"\n1'den {n}'e kadar olan sayılar:");

                    SayilariYazdir(n);
                }
                else
                {
                    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
                }
            }

            static void SayilariYazdir(int n)
            {
 
                if (n == 0)
                {
                    return;
                }

                SayilariYazdir(n - 1);

           
                Console.WriteLine(n);
            }
        }
    }

    

