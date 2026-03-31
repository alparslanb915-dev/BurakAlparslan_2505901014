using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
        
                Queue<string> bankaKuyrugu = new Queue<string>();

            
                bankaKuyrugu.Enqueue("Ali");
                bankaKuyrugu.Enqueue("Ayşe");
                bankaKuyrugu.Enqueue("Mehmet");
                bankaKuyrugu.Enqueue("Zeynep");

                Console.WriteLine("--- Banka Kuyruğu Simülasyonu ---\n");

          
                string siradakiMusteri = bankaKuyrugu.Peek();
                Console.WriteLine($"[BİLGİ] Sırada bekleyen ilk müşteri (Peek): {siradakiMusteri}\n");

                Console.WriteLine("--- İşlem Gören Müşteriler ---");
                Console.WriteLine($"Hizmet verildi: {bankaKuyrugu.Dequeue()}");
                Console.WriteLine($"Hizmet verildi: {bankaKuyrugu.Dequeue()}");
                Console.WriteLine("------------------------------\n");

              
                Console.WriteLine("--- Kalan Kuyruk Durumu ---");
                Console.WriteLine($"Bekleyen Müşteri Sayısı (Count): {bankaKuyrugu.Count}");

                Console.WriteLine("Kuyrukta bekleyen kişiler sırasıyla:");
                foreach (string musteri in bankaKuyrugu)
                {
                    Console.WriteLine($"- {musteri}");
                }
            }
        }
    }

    

