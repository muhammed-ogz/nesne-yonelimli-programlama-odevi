using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_yonelimli_programlama_odevi
{
    internal class Hasta : Hastane
    {
        public Hasta()
        {

        }
        public DateTime yatisTarihi { get; set; }
        public string poliklinikServisi { get; set; }
    }
}
