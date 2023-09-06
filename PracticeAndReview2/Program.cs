using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            Console.WriteLine("Bugunun gun bilgisi : " + DateTime.Now.Day); //  6 
            Console.WriteLine("Bugunun ay bilgisi : " + DateTime.Now.Month); // Eylul
            Console.WriteLine("Bugunun yil bilgisi : " + DateTime.Now.Year); // 2023
            Console.WriteLine("Bugunun saat bilgisi : " + DateTime.Now.Hour);
            Console.WriteLine("Bugunun saat bilgisi : " + DateTime.Now.Minute);
            Console.WriteLine("Bugunun saat bilgisi : " + DateTime.Now.Second);
            Console.WriteLine("Bugunun kisa tarih bilgisi : " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Bugunun uzun tarih bilgisi : " + DateTime.Now.ToLongDateString());
            Console.WriteLine();

            //TimeSpan

            int gunFarki;
            DateTime tarih1, tarih2;
            tarih1 = Convert.ToDateTime("01.02.2023");
            tarih2 = Convert.ToDateTime("15.02.2023");
            TimeSpan zaman = tarih2 - tarih1;
            gunFarki = zaman.Days;
            Console.WriteLine("Gun farki : " + gunFarki);
            Console.WriteLine();

            //TimeSpan example 2
            DateTime tarih3 = Convert.ToDateTime("11.03.2023");
            DateTime tarih4 = Convert.ToDateTime("22.03.2023");
            TimeSpan zaman2 = tarih4 - tarih3;
            int gunFarki2 = zaman2.Days;
            Console.WriteLine("Gun farki2 : " + gunFarki2);

            //TimeSpan example 3

            DateTime tarih5 = Convert.ToDateTime("01.05.2020");
            DateTime tarih6 = Convert.ToDateTime("01.05.2021");
            TimeSpan zaman3 = tarih6 - tarih5;
            int gunFarki3 = zaman3.Days;
            Console.WriteLine("Gun farki : " + gunFarki3);

            //Bugune kadar kac gun yasadim ?
            DateTime tarih7 = Convert.ToDateTime("17.03.1985");
            DateTime tarih8 = Convert.ToDateTime("06.09.2023");
            TimeSpan zaman4 = tarih8 - tarih7;
            int gunFarki4 = zaman4.Days;
            Console.WriteLine("Kac gun yasamisim : " + gunFarki4);


            Console.Read();
        }
    }
}
