using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hafta2_11
{
   
        class Program
        {
            static void Main(string[] args)
            {
                PriorityQueue<string, (int Oncelik, long EklenmeSirasi)> stabilKuyruk = new PriorityQueue<string, (int, long)>();

                long globalSayac = 0; 

                Console.WriteLine("--- Aynı Öncelikli Görevlerin Stabil (Sıralı) İşlenmesi ---\n");

               
                void GorevEkle(string gorevAdi, int oncelikDerecesi)
                {
                    globalSayac++;

                 
                    stabilKuyruk.Enqueue(gorevAdi, (oncelikDerecesi, globalSayac));

                    Console.WriteLine($"[Kuyruğa Girdi] Öncelik: {oncelikDerecesi} | Sıra: {globalSayac} | Görev: {gorevAdi}");
                }

              
                GorevEkle("Acil Güvenlik Yaması", 1);
                GorevEkle("Arayüz Hatası - Rapor 1", 2);
                GorevEkle("Arayüz Hatası - Rapor 2", 2); 
                GorevEkle("Arayüz Hatası - Rapor 3", 2); 
                GorevEkle("Sunucu Çökmesi", 1);         
                Console.WriteLine("\n--- Görevler Kuyruktan Çıkarılıyor (Dequeue) ---");

               
                while (stabilKuyruk.Count > 0)
                {
                    if (stabilKuyruk.TryDequeue(out string islenenGorev, out var oncelikBilgisi))
                    {
                        Console.WriteLine($"Çalıştırılıyor -> Öncelik: {oncelikBilgisi.Oncelik} | Eklenme Sırası: {oncelikBilgisi.EklenmeSirasi} | Görev: {islenenGorev}");
                    }
                }
            }
        }
    }

    