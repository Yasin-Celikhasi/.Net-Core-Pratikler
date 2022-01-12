using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            // Dizilere deger atama ve erisim
            renkler [0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Dongulerle dizi kullanımı
            // Klavyeden girilen n tane sayinin ort bulan program
            Console.WriteLine("Lütfen dizinin eleman sayisini giriniz: ");
            int diziLength = int.Parse(Console.ReadLine());
            int[] sayi = new int[diziLength];

            for (int i = 0; i < diziLength; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz.. ", i+1);
                sayi [i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayi)
            {
                toplam += item;
                Console.WriteLine("Ortalama :" + toplam/diziLength);
            }
        }
    }
}
