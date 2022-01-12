using System;

namespace degiskenler
{
    class Program
    {
        private const string V = "Ali";

        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b = 5;     // 1 byte
            sbyte c = 5;    // 1 byte

            short s = 5;    //2 byte    
            ushort us = 5;  //2 byte , 0 dan kücük deger alamıyor

            Int16 i1 = 2;   // 2 byte      
            int i = 2;      // 4 byte      
            Int32 i32 = 2;    // 4 byte      
            Int64 i64 = 2;    // 8 byte

            uint ui = 2;    // 4 byte
            long l = 4;     // 8 byte      
            ulong ul = 4;    // 8 byte

            float f = 5;    // 4 byte      
            double d = 5;   // 8 byte      
            decimal dd = 5;  // 16 byte

            char cc = '2';   // 2 byte
            var str = "ali"; // sınırsız

            bool bo = true;  

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt); 

            // Object
            object o1 = "x";
            object o2 = 3;

            // Strin ifadeler
            string str1 = string.Empty;
            str1 = "Ali Veli";
            string ad = "Ali";
            string soyad = "Veli";
            string tamIsim = ad + " " + soyad;

            // Integer tanımlama
            int int1 = 5; 
            int int2 = 2; 
            int int3 = int1 * int2;

            // boolean
            bool b3 = 10 > 3;

            // Degisken dönüsümleri
            string str4 = "20";
            int int4 = 20;
            string yeniDeger = str4 + int4.ToString();

            int in22 = int4 + int.Parse(str4); // Ciktisi 40

            // datetime
            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime); 

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime); 

        }
    }
}
