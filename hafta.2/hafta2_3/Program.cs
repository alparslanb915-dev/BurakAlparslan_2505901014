using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_3
{
    
    
        
        
           
namespace UndoIslemi
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                Stack<string> islemGecmisi = new Stack<string>();

                Console.WriteLine("--- İşlem Takip (Undo) Sistemine Hoş Geldiniz ---");
                Console.WriteLine("Bir işlem yazın (Örnek: Add, Remove, Update)");
                Console.WriteLine("Son işlemi geri almak için: undo");
                Console.WriteLine("Programdan çıkmak için: exit\n");

                while (true)
                {
                    Console.Write("Komutunuzu girin: ");
                    string komut = Console.ReadLine();

                  
                    if (string.IsNullOrWhiteSpace(komut))
                    {
                        continue;
                    }

                    
                    string kontrolKomutu = komut.ToLower();

                    if (kontrolKomutu == "exit")
                    {
                        Console.WriteLine("Programdan çıkılıyor...");
                        break; 
                    }
                    else if (kontrolKomutu == "undo")
                    {
                       
                        if (islemGecmisi.Count > 0)
                        {
                            
                            string iptalEdilen = islemGecmisi.Pop();
                            Console.WriteLine($"[GERİ ALINDI] İptal edilen işlem: {iptalEdilen}");
                        }
                        else
                        {
                            Console.WriteLine("[UYARI] Geri alınacak herhangi bir işlem bulunmuyor. Geçmiş boş.");
                        }
                    }
                    else
                    {
                        
                        islemGecmisi.Push(komut);
                        Console.WriteLine($"[KAYDEDİLDİ] Yapılan işlem: {komut}");
                    }
                }
            }
        }
    }
}
    

