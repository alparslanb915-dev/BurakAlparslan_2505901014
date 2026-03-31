using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_3
{



    using System;
    using System.Collections.Generic;

    namespace KuyrukDiziKopyalama
    {
        class Program
        {
            static void Main(string[] args)
            {

                Queue<int> sayiKuyrugu = new Queue<int>();


                sayiKuyrugu.Enqueue(10);
                sayiKuyrugu.Enqueue(20);
                sayiKuyrugu.Enqueue(30);
                sayiKuyrugu.Enqueue(40);


                int[] dizi = new int[10];


                sayiKuyrugu.CopyTo(dizi, 3);

                Console.WriteLine("--- Diziye Kopyalama İşlemi Sonucu ---");

                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine($"İndeks {i}: {dizi[i]}");
                }

                Console.WriteLine("\n--- Kuyruğu Boşaltma (Dequeue) İşlemi ---");


                while (sayiKuyrugu.Count > 0)
                {
                    int cikanEleman = sayiKuyrugu.Dequeue();
                    Console.WriteLine($"Çıkan: {cikanEleman}");
                }


                Console.WriteLine($"\n[BİLGİ] İşlem bitti. Güncel kuyruk eleman sayısı: {sayiKuyrugu.Count}");
            }
        }
            
        
    



