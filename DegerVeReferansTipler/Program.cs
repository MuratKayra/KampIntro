using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); //sayi1 kaçtır? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //sayilar1 in 0. elemanı kaçtır? 999

            //int, decimal, float, double, bool gibi tipler değer tiptir. değer tipler stack te tutulur.
            //array, class, interface gibi tipler referans tiptir. referans tipler heap te tutulur.


        }
    }
}
