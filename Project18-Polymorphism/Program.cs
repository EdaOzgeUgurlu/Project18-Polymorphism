using static Project18_Polymorphism.BaseGeometrikSekil;
class Program
{
    static void Main(string[] args)
    {
        // Kare nesnesi oluşturuluyor (kenar uzunluğu 5)
        BaseGeometrikSekil kare = new Kare(5);
        // Dikdörtgen nesnesi oluşturuluyor (genişlik 4, yükseklik 6)
        BaseGeometrikSekil dikdörtgen = new Dikdörtgen(4, 6);
        // Dik Üçgen nesnesi oluşturuluyor (genişlik 4, yükseklik 3)
        BaseGeometrikSekil dikUcgen = new DikUcgen(4, 3);

        // Kare'nin alanı hesaplanıyor ve konsola yazdırılıyor
        Console.WriteLine($"Kare'nin alanı: {kare.AlanHesapla()}");
        // Dikdörtgen'in alanı hesaplanıyor ve konsola yazdırılıyor
        Console.WriteLine($"Dikdörtgen'in alanı: {dikdörtgen.AlanHesapla()}");
        // Dik Üçgen'in alanı hesaplanıyor ve konsola yazdırılıyor
        Console.WriteLine($"Dik Üçgen'in alanı: {dikUcgen.AlanHesapla()}");

        Console.ReadLine();
    }
}
