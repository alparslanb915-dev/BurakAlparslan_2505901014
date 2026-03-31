using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_8
{
   
    {
        class Program
        {
            static void Main(string[] args)
            {
              
                int[] sayilar = { 45, 12, 78, 3, 99, 21, 8, 15, 6, 88, 2, 34, 1, 55 };
                int k = 5; 

               
                PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

               
                foreach (int sayi in sayilar)
                {
                    minHeap.Enqueue(sayi, sayi);
                }

                Console.WriteLine("Orijinal Dizi: " + string.Join(", ", sayilar));
                Console.WriteLine($"\nTam sıralama yapılmadan bulunan en küçük {k} eleman:");

               
                for (int i = 0; i < k; i++)
                {
                    
                    if (minHeap.Count > 0)
                    {
                      
                        int enKucuk = minHeap.Dequeue();
                        Console.WriteLine($"{i + 1}. en küçük sayı: {enKucuk}");
                    }
                }
            }
        }
    }
}
    }
}
