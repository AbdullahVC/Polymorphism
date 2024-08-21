using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Base class: BaseGeometrikSekil
    class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Derived class: Kare
    class Kare : BaseGeometrikSekil
    {
        public Kare(double kenar)
        {
            Genislik = kenar;
            Yukseklik = kenar;
        }
    }

    // Derived class: Dikdortgen
    class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }
    }

    // Derived class: DikUcgen
    class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }

}
