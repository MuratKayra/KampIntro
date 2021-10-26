using System;
using System.Linq;

namespace YirmiBirYirmiYedi
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();

            int result = Add2();
            Console.WriteLine(result);
            Console.WriteLine(Add2(20, 30));

            Console.WriteLine();
            Console.WriteLine("Metod Aşırı Yükleme Örnek");
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,6));

            Console.WriteLine();
            Console.WriteLine("Params");
            Console.WriteLine(Add4(1,2,3,4,5,6));
            
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1=10, int number2=20)
        {
            int result = number1 + number2;
            return result;
        }
        //void bir işi yaptırmak için kullanılır. Return(değer döndürme) kullanılacak ise void yerine o işin tipi girilmelidir.
        //ref ve out değer türündeki verilerin referans  tıp olarak  davranması sağlanır. ref ve out anahtar kelimeleri aynı işlemiler için kullanır.
        //fakat ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out ta gerek yoktur.


        //Method Overloading - Metod aşırı yükleme aynı metod adını bir den fazla kullanarak oluşturulur.
        //2 rakamı çarpan Multiply metodu
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //3 rakamı çarpan Multiply metodu
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        
        //params ile metodumuza aynı tipte istediğimiz kadar değer gönderebiliriz.
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
        
    }
}
