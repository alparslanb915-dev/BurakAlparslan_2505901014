using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_5
{
    
    
  
        
            

namespace ParantezDengesi
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Lütfen kontrol edilecek metni giriniz: ");
                string metin = Console.ReadLine();

                bool dengeliMi = ParantezKontrolEt(metin);

                Console.WriteLine("\n--- Kontrol Sonucu ---");
                if (dengeliMi)
                {
                    Console.WriteLine("Metindeki parantezler DENGELİ. ✔️");
                }
                else
                {
                    Console.WriteLine("Metindeki parantezler DENGESİZ! ❌");
                }
            }

            static bool ParantezKontrolEt(string metin)
            {
      
                Stack<char> parantezYigini = new Stack<char>();

        
                foreach (char karakter in metin)
                {
      
                    if (karakter == '(')
                    {
                        parantezYigini.Push(karakter);
                    }
        
                    else if (karakter == ')')
                    {
     
                        if (parantezYigini.Count == 0)
                        {
                            return false;
                        }

                        parantezYigini.Pop();
                    }
            
                }

               
                return parantezYigini.Count == 0;
            }
        }
    }

    }
