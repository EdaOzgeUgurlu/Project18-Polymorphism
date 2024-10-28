using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18_Polymorphism
{
    internal class BaseGeometrikSekil
    {
        // Soyut temel sınıf
        public abstract class BaseGeometrikSekil
        {
            // Genişlik özelliği
            public double Genişlik { get; set; }

            // Yükseklik özelliği
            public double Yükseklik { get; set; }

            // Soyut alan hesaplama metodu, alt sınıflarda uygulanacak
            public abstract double AlanHesapla();
        }

        // Kare sınıfı, temel sınıftan türetiliyor
        public class Kare : BaseGeometrikSekil
        {
            // Yapıcı metod, kenar uzunluğunu alır
            public Kare(double kenar)
            {
                Genişlik = kenar; // Genişlik ve yükseklik aynı olduğu için kenar atanır
                Yükseklik = kenar;
            }

            // Alan hesaplama metodunu uygulama
            public override double AlanHesapla()
            {
                return Genişlik * Yükseklik; // Alan: kenar * kenar
            }
        }

        // Dikdörtgen sınıfı, temel sınıftan türetiliyor
        public class Dikdörtgen : BaseGeometrikSekil
        {
            // Yapıcı metod, genişlik ve yükseklik alır
            public Dikdörtgen(double genislik, double yükseklik)
            {
                Genişlik = genislik; // Genişlik atanıyor
                Yükseklik = yükseklik; // Yükseklik atanıyor
            }

            // Alan hesaplama metodunu uygulama
            public override double AlanHesapla()
            {
                return Genişlik * Yükseklik; // Alan: genişlik * yükseklik
            }
        }

        // Dik Üçgen sınıfı, temel sınıftan türetiliyor
        public class DikUcgen : BaseGeometrikSekil
        {
            // Yapıcı metod, genişlik ve yükseklik alır
            public DikUcgen(double genislik, double yükseklik)
            {
                Genişlik = genislik; // Genişlik atanıyor
                Yükseklik = yükseklik; // Yükseklik atanıyor
            }

            // Alan hesaplama metodunu uygulama
            public override double AlanHesapla()
            {
                return (Genişlik * Yükseklik) / 2; // Alan: (genişlik * yükseklik) / 2
            }
        }
    }
}
