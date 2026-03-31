using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_4
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
                Stack<int> sayilar = new Stack<int>();
                sayilar.Push(8);
                sayilar.Push(3);
                sayilar.Push(5);

                Console.WriteLine("--- İşlem Başlıyor ---");
                Console.WriteLine("Başlangıç Yığını (En üstten alta): " + string.Join(", ", sayilar));
                Console.WriteLine("----------------------\n");

                int adim = 1;

         
                while (sayilar.Count > 0 && adim <= 10)
                {

                    int ustteki = sayilar.Peek();

                    Console.Write($"Adım {adim} | Üstteki Eleman: {ustteki} -> ");

              
                    if (ustteki % 2 == 0)
                    {
                        sayilar.Pop();
                        Console.WriteLine("Çift olduğu için POP edildi.");
                    }
                    else
                    {

                        int eklenecekSayi = ustteki + 1;
                        sayilar.Push(eklenecekSayi);
                        Console.WriteLine($"Tek olduğu için {eklenecekSayi} PUSH edildi.");
                    }

                    adim++;
                }

                Console.WriteLine("\n----------------------");

              
                if (sayilar.Count > 0)
                {
                    Console.WriteLine("10 Adım Sonrası Yığın (En üstten alta): " + string.Join(", ", sayilar));
                }
                else
                {
                    Console.WriteLine("Yığın tamamen boşaldı.");
                }
            }
        }
    }

    

