using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_6
{
    
        
        
           
namespace OncelikliGorevler
    {
        class Program
        {
            static void Main(string[] args)
            {
               
                PriorityQueue<string, int> gorevKuyrugu = new PriorityQueue<string, int>();

                
                gorevKuyrugu.Enqueue("Evi temizle", 3);
                gorevKuyrugu.Enqueue("Faturaları öde", 1);
                gorevKuyrugu.Enqueue("Spor yap", 4);
                gorevKuyrugu.Enqueue("Proje kodlarını yaz", 2);
                gorevKuyrugu.Enqueue("Kitap oku", 5);
                gorevKuyrugu.Enqueue("Markete git", 2); 

                Console.WriteLine("--- Görevler Öncelik Sırasına Göre Çalıştırılıyor ---\n");

              
                while (gorevKuyrugu.Count > 0)
                {
                   
                    if (gorevKuyrugu.TryDequeue(out string gorev, out int oncelik))
                    {
                        Console.WriteLine($"[Öncelik: {oncelik}] Çalıştırılan Görev: {gorev}");
                    }
                }

                Console.WriteLine("\nTüm görevler tamamlandı.");
            }
        }
    }
}
    

