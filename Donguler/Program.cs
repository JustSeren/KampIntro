using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
                           //şart|
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] kurslar = new string[] {"ygkmpı","proglamlamagırıs","java" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu - footer");

            foreach (string kurs in kurslar)
            {//dizileri kolay dolaşırken kullanılıyor daha cok
                Console.WriteLine(kurs);
            }
        }
    }
}
