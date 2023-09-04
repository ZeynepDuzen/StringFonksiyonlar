using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin giriniz : ");
            string metin1 = Console.ReadLine();
            Console.WriteLine("2.metni giriniz :");
            string metin2 = Console.ReadLine();

            Console.WriteLine("Concat ile birlestirme : " + string.Concat(metin1,metin2));
            Console.WriteLine("Metin1 icin karakter sayisi : " + metin1.Length);
            Console.WriteLine("Indexof ornegi : " + metin1.IndexOf("aydin"));
            Console.WriteLine("Indexof ornegi2 : " + metin2.IndexOf("Is"));
            Console.WriteLine("Startswith ornegi : " + metin1.StartsWith("Gunaydin"));
            Console.WriteLine("Startswith ornegi : "  + metin1.StartsWith("merhaba"));
            Console.WriteLine("Klavyeden girilen metin1'in basindaki ve sonundaki boslukları trimler:" + metin1.Trim());
            Console.WriteLine("Buyuk harf ile gosterim : " + metin1.ToUpper());
            Console.WriteLine("Kucuk harf ile gosterim : " + metin2.ToLower());
            Console.WriteLine("Remove kullanimi : " + metin1.Remove(3));
            Console.WriteLine("Replace kullanimi : " + metin1.Replace("a","A"));
            Console.WriteLine("Replace kullanimi : " + metin2.Replace("a","A"));
            Console.WriteLine("Substring kullanimi : " + metin1.Substring(3));


            Console.Read();
        }
    }
}
