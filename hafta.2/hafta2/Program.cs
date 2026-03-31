using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

namespace StackToplami
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Lütfen n değerini giriniz: ");

               
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    Stack<int> sayiYigini = new Stack<int>();

                   
                    for (int i = 1; i <= n; i++)
                    {
                        sayiYigini.Push(i);
                    }

                    int toplam = 0;

                    while (sayiYigini.Count > 0)
                    {
                        int cikarilanSayi = sayiYigini.Pop();
                        toplam += cikarilanSayi;
                    }

                 
                    Console.WriteLine($"\nStack'ten çıkarılan sayıların toplamı: {toplam}");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli pozitif bir tam sayı giriniz.");
                }
            }
        }
    }
}
    

