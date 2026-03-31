using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_6
{
    

namespace ListeDiziKopyalama
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                List<int> sayilar = new List<int> { 4, 8, 15, 16, 23, 42 };

               
                int[] dizi = new int[15];

              
                sayilar.CopyTo(dizi, 5);

                Console.WriteLine("--- Diziye Aktarılan Elemanlar ---");

                
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine($"İndeks {i}: {dizi[i]}");
                }

                Console.WriteLine("\n--- Liste Temizleme İşlemi ---");
                Console.WriteLine($"Temizleme öncesi listedeki eleman sayısı: {sayilar.Count}");

               
                sayilar.Clear();

                Console.WriteLine("Liste Clear() metodu ile tamamen temizlendi.");
                Console.WriteLine($"Güncel liste eleman sayısı (Count): {sayilar.Count}");
            }
        }
    }
}
    

