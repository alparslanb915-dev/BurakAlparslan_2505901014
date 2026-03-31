using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_4
{


    
        class Program
        {
            static void Main(string[] args)
           {
   
               List<int> notlar = new List<int>();

                Console.WriteLine("--- Öğrenci Not Sistemi ---");

       
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{i}. notu giriniz: ");

                    if (int.TryParse(Console.ReadLine(), out int girilenNot))
                    {
                        notlar.Add(girilenNot);
                    }
                    else
                    {
                        Console.WriteLine("[HATA] Lütfen geçerli bir sayı giriniz.");
                        i--; 
                    }
                }

                Console.WriteLine("\n--- Liste İşlemleri ---");

                
                Console.WriteLine($"Girilen toplam not sayısı (Count): {notlar.Count}");

            
                notlar.Sort();
                Console.WriteLine("\nKüçükten büyüğe sıralanmış hali (Sort):");
                Console.WriteLine(string.Join(", ", notlar));

                notlar.Reverse();
                Console.WriteLine("\nTers çevrilmiş hali / Büyükten küçüğe (Reverse):");
                Console.WriteLine(string.Join(", ", notlar));

                Console.WriteLine($"\nListenin 0. indeksindeki eleman (notlar[0]): {notlar[0]}");
            }
        }
    }

  

