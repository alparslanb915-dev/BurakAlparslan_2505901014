using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_7
{


    
        class Program
        {
            static void Main(string[] args)
            {

                Dictionary<string, string> rehber = new Dictionary<string, string>();

                rehber.Add("Ali Yılmaz", "05550000001");
                rehber.Add("Ayşe Kaya", "05550000002");
                rehber.Add("Mehmet Demir", "05550000003");

                Console.WriteLine("--- Telefon Rehberi Uygulaması ---\n");

                Console.Write("Lütfen işlem yapmak istediğiniz kişinin Adını ve Soyadını giriniz: ");
                string arananIsim = Console.ReadLine();

              
                if (rehber.ContainsKey(arananIsim))
                {
                    Console.WriteLine($"[BİLGİ] Bu kişi zaten var. Mevcut Numarası: {rehber[arananIsim]}");
                    Console.Write("Lütfen yeni numarayı girerek güncelleyin: ");
                    string yeniNo = Console.ReadLine();

              
                    rehber[arananIsim] = yeniNo;
                    Console.WriteLine("[BAŞARILI] Numara güncellendi. ✔️");
                }
                else
                {
                    Console.WriteLine("[BİLGİ] Bu kişi rehberde yok, yeni kayıt oluşturuluyor.");
                    Console.Write("Lütfen eklenecek telefon numarasını giriniz: ");
                    string yeniNo = Console.ReadLine();

               
                    rehber.Add(arananIsim, yeniNo);
                    Console.WriteLine("[BAŞARILI] Yeni kişi rehbere eklendi. ✔️");
                }

                Console.WriteLine("\n--- Rehberden Kişi Silme ---");

                Console.Write("Lütfen silmek istediğiniz kişinin Adını ve Soyadını tam giriniz: ");
                string silinecekIsim = Console.ReadLine();

             
                if (rehber.ContainsKey(silinecekIsim))
                {
                    rehber.Remove(silinecekIsim); 
                    Console.WriteLine($"[SİLİNDİ] '{silinecekIsim}' rehberden başarıyla çıkarıldı.");
                }
                else
                {
                    Console.WriteLine($"[HATA] '{silinecekIsim}' rehberde bulunamadı, silme işlemi iptal edildi.");
                }

                Console.WriteLine("\n--- Güncel Telefon Rehberi ---");

        
                Console.WriteLine($"Rehberdeki Toplam Kişi Sayısı (Count): {rehber.Count}\n");

                
                foreach (KeyValuePair<string, string> kisi in rehber)
                {
                    Console.WriteLine($"- {kisi.Key}: {kisi.Value}");
                }
            }
        }
    }

    

