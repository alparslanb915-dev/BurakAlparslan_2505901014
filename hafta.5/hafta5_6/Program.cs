using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_6
{
    


    
        class Program
        {
            static void Main(string[] args)
            {
               
                int[] sayilar = { 15, 42, 8, 99, 23, 7 };

              
                int enBuyuk = EnBuyukBul(sayilar, 0);

                Console.WriteLine("--- Dizi İçinde En Büyük Elemanı Bulma ---");
                Console.WriteLine("Dizi: " + string.Join(", ", sayilar));
                Console.WriteLine($"\nEn büyük eleman: {enBuyuk}");
            }

         
            static int EnBuyukBul(int[] dizi, int indeks)
            {
                
                if (indeks == dizi.Length - 1)
                {
                    return dizi[indeks];
                }

               
                int geriKalaninEnBuyugu = EnBuyukBul(dizi, indeks + 1);

              
                return Math.Max(dizi[indeks], geriKalaninEnBuyugu);
            }
        }
    }

    

