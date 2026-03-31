using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_10
{
    
    
        class Program
        {
            static void Main(string[] args)
            {
                PriorityQueue<string, int> aiKararMekanizmasi = new PriorityQueue<string, int>();

               
                aiKararMekanizmasi.Enqueue("Patrol (Devriye Gez)", 5);
                aiKararMekanizmasi.Enqueue("Chase (Hedefi Kovala)", 2);
                aiKararMekanizmasi.Enqueue("Attack (Saldır!)", 1);
                aiKararMekanizmasi.Enqueue("Run (Kaç!)", 0); 

                Console.WriteLine("--- Yapay Zeka Karar Verme Süreci Başladı ---\n");

                
                while (aiKararMekanizmasi.Count > 0)
                {
                   
                    if (aiKararMekanizmasi.TryDequeue(out string gorev, out int oncelik))
                    {
                        Console.WriteLine($"[Öncelik: {oncelik}] AI şu an şu görevi yapıyor: {gorev}");

                        
                    }
                }

                Console.WriteLine("\nKuyrukta bekleyen başka görev kalmadı.");
            }
        }
    }

    
