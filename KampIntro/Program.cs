using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //type safety = tip güvenliği
            //Do not Repeat Yourself

            string katagoriEtiketi = "Katagori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarinDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarBugun < dolarinDun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun > dolarinDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Sisteme giris Yap");
            }


        }
    }
}
