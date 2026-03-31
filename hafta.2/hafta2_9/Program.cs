using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_9
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
                
                PriorityQueue<string, int> skorTablosu = new PriorityQueue<string, int>();

               
                Ekle(skorTablosu, "Ahmet", 1500);
                Ekle(skorTablosu, "Elif", 2850);
                Ekle(skorTablosu, "Can", 1200);
                Ekle(skorTablosu, "Deniz", 3500);
                Ekle(skorTablosu, "Merve", 2100);
                Ekle(skorTablosu, "Selin", 4200);

                Console.WriteLine("--- Haftalık Skor Tablosu (En Yüksek 3 Oyuncu) ---\n");

               
                for (int i = 1; i <= 3; i++)
                {
                    if (skorTablosu.Count > 0)
                    {
                      
                        if (skorTablosu.TryDequeue(out string oyuncu, out int negatifSkor))
                        {
                       
                            int gercekSkor = negatifSkor * -1;
                            Console.WriteLine($"{i}. Sırada: {oyuncu} - Puan: {gercekSkor}");
                        }
                    }
                }
            }

           
            static void Ekle(PriorityQueue<string, int> kuyruk, string isim, int skor)
            {
               
                kuyruk.Enqueue(isim, -skor);
            }
        }
    }

    

