﻿using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminiz : ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba : " + name + " " + surname);
        }
    }
}