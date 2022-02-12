using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 Adet Pozitif Sayı Giriniz");
            
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            int inputNumber = 0;

            for (int a = 2; a <= 13; a++)
            {
                try
                {
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    if (inputNumber < 0)
                        throw new Exception();

                    int sonuc = Asalmi(inputNumber);

                    if (sonuc == 0)
                    {
                        asalOlmayanlar.Add(inputNumber);
                    }
                    else
                    {
                        asalSayilar.Add(inputNumber);
                    }
                }
                catch (Exception)
                {
                    a = 1;
                    Console.WriteLine("Lütfen Sadece Pozitif Sayı Giriniz");
                }
            }

            Console.WriteLine("*** Asal Sayılar - Büyükten Küçüğe ***");
            asalSayilar.Sort();
            asalSayilar.Reverse();

            int asalToplam = 0;
            foreach (var item in asalSayilar)
            {
                Console.WriteLine(item);
                asalToplam += (int)item;
            }
            Console.WriteLine("*** Eleman Sayısı: " + asalSayilar.Count + "*** Ortalaması :" + (asalToplam / asalSayilar.Count));
            

            Console.WriteLine("*** Asal Olmayan Sayılar - Büyükten Küçüğe ***");
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();
            
            int asalOlmayanToplam = 0;
            foreach (var item in asalOlmayanlar)
            {
                Console.WriteLine(item);
                asalOlmayanToplam += (int)item;
            }

            Console.WriteLine("*** Eleman Sayısı: " + asalOlmayanlar.Count + "*** Ortalaması :" + (asalOlmayanToplam / asalOlmayanlar.Count));

        }

        private static int Asalmi(int sayi)
        {
            int i; //7
            for (i = 2;  i <= sayi -1; i++)
            {
                if(sayi % i == 0)
                {
                    return 0;
                }
            }

            if (i == sayi)
            {
                return 1;
            }
            return 0;
        }
    }
}
