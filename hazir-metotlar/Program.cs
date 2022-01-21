﻿using System;

namespace hazir_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz C#, Hosegldiniz";
            string degisken2 = "dersimiz C#, Hosegldiniz";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Selam"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("cs"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            // Insert
            Console.WriteLine(degisken.Insert(0, "merhaba "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30 , '*'));

            //Remove
            Console.WriteLine(degisken.Remove(10)); // 10. indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5,3));    //5. indexten sonra 3 karakter siler

            //Replace
            Console.WriteLine(degisken.Replace("C##", "C sharp"));

            // Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4)); // 4. indexten baslayip sonuna kadar getirdi..
        }
    }
}
