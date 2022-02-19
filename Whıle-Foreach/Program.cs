using System;

namespace Whıle_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak consoleden girilen sayıya kadar ortalama hesaplauıp console e yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi= int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            Console.WriteLine("************************");

            //a'dan z'ye kadar bütün harfleri conseleye yazdır.
            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("************************");

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
