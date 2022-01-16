using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donustipi metot_adi(parametre/arguman)

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();            // Farklı bir class tan aldigimiz icin instance olusturduk !
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));      // a ve b ref olarak verilirse burası 5 yerine 7 olarak gelir !


            // ******** Overloading *********
             // Out parametreler
             string sayi = "999";
            bool sonuc3  = int.TryParse(sayi, out int outSayi);
            if(sonuc3){
                Console.WriteLine("Basarılı", sonuc3);
            }else
            {
                Console.WriteLine("Basarisiz");
            }
        }

        static int Topla(int deger1, int deger2){
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1 + deger2;
        }
    }
}
