using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriye_Koleksiyon_Donduren_ve_Veriyi_Filtreleyen_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] stringDizisi = { "Polat", "Fenerbahçe", "Muz", "Bilgisayar", "Mühendisliği", "GYM", "C#", "Motorsiklet", "Ödev" };

                List<string> filtrelenmisListe = FiltreUzunlukBesUzeri(stringDizisi);

                Console.WriteLine("Uzunluğu 5 Karakterden Büyük Olan Elemanlar: ");
                foreach (var eleman in filtrelenmisListe)
                {
                    Console.WriteLine(eleman);
                }

                Console.ReadKey();
        }

         static List<string> FiltreUzunlukBesUzeri(string[] dizi)
         {
                List<string> sonucListesi = new List<string>();

                foreach (var eleman in dizi)
                {
                    if (eleman.Length > 5)
                    {
                        sonucListesi.Add(eleman);
                    }
                }

                return sonucListesi;
         }
    }
}
