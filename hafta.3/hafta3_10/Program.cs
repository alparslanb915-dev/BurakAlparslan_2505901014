using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_10
{



    
        class Program
        {
            static void Main(string[] args)
            {
                Tuple<string, string, int, string> calisan = new Tuple<string, string, int, string>("Ibrahim", "Seckin", 5, "Developer");

                Console.WriteLine("--- Personel Bilgisi ---");

               
                Console.WriteLine($"{calisan.Item1} {calisan.Item2} - {calisan.Item3} yıl - {calisan.Item4}");
            }
        }
    }

    

