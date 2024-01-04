using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_yonelimli_programlama_odevi
{
    internal class Hastane
    {
        //hasta bilgilerini tutmak için Array list oluşturuyorum 
        private ArrayList hastaListesi;
        public Hastane()
        {
            hastaListesi = new ArrayList();
        }
        //hasta ekleme methodu
        public void HastaEkle(Hasta yeniHasta)
        {
            hastaListesi.Add(yeniHasta);
        }
        //hasta bilgilerini göstermek
        public void HastaBilgileriniYazdir()
        {
            Console.WriteLine("Hasta Bilgileri : ");

            foreach (var hasta in hastaListesi)
            {
                if (hasta is Hasta)
                {
                    Hasta hastaObj = (Hasta)hasta;
                    Console.WriteLine($"Ad: {hastaObj.ad}, \nSoyad: {hastaObj.soyad}, \nCinsiyet: {hastaObj.cinsiyet}, \nyatis tarihi: {hastaObj.yatisTarihi}, \npoliklinik servisi: {hastaObj.poliklinikServisi} \n\n\n");
                }
            }
        }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }

        private long _tc;
        public long TC 
        {
            get { return _tc; }
            set { _tc = value; }    
        }
    }
}
