using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilincsiz Dönüsüm)
               byte a = 5;
               sbyte b = 30;
               short c = 10;

               int d = a + b + c;
            // Explicit Conversion (Bilincli Dönüsüm)   c# kendisi yapamıyor bu tür donusumleri
            int x = 4;
            byte y = (byte)x;   // bu sekilde saginda paranteze almak gerekir

            // ToString methodu
            int x1 = 6;
            string y1 = x1.ToString();

            // System.Convert()
            Convert.ToInt32(x1);

            // Parse
            ParseMethod();

        }

        public static void ParseMethod() {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1 ;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);
        }
    }
}
