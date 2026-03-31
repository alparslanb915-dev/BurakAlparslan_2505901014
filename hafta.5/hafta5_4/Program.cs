using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_4
{
    internal class Program
    {
      


    
        
           static void Main(string[] args)
            {
                Console.Write("Lütfen ters çevrilecek kelimeyi giriniz: ");
                string kelime = Console.ReadLine();

                string tersKelime = TersCevir(kelime);

                Console.WriteLine($"\nOrijinal Metin: {kelime}");
                Console.WriteLine($"Ters Çevrilmiş Hali: {tersKelime}");
            }

           
            static string TersCevir(string metin)
            {
           
                if (string.IsNullOrEmpty(metin) || metin.Length <= 1)
                {
                    return metin;
                }

                return TersCevir(metin.Substring(1)) + metin[0];
            }
        }
    }

    

