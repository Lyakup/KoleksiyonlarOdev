using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = {3,45,67,2,8,1,99 }; //new int[20];

            int[] bigNumbers = new int[3];
            int[] smallNumbers = new int[3];

            //Sürekli Değer Yazmak İstemedim :D
            /*
            for (int i = 0; i <= inputNumbers.Length; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
            */

            Array.Sort(inputNumbers);
            for (int i = 0; i < 3; i++)
            {
                smallNumbers[i] = inputNumbers[i];
            }

            Array.Reverse(inputNumbers);
            for (int i = 0; i < 3; i++)
            {
                bigNumbers[i] = inputNumbers[i];
            }


            Console.WriteLine("*** Girilen Sayılar");
            foreach (var item in inputNumbers)
                Console.WriteLine(item);
            

            Console.WriteLine("*** En Büyük 3 Sayı");
            foreach (var item in bigNumbers)
                Console.WriteLine(item);
            

            Console.WriteLine("*** En Küçük 3 Sayı");

            foreach (var item in smallNumbers)
                Console.WriteLine(item);


            Console.WriteLine("Büyük Sayıların Ortalaması:" + bigNumbers.Average().ToString("00.00"));
            Console.WriteLine("Küçük Sayıların Ortalaması:" + smallNumbers.Average());
            
            Console.WriteLine("Büyük ve Küçük Sayıların Ortalama Toplamı:" + 
                (bigNumbers.Average() + smallNumbers.Average()).ToString("00.00"));



        }
    }
}
