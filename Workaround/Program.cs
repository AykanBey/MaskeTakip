using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(6, 58);

            //Diziler / Arrays

            string orgrenci1 = "Engin";
            string orgrenci2 = "Kerem";
            string orgrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {



                Console.WriteLine(sehir);

            }

            //MyList
            List<string> YeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            YeniSehirler1.Add("Adana");

            foreach (var sehir in YeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Console.ReadLine();

        }

            //resharper
            static void SelamVer(string isim = "isimsiz")
            {
                Console.WriteLine("Merhaba" + isim);
            }

            static int Topla(int sayi1 = 5, int sayi2 = 10)
            {
                return sayi1 + sayi2;
            }


            private static void Degiskenler()
            {
                string mesaj = "Merhaba";
                double tutar = 100000; //db den gelir
                int sayi = 100;
                bool girisYapmisMi = false;

                string ad = "Engin";
                string soyad = "Demiroğ";
                int dogumYili = 1985;
                long tcNo = 12345678910;

                Console.WriteLine(tutar * 1.18);

                Console.WriteLine(tutar * 1.18);
            }
        }
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }
    }
