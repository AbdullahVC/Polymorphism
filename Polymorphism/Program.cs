using System;
namespace Polymorphism 
{
class Program
{
    static void Main()
    {
        // Kare
        Console.Write("Kare için kenar uzunluğunu giriniz: ");
        double kareKenar = Convert.ToDouble(Console.ReadLine());
        Kare kare = new Kare(kareKenar);
        Console.WriteLine("Kare Alanı: " + kare.AlanHesapla());
            Console.WriteLine("");

        // Dikdörtgen
        Console.Write("Dikdörtgen için genişlik giriniz: ");
        double dikdortgenGenislik = Convert.ToDouble(Console.ReadLine());
        Console.Write("Dikdörtgen için yükseklik giriniz: ");
        double dikdortgenYukseklik = Convert.ToDouble(Console.ReadLine());
        Dikdortgen dikdortgen = new Dikdortgen(dikdortgenGenislik, dikdortgenYukseklik);
        Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen.AlanHesapla());
            Console.WriteLine("");

        // Dik Üçgen
        Console.Write("Dik Üçgen için genişlik giriniz: ");
        double dikUcgenGenislik = Convert.ToDouble(Console.ReadLine());
        Console.Write("Dik Üçgen için yükseklik giriniz: ");
        double dikUcgenYukseklik = Convert.ToDouble(Console.ReadLine());
        DikUcgen dikUcgen = new DikUcgen(dikUcgenGenislik, dikUcgenYukseklik);
        Console.WriteLine("Dik Üçgen Alanı: " + dikUcgen.AlanHesapla());
    }
}
}