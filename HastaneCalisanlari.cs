using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_yonelimli_programlama_odevi
{
    internal class HastaneCalisanlari : Hastane
    {
        private ArrayList calisanListesi;
        public HastaneCalisanlari()
        {
            calisanListesi = new ArrayList();
        }

        public void hastaneCalisaniEkle(HastaneCalisanlari yeniCalisan)
        {
            calisanListesi.Add(yeniCalisan);
        }

        public string sicilNo { get; }
        public string ekGosterge { get; set; }
        public string calistigiDepartman { get; set; }
        public string maas { get; set; }
        public int Ek_gosterge { get; set; }

        public string MaasHesapla()
        {
            if (Ek_gosterge <= 1500)
            {
                return "15000";
            }
            else if (Ek_gosterge > 1500 && Ek_gosterge <= 2200)
            {
                return "20000";
            }
            else if (Ek_gosterge > 2200 && Ek_gosterge <= 3000)
            {
                return "30000";
            }
            else if (Ek_gosterge > 3000 && Ek_gosterge <= 3600)
            {
                return "40000";
            }
            else
            {
                return "0";
            }
        }
        public void hastaneCalisanBilgileriniYazdir()
        {
            Console.WriteLine("Çalışan Bilgileri : ");

            foreach (var calisan in calisanListesi)
            {
                if (calisan is HastaneCalisanlari)
                {
                    HastaneCalisanlari calisanObj = (HastaneCalisanlari)calisan;
                    Console.WriteLine($"Ad : {calisanObj.ad}, \nSoyad: {calisanObj.soyad}, \ncinsiyet: {calisanObj.cinsiyet}, \nçalıştığı departman : {calisanObj.calistigiDepartman}, \nmaaş : {calisanObj.MaasHesapla()} \n\n\n");
                }
            }
        }
    }



}
