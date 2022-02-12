using System;
using System.Collections.Generic;

namespace Koleksiyonlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] sabitSesliHarfler = {"a", "e", "ı", "i", "o", "ö", "u", "ü"};
            string sabitSesliHarfler = "aeıioöuü";
            string cumle = "sesli harfleri bir dizi içerisinde sakla";

            char[] bosluksuzCumleHarfleri = cumle.ToCharArray();

            List<char> cumledekiSesliHarfler = new List<char>();

            for (int i = 0; i < bosluksuzCumleHarfleri.Length; i++)
            {
                for (int j = 0; j < sabitSesliHarfler.Length; j++)
                {
                    if (bosluksuzCumleHarfleri[i] == sabitSesliHarfler[j])
                    {
                        cumledekiSesliHarfler.Add(bosluksuzCumleHarfleri[i]);
                    }
                }
            }

            Console.WriteLine("*** Cümlede ki Sesli Harfler ***");
            foreach (var item in cumledekiSesliHarfler)
            {
                Console.Write( item + " ");
            }
        }
    }
}
