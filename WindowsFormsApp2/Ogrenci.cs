using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Ogrenci
    {
        int numara;
        string adSoyad;
        string sinif;
        string telefon;

        public int Numara { get => numara; set => numara = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Sinif { get => sinif; set => sinif = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public Ogrenci(int numara, string adSoyad, string sinif, string telefon)
        {
            this.numara = numara;
            this.adSoyad = adSoyad;
            this.sinif = sinif;
            this.telefon = telefon;
        }
    }
}
