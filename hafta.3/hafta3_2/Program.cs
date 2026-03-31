using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_2

        
        

    {
        class Program
        {
            static void Main(string[] args)
            {
              
                Queue<int> urunKuyrugu = new Queue<int>();

             
                urunKuyrugu.Enqueue(101);
                urunKuyrugu.Enqueue(203);
                urunKuyrugu.Enqueue(305);
                urunKuyrugu.Enqueue(407);
                urunKuyrugu.Enqueue(509);

                Console.WriteLine("--- Ürün Stok Kontrol Sistemi ---\n");

                Console.Write("Lütfen sorgulamak istediğiniz ürün kodunu giriniz: ");

              
                if (int.TryParse(Console.ReadLine(), out int arananUrunKodu))
                {
                    
                    if (urunKuyrugu.Contains(arananUrunKodu))
                    {
                        Console.WriteLine("\n[SONUÇ] Ürün mevcut. ✔️");
                    }
                    else
                    {
                        Console.WriteLine("\n[SONUÇ] Ürün yok. ❌");
                    }
                }
                else
                {
                    Console.WriteLine("\n[HATA] Geçersiz giriş yaptınız. Lütfen sadece sayısal bir kod giriniz.");
                }

                Console.WriteLine("\n--- Gün Sonu Temizlik İşlemleri ---");
                Console.WriteLine($"Temizleme işlemi öncesi kuyruktaki ürün sayısı (Count): {urunKuyrugu.Count}");

              
                urunKuyrugu.Clear();
                Console.WriteLine("Kuyruktaki tüm ürünler silindi (Clear() çalıştırıldı).");

               
                Console.WriteLine($"Güncel kuyruk eleman sayısı (Count): {urunKuyrugu.Count}");
            }
        }
    }

    

