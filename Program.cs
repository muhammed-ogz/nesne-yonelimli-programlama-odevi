using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nesne_yonelimli_programlama_odevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hastane örneği oluşturma
            Hastane hastane = new Hastane();

            //Hasta bilgileri oluşturma
            Hasta hasta1 = new Hasta
            {
                ad = "Ahmet",
                soyad = "Deniz",
                cinsiyet = "erkek",
                TC = 85948702345,
                yatisTarihi = new DateTime(2023, 03, 23),
                poliklinikServisi = "Kardiyoloji"
            };
            Hasta hasta2 = new Hasta
            {
                ad = "Merve",
                soyad = "Soyas",
                cinsiyet = "kadın",
                TC = 57893480231,
                yatisTarihi = new DateTime(2023, 12, 3),
                poliklinikServisi = "Fizyoloji"
            };

            Doktor doktor = new Doktor();

            Doktor doktor1 = new Doktor
            {
                ad = "Kemal",
                soyad = "Tahir",
                cinsiyet = "erkek",
                bransBilgileri = "Kalp Doktoru"
            };

            HastaneCalisanlari calisan = new HastaneCalisanlari();

            HastaneCalisanlari calisan1 = new HastaneCalisanlari
            {
                ad = "Melek",
                soyad = "Canan",
                cinsiyet = "kadın",
                calistigiDepartman = "Temizlik",
                Ek_gosterge = 2000,
            };
            doktor.doktorEkle(doktor1);


            //Hastane sınıfına hasta ekleme işlemi 
            hastane.HastaEkle(hasta1);
            hastane.HastaEkle(hasta2);
            calisan.hastaneCalisaniEkle(calisan1);



            //Hasta Bilgilerini yazdırma 
            hastane.HastaBilgileriniYazdir();

            doktor.doktorBilgileriniYazdir();

            calisan.hastaneCalisanBilgileriniYazdir();

            Console.ReadKey();
        }
    }
}
