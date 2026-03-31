using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_8

{ 


    class Program

{
        static void Main(string[] args)
        {

            Dictionary<string, int> stokDurumu = new Dictionary<string, int>();

            stokDurumu.Add("Kalem", 20);
            stokDurumu.Add("Defter", 0);
            stokDurumu.Add("Silgi", 50);
            stokDurumu.Add("Kitap", 8);

            Console.WriteLine("--- Ürün Stok Takip Sistemi ---\n");


            Console.Write("Lütfen stok durumunu öğrenmek istediğiniz ürünü giriniz: ");
            string arananUrun = Console.ReadLine();


            if (stokDurumu.ContainsKey(arananUrun))
            {
                int stokMiktari = stokDurumu[arananUrun];
                Console.WriteLine($"[SONUÇ] '{arananUrun}' adlı ürünün güncel stok miktarı: {stokMiktari} adet. ✔️");
            }
            else
            {
                Console.WriteLine($"[SONUÇ] '{arananUrun}' adlı ürün stoklarımızda yok. ❌");
            }

            Console.WriteLine("\n--- Genel Stok Analizi ---");


        if (stokDurumu.ContainsValue(0))
        {
            Console.WriteLine("[UYARI] Dikkat! Sistemde stoku tükenmiş (0 olan) en az bi");
        }
        else
        {
            Console.WriteLine("[BİLGİ] Sistemdeki tüm ürünlerden stokta mevcut (Stoku 0 olan ürün yok).");
        }

          
            Console.WriteLine($"Sistemde kayıtlı toplam farklı ürün sayısı (Count): {stokDurumu.Count}");
        }
    }
}


            
        
    
   

