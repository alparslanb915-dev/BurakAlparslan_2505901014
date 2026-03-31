using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_2
{
    internal class Program
    {
        static void Main(string[] args)
        
            

namespace KelimeTersCevir
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Lütfen ters çevrilecek kelimeyi giriniz: ");
                string kelime = Console.ReadLine();

                if (!string.IsNullOrEmpty(kelime))
                {
       
                    Stack<char> harfYigini = new Stack<char>();

          
                    foreach (char harf in kelime)
                    {
                        harfYigini.Push(harf);
                    }

                    string tersKelime = "";

                    while (harfYigini.Count > 0)
                    {
                        tersKelime += harfYigini.Pop();
                    }


                    Console.WriteLine($"\nOrijinal Kelime : {kelime}");
                    Console.WriteLine($"Ters Çevrilmiş Hali : {tersKelime}");
                }
                else
                {
                    Console.WriteLine("Herhangi bir kelime girmediniz.");
                }
            }
        }
    }
}
    

