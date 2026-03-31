using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_9
{
    


    
        class Program
        {
            static void Main(string[] args)
            {
      
                Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

           
                ogrenciler.Add(1001, "Oyun Geliştirme");
                ogrenciler.Add(1002, "Yazılım");
                ogrenciler.Add(1003, "Grafik");
                ogrenciler.Add(1004, "Veri Bilimi");


                KeyValuePair<int, string>[] dizi = new KeyValuePair<int, string>[10];

                object value =ogrenciler.CopyTo(dizi, 3);

                Console.WriteLine("--- Diziye Aktarılan Öğrenci Kayıtları ---\n");

                for (int i = 0; i < dizi.Length; i++)
                {

                    string bolumDegeri = dizi[i].Value == null ? "BOŞ" : dizi[i].Value;

                    Console.WriteLine($"İndeks {i}: Anahtar (Key): {dizi[i].Key} -> Değer (Value): {bolumDegeri}");
                }

                Console.WriteLine("\n--- Sözlük Temizleme (Clear) İşlemi ---");
                Console.WriteLine($"Temizleme öncesi sözlükteki kayıt sayısı: {ogrenciler.Count}");

    
                ogrenciler.Clear();

                Console.WriteLine("Sözlük Clear() metodu ile tamamen temizlendi.");
                Console.WriteLine($"Güncel sözlük kayıt sayısı (Count): {ogrenciler.Count}");
            }
        }
    }

    

