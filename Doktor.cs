using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_yonelimli_programlama_odevi
{
    internal class Doktor : HastaneCalisanlari
    {
        private ArrayList doktorListesi;
        public Doktor()
        {
            doktorListesi = new ArrayList();
        }

        public void doktorEkle(Doktor yeniDoktor)
        {
            doktorListesi.Add(yeniDoktor);
        }
        public int diplomaNo { get; }
        public string bransBilgileri { get; set; }

        public void doktorBilgileriniYazdir()
        {
            Console.WriteLine("Doktor Bilgileri : ");

            foreach (var doktor in doktorListesi)
            {
                if (doktor is Doktor)
                {
                    Doktor doktorObj = (Doktor)doktor;
                    Console.WriteLine($"Ad: {doktorObj.ad}, \nSoyad: {doktorObj.soyad}, \nCinsiyet: {doktorObj.cinsiyet}, \nDiploma no : ***** ,\nBranş Bilgileri : {doktorObj.bransBilgileri} \n\n\n");
                }
            }
        }
        //maaş hesaplama methodu yapılacak buraya 
    }
}
