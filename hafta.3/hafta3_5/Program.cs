using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_5
{
 

    
        class Program
    {
        static void Main(string[] args)
        {

            List<string> urunler = new List<string> { "Mouse", "Klavye", "Monitör", "Kulaklık", "Webcam" };

            Console.WriteLine("--- Mevcut Ürün Listesi ---");
            for (int i = 0; i < urunler.Count; i++)
            {
                Console.WriteLine($"[{i}] {urunler[i]}");
            }


            Console.Write("\nLütfen aramak istediğiniz ürünün adını tam olarak giriniz: ");
            string arananUrun = Console.ReadLine();


            if (urunler.Contains(arananUrun))
            {
                int indeks = urunler.IndexOf(arananUrun);
                Console.WriteLine($"[BULUNDU] '{arananUrun}' adlı ürün listenin {indeks}. indeksinde yer alıyor. ✔️");
            }
            else
            {
                Console.WriteLine($"[BİLGİ] '{arananUrun}' adlı ürün listede bulunamadı. ❌");
            }


            Console.WriteLine("\n--- Ürün Silme İşlemi ---");

        }
    }
}

